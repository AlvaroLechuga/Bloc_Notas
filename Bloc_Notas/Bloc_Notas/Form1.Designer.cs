namespace Bloc_Notas
{
    partial class Bloc_Notas
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloc_Notas));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblLineaActual = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtResultado = new System.Windows.Forms.RichTextBox();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mNuevo = new System.Windows.Forms.ToolStripMenuItem();
			this.mAbrir = new System.Windows.Forms.ToolStripMenuItem();
			this.mGuardar = new System.Windows.Forms.ToolStripMenuItem();
			this.mSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mCortar = new System.Windows.Forms.ToolStripMenuItem();
			this.mCopiar = new System.Windows.Forms.ToolStripMenuItem();
			this.mPegar = new System.Windows.Forms.ToolStripMenuItem();
			this.mBuscar = new System.Windows.Forms.ToolStripMenuItem();
			this.mFuente = new System.Windows.Forms.ToolStripMenuItem();
			this.mColor = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientas = new System.Windows.Forms.ToolStrip();
			this.Nuevo = new System.Windows.Forms.ToolStripButton();
			this.Abrir = new System.Windows.Forms.ToolStripButton();
			this.Guardar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Cortar = new System.Windows.Forms.ToolStripButton();
			this.Copiar = new System.Windows.Forms.ToolStripButton();
			this.Pegar = new System.Windows.Forms.ToolStripButton();
			this.Buscar = new System.Windows.Forms.ToolStripButton();
			this.Fuente = new System.Windows.Forms.ToolStripButton();
			this.Color = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menu.SuspendLayout();
			this.herramientas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.txtResultado);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 379);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.herramientas);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLineaActual});
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblLineaActual
			// 
			this.lblLineaActual.Name = "lblLineaActual";
			this.lblLineaActual.Size = new System.Drawing.Size(76, 17);
			this.lblLineaActual.Text = "Linea actual: ";
			// 
			// txtResultado
			// 
			this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResultado.Location = new System.Drawing.Point(0, 0);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(800, 379);
			this.txtResultado.TabIndex = 0;
			this.txtResultado.Text = "";
			// 
			// menu
			// 
			this.menu.Dock = System.Windows.Forms.DockStyle.None;
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(800, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNuevo,
            this.mAbrir,
            this.mGuardar,
            this.mSalir});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// mNuevo
			// 
			this.mNuevo.Name = "mNuevo";
			this.mNuevo.Size = new System.Drawing.Size(116, 22);
			this.mNuevo.Text = "Nuevo";
			this.mNuevo.Click += new System.EventHandler(this.mNuevo_Click);
			// 
			// mAbrir
			// 
			this.mAbrir.Name = "mAbrir";
			this.mAbrir.Size = new System.Drawing.Size(116, 22);
			this.mAbrir.Text = "Abrir";
			this.mAbrir.Click += new System.EventHandler(this.mAbrir_Click);
			// 
			// mGuardar
			// 
			this.mGuardar.Name = "mGuardar";
			this.mGuardar.Size = new System.Drawing.Size(116, 22);
			this.mGuardar.Text = "Guardar";
			this.mGuardar.Click += new System.EventHandler(this.mGuardar_Click);
			// 
			// mSalir
			// 
			this.mSalir.Name = "mSalir";
			this.mSalir.Size = new System.Drawing.Size(116, 22);
			this.mSalir.Text = "Salir";
			this.mSalir.Click += new System.EventHandler(this.mSalir_Click);
			// 
			// ediciónToolStripMenuItem
			// 
			this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCortar,
            this.mCopiar,
            this.mPegar,
            this.mBuscar,
            this.mFuente,
            this.mColor});
			this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
			this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.ediciónToolStripMenuItem.Text = "Edición";
			// 
			// mCortar
			// 
			this.mCortar.Name = "mCortar";
			this.mCortar.Size = new System.Drawing.Size(180, 22);
			this.mCortar.Text = "Cortar";
			this.mCortar.Click += new System.EventHandler(this.mCortar_Click);
			// 
			// mCopiar
			// 
			this.mCopiar.Name = "mCopiar";
			this.mCopiar.Size = new System.Drawing.Size(180, 22);
			this.mCopiar.Text = "Copiar";
			this.mCopiar.Click += new System.EventHandler(this.mCopiar_Click);
			// 
			// mPegar
			// 
			this.mPegar.Name = "mPegar";
			this.mPegar.Size = new System.Drawing.Size(180, 22);
			this.mPegar.Text = "Pegar";
			this.mPegar.Click += new System.EventHandler(this.mPegar_Click);
			// 
			// mBuscar
			// 
			this.mBuscar.Name = "mBuscar";
			this.mBuscar.Size = new System.Drawing.Size(180, 22);
			this.mBuscar.Text = "Buscar";
			this.mBuscar.Click += new System.EventHandler(this.mBuscar_Click);
			// 
			// mFuente
			// 
			this.mFuente.Name = "mFuente";
			this.mFuente.Size = new System.Drawing.Size(180, 22);
			this.mFuente.Text = "Fuente";
			this.mFuente.Click += new System.EventHandler(this.mFuente_Click);
			// 
			// mColor
			// 
			this.mColor.Name = "mColor";
			this.mColor.Size = new System.Drawing.Size(180, 22);
			this.mColor.Text = "Color";
			this.mColor.Click += new System.EventHandler(this.mColor_Click);
			// 
			// herramientas
			// 
			this.herramientas.Dock = System.Windows.Forms.DockStyle.None;
			this.herramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Abrir,
            this.Guardar,
            this.toolStripSeparator1,
            this.Cortar,
            this.Copiar,
            this.Pegar,
            this.Buscar,
            this.Fuente,
            this.Color});
			this.herramientas.Location = new System.Drawing.Point(3, 24);
			this.herramientas.Name = "herramientas";
			this.herramientas.Size = new System.Drawing.Size(225, 25);
			this.herramientas.TabIndex = 1;
			// 
			// Nuevo
			// 
			this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
			this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Nuevo.Name = "Nuevo";
			this.Nuevo.Size = new System.Drawing.Size(23, 22);
			this.Nuevo.Text = "Nuevo Fichero";
			this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
			// 
			// Abrir
			// 
			this.Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
			this.Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Abrir.Name = "Abrir";
			this.Abrir.Size = new System.Drawing.Size(23, 22);
			this.Abrir.Text = "Abrir Fichero";
			this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
			// 
			// Guardar
			// 
			this.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
			this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(23, 22);
			this.Guardar.Text = "Guardar Fichero";
			this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// Cortar
			// 
			this.Cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Cortar.Image = ((System.Drawing.Image)(resources.GetObject("Cortar.Image")));
			this.Cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Cortar.Name = "Cortar";
			this.Cortar.Size = new System.Drawing.Size(23, 22);
			this.Cortar.Text = "Cortar";
			this.Cortar.Click += new System.EventHandler(this.Cortar_Click);
			// 
			// Copiar
			// 
			this.Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Copiar.Image = ((System.Drawing.Image)(resources.GetObject("Copiar.Image")));
			this.Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Copiar.Name = "Copiar";
			this.Copiar.Size = new System.Drawing.Size(23, 22);
			this.Copiar.Text = "Copiar";
			this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
			// 
			// Pegar
			// 
			this.Pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Pegar.Image = ((System.Drawing.Image)(resources.GetObject("Pegar.Image")));
			this.Pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Pegar.Name = "Pegar";
			this.Pegar.Size = new System.Drawing.Size(23, 22);
			this.Pegar.Text = "Pegar";
			this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
			// 
			// Buscar
			// 
			this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
			this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(23, 22);
			this.Buscar.Text = "Buscar";
			this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
			// 
			// Fuente
			// 
			this.Fuente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Fuente.Image = ((System.Drawing.Image)(resources.GetObject("Fuente.Image")));
			this.Fuente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Fuente.Name = "Fuente";
			this.Fuente.Size = new System.Drawing.Size(23, 22);
			this.Fuente.Text = "Fuente";
			this.Fuente.Click += new System.EventHandler(this.Fuente_Click);
			// 
			// Color
			// 
			this.Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Color.Image = ((System.Drawing.Image)(resources.GetObject("Color.Image")));
			this.Color.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Color.Name = "Color";
			this.Color.Size = new System.Drawing.Size(23, 22);
			this.Color.Text = "Color";
			this.Color.Click += new System.EventHandler(this.Color_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Bloc_Notas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menu;
			this.Name = "Bloc_Notas";
			this.Text = "Bloc de Notas";
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.herramientas.ResumeLayout(false);
			this.herramientas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStrip herramientas;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Abrir;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripMenuItem mNuevo;
        private System.Windows.Forms.ToolStripMenuItem mAbrir;
        private System.Windows.Forms.ToolStripMenuItem mGuardar;
        private System.Windows.Forms.ToolStripMenuItem mSalir;
        private System.Windows.Forms.ToolStripMenuItem mCortar;
        private System.Windows.Forms.ToolStripMenuItem mCopiar;
        private System.Windows.Forms.ToolStripMenuItem mPegar;
        private System.Windows.Forms.ToolStripMenuItem mBuscar;
        private System.Windows.Forms.ToolStripMenuItem mFuente;
        private System.Windows.Forms.ToolStripMenuItem mColor;
        private System.Windows.Forms.ToolStripButton Cortar;
        private System.Windows.Forms.ToolStripButton Copiar;
        private System.Windows.Forms.ToolStripButton Pegar;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripButton Fuente;
        private System.Windows.Forms.ToolStripButton Color;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLineaActual;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

