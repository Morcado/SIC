using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Antlr4.Runtime;
using System.IO;
using System.Drawing;
using System.Linq;

namespace ProyectoSIC {
    /* Conjunto de instrucciones en formato decimal*/
    public enum Instrucciones {
        ADD = 24, AND = 80, COMP = 40, DIV = 36, J = 60, JEQ = 48, JGT = 52,
        JLT = 56, JSUB = 72, LDA = 00, LDCH = 50, LDL = 08, LDX = 04,
        MUL = 32, OR = 68, RD = 216, RSUB = 76, STA = 12, STCH = 84, STL = 20,
        STSW = 232, STX = 16, SUB = 28, TD = 224, TIX = 44, WD = 220
    }

    public enum Directivas {
        START, END, BYTE, WORD, RESB, RESW
    }

    public partial class Principal : Form {
        public string nombre, ruta;
        private Programa prog;
        private int LongPrograma;


        public Principal() {
            InitializeComponent();
            tbPrograma.Select();
            LongitudPrograma.Text = "";
        }

        private void EstablecerBotonesArchivo(bool nuevo, bool abrir, bool guardar, bool guardarComo, bool cerrar, bool salir) {
            nuevoToolStripMenuItem.Enabled = nuevo;
            abrirProgramaObjetoToolStripMenuItem.Enabled = abrir;
            guardarToolStripMenuItem.Enabled = guardar;
            guardarComoToolStripMenuItem.Enabled = guardarComo;
            cerrarToolStripMenuItem.Enabled = cerrar;
            salirToolStripMenuItem.Enabled = salir;
        }

        private void EstablecerBotonesEnsamblador(bool analizar, bool paso1, bool paso2) {
            analizarToolStripMenuItem.Enabled = btnAnalizar.Enabled = analizar;
            paso1ToolStripMenuItem.Enabled = btnPaso1.Enabled = paso1;
            paso2ToolStripMenuItem.Enabled = btnPaso2.Enabled = paso2;
        }

        private void EstablecerBotonesEjecutar(bool abrir, bool cargar) {
            abrirProgramaObjetoToolStripMenuItem.Enabled = btnAbrirObjeto.Enabled = abrir;
            cargarToolStripMenuItem.Enabled = btnCargarMemoria.Enabled = cargar;
        }

        private void Nuevo(object sender, EventArgs e) {
            tbPrograma.Text = "";
            tbLinea.Text = "";
            tbErrores.Text = "";
            nombre = "";
            ActiveForm.Text = "SIC";
            DireccionArchivo.Text = "";
            LongitudPrograma.Text = "";

            EstablecerBotonesArchivo(true, true, true, true, true, true);
            EstablecerBotonesEnsamblador(true, false, false);
            EstablecerBotonesEjecutar(false, false);
            tbPrograma.Enabled = true;

            prog = new Programa();
            intermedio.Rows.Clear();
            dataGridTabSim.Rows.Clear();
            tbErrores.Clear();
            tbRegistros.Clear();
            textBoxRes.BackColor = Color.White;
            textBoxRes.Text = "";
        }

        private void Abrir(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog {
                InitialDirectory = Application.StartupPath + "\\example",
                Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
                DefaultExt = ".s"
            };
            if (open.ShowDialog() == DialogResult.OK) {
                ruta = Directory.GetParent(open.FileName).ToString();
                tbPrograma.Lines = File.ReadAllLines(open.FileName);
                string[] files = open.FileName.Split((char)92);
                string[] file = files[files.Length - 1].Split('.');
                nombre = file[0];
                TbPrograma_TextChanged(this, null);
                ActiveForm.Text = "SIC - " + nombre;
                DireccionArchivo.Text = open.FileName;

                EstablecerBotonesArchivo(true, true, true, true, true, true);
                EstablecerBotonesEnsamblador(true, false, false);
                EstablecerBotonesEjecutar(true, false);
                tbPrograma.Enabled = true;

                prog = new Programa();
                intermedio.Rows.Clear();
                dataGridTabSim.Rows.Clear();
                tbErrores.Clear();
                tbRegistros.Clear();
                textBoxRes.BackColor = Color.White;
                textBoxRes.Text = "";
            }
        }

        private void Guardar(object sender, EventArgs e) {
            if (ruta != null) {
                File.WriteAllLines(ruta + @"\" + nombre + ".s", tbPrograma.Lines);
                tbPrograma.DeselectAll();
            }
            else {
                guardarComoToolStripMenuItem.PerformClick();
            }
        }

        private void GuardarComo(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog {
                InitialDirectory = Application.StartupPath + "\\example",
                Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
                DefaultExt = ".s"
            };
            if (save.ShowDialog() == DialogResult.OK) {
                File.WriteAllLines(save.FileName, tbPrograma.Lines);
                tbPrograma.DeselectAll();
                string[] files = save.FileName.Split((char)92);
                string[] file = files[files.Length - 1].Split('.');
                nombre = file[0];
                ActiveForm.Text = "SIC - " + nombre;
                DireccionArchivo.Text = save.FileName;
                ruta = Directory.GetParent(save.FileName).ToString();
            }
        }

        private void Cerrar(object sender, EventArgs e) {
            tbPrograma.Text = "";
            tbLinea.Text = "";
            tbErrores.Text = "";
            nombre = "";
            ActiveForm.Text = "SIC";
            DireccionArchivo.Text = "";
            LongitudPrograma.Text = "";
            intermedio.Rows.Clear();
            dataGridTabSim.Rows.Clear();
            tbErrores.Clear();
            tbRegistros.Clear();
            textBoxRes.Clear();

            EstablecerBotonesArchivo(true, true, false, false, false, true);
            EstablecerBotonesEnsamblador(false, false, false);
            EstablecerBotonesEjecutar(true, false);
            tbPrograma.Enabled = false;
            textBoxRes.BackColor = Color.White;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void Analizar(object sender, EventArgs e) {
            if (tbPrograma.Text != "") {
                int cont = 1;
                bool correcto = true;
                List<string> results = new List<string>();
                prog.lineas.Clear();
                foreach (string line in tbPrograma.Lines) {
                    if (line != "") { 
                        Linea linea = new Linea(line);
                        prog.lineas.Add(linea);
                        GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(line + Environment.NewLine));
                        CommonTokenStream tokens = new CommonTokenStream(lex);
                        GramaticaParser parser = new GramaticaParser(tokens);
                        try {
                            parser.prog();
                            if (parser.NumberOfSyntaxErrors != 0) {
                                results.Add("Error linea " + (cont).ToString());
                                correcto = false;
                                prog.lineas[prog.lineas.Count - 1].Error = true;
                            }
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.ToString());
                            throw;
                        }
                        cont++;
                        tbPrograma.DeselectAll();
                    }
                }
                if (correcto) {
                    textBoxRes.BackColor = Color.Green;
                    textBoxRes.Text = "LISTO";
                }
                else {
                    textBoxRes.BackColor = Color.Red;
                    textBoxRes.ForeColor = Color.White;
                    textBoxRes.Text = "ERROR";
                    tbErrores.Lines = results.ToArray();
                    File.WriteAllLines(ruta + @"\" + nombre + ".t", tbErrores.Lines);
                }
                EstablecerBotonesEnsamblador(true, true, false);

                tbRegistros.Clear();
                intermedio.Rows.Clear();
                dataGridTabSim.Rows.Clear();

            }
            else {
                MessageBox.Show("Carga un programa");
            }
        }

        /* Checar errores y demas*/
        private void Paso1(object sender, EventArgs e) {
            intermedio.RowHeadersWidth = 60;
            dataGridTabSim.Rows.Clear();
            intermedio.Rows.Clear();
            int contador = prog.lineas[0].Operando.ToDec();
            string hexCont = "";
            for (int i = 0; i < prog.lineas.Count; i++) {
                hexCont = contador.ToHex();
                string valor = prog.lineas[i].Operando;
                
                intermedio.Rows.Add(hexCont, prog.lineas[i].Etiqueta, prog.lineas[i].CodigoOp, valor);

                bool Repetido = false;
                foreach (DataGridViewRow row in dataGridTabSim.Rows) {
                    if (row.Cells[0].Value.ToString() == prog.lineas[i].Etiqueta) {
                        Repetido = true;
                        break;
                    }
                }
                if (prog.lineas[i].Etiqueta != "" && i != 0 && !Repetido && EsEtiquetaValida(prog.lineas[i].Etiqueta)) {
                    dataGridTabSim.Rows.Add(prog.lineas[i].Etiqueta, hexCont.Substring(2));
                }

                intermedio.Rows[i].HeaderCell.Value = (i + 1).ToString();
                if (!prog.lineas[i].Error) {
                    if (prog.lineas[i].CodigoOp == "RESW") {
                        contador += prog.lineas[i].Operando.ToDec() * 3;
                    }
                    else {
                        if (prog.lineas[i].CodigoOp == "RESB") {
                            contador += prog.lineas[i].Operando.ToDec();
                        }
                        else {
                            if (prog.lineas[i].CodigoOp == "BYTE") {
                                if (prog.lineas[i].Operando.StartsWith("X'") && prog.lineas[i].Operando.EndsWith("'")) {
                                    //contador += int.Parse(Math.Round((decimal)(prog.lineas[i].Operando.Length - 3) / 2, 0).ToString(), System.Globalization.NumberStyles.HexNumber);
                                    contador += (prog.lineas[i].Operando.Length - 3) / 2;
                                }
                                if (prog.lineas[i].Operando.StartsWith("C'") && prog.lineas[i].Operando.EndsWith("'")) {
                                    //contador += int.Parse((prog.lineas[i].Operando.Length - 3).ToString(), System.Globalization.NumberStyles.HexNumber);
                                    contador += prog.lineas[i].Operando.Length - 3;
                                }
                            }
                            else {
                                if (i == 0) {
                                    continue;
                                }
                                contador += 3;
                            }
                        }
                    }
                }
            }
            LongPrograma = hexCont.ToDec() - intermedio.Value(0, 0).ToDec();
            LongPrograma = hexCont.ToDec() - intermedio[0, 0].Value.ToString().ToDec();
            LongitudPrograma.Text = "Tamaño del programa: " + LongPrograma.ToHex() + "H";
            EstablecerBotonesEnsamblador(true, true, true);

        }

        /* crea codigo objeto */
        private void Paso2(object sender, EventArgs e) {
            foreach (DataGridViewRow row in intermedio.Rows) {
                if (EsEtiquetaValida(row.Cells[1].Value.ToString())) {
                    if (row.Cells[2].Value.ToString() != "START" && row.Cells[2].Value.ToString() != "END" && row.Cells[2].Value.ToString() != "RESB" && row.Cells[2].Value.ToString() != "RESW") {
                        if (row.Cells[2].Value.ToString().Contains("WORD")) {
                            string word = "";
                            for (int i = row.Cells[3].Value.ToString().Length; i < 6; i++) {
                                word += "0";
                            }
                            word += row.Cells[3].Value.ToString();
                            row.Cells[4].Value = word;
                        }
                        else if (row.Cells[2].Value.ToString() == "BYTE") {
                            if (row.Cells[3].Value.ToString().StartsWith("C'") && row.Cells[3].Value.ToString().EndsWith("'")) {
                                string[] operando = row.Cells[3].Value.ToString().Split((char)39);
                                string cadenaBytes = "";
                                foreach (char aux in operando[1]) {
                                    int ascii = aux;
                                    cadenaBytes += ascii.ToString("X");
                                }
                                row.Cells[4].Value = cadenaBytes;
                            }
                            else if (row.Cells[3].Value.ToString().StartsWith("X'") && row.Cells[3].Value.ToString().EndsWith("'")) {
                                string[] operando = row.Cells[3].Value.ToString().Split((char)39);
                                if (operando[1].Length % 2 != 0) {
                                    row.Cells[4].Value = "0" + operando[1];
                                }
                                else {
                                    row.Cells[4].Value = operando[1];
                                }
                            }
                            else {
                                row.Cells[4].Value = "Error: Sintaxis";
                            }
                        }
                        else {
                            bool existe = false;
                            foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones))) {
                                if (row.Cells[2].Value.ToString() == instr.ToString()) {
                                    existe = true;
                                    if (instr.GetHashCode().ToString("X").Length == 1)
                                        row.Cells[4].Value = "0" + instr.GetHashCode().ToString("X");
                                    else
                                        row.Cells[4].Value = instr.GetHashCode().ToString("X");
                                    if (instr.ToString() == "RSUB") {
                                        if (row.Cells[3].Value.ToString().Length != 0)
                                            row.Cells[4].Value = "Error: Sintaxis";
                                        else
                                            row.Cells[4].Value += "0000";
                                    }
                                    else {
                                        string valorSimbolo = "";
                                        foreach (DataGridViewRow row2 in dataGridTabSim.Rows) {
                                            if (row.Cells[3].Value.ToString().Contains(row2.Cells[0].Value.ToString())) {
                                                valorSimbolo = row2.Cells[1].Value.ToString();
                                                break;
                                            }
                                        }
                                        if (valorSimbolo != "") {
                                            if (row.Cells[3].Value.ToString().Contains("X")) {
                                                int contador = int.Parse(valorSimbolo, System.Globalization.NumberStyles.HexNumber) + 32768;
                                                row.Cells[4].Value += contador.ToString("X");
                                            }
                                            else {
                                                row.Cells[4].Value += valorSimbolo;
                                            }
                                            break;
                                        }
                                        else {
                                            row.Cells[4].Value += "FFFF Error: Simbolo no encontrado";
                                            break;
                                        }
                                    }
                                }
                            }
                            if (!existe)
                                row.Cells[4].Value = "Error: Instruccion no valida";
                        }
                    }
                    else
                        row.Cells[4].Value = "---";
                }
                else {
                    row.Cells[4].Value = "Error: Sintaxis";
                }
            }
            RegistroH();
            RegistroT();
            RegistroE();
            File.WriteAllLines(ruta + @"\" + nombre + ".obj", tbRegistros.Lines);
        }

        private void TbPrograma_TextChanged(object sender, EventArgs e) {
            tbLinea.Text = "";
            int cont = 1;
            foreach (string line in tbPrograma.Lines) {
                tbLinea.Text += cont.ToString() + string.Format(Environment.NewLine);
                cont++;
            }
        }

        private void RegistroH() {
            string H = "H";
            string aux;
            //Llenado con el nombre
            if (intermedio.Value(0, 1).Length > 6) { 
                H += intermedio.Value(0, 1).Substring(0, 6);
            }
            else {
                H += intermedio.Value(0, 1);
                for (int i = H.Length - 1; i < 6; i++) {
                    H += " ";
                }
            }

            //Llenado con la dirección de inicio
            aux = intermedio.Value(0, 3);
            while (aux.Length < 6) {
                aux = "0" + aux;
            }
            H += aux;

            //Longitud del programa
            aux = LongPrograma.ToHex();
            while (aux.Length < 6) {
                aux = "0" + aux;
            }
            H += aux;
            tbRegistros.Text += H + Environment.NewLine;
        }

        private void RegistroT() {
            List<string> T = new List<string>();
            List<string> DirT = new List<string>();
            string RegistroT = "";

            foreach (DataGridViewRow row in intermedio.Rows) {
                if (row.Cells[2].Value.ToString() != "START") {
                    if (row.Cells[2].Value.ToString() != "RESW" && row.Cells[2].Value.ToString() != "RESB" && row.Cells[2].Value.ToString() != "END") {
                        if (!row.Cells[4].Value.ToString().StartsWith("Error")) {

                            if (RegistroT.Length + row.Cells[4].Value.ToString().Length <= 60) {
                                if (RegistroT == "") {
                                    DirT.Add(row.Cells[0].Value.ToString());
                                }
                                if (row.Cells[4].Value.ToString().Contains(" Error: Simbolo no encontrado"))
                                    RegistroT += row.Cells[4].Value.ToString().Substring(0, row.Cells[4].Value.ToString().Length - 29);
                                else
                                    RegistroT += row.Cells[4].Value.ToString();
                            }
                            else {
                                T.Add(RegistroT);
                                DirT.Add(row.Cells[0].Value.ToString());
                                RegistroT = row.Cells[4].Value.ToString();
                            }
                        }
                    }
                    else {
                        if (row.Cells[2].Value.ToString() == "END") {
                            if (RegistroT != "") {
                                T.Add(RegistroT);
                                RegistroT = "";
                            }
                        }
                        else
                        {
                            T.Add(RegistroT);
                            RegistroT = "";
                        }
                    }
                }
            }

            T = T.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            for (int i = 0; i < T.Count; i++) {
                string DireccionT = "";
                string LongitudT = "";

                for (int j = DirT[i].Length; j < 6; j++) {
                    DireccionT += "0";
                }
                DireccionT += DirT[i];

                for (int j = (T[i].Length / 2).ToString("X").Length; j < 2; j++) {
                    LongitudT += "0";
                }
                LongitudT += (T[i].Length / 2).ToString("X");

                tbRegistros.Text += "T" + DireccionT + LongitudT + T[i] + Environment.NewLine;
            }
        }

        private void RegistroE() {
            string E = "E";
            //Caso en que exista un operando
            if (intermedio.Rows[intermedio.Rows.Count - 1].Cells[3].Value.ToString() != "") {
                foreach (DataGridViewRow row in dataGridTabSim.Rows) {
                    if (row.Cells[0].Value.ToString() == intermedio.Rows[intermedio.Rows.Count - 1].Cells[3].Value.ToString()) {
                        for (int i = row.Cells[1].Value.ToString().Length; i < 6; i++) {
                            E += "0";
                        }
                        E += row.Cells[1].Value.ToString();
                        tbRegistros.Text += E;
                        return;
                    }
                }
                E += "FFFFFF";
                tbRegistros.Text += E;
            }
            //Caso en que no haya operando
            else {
                foreach (DataGridViewRow row in intermedio.Rows) {
                    foreach (Instrucciones instr in Enum.GetValues(typeof(Instrucciones))) {
                        if (row.Cells[2].Value.ToString() == instr.ToString()) {
                            for (int i = row.Cells[0].Value.ToString().Length; i < 6; i++) {
                                E += "0";
                            }
                            E += row.Cells[0].Value.ToString();
                            tbRegistros.Text += E;
                            return;
                        }
                    }
                }
            }
        }


        private bool EsEtiquetaValida(string etiqueta) {
            bool valido = true;
            valido = !Enum.IsDefined(typeof(Instrucciones), etiqueta);
            valido = !Enum.IsDefined(typeof(Directivas), etiqueta);
            return valido;
        }

        private void btnCargarMemoria_Click(object sender, EventArgs e) {
            MapaMemoria mm = new MapaMemoria(tbRegistros.Lines, LongPrograma);
            mm.Show();
        }

        private void btnAbrirObjeto_Click(object sender, EventArgs e) {
            OpenFileDialog op = new OpenFileDialog {
                InitialDirectory = Application.StartupPath + "\\example",
                Filter = "OBJ File (*.obj)|*.obj|All files (*.*)|*.*",
                DefaultExt = ".obj"
            };
            if (op.ShowDialog() == DialogResult.OK) {
                tbRegistros.Lines = File.ReadAllLines(op.FileName);
            }
        }

        private void tbRegistros_TextChanged(object sender, EventArgs e) {
            if (tbRegistros.Text == "") {
                EstablecerBotonesEjecutar(true, false);
            }
            else {
                EstablecerBotonesEjecutar(true, true);
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e) {

        }


    }
}
