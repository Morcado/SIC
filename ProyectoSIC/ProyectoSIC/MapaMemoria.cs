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
		private string A;
		private string L;
		private string X;
		private string CP;


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
				dir ="00" + (dir.ToDec() + 16).ToHex(); // ("100".ToDec() + dir.ToDec()).TotHex();
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
			ColoreaBytes(pos, Color.LightBlue);
			//Ejecutar();
			EjecutaBytes(textBoxCP.Text);
		}

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

		private void button1_Click(object sender, EventArgs e) {
			Ejecutar();
		}

		private void ColoreaBytes(int[] pos, Color color) {
			for (int i = 0; i < 3; i++) {
				memoria[pos[1], pos[0]].Style.BackColor = color;
				pos[1]++;
			}
		}

		private void Ejecutar() {

		}

		private void EjecutaBytes(string bytes) {
			string codOp = Enum.GetName(typeof(Instrucciones), Convert.ToInt32(bytes.Substring(0, 2)));
			string op = "";
			switch (codOp) {
				case "LDA":
					// Es indexado
					if (bytes[2].ToString().ToDec() > 8 && bytes[2].ToString().ToDec() <= 15) {
						textBoxA.Text = 
					}
					break;
				default:
					break;
			}
		}

		private void btnPaso_Click(object sender, EventArgs e) {

		}

		private void AccedeMemoria() {

		}
	}
}
