using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProyectoSIC {
	public class Linea {
		public string Etiqueta { get; set; }
		public string CodigoOp { get; set; }
		public string Operando { get; set; }
		public bool Indexado { get; set; }
		public int TipoOperando;


		public Linea(string lin) {
			lin.Replace("\t", " ");
			lin = Regex.Replace(lin, @"\s+", " ");
			string[] valores = lin.Split(' ');


			if (valores.Length == 3) {
				Etiqueta = valores[0];
				CodigoOp = valores[1];
				Operando = valores[2];
			}
			else {
				if (valores.Length == 2) {

				Etiqueta = "";
				CodigoOp = valores[0];
				Operando = valores[1];
				}
				else {
					Etiqueta = "";
					CodigoOp = valores[0];
					Operando = "";
				}
			}

			// Verificar que si no es una etiqueta
			//if (Operando != "" && char.IsDigit(Operando.First())) {
			//	if (Operando.Last() != 'h' || Operando.Last() != 'H') {
			//		Operando = Operando.Remove(Operando.Length-1);
			//	}
			//	else {

			//	}
			//}
		}
	}
}
