using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Antlr4;
using Antlr4.Runtime;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		

		private void button1_Click(object sender, EventArgs e) {
			int cont = 1;
			List<string> results = new List<string>();
			foreach (string line in textBox1.Lines) {

				Combined1Lexer lex = new Combined1Lexer(new AntlrInputStream(line + Environment.NewLine));
				CommonTokenStream tokens = new CommonTokenStream(lex);
				Combined1Parser parser = new Combined1Parser(tokens);

				try {
					parser.prog();
					if (parser.NumberOfSyntaxErrors != 0) {
						results.Add("Error linea " + cont);
					}
					else {
						results.Add("Correcto");
					}
				}
				catch (Exception ex) {
					MessageBox.Show(ex.ToString());
					throw;
				}
				cont++;

			}
			textBox2.Lines = results.ToArray();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog open = new OpenFileDialog {
				InitialDirectory = Application.StartupPath + "\\example",
				Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
				DefaultExt = ".s"
			};
			if (open.ShowDialog() == DialogResult.OK) {
				try {
					textBox1.Lines = File.ReadAllLines(open.FileName);
				}
				catch (IOException ex) {
					MessageBox.Show(ex.ToString());
					throw;
				}
			}
		}


	}



}
