using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Antlr4.Runtime;
using System.IO;
using System.Drawing;

namespace ProyectoSIC {
	public enum Instrucciones{
		ADD, AND, COMP, DIV, J, JEQ, JGT, JLT, JSUB, LDA, LDCH, LDL, LDX, MUL, OR, RD, RSUB, STA, STCH, STL, STSW, STX, SUB, TD, TIX, WD
	}

	public partial class Principal : Form
	{
		public string nombre, ruta;
		private Programa programa;

		public Principal() {
			InitializeComponent();
			tbPrograma.Select();
			tbPrograma.Enabled = false;
		}

		private void Nuevo(object sender, EventArgs e) {
			tbPrograma.Text = "";
			tbLinea.Text = "";
			tbErrores.Text = "";
			nombre = "";
			ActiveForm.Text = "SIC";
			DireccionArchivo.Text = "";
			ActivaControles();
			programa = new Programa();
		}

		private void Abrir(object sender, EventArgs e){
			OpenFileDialog open = new OpenFileDialog {
				InitialDirectory = Application.StartupPath + "\\example",
				Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
				DefaultExt = ".s"
			};
			if (open.ShowDialog() == DialogResult.OK) {
				ruta = Directory.GetParent(open.FileName).ToString();
				tbPrograma.Lines = File.ReadAllLines(open.FileName);
				string[] files = open.FileName.Split((char)92);
				string[] file = files[files.Length - 1].Split('.');
				nombre = file[0];
				tbPrograma_TextChanged(this, null);
				ActiveForm.Text = "SIC - " + nombre;
				DireccionArchivo.Text = open.FileName;
				ActivaControles();
				programa = new Programa();
			}
		}

		private void Guardar(object sender, EventArgs e) {
			if (ruta != null){
				File.WriteAllLines(ruta + @"\" + nombre + ".s", tbPrograma.Lines);
				tbPrograma.DeselectAll();
			}
			else{
				guardarComoToolStripMenuItem.PerformClick();
			}
		}

		private void GuardarComo(object sender, EventArgs e) {
			SaveFileDialog save = new SaveFileDialog {
				InitialDirectory = Application.StartupPath + "\\example",
				Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
				DefaultExt = ".s"
			};
			if (save.ShowDialog() == DialogResult.OK) {
				File.WriteAllLines(save.FileName, tbPrograma.Lines);
				tbPrograma.DeselectAll();
			}
		}

		private void ActivaControles() {
			tbPrograma.Enabled = true;
			guardarToolStripMenuItem.Enabled = true;
			guardarComoToolStripMenuItem.Enabled = true;
			cerrarToolStripMenuItem.Enabled = true;
			analizarProgramaToolStripMenuItem.Enabled = true;
			ensamblarCodigoToolStripMenuItem.Enabled = false;
		}
		private void DesactivaControles() {
			tbPrograma.Enabled = false;
			guardarToolStripMenuItem.Enabled = false;
			guardarComoToolStripMenuItem.Enabled = false;
			cerrarToolStripMenuItem.Enabled = false;
			analizarProgramaToolStripMenuItem.Enabled = false;
		}

		private void Cerrar(object sender, EventArgs e) {
			tbPrograma.Text = "";
			tbLinea.Text = "";
			tbErrores.Text = "";
			nombre = "";
			ActiveForm.Text = "SIC";
			DireccionArchivo.Text = "";
			DesactivaControles();
		}

		private void Iniciar(object sender, EventArgs e) {
			if (tbPrograma.Text != "") {
				int cont = 0;
				bool correcto = true;
				List<string> results = new List<string>();
				programa.lineas.Clear();
				foreach (string line in tbPrograma.Lines) {
					Linea linea = new Linea(line);
					programa.lineas.Add(linea);
					GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(line + Environment.NewLine));
					CommonTokenStream tokens = new CommonTokenStream(lex);
					GramaticaParser parser = new GramaticaParser(tokens);

					try {
						parser.prog();
						if (parser.NumberOfSyntaxErrors != 0) {
							results.Add("Error linea " + (cont).ToString());
							correcto = false;
						}
					}
					catch (Exception ex) {
						MessageBox.Show(ex.ToString());
						throw;
					}

					cont++;
				}
				if (correcto) {
					ensamblarCodigoToolStripMenuItem.Enabled = true;
					textBoxRes.BackColor = Color.Green;
					textBoxRes.Text = "OK";
				}
				else {
					textBoxRes.BackColor = Color.Red;
					textBoxRes.ForeColor = Color.White;
					textBoxRes.Text = "NO";
					tbErrores.Lines = results.ToArray();
					File.WriteAllLines(ruta + @"\" + nombre + ".t", tbErrores.Lines);
				}
			}
			else {
				MessageBox.Show("Carga un programa");
			}
		}

		private void tbPrograma_TextChanged(object sender, EventArgs e)
		{
			tbLinea.Text = "";
			int cont = 0;
			foreach (string line in tbPrograma.Lines) {
				tbLinea.Text += cont.ToString() + string.Format(Environment.NewLine);

				cont++;
			}
		}

		private void EnsamblarCodigoToolStripMenuItem_Click(object sender, EventArgs e) {
			var dt = new DataGridViewTextBoxColumn() { HeaderText = "Dirección", Name = "Dirección" };
			var dt2 = new DataGridViewTextBoxColumn() { HeaderText = "Etiqueta", Name = "Etiqueta" };
			var dt3 = new DataGridViewTextBoxColumn() { HeaderText = "Código de operación", Name = "Código de operación" };
			var dt4 = new DataGridViewTextBoxColumn() { HeaderText = "Operando", Name = "Operando" };
			dataGridIntermedio.Columns.AddRange(dt, dt2, dt3, dt4);
			dataGridIntermedio.RowHeadersWidth = 60;

			// hacer las operaciones de suma de contador en decimal, al imprimir hacerlo en hexadecimal
			//if (char.IsLetter(programa.lineas[0].Operando[programa.lineas[0].Operando.Length - 1])) {
			//	programa.lineas[0]
			//}

			//string start = Convert.ToInt32(programa.lineas[0].Operando).ToString("X");


			for (int i = 0; i < programa.lineas.Count; i++) {
				dataGridIntermedio.Rows.Add("hola", programa.lineas[i].Etiqueta, programa.lineas[i].CodigoOp, programa.lineas[i].Operando);
				dataGridIntermedio.Rows[i].HeaderCell.Value = (i + 1).ToString();
				
			}
		}

		private void SalirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

	}
}
