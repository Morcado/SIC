using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSIC {
    public static class Extensions {
        /* Convierte una cadena hexadecimal a entero */
        public static int ToDec(this string hexNum) {
            return int.Parse(hexNum, System.Globalization.NumberStyles.HexNumber);
        }

        /* Convierte entero a cadena hexadecimal*/
        public static string ToHex(this int decNum) {
            return decNum.ToString("X");
        }

        /* Convierte un caracter hexadecimal a entero*/
        public static int ToDec(this char hexNum) {
            return int.Parse(hexNum.ToString(), System.Globalization.NumberStyles.HexNumber);
        }

        /* Obtiene el codigo de operacion de un codigo objeto*/
        public static string CodOp(this string codbj) {
            return codbj.Substring(0, 2);
        }

        /* Verifica si la instruccion es indexada */
        public static bool Indexado(this string codObj) {
            char thirdByte = codObj[2];
            string binary = Convert.ToString(thirdByte - 48, 2).PadLeft(4, '0');
            return binary[0] == '1';
        }

        public static string Add(this string num, string num2) {
            return (num.ToDec() + num2.ToDec()).ToString();
        }

        /* Regresa la dirección del codigo de operacion */
        public static string Dir(this string codObj) {
            string binary = Convert.ToString(codObj.ToDec(), 2).PadLeft(16, '0');
            return Convert.ToInt32(binary.Substring(9), 2).ToString("X");

        }

        /* Regresa el nemonico del codigo de operacion*/
        public static string Nemonico(this string codObj) {
            return Enum.GetName(typeof(Instrucciones), Convert.ToInt32(codObj.Substring(0, 2)));
        }


        /* Obtiene el valor de una celda en la memoria */
        public static string Value(this DataGridView data, int i, int j) {
            return data.Rows[i].Cells[j].Value.ToString();
        }

        /* Acceder a la memoria , recibe una dirección*/
        public static void AccesaMemoria(this DataGridView data, int i, int j, Color color) {
            if (i != -1 && j != -1) {
                data.Rows[i].Cells[j].Style.BackColor = color;
            }
        }

        /* Guarda algo en la memoria */
        public static void GuardaMemoria(this DataGridView data, int i, int j, Color color) {
            if (i != -1 && j != -1) {
                data.Rows[i].Cells[j].Style.BackColor = color;
            }
        }
        public static void SetColor(this DataGridView data, int i, int j, Color color) {
            if (i != -1 && j != -1) {
                data.Rows[i].Cells[j].Style.BackColor = color;
            }
        }
    }
}
