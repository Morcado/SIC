using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4;
using Antlr4.Runtime;
using System.IO;

namespace ProyectoSIC
{
    public partial class Principal : Form
    {
        public string nombre, ruta;

        public Principal()
        {
            InitializeComponent();
            tbPrograma.Select();
            tbPrograma.Enabled = false;
        }

        private void Nuevo(object sender, EventArgs e)
        {
            tbPrograma.Text = "";
            tbLinea.Text = "";
            tbErrores.Text = "";
            nombre = "";
            ActiveForm.Text = "SIC";
            DireccionArchivo.Text = "";
            tbPrograma.Enabled = true;
        }

        private void Abrir(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath + "\\example",
                Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
                DefaultExt = ".s"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta = Directory.GetParent(open.FileName).ToString();
                tbPrograma.Lines = File.ReadAllLines(open.FileName);
                string[] files = open.FileName.Split((char)92);
                string[] file = files[files.Length - 1].Split('.');
                nombre = file[0];
                ActualizaNumeroLineas();
                ActiveForm.Text = "SIC - " + nombre;
                DireccionArchivo.Text = open.FileName;
                tbPrograma.Enabled = true;
            }
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (ruta != null)
            {
                File.WriteAllLines(ruta + @"\" + nombre + ".s", tbPrograma.Lines);
                tbPrograma.DeselectAll();
            }
            else
            {
                guardarComoToolStripMenuItem.PerformClick();
            }
        }

        private void GuardarComo(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath + "\\example",
                Filter = "SIC File (*.s)|*.s|All files (*.*)|*.*",
                DefaultExt = ".s"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(save.FileName, tbPrograma.Lines);
                tbPrograma.DeselectAll();
            }
        }

        private void Cerrar(object sender, EventArgs e)
        {
            tbPrograma.Text = "";
            tbLinea.Text = "";
            tbErrores.Text = "";
            nombre = "";
            ActiveForm.Text = "SIC";
            DireccionArchivo.Text = "";
            tbPrograma.Enabled = false;
        }

        private void Iniciar(object sender, EventArgs e)
        {
            if (tbPrograma.Text != "")
            {
                int cont = 1;
                List<string> results = new List<string>();

                foreach (string line in tbPrograma.Lines)
                {
                    GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(line + Environment.NewLine));
                    CommonTokenStream tokens = new CommonTokenStream(lex);
                    GramaticaParser parser = new GramaticaParser(tokens);

                    try
                    {
                        parser.prog();
                        if (parser.NumberOfSyntaxErrors != 0)
                        {
                            results.Add("Error linea " + cont);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                    cont++;
                }
                tbErrores.Lines = results.ToArray();
                File.WriteAllLines(ruta + @"\" + nombre + ".t", tbErrores.Lines);
            }
            else
                MessageBox.Show("Carga un programa");
        }

        private void tbPrograma_TextChanged(object sender, EventArgs e)
        {
            ActualizaNumeroLineas();
        }

        private void ActualizaNumeroLineas()
        {
            tbLinea.Text = "";
            int cont = 1;
            foreach (string line in tbPrograma.Lines)
            {
                tbLinea.Text += cont.ToString() + string.Format(Environment.NewLine);
                cont++;
            }
        }
    }
}
