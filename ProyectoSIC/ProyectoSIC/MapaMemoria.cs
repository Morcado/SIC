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
                memoria.Rows[i].HeaderCell.Value = dir.Substring(2);
                dir = "00" + (dir.ToDec() + 16).ToHex(); // ("100".ToDec() + dir.ToDec()).TotHex();
            }

            for (int i = 1; i < objText.Length - 1; i++) {
                pos = EncuentraCasilla(objText[i].Substring(1, 6));
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

            pos = EncuentraCasilla(dirInicio);
            ColoreaBytes(pos[0], pos[1], Color.LightBlue);
            //Ejecutar();
            EjecutaBytes(textBoxCP.Text);
        }
    
        /* Regresa la posición de la memoria que contiene la dirección*/
        public int[] EncuentraCasilla(string address) {
            int[] pos = { -1, -1 };
            for (int i = 0; i < memoria.Rows.Count; i++) {
                if ("00" + memoria.Rows[i].HeaderCell.Value.ToString().Substring(0, 3) == address.Substring(0, 5)) {
                    for (int j = 0; j < 16; j++) {
                        if ("00" + memoria.Rows[i].HeaderCell.Value.ToString().Remove(3) + j.ToHex() == address) {
                            pos[0] = i;
                            pos[1] = j;
                            return pos;
                        }
                    }
                }
            }
            return pos;
        }

        /* Regresa 3 bytes de la memoria dadas un punto x y y del datagrid*/
        public string PosMemoria(int x, int y) {
            string dir = "";
            for (int i = 0; i < 3; i++) {
                dir += memoria[y, x].Value.ToString();
                if (i == memoria.Columns.Count - 1) {
                    y = 0;
                    x++;
                }
                else {
                    y++;
                }
            }
            return dir;
        }

        private void Button1_Click(object sender, EventArgs e) {
            Ejecutar();
        }

        private void ColoreaBytes(int x, int y, Color color) {
            for (int i = 0; i < 3; i++) {
                memoria[y, x].Style.BackColor = color;
                if (i == memoria.Columns.Count - 1) {
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
            string nemonico = codObj.Nemonico();
            switch (nemonico) {
                case "ADD":
                    // Es indexado
                    if (codObj.Indexado()) {
                        int m = 2;
                    }
                    break;
                case "AND":
                    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
                //case "LDX":
                //    break;
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

        }

        private void AccedeMemoria() {

        }
    }
}
