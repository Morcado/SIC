using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSIC {
	public static class Extensions {
		public static int ToDec(this string hexNum) {
			return int.Parse(hexNum, System.Globalization.NumberStyles.HexNumber);
		}

		public static string ToHex(this int decNum) {
			return decNum.ToString("X");
		}

		public static string Value(this DataGridView data, int i, int j) {
			return data.Rows[i].Cells[j].Value.ToString();
		}

		public static void SetValue(this DataGridView data, int i, int j, object dat) {
			data.Rows[i].Cells[j].Value = dat;
		}
	}
}
