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
        private string A = "000000";
        private string L = "000000";
        private string X = "000000";
        private string CP = "000000";
        private string CC = "";
        private string SW = "FFFFFF";

        public MapaMemoria(string[] objText, int longPrograma) {
            InitializeComponent();
            textBoxA.Text = A;
            textBoxCP.Text = CP;
            textBoxL.Text = L;
            textBoxX.Text = X;

            string dir = objText[0].Substring(7, 6);
            string dirInicio = dir;
            int[] pos;

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
        private void EjecutaBytes(string codObj) {
            int n1, n2;
            string dato;
            string nemonico = codObj.Nemonico();
            string direccion = codObj.Indexado() ? codObj.Dir().Sum(X) : codObj.Dir();

            memoria.Colorea(CP, Color.White, 3);
            AgregaLinea(nemonico, direccion);
            switch (nemonico) {
                case "ADD":
                 
                    dato = memoria.Accede(direccion);
                    A = A.Sum(dato);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "AND":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 & n2).ToHex();
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
                    break;
                case "DIV":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 / n2).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "J":
                    CP = direccion;
                    break;
                case "JEQ":
                    CP = CC == "=" ? direccion : (CP.ToDec() + 3).ToHex();
                    break;
                case "JGT":
                    CP = CC == ">" ? direccion : (CP.ToDec() + 3).ToHex();
                    break;
                case "JLT":
                    CP = CC == "<" ? direccion : (CP.ToDec() + 3).ToHex();
                    break;
                case "JSUB":
                    L = memoria.Accede(CP);
                    CP = direccion;
                    break;
                case "LDA":
                    A = memoria.Accede(direccion);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "LDCH":
                    A = A.SetMSB(memoria.Accede(direccion).GetLSB());
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "LDL":
                    L = memoria.Accede(direccion);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "LDX":
                    X = memoria.Accede(direccion);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "MUL":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 * n2).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "OR":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 | n2).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "RD":
                    /* pediente */
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "RSUB":
                    CP = L;
                    break;
                case "STA":
                    memoria.Guarda(direccion, A, 3);
                    memoria.Colorea(direccion, Color.OrangeRed, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STCH":
                    
                    dato = A.GetMSB();
                    memoria.Guarda(direccion, dato, 1);
                    memoria.Colorea(direccion, Color.OrangeRed, 1);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STL":
                    memoria.Guarda(direccion, L, 3);
                    memoria.Colorea(direccion, Color.OrangeRed, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STSW":
                    memoria.Guarda(direccion, SW, 3);
                    memoria.Colorea(direccion, Color.OrangeRed, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "STX":
                    memoria.Guarda(direccion, X, 3);
                    memoria.Colorea(direccion, Color.OrangeRed, 3);
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "SUB":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 - n2).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "TD":
                    /* pendiente */
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                case "TIX":
                    X = (X.ToDec() + 1).ToHex();
                    CP = (CP.ToDec() + 3).ToHex();

                    n1 = X.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    if (n1 < n2) {
                        CC = "<";
                    }
                    else {
                        CC = n1 > n2 ? ">" : "=";
                    }
                    
                    break;
                case "WD":
                    /* pendiente */
                    CP = (CP.ToDec() + 3).ToHex();
                    break;
                default:
                    MessageBox.Show("Operación inválida. Termina ejecución");
                    break;
            }
            memoria.Colorea(CP, Color.LightBlue, 3);
            textBoxA.Text = A;
            textBoxCP.Text = CP;
            textBoxX.Text = X;
            textBoxL.Text = L;
            
        }

        public void AgregaLinea(string nemonico, string direccion) {
            List<string> lines = textBox5.Lines.ToList();
            lines.Add(nemonico + ", " + CP + ", " + direccion);
            textBox5.Lines = lines.ToArray();
        }

        /* Avanza un paso en la ejecución del programa*/
        private void BtnPaso_Click(object sender, EventArgs e) {
            string codOp = memoria.Accede(CP);
            EjecutaBytes(codOp);
        }

        private void MapaMemoria_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F9) {
                MessageBox.Show("f9 pressed");
            }
        }

        private void MapaMemoria_KeyUp(object sender, KeyEventArgs e) {

        }

        private void BtnEjecutaN(object sender, EventArgs e) {

        }

        private void BtnEjecutaTodo(object sender, EventArgs e) {

        }
    }
}
