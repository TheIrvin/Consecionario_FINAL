namespace FormularioDeInicio
{
    partial class CatalogoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCliente));
            this.lblCatalogoMotos = new System.Windows.Forms.Label();
            this.lblxCatalogoMotos = new System.Windows.Forms.Label();
            this.panelCatalogoMotos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedorCatalogo = new System.Windows.Forms.Panel();
            this.tsCatalogo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dtgvContenedorCatalogo = new System.Windows.Forms.DataGridView();
            this.panelCatalogoMotos.SuspendLayout();
            this.panelContenedorCatalogo.SuspendLayout();
            this.tsCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatalogoMotos
            // 
            this.lblCatalogoMotos.AutoSize = true;
            this.lblCatalogoMotos.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoMotos.Location = new System.Drawing.Point(8, 0);
            this.lblCatalogoMotos.Name = "lblCatalogoMotos";
            this.lblCatalogoMotos.Size = new System.Drawing.Size(269, 26);
            this.lblCatalogoMotos.TabIndex = 1;
            this.lblCatalogoMotos.Text = "CATÁLOGO DE MOTOS";
            // 
            // lblxCatalogoMotos
            // 
            this.lblxCatalogoMotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxCatalogoMotos.AutoSize = true;
            this.lblxCatalogoMotos.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxCatalogoMotos.Location = new System.Drawing.Point(770, 0);
            this.lblxCatalogoMotos.Name = "lblxCatalogoMotos";
            this.lblxCatalogoMotos.Size = new System.Drawing.Size(27, 26);
            this.lblxCatalogoMotos.TabIndex = 2;
            this.lblxCatalogoMotos.Text = "X";
            this.lblxCatalogoMotos.Click += new System.EventHandler(this.lblxCatalogoClientes_Click);
            // 
            // panelCatalogoMotos
            // 
            this.panelCatalogoMotos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCatalogoMotos.Controls.Add(this.panel2);
            this.panelCatalogoMotos.Controls.Add(this.lblCatalogoMotos);
            this.panelCatalogoMotos.Controls.Add(this.lblxCatalogoMotos);
            this.panelCatalogoMotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogoMotos.Location = new System.Drawing.Point(0, 0);
            this.panelCatalogoMotos.Name = "panelCatalogoMotos";
            this.panelCatalogoMotos.Size = new System.Drawing.Size(800, 35);
            this.panelCatalogoMotos.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 5;
            // 
            // panelContenedorCatalogo
            // 
            this.panelContenedorCatalogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorCatalogo.Controls.Add(this.dtgvContenedorCatalogo);
            this.panelContenedorCatalogo.Controls.Add(this.tsCatalogo);
            this.panelContenedorCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorCatalogo.Location = new System.Drawing.Point(0, 35);
            this.panelContenedorCatalogo.Name = "panelContenedorCatalogo";
            this.panelContenedorCatalogo.Size = new System.Drawing.Size(800, 415);
            this.panelContenedorCatalogo.TabIndex = 6;
            // 
            // tsCatalogo
            // 
            this.tsCatalogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripLabel3,
            this.toolStripSeparator7,
            this.toolStripButton2,
            this.toolStripSeparator8,
            this.toolStripButton3,
            this.toolStripSeparator9,
            this.toolStripButton4,
            this.toolStripSeparator10,
            this.toolStripButton5});
            this.tsCatalogo.Location = new System.Drawing.Point(0, 0);
            this.tsCatalogo.Name = "tsCatalogo";
            this.tsCatalogo.Size = new System.Drawing.Size(800, 25);
            this.tsCatalogo.TabIndex = 0;
            this.tsCatalogo.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "Filtrar:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(110, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel3.Text = "Acciones:";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton2.Text = "Agregar";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton3.Text = "Modificar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton4.Text = "Eliminar";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton5.Text = "Imprimir";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // dtgvContenedorCatalogo
            // 
            this.dtgvContenedorCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContenedorCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContenedorCatalogo.Location = new System.Drawing.Point(0, 25);
            this.dtgvContenedorCatalogo.Name = "dtgvContenedorCatalogo";
            this.dtgvContenedorCatalogo.Size = new System.Drawing.Size(800, 390);
            this.dtgvContenedorCatalogo.TabIndex = 3;
            // 
            // CatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorCatalogo);
            this.Controls.Add(this.panelCatalogoMotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoCliente";
            this.Text = "CatalogoCliente";
            this.panelCatalogoMotos.ResumeLayout(false);
            this.panelCatalogoMotos.PerformLayout();
            this.panelContenedorCatalogo.ResumeLayout(false);
            this.panelContenedorCatalogo.PerformLayout();
            this.tsCatalogo.ResumeLayout(false);
            this.tsCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCatalogoMotos;
        private System.Windows.Forms.Label lblxCatalogoMotos;
        private System.Windows.Forms.Panel panelCatalogoMotos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedorCatalogo;
        private System.Windows.Forms.ToolStrip tsCatalogo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView dtgvContenedorCatalogo;
    }
}