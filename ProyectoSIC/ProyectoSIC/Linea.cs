using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProyectoSIC
{
	public class Linea
    {
		public string Etiqueta { get; set; }
		public string CodigoOp { get; set; }
		public string Operando { get; set; }
		public bool Indexado { get; set; }
		public bool EsHexadecimal { get; set; }
        public bool Error { get; set; }
		public int TipoOperando;

		public Linea(string lin)
        {
			lin.Replace("\t", " ");
			lin = Regex.Replace(lin, @"\s+", " ");
			string[] valores = lin.Split(' ');

			if (valores.Length == 3)
            {
				Etiqueta = valores[0];
				CodigoOp = valores[1];
				// Convierte todos los valores a decimal
				if (char.IsDigit(valores[2].First()) && (valores[2].Last() == 'h' || valores[2].Last() == 'H'))
                {
					Operando = valores[2].Remove(valores[2].Length - 1);
					Operando = int.Parse(Operando, System.Globalization.NumberStyles.HexNumber).ToString();
					EsHexadecimal = true;
				}
				else
                {
					Operando = valores[2];
				}
			}
			else
            {
				if (valores.Length == 2)
                {
					if (valores[1] == "RSUB" || valores[1] == "END")
                    {
						Etiqueta = "";
						CodigoOp = valores[1];
						Operando = "";
					}
					else
                    {
						Etiqueta = "";
						CodigoOp = valores[0];
						if (char.IsDigit(valores[1].First()) && valores[1].Last() == 'h' || valores[1].Last() == 'H')
                        {
							Operando = valores[1].Remove(valores[1].Length - 1);
							EsHexadecimal = true;
						}
						else
                        {
                            Operando = valores[1];
						}
					}
				}
				else
                {
					// indexado
					if (valores.Length == 4)
                    {
						Etiqueta = valores[0];
						CodigoOp = valores[1];
						Operando = valores[2] + valores[3];
						Indexado = true;
					}
				}
			}
		}
	}
}
