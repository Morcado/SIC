namespace ProyectoSIC
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.analizarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ensamblarCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbErrores = new System.Windows.Forms.TextBox();
			this.Letrero1 = new System.Windows.Forms.Label();
			this.Letrero2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Letrero3 = new System.Windows.Forms.Label();
			this.Letrero4 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ArchivoActivo = new System.Windows.Forms.StatusStrip();
			this.DireccionArchivo = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridIntermedio = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tbLinea = new SyncTextBox();
			this.tbPrograma = new SyncTextBox();
			this.textBoxRes = new System.Windows.Forms.TextBox();
			this.Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.ArchivoActivo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIntermedio)).BeginInit();
			this.SuspendLayout();
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.iniciarToolStripMenuItem});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(1311, 24);
			this.Menu.TabIndex = 0;
			this.Menu.Text = "Menu";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.Nuevo);
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.abrirToolStripMenuItem.Text = "Abrir";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.Abrir);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Enabled = false;
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.Guardar);
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Enabled = false;
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.guardarComoToolStripMenuItem.Text = "Guardar Como";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComo);
			// 
			// cerrarToolStripMenuItem
			// 
			this.cerrarToolStripMenuItem.Enabled = false;
			this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
			this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.cerrarToolStripMenuItem.Text = "Cerrar";
			this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.Cerrar);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
			// 
			// iniciarToolStripMenuItem
			// 
			this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizarProgramaToolStripMenuItem,
            this.ensamblarCodigoToolStripMenuItem});
			this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
			this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.iniciarToolStripMenuItem.Text = "Análisis";
			// 
			// analizarProgramaToolStripMenuItem
			// 
			this.analizarProgramaToolStripMenuItem.Enabled = false;
			this.analizarProgramaToolStripMenuItem.Name = "analizarProgramaToolStripMenuItem";
			this.analizarProgramaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.analizarProgramaToolStripMenuItem.Text = "Analizar código";
			this.analizarProgramaToolStripMenuItem.Click += new System.EventHandler(this.Iniciar);
			// 
			// ensamblarCodigoToolStripMenuItem
			// 
			this.ensamblarCodigoToolStripMenuItem.Enabled = false;
			this.ensamblarCodigoToolStripMenuItem.Name = "ensamblarCodigoToolStripMenuItem";
			this.ensamblarCodigoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.ensamblarCodigoToolStripMenuItem.Text = "Ensamblar código (paso 1)";
			this.ensamblarCodigoToolStripMenuItem.Click += new System.EventHandler(this.EnsamblarCodigoToolStripMenuItem_Click);
			// 
			// tbErrores
			// 
			this.tbErrores.Location = new System.Drawing.Point(1105, 54);
			this.tbErrores.Multiline = true;
			this.tbErrores.Name = "tbErrores";
			this.tbErrores.ReadOnly = true;
			this.tbErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbErrores.Size = new System.Drawing.Size(197, 248);
			this.tbErrores.TabIndex = 2;
			// 
			// Letrero1
			// 
			this.Letrero1.AutoSize = true;
			this.Letrero1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Letrero1.Location = new System.Drawing.Point(9, 35);
			this.Letrero1.Name = "Letrero1";
			this.Letrero1.Size = new System.Drawing.Size(117, 16);
			this.Letrero1.TabIndex = 3;
			this.Letrero1.Text = "Programa fuente";
			// 
			// Letrero2
			// 
			this.Letrero2.AutoSize = true;
			this.Letrero2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Letrero2.Location = new System.Drawing.Point(1102, 35);
			this.Letrero2.Name = "Letrero2";
			this.Letrero2.Size = new System.Drawing.Size(139, 16);
			this.Letrero2.TabIndex = 4;
			this.Letrero2.Text = "Errores en el código";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(884, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(215, 248);
			this.dataGridView1.TabIndex = 10;
			// 
			// Letrero3
			// 
			this.Letrero3.AutoSize = true;
			this.Letrero3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Letrero3.Location = new System.Drawing.Point(881, 35);
			this.Letrero3.Name = "Letrero3";
			this.Letrero3.Size = new System.Drawing.Size(123, 16);
			this.Letrero3.TabIndex = 12;
			this.Letrero3.Text = "Tabla de símbolos";
			// 
			// Letrero4
			// 
			this.Letrero4.AutoSize = true;
			this.Letrero4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Letrero4.Location = new System.Drawing.Point(336, 35);
			this.Letrero4.Name = "Letrero4";
			this.Letrero4.Size = new System.Drawing.Size(130, 16);
			this.Letrero4.TabIndex = 13;
			this.Letrero4.Text = "Archivo intermedio";
			// 
			// dataGridView2
			// 
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(884, 334);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(418, 216);
			this.dataGridView2.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(881, 315);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Registros";
			// 
			// ArchivoActivo
			// 
			this.ArchivoActivo.AllowMerge = false;
			this.ArchivoActivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DireccionArchivo});
			this.ArchivoActivo.Location = new System.Drawing.Point(0, 569);
			this.ArchivoActivo.Name = "ArchivoActivo";
			this.ArchivoActivo.Size = new System.Drawing.Size(1311, 22);
			this.ArchivoActivo.SizingGrip = false;
			this.ArchivoActivo.Stretch = false;
			this.ArchivoActivo.TabIndex = 17;
			// 
			// DireccionArchivo
			// 
			this.DireccionArchivo.Name = "DireccionArchivo";
			this.DireccionArchivo.Size = new System.Drawing.Size(0, 17);
			// 
			// dataGridIntermedio
			// 
			this.dataGridIntermedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridIntermedio.Location = new System.Drawing.Point(349, 53);
			this.dataGridIntermedio.Name = "dataGridIntermedio";
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F);
			this.dataGridIntermedio.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridIntermedio.Size = new System.Drawing.Size(517, 497);
			this.dataGridIntermedio.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(159, 518);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Ensamblar (paso 1)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.EnsamblarCodigoToolStripMenuItem_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 518);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "Analizar código";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Iniciar);
			// 
			// tbLinea
			// 
			this.tbLinea.Buddy = this.tbPrograma;
			this.tbLinea.Enabled = false;
			this.tbLinea.Font = new System.Drawing.Font("Consolas", 9F);
			this.tbLinea.Location = new System.Drawing.Point(12, 53);
			this.tbLinea.Multiline = true;
			this.tbLinea.Name = "tbLinea";
			this.tbLinea.ReadOnly = true;
			this.tbLinea.Size = new System.Drawing.Size(34, 450);
			this.tbLinea.TabIndex = 9;
			this.tbLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbPrograma
			// 
			this.tbPrograma.AcceptsTab = true;
			this.tbPrograma.Buddy = this.tbLinea;
			this.tbPrograma.Font = new System.Drawing.Font("Consolas", 9F);
			this.tbPrograma.Location = new System.Drawing.Point(45, 53);
			this.tbPrograma.Multiline = true;
			this.tbPrograma.Name = "tbPrograma";
			this.tbPrograma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbPrograma.Size = new System.Drawing.Size(288, 450);
			this.tbPrograma.TabIndex = 8;
			this.tbPrograma.TextChanged += new System.EventHandler(this.TbPrograma_TextChanged);
			// 
			// textBoxRes
			// 
			this.textBoxRes.Location = new System.Drawing.Point(121, 520);
			this.textBoxRes.Name = "textBoxRes";
			this.textBoxRes.Size = new System.Drawing.Size(32, 20);
			this.textBoxRes.TabIndex = 19;
			this.textBoxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1311, 591);
			this.Controls.Add(this.textBoxRes);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ArchivoActivo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.Letrero4);
			this.Controls.Add(this.Letrero3);
			this.Controls.Add(this.dataGridIntermedio);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tbLinea);
			this.Controls.Add(this.tbPrograma);
			this.Controls.Add(this.Letrero2);
			this.Controls.Add(this.Letrero1);
			this.Controls.Add(this.tbErrores);
			this.Controls.Add(this.Menu);
			this.MainMenuStrip = this.Menu;
			this.MaximizeBox = false;
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIC";
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ArchivoActivo.ResumeLayout(false);
			this.ArchivoActivo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIntermedio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.TextBox tbErrores;
        private System.Windows.Forms.Label Letrero1;
        private System.Windows.Forms.Label Letrero2;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private SyncTextBox tbPrograma;
        private SyncTextBox tbLinea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Letrero3;
        private System.Windows.Forms.Label Letrero4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ArchivoActivo;
        private System.Windows.Forms.ToolStripStatusLabel DireccionArchivo;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem analizarProgramaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ensamblarCodigoToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridIntermedio;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxRes;
	}
}

