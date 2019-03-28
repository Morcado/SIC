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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.tbErrores = new System.Windows.Forms.TextBox();
			this.Letrero1 = new System.Windows.Forms.Label();
			this.Letrero2 = new System.Windows.Forms.Label();
			this.dataGridTabSim = new System.Windows.Forms.DataGridView();
			this.dgSimbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Letrero3 = new System.Windows.Forms.Label();
			this.Letrero4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ArchivoActivo = new System.Windows.Forms.StatusStrip();
			this.DireccionArchivo = new System.Windows.Forms.ToolStripStatusLabel();
			this.intermedio = new System.Windows.Forms.DataGridView();
			this.dgCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgEtiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgInstruccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgOperando = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCodObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxRes = new System.Windows.Forms.TextBox();
			this.tbRegistros = new System.Windows.Forms.TextBox();
			this.LongitudPrograma = new System.Windows.Forms.Label();
			this.btnCargarMemoria = new System.Windows.Forms.Button();
			this.btnAbrirObjeto = new System.Windows.Forms.Button();
			this.analisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.analizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paso1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paso2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejecuciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargarProgramaObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbLinea = new SyncTextBox();
			this.tbPrograma = new SyncTextBox();
			this.btnAnalizar = new System.Windows.Forms.Button();
			this.btnPaso1 = new System.Windows.Forms.Button();
			this.btnPaso2 = new System.Windows.Forms.Button();
			this.Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTabSim)).BeginInit();
			this.ArchivoActivo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.intermedio)).BeginInit();
			this.SuspendLayout();
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.analisisToolStripMenuItem,
            this.ejecuciónToolStripMenuItem});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(1360, 24);
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
			// tbErrores
			// 
			this.tbErrores.Enabled = false;
			this.tbErrores.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbErrores.Location = new System.Drawing.Point(1182, 53);
			this.tbErrores.Multiline = true;
			this.tbErrores.Name = "tbErrores";
			this.tbErrores.ReadOnly = true;
			this.tbErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbErrores.Size = new System.Drawing.Size(166, 248);
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
			this.Letrero2.Location = new System.Drawing.Point(1179, 34);
			this.Letrero2.Name = "Letrero2";
			this.Letrero2.Size = new System.Drawing.Size(139, 16);
			this.Letrero2.TabIndex = 4;
			this.Letrero2.Text = "Errores en el código";
			// 
			// dataGridTabSim
			// 
			this.dataGridTabSim.AllowUserToAddRows = false;
			this.dataGridTabSim.AllowUserToDeleteRows = false;
			this.dataGridTabSim.AllowUserToResizeColumns = false;
			this.dataGridTabSim.AllowUserToResizeRows = false;
			this.dataGridTabSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridTabSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSimbolo,
            this.dgDireccion});
			this.dataGridTabSim.Location = new System.Drawing.Point(899, 53);
			this.dataGridTabSim.Name = "dataGridTabSim";
			this.dataGridTabSim.ReadOnly = true;
			this.dataGridTabSim.RowHeadersWidth = 20;
			this.dataGridTabSim.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridTabSim.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridTabSim.Size = new System.Drawing.Size(277, 248);
			this.dataGridTabSim.TabIndex = 10;
			// 
			// dgSimbolo
			// 
			this.dgSimbolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgSimbolo.HeaderText = "Simbolo";
			this.dgSimbolo.Name = "dgSimbolo";
			this.dgSimbolo.ReadOnly = true;
			this.dgSimbolo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dgDireccion
			// 
			this.dgDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgDireccion.HeaderText = "Direccion";
			this.dgDireccion.Name = "dgDireccion";
			this.dgDireccion.ReadOnly = true;
			this.dgDireccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Letrero3
			// 
			this.Letrero3.AutoSize = true;
			this.Letrero3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Letrero3.Location = new System.Drawing.Point(896, 34);
			this.Letrero3.Name = "Letrero3";
			this.Letrero3.Size = new System.Drawing.Size(123, 16);
			this.Letrero3.TabIndex = 12;
			this.Letrero3.Text = "Tabla de símbolos";
			// 
			// Letrero4
			// 
			this.Letrero4.AutoSize = true;
			this.Letrero4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Letrero4.Location = new System.Drawing.Point(298, 35);
			this.Letrero4.Name = "Letrero4";
			this.Letrero4.Size = new System.Drawing.Size(130, 16);
			this.Letrero4.TabIndex = 13;
			this.Letrero4.Text = "Archivo intermedio";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(899, 314);
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
			this.ArchivoActivo.Size = new System.Drawing.Size(1360, 22);
			this.ArchivoActivo.SizingGrip = false;
			this.ArchivoActivo.Stretch = false;
			this.ArchivoActivo.TabIndex = 17;
			// 
			// DireccionArchivo
			// 
			this.DireccionArchivo.Name = "DireccionArchivo";
			this.DireccionArchivo.Size = new System.Drawing.Size(0, 17);
			// 
			// intermedio
			// 
			this.intermedio.AllowUserToAddRows = false;
			this.intermedio.AllowUserToDeleteRows = false;
			this.intermedio.AllowUserToResizeColumns = false;
			this.intermedio.AllowUserToResizeRows = false;
			this.intermedio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.intermedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.intermedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCP,
            this.dgEtiqueta,
            this.dgInstruccion,
            this.dgOperando,
            this.dgCodObj});
			this.intermedio.Location = new System.Drawing.Point(301, 53);
			this.intermedio.Name = "intermedio";
			this.intermedio.ReadOnly = true;
			this.intermedio.RowHeadersWidth = 36;
			this.intermedio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F);
			this.intermedio.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.intermedio.Size = new System.Drawing.Size(592, 467);
			this.intermedio.TabIndex = 10;
			// 
			// dgCP
			// 
			this.dgCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgCP.FillWeight = 36F;
			this.dgCP.HeaderText = "CP";
			this.dgCP.Name = "dgCP";
			this.dgCP.ReadOnly = true;
			this.dgCP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dgEtiqueta
			// 
			this.dgEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgEtiqueta.FillWeight = 46F;
			this.dgEtiqueta.HeaderText = "Etiqueta";
			this.dgEtiqueta.Name = "dgEtiqueta";
			this.dgEtiqueta.ReadOnly = true;
			this.dgEtiqueta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dgInstruccion
			// 
			this.dgInstruccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgInstruccion.FillWeight = 46F;
			this.dgInstruccion.HeaderText = "Instrucción";
			this.dgInstruccion.Name = "dgInstruccion";
			this.dgInstruccion.ReadOnly = true;
			this.dgInstruccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dgOperando
			// 
			this.dgOperando.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgOperando.FillWeight = 57.31839F;
			this.dgOperando.HeaderText = "Operando";
			this.dgOperando.Name = "dgOperando";
			this.dgOperando.ReadOnly = true;
			this.dgOperando.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dgCodObj
			// 
			this.dgCodObj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgCodObj.FillWeight = 70F;
			this.dgCodObj.HeaderText = "Codigo Objeto";
			this.dgCodObj.Name = "dgCodObj";
			this.dgCodObj.ReadOnly = true;
			this.dgCodObj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// textBoxRes
			// 
			this.textBoxRes.Location = new System.Drawing.Point(1116, 571);
			this.textBoxRes.Name = "textBoxRes";
			this.textBoxRes.ReadOnly = true;
			this.textBoxRes.Size = new System.Drawing.Size(81, 20);
			this.textBoxRes.TabIndex = 19;
			this.textBoxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbRegistros
			// 
			this.tbRegistros.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRegistros.Location = new System.Drawing.Point(899, 333);
			this.tbRegistros.Multiline = true;
			this.tbRegistros.Name = "tbRegistros";
			this.tbRegistros.ReadOnly = true;
			this.tbRegistros.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbRegistros.Size = new System.Drawing.Size(449, 187);
			this.tbRegistros.TabIndex = 20;
			this.tbRegistros.WordWrap = false;
			this.tbRegistros.TextChanged += new System.EventHandler(this.tbRegistros_TextChanged);
			// 
			// LongitudPrograma
			// 
			this.LongitudPrograma.AutoSize = true;
			this.LongitudPrograma.Location = new System.Drawing.Point(1203, 574);
			this.LongitudPrograma.Name = "LongitudPrograma";
			this.LongitudPrograma.Size = new System.Drawing.Size(35, 13);
			this.LongitudPrograma.TabIndex = 21;
			this.LongitudPrograma.Text = "label2";
			// 
			// btnCargarMemoria
			// 
			this.btnCargarMemoria.Location = new System.Drawing.Point(899, 526);
			this.btnCargarMemoria.Name = "btnCargarMemoria";
			this.btnCargarMemoria.Size = new System.Drawing.Size(117, 23);
			this.btnCargarMemoria.TabIndex = 22;
			this.btnCargarMemoria.Text = "Cargar en memoria";
			this.btnCargarMemoria.UseVisualStyleBackColor = true;
			this.btnCargarMemoria.Click += new System.EventHandler(this.btnCargarMemoria_Click);
			// 
			// btnAbrirObjeto
			// 
			this.btnAbrirObjeto.Location = new System.Drawing.Point(1213, 526);
			this.btnAbrirObjeto.Name = "btnAbrirObjeto";
			this.btnAbrirObjeto.Size = new System.Drawing.Size(135, 23);
			this.btnAbrirObjeto.TabIndex = 23;
			this.btnAbrirObjeto.Text = "Abrir programa objeto";
			this.btnAbrirObjeto.UseVisualStyleBackColor = true;
			this.btnAbrirObjeto.Click += new System.EventHandler(this.btnAbrirObjeto_Click);
			// 
			// analisisToolStripMenuItem
			// 
			this.analisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizarToolStripMenuItem,
            this.paso1ToolStripMenuItem,
            this.paso2ToolStripMenuItem});
			this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
			this.analisisToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.analisisToolStripMenuItem.Text = "Ensamblador";
			// 
			// analizarToolStripMenuItem
			// 
			this.analizarToolStripMenuItem.Name = "analizarToolStripMenuItem";
			this.analizarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.analizarToolStripMenuItem.Text = "Analizar código";
			this.analizarToolStripMenuItem.Click += new System.EventHandler(this.Analizar);
			// 
			// paso1ToolStripMenuItem
			// 
			this.paso1ToolStripMenuItem.Name = "paso1ToolStripMenuItem";
			this.paso1ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.paso1ToolStripMenuItem.Text = "Paso 1 Archivo Intermedio";
			this.paso1ToolStripMenuItem.Click += new System.EventHandler(this.Paso1);
			// 
			// paso2ToolStripMenuItem
			// 
			this.paso2ToolStripMenuItem.Name = "paso2ToolStripMenuItem";
			this.paso2ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.paso2ToolStripMenuItem.Text = "Paso 2 Código objeto";
			this.paso2ToolStripMenuItem.Click += new System.EventHandler(this.Paso2);
			// 
			// ejecuciónToolStripMenuItem
			// 
			this.ejecuciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarProgramaObjetoToolStripMenuItem,
            this.cargarToolStripMenuItem});
			this.ejecuciónToolStripMenuItem.Name = "ejecuciónToolStripMenuItem";
			this.ejecuciónToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.ejecuciónToolStripMenuItem.Text = "Ejecución";
			// 
			// cargarProgramaObjetoToolStripMenuItem
			// 
			this.cargarProgramaObjetoToolStripMenuItem.Name = "cargarProgramaObjetoToolStripMenuItem";
			this.cargarProgramaObjetoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.cargarProgramaObjetoToolStripMenuItem.Text = "Abrir programa objeto";
			this.cargarProgramaObjetoToolStripMenuItem.Click += new System.EventHandler(this.btnAbrirObjeto_Click);
			// 
			// cargarToolStripMenuItem
			// 
			this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
			this.cargarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.cargarToolStripMenuItem.Text = "Cargar en la memoria";
			this.cargarToolStripMenuItem.Click += new System.EventHandler(this.btnCargarMemoria_Click);
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
			this.tbLinea.Size = new System.Drawing.Size(34, 467);
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
			this.tbPrograma.Size = new System.Drawing.Size(250, 467);
			this.tbPrograma.TabIndex = 8;
			this.tbPrograma.TextChanged += new System.EventHandler(this.TbPrograma_TextChanged);
			// 
			// btnAnalizar
			// 
			this.btnAnalizar.Location = new System.Drawing.Point(12, 527);
			this.btnAnalizar.Name = "btnAnalizar";
			this.btnAnalizar.Size = new System.Drawing.Size(127, 23);
			this.btnAnalizar.TabIndex = 24;
			this.btnAnalizar.Text = "Analizar código";
			this.btnAnalizar.UseVisualStyleBackColor = true;
			this.btnAnalizar.Click += new System.EventHandler(this.Analizar);
			// 
			// btnPaso1
			// 
			this.btnPaso1.Location = new System.Drawing.Point(301, 527);
			this.btnPaso1.Name = "btnPaso1";
			this.btnPaso1.Size = new System.Drawing.Size(177, 23);
			this.btnPaso1.TabIndex = 25;
			this.btnPaso1.Text = "Paso 1: Archivo intermedio";
			this.btnPaso1.UseVisualStyleBackColor = true;
			this.btnPaso1.Click += new System.EventHandler(this.Paso1);
			// 
			// btnPaso2
			// 
			this.btnPaso2.Location = new System.Drawing.Point(484, 527);
			this.btnPaso2.Name = "btnPaso2";
			this.btnPaso2.Size = new System.Drawing.Size(177, 23);
			this.btnPaso2.TabIndex = 25;
			this.btnPaso2.Text = "Paso 2: Código objeto";
			this.btnPaso2.UseVisualStyleBackColor = true;
			this.btnPaso2.Click += new System.EventHandler(this.Paso2);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1360, 591);
			this.Controls.Add(this.btnPaso2);
			this.Controls.Add(this.btnPaso1);
			this.Controls.Add(this.btnAnalizar);
			this.Controls.Add(this.btnAbrirObjeto);
			this.Controls.Add(this.btnCargarMemoria);
			this.Controls.Add(this.LongitudPrograma);
			this.Controls.Add(this.tbRegistros);
			this.Controls.Add(this.textBoxRes);
			this.Controls.Add(this.ArchivoActivo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Letrero4);
			this.Controls.Add(this.Letrero3);
			this.Controls.Add(this.intermedio);
			this.Controls.Add(this.dataGridTabSim);
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridTabSim)).EndInit();
			this.ArchivoActivo.ResumeLayout(false);
			this.ArchivoActivo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.intermedio)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridTabSim;
        private System.Windows.Forms.Label Letrero3;
        private System.Windows.Forms.Label Letrero4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip ArchivoActivo;
        private System.Windows.Forms.ToolStripStatusLabel DireccionArchivo;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.DataGridView intermedio;
		private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSimbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDireccion;
        private System.Windows.Forms.TextBox tbRegistros;
        private System.Windows.Forms.Label LongitudPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEtiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInstruccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgOperando;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodObj;
		private System.Windows.Forms.Button btnCargarMemoria;
		private System.Windows.Forms.Button btnAbrirObjeto;
		private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem analizarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paso1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paso2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejecuciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cargarProgramaObjetoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
		private System.Windows.Forms.Button btnAnalizar;
		private System.Windows.Forms.Button btnPaso1;
		private System.Windows.Forms.Button btnPaso2;
	}
}

