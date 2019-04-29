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

        public MapaMemoria(string[] objText, int longPrograma) {
            InitializeComponent();
            string dir = objText[0].Substring(7, 6);
            string dirInicio = dir;
            int[] pos;

            label7.Text = objText[0].Substring(13, 6);
            memoria.RowHeadersWidth = 80;
            // Agrega las columnas de la 
            for (int i = 0; i < 16; i++) {
                memoria.Columns.Add(i.ToString("X"), i.ToString("X"));
                memoria.Columns[i].Width = 30;
            }

            for (int i = 0; i < objText[0].Substring(13, 6).ToDec() / 16 + 1; i++) {
                memoria.Rows.Add("FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                memoria.Rows[i].HeaderCell.Value = dir;
                dir = (dir.ToDec() + 16).ToHex(); // ("100".ToDec() + dir.ToDec()).TotHex();
            }

            for (int i = 1; i < objText.Length - 1; i++) {
                pos = memoria.Posicion(objText[i].Substring(1, 6));
                int cont = objText[i].Substring(7, 2).ToDec();
                string resto = objText[i].Substring(9);

                for (int j = 0; j < cont * 2; j += 2) {
                    memoria[pos[1], pos[0]].Value = resto[j].ToString() + resto[j + 1].ToString();

                    pos[1]++;
                    if (pos[1] == 16) {
                        pos[1] = 0;
                        pos[0]++;
                    }
                }
            }

            textBoxCP.Text = objText[0].Substring(7, 6);
            memoria[2, 2].Selected = true;
            memoria.ClearSelection();

            pos = memoria.Posicion(dirInicio);
            ColoreaBytes(0, 14, Color.LightBlue);
            //Ejecutar();
            //EjecutaBytes(textBoxCP.Text);
        }
    
        /* Regresa la posición de la memoria que contiene la dirección*/
        //public int[] EncuentraCasilla(string address) {
        //    int[] pos = { -1, -1 };
        //    for (int i = 0; i < memoria.Rows.Count; i++) {
        //        if ("00" + memoria.Rows[i].HeaderCell.Value.ToString().Substring(0, 3) == address.Substring(0, 5)) {
        //            for (int j = 0; j < 16; j++) {
        //                if ("00" + memoria.Rows[i].HeaderCell.Value.ToString().Remove(3) + j.ToHex() == address) {
        //                    pos[0] = i;
        //                    pos[1] = j;
        //                    return pos;
        //                }
        //            }
        //        }
        //    }
        //    return pos;
        //}

        /* Regresa 3 bytes de la memoria dadas un punto x y y del datagrid*/
        //public string PosMemoria(int x, int y) {
        //    string dir = "";
        //    for (int i = 0; i < 3; i++) {
        //        dir += memoria[y, x].Value.ToString();
        //        if (i == memoria.Columns.Count - 1) {
        //            y = 0;
        //            x++;
        //        }
        //        else {
        //            y++;
        //        }
        //    }
        //    return dir;
        //}

        private void Button1_Click(object sender, EventArgs e) {
            Ejecutar();
        }

        private void ColoreaBytes(int x, int y, Color color) {
            for (int i = 0; i < 3; i++) {
                memoria[y, x].Style.BackColor = color;
                if (y == memoria.Columns.Count - 1) {
                    y = 0;
                    x++;
                }
                else {
                    y++;
                }
            }
        }

        /* Ejecuta todo el programa hasta que la memoria finalice o haya un fallo */
        private void Ejecutar() {

        }

        /* Ejecuta una instrucción de codigo objeto*/
        private void EjecutaBytes(string codObj) {
            int n1, n2;
            string dato;
            string nemonico = codObj.Nemonico();
            string direccion = codObj.Indexado() ? codObj.Dir() : codObj.Dir().Sum(X);

            switch (nemonico) {
                case "ADD":
                 
                    dato = memoria.Accede(direccion);
                    A = A.Sum(dato);

                    break;
                case "AND":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 & n2).ToHex();

                    break;
                case "COMP":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
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

                    break;
                case "DIV":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 / n2).ToHex();
                    break;
                case "J":
                    CP = direccion;
                    break;
                case "JEQ":
                    if (CC == "=") {
                        CP = direccion;
                    }
                    break;
                case "JGT":
                    if (CC == ">") {
                        CP = direccion;
                    }
                    break;
                case "JLT":
                    if (CC == "<") {
                        CP = direccion;
                    }
                    break;
                case "JSUB":
                    L = memoria.Accede(CP);
                    CP = direccion;
                    break;
                case "LDA":
                    A = memoria.Accede(direccion);
                    break;
                case "LDCH":
                    A.SetLSB(memoria.Accede(direccion).GetMSB());
                    break;
                case "LDL":
                    L = memoria.Accede(direccion);
                    break;
                case "LDX":
                    X = memoria.Accede(direccion);
                    break;
                case "MUL":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 * n2).ToHex();
                    break;
                case "OR":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 | n2).ToHex();
                    break;
                case "RD":
                    /* pediente */
                    break;
                case "RSUB":
                    CP = L;
                    break;
                case "STA":
                    memoria.Guarda(direccion, A);
                    break;
                case "STCH":
                    dato = memoria.Accede(direccion);
                    dato.SetMSB(A.GetLSB());
                    memoria.Guarda(direccion, dato);
                    break;
                case "STL":
                    memoria.Guarda(direccion, L);
                    break;
                case "STSW":
                    memoria.Guarda(direccion, SW);
                    break;
                case "STX":
                    memoria.Guarda(direccion, X);
                    break;
                case "SUB":
                    n1 = A.ToDec();
                    n2 = memoria.Accede(direccion).ToDec();
                    A = (n1 - n2).ToHex();
                    break;
                case "TD":
                    /* pendiente */
                    break;
                case "TIX":
                    X = (X.ToDec() + 1).ToHex();
                    break;
                case "WD":
                    /* pendiente */
                default:
                    break;
            }
            textBoxA.Text = A;
            textBoxCP.Text = CP;
            textBoxX.Text = X;
            textBoxL.Text = L;

        }

        /* Avanza un paso en la ejecución del programa*/
        private void BtnPaso_Click(object sender, EventArgs e) {
            memoria.Accede("00106F");
            memoria.Guarda("00106F", "888888");
        }

        private void AccedeMemoria() {
            
        }
    }
}
