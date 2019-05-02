using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSIC {
    public partial class MapaMemoria : Form {
        private string A = "FFFFFF";
        private string L = "FFFFFF";
        private string X = "FFFFFF";
        private string CP = "FFFFFF";
        private string CC = "";
        private string SW = "FFFFFF";
        private int tamProg = 0;
        private string[] obj;
        public MapaMemoria(string[] objText, int longPrograma) {
            InitializeComponent();
            obj = objText;
            InicializaMemoria(obj);
        }

        private void InicializaMemoria(string[] objText) {
            textBoxA.Text = A;
            textBoxCP.Text = CP;
            textBoxL.Text = L;
            textBoxX.Text = X;


            string dir = objText[0].Substring(7, 6);
            string dirInicio = dir;
            int[] pos;
            tamProg = objText[0].Substring(13, 6).ToDec() + dir.ToDec();

            label7.Text = objText[0].Substring(13, 6);
            memoria.RowHeadersWidth = 80;
            // Agrega las columnas de la tabal
            for (int i = 0; i < 16; i++) {
                memoria.Columns.Add(i.ToString("X"), i.ToString("X"));
                memoria.Columns[i].Width = 30;
            }
            dir = dir.Substring(0, 5) + "0";
            // Agrega las filas de la tabla + 1
            for (int i = 0; i < (int)Math.Ceiling(objText[0].Substring(13, 6).ToDec() / 16.0) + 1; i++) {
                memoria.Rows.Add("FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                memoria.Rows[i].HeaderCell.Value = dir;
                dir = (dir.ToDec() + 16).ToHex(); // ("100".ToDec() + dir.ToDec()).TotHex();
            }

            for (int i = 1; i < objText.Length - 1; i++) {
                pos = memoria.Posicion(objText[i].Substring(1, 6));
                int cont = objText[i].Substring(7, 2).ToDec();
                string resto = objText[i].Substring(9);

                for (int j = 0; j < cont * 2; j += 2) {
                    //memoria[pos[1], pos[0]].Value = resto[j].ToString() + resto[j + 1].ToString();
                    memoria.Rows[pos[0]].Cells[pos[1]].Value = resto[j].ToString() + resto[j + 1].ToString();
                    pos[1]++;
                    if (pos[1] == 16) {
                        pos[1] = 0;
                        pos[0]++;
                    }
                }
            }

            CP = textBoxCP.Text = objText[0].Substring(7, 6);
            //memoria[2, 2].Selected = true;
            memoria.ClearSelection();
            memoria.Colorea(dirInicio, Color.LightBlue, 3);
        }

        private void Button1_Click(object sender, EventArgs e) {

        }

        /* Ejecuta una instrucción de codigo objeto*/
        private bool EjecutaBytes(string codObj) {
            int n1, n2, ndato;
            string sdato;
            string nemonico = codObj.Nemonico();
            string direccion = codObj.Indexado() ? codObj.Dir().Sum(X) : codObj.Dir();
            string CPToWrite;
            string efecto = "";
            if (direccion.ToDec() > tamProg) {
                memoria.Colorea(CP, Color.OrangeRed, 3);
                MessageBox.Show("Intrucción inválida, ejecución terminada");
                return false;
            }
            memoria.Colorea(CP, Color.White, 3);
            CPToWrite = CP;
            switch (nemonico) {
                case "ADD":
                    sdato = memoria.Accede(direccion);
                    efecto = "A ← (A) + (m..m+2)\tA ← " + A + "+" + sdato;
                    A = A.Sum(sdato);
                    CP = (CP.ToDec() + 3).ToHex();

                    break;
                case "AND":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    ndato = n1 & n2;
                    efecto = "A ← (A) & (m..m+2)\tA ← " + A + "&" + ndato;
                    A = ndato.ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "COMP":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    if (n1 < n2) {
                        CC = "<";
                    }
                    else {
                        CC = n1 > n2 ? ">" : "=";
                    }
                    CP = (CP.ToDec() + 3).ToHex();
                    efecto = "(A) : (m..m+2)\t(" + A + ") : " + n2 + "\tC ← " + CC;
                    break;
                case "DIV":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    ndato = n1 / n2;
                    A = ndato.ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    efecto = "A ← (A) / (m..m+2)\tA ← " + A + "\\" + ndato;
                    break;
                case "J":
                    efecto = "CP ← M\tCP ← " + direccion;
                    CP = direccion;
                    break;
                case "JEQ":
                    efecto = "CP ← M si CC => =\tCP ← ";
                    if (CC == "=") {
                        efecto += direccion;
                        CP = direccion;
                    }
                    else {
                        CP = (CP.ToDec() + 3).ToHex();
                    }
                    break;
                case "JGT":
                    efecto = "CP ← M si CC => >\tCP ← ";
                    if (CC == ">") {
                        efecto += direccion;
                        CP = direccion;
                    }
                    else {
                        CP = (CP.ToDec() + 3).ToHex();
                    }
                    break;
                case "JLT":
                    efecto = "CP ← M si CC => <\tCP ← ";
                    if (CC == "<") {
                        efecto += direccion;
                        CP = direccion;
                    }
                    else {
                        CP = (CP.ToDec() + 3).ToHex();
                    }
                    break;
                case "JSUB":
                    sdato = memoria.Accede(CP);
                    efecto = "L ← (CP); CP ← m\tL ← " + sdato + "; CP ← " + direccion;
                    L = sdato;
                    CP = direccion;
                    break;
                case "LDA":
                    sdato = memoria.Accede(direccion);
                    efecto = "A ← (m..m+2)\tA ← " + sdato;
                    A = sdato;
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "LDCH":
                    sdato = memoria.Accede(direccion).GetLSB();
                    efecto = "A[byte mas derecha] ← (m)\tA ← " + sdato;
                    A = A.SetMSB(sdato);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "LDL":
                    sdato = memoria.Accede(direccion);
                    efecto = "L ← (m..m+2)\tL ← " + sdato;
                    L = sdato;
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "LDX":
                    sdato = memoria.Accede(direccion);
                    efecto = "X ← (m..m+2)\tX ← " + sdato;
                    X = sdato;
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "MUL":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    ndato = n1 * n2;
                    efecto = "A ← (A) * (m..m+2)\tA ← " + A + "*" + ndato;
                    A = ndato.ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "OR":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    ndato = n1 | n2;
                    efecto = "A ← (A) | (m..m+2)\tA ← " + A + "|" + ndato;
                    A = ndato.ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "RD":
                    /* pediente */
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "RSUB":
                    efecto = "CP ← L\tCP ← " + L;
                    CP = L;
                    break;
                case "STA":
                    efecto = "m..m+2 ← (A)\t(" + direccion + ") ← " + A;
                    memoria.Guarda(direccion, A, 3);
                    memoria.Colorea(direccion, Color.LightGreen, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STCH":
                    sdato = A.GetMSB();
                    efecto = "m ← (A)[byte mas derecha]\t(" + direccion + ") ← " + sdato;
                    memoria.Guarda(direccion, sdato, 1);
                    memoria.Colorea(direccion, Color.LightGreen, 1);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STL":
                    efecto = "m..m+2 ← (L)\t(" + direccion + ") ← " + L;
                    memoria.Guarda(direccion, L, 3);
                    memoria.Colorea(direccion, Color.LightGreen, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STSW":
                    efecto = "m..m+2 ← (SW)\t(" + direccion + ") ← " + SW;
                    memoria.Guarda(direccion, SW, 3);
                    memoria.Colorea(direccion, Color.LightGreen, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STX":
                    efecto = "m..m+2 ← (X)\t(" + direccion + ") ← " + X;
                    memoria.Guarda(direccion, X, 3);
                    memoria.Colorea(direccion, Color.LightGreen, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "SUB":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    ndato = n1 - n2;
                    efecto = "A ← (A) - (m..m+2)\tA ← " + A + "-" + ndato;
                    A = (n1 - n2).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "TD":
                    /* pendiente */
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "TIX":
                    
                    efecto = "X ← (X) + 1; (X) : (m..m+2)\tX = " + X + " + 1; ";

                    X = (X.ToDec() + 1).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    n1 = X.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();

                    efecto += "(" + X + ")" + " : " + n2 + ", ";
                    if (n1 < n2) {
                        CC = "<";
                    }
                    else {
                        if (n1 > n2) {
                            CC = ">";
                        }
                        else {
                            CC = "=";
                        }
                    }

                    efecto += "CC ← " + CC;
                    break;
                case "WD":
                    /* pendiente */
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                default:
                    memoria.Colorea(CP, Color.OrangeRed, 3);
                    MessageBox.Show("Intrucción inválida, ejecución terminada");
                    return false;
            }

            AgregaLinea(nemonico, CPToWrite, efecto);
            memoria.Colorea(CP, Color.LightBlue, 3);
            textBoxA.Text = A;
            textBoxCP.Text = CP;
            textBoxX.Text = X;
            textBoxL.Text = L;
            textBoxCC.Text = CC;
            return true;
        }

        public void AgregaLinea(string nemonico, string direccion, string effect) {
            List<string> lines = textBox5.Lines.ToList();
            if (nemonico != "RSUB" && !Enum.IsDefined(typeof(Directivas), nemonico)) {
                lines.Add("CP: " + CP + ", Instruccion: " + nemonico + " m");
            }
            else {
                lines.Add("CP: " + CP + ", Instruccion: " + nemonico + ", " + "Efecto: " + effect);
            }
            lines.Add("Efecto: " + effect);
            lines.Add("");
            textBox5.Lines = lines.ToArray();
        }

        /* Avanza un paso en la ejecución del programa*/
        private void BtnPaso_Click(object sender, EventArgs e) {
            string codOp = memoria.Accede(CP);
            EjecutaBytes(codOp);
        }

        private void MapaMemoria_KeyDown(object sender, KeyEventArgs e) {
            string codOp = memoria.Accede(CP);
            EjecutaBytes(codOp);
        }

        private void BtnEjecutaN(object sender, EventArgs e) {
            int n = Convert.ToInt32(numericUpDown1.Value);

            bool quizo = true;

            for (int i = 0; i < n && quizo; i++) {
                string codOp = memoria.Accede(CP);
                quizo = EjecutaBytes(codOp);
            }

            if (quizo) {
                MessageBox.Show(n.ToString() + " instrucciones ejecutadas");
            }
        }

        private void BtnEjecutaTodo(object sender, EventArgs e) {
            bool quiere = true;

            while (quiere) {
                string codOp = memoria.Accede(CP);
                quiere = EjecutaBytes(codOp);
            }
            

        }

        private void BtnReiniciar_Click(object sender, EventArgs e) {
            memoria.Columns.Clear();
            textBox5.Clear();
            textBoxA.Text = A = "FFFFFF";
            textBoxCP.Text = CP = "FFFFFF";
            textBoxL.Text = L = "FFFFFF";
            textBoxX.Text = X = "FFFFFF";
            InicializaMemoria(obj);
        }
    }
}
