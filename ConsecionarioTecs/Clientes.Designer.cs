namespace FormularioDeInicio
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.lblClientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblxClientes = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAgregarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.dtgvContendorClientes = new System.Windows.Forms.DataGridView();
            this.panelContenedorClientes = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContendorClientes)).BeginInit();
            this.panelContenedorClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(11, 0);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(157, 34);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "CLIENTES";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 32);
            this.panel1.TabIndex = 4;
            // 
            // lblxClientes
            // 
            this.lblxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxClientes.AutoSize = true;
            this.lblxClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxClientes.Location = new System.Drawing.Point(1027, 0);
            this.lblxClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblxClientes.Name = "lblxClientes";
            this.lblxClientes.Size = new System.Drawing.Size(35, 34);
            this.lblxClientes.TabIndex = 3;
            this.lblxClientes.Text = "X";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttlbFiltrar,
            this.tstxtFiltrar,
            this.tsbtnFiltrar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsbtnAgregarCliente,
            this.toolStripSeparator3,
            this.tsBtnModificarCliente,
            this.toolStripSeparator4,
            this.tsbtnEliminar,
            this.toolStripSeparator5,
            this.tsbtnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ttlbFiltrar
            // 
            this.ttlbFiltrar.Name = "ttlbFiltrar";
            this.ttlbFiltrar.Size = new System.Drawing.Size(50, 28);
            this.ttlbFiltrar.Text = "Filtrar:";
            // 
            // tstxtFiltrar
            // 
            this.tstxtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFiltrar.Name = "tstxtFiltrar";
            this.tstxtFiltrar.Size = new System.Drawing.Size(145, 31);
            // 
            // tsbtnFiltrar
            // 
            this.tsbtnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrar.Image")));
            this.tsbtnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrar.Name = "tsbtnFiltrar";
            this.tsbtnFiltrar.Size = new System.Drawing.Size(29, 28);
            this.tsbtnFiltrar.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 28);
            this.toolStripLabel1.Text = "Acciones:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnAgregarCliente
            // 
            this.tsbtnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarCliente.Image")));
            this.tsbtnAgregarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarCliente.Name = "tsbtnAgregarCliente";
            this.tsbtnAgregarCliente.Size = new System.Drawing.Size(87, 28);
            this.tsbtnAgregarCliente.Text = "Agregar";
            this.tsbtnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsBtnModificarCliente
            // 
            this.tsBtnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModificarCliente.Image")));
            this.tsBtnModificarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificarCliente.Name = "tsBtnModificarCliente";
            this.tsBtnModificarCliente.Size = new System.Drawing.Size(97, 28);
            this.tsBtnModificarCliente.Text = "Modificar";
            this.tsBtnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(87, 28);
            this.tsbtnEliminar.Text = "Eliminar";
            this.tsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnImprimir
            // 
            this.tsbtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImprimir.Image")));
            this.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimir.Name = "tsbtnImprimir";
            this.tsbtnImprimir.Size = new System.Drawing.Size(90, 28);
            this.tsbtnImprimir.Text = "Imprimir";
            this.tsbtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // dtgvContendorClientes
            // 
            this.dtgvContendorClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContendorClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvContendorClientes.Location = new System.Drawing.Point(0, 34);
            this.dtgvContendorClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvContendorClientes.Name = "dtgvContendorClientes";
            this.dtgvContendorClientes.RowHeadersWidth = 51;
            this.dtgvContendorClientes.Size = new System.Drawing.Size(1067, 480);
            this.dtgvContendorClientes.TabIndex = 1;
            this.dtgvContendorClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvContendorClientes_CellContentClick);
            // 
            // panelContenedorClientes
            // 
            this.panelContenedorClientes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorClientes.Controls.Add(this.dtgvContendorClientes);
            this.panelContenedorClientes.Controls.Add(this.toolStrip1);
            this.panelContenedorClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContenedorClientes.Location = new System.Drawing.Point(0, 40);
            this.panelContenedorClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedorClientes.Name = "panelContenedorClientes";
            this.panelContenedorClientes.Size = new System.Drawing.Size(1067, 514);
            this.panelContenedorClientes.TabIndex = 5;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContenedorClientes);
            this.Controls.Add(this.lblxClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContendorClientes)).EndInit();
            this.panelContenedorClientes.ResumeLayout(false);
            this.panelContenedorClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblxClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrar;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAgregarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnModificarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.Panel panelContenedorClientes;
        public System.Windows.Forms.DataGridView dtgvContendorClientes;
    }
}