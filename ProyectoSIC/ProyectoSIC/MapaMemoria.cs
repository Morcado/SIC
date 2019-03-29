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

		public MapaMemoria(string[] objText, int longPrograma) {
			InitializeComponent();
			memoria.RowHeadersWidth = 80;
			label7.Text = objText[0].Substring(13, 6);
			

			string dir = "";

			for (int i = 0; i < 16; i++) {
				memoria.Columns.Add(i.ToString("X"), i.ToString("X"));
				memoria.Columns[i].Width = 30;
			}

			if (objText[0][0] != 'H') {
				dir = "000000";
			}
			else {
				dir = objText[0].Substring(9, 4);
			}

		
			for (int i = 0; i < objText[0].Substring(13, 6).ToDec() / 16 + 1; i++) {
				memoria.Rows.Add("FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
				memoria.Rows[i].HeaderCell.Value = "00" + dir;
				dir = (dir.ToDec() + 16).ToHex(); // ("100".ToDec() + dir.ToDec()).TotHex();
			}

			for (int i = 1; i < objText.Length - 1; i++) { 
				int[] pos = FindRow(objText[i].Substring(1, 6));
				int cont = objText[i].Substring(7, 2).ToDec();
				string resto = objText[i].Substring(9);

				for (int j = 0; j < cont * 2; j += 2) {
					memoria.SetValue(pos[0], pos[1], resto[j].ToString() + resto[j + 1].ToString());
					
					pos[1]++;
					if (pos[1] == 16) {
						pos[1] = 0;
						pos[0]++;
					}
					//memoria.Value(i, j) = 
				}
			}


		}

		public int[] FindRow(string address) {
			int[] pos = { -1, -1 };
			for (int i = 0; i < memoria.Rows.Count; i++) {
				if (memoria.Rows[i].HeaderCell.Value.ToString().Substring(0, 5) == address.Substring(0, 5)) {
					for (int j = 0; j < 16; j++) {
						if (memoria.Rows[i].HeaderCell.Value.ToString().Remove(5) + j.ToHex() == address) {
							pos[0] = i;
							pos[1] = j;
							return pos;
						}
					}
				}
			}
			return pos;
		}
	}
}
