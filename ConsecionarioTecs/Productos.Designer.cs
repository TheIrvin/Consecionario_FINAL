namespace FormularioDeInicio
{
    partial class Productos
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
            this.lblProductos1 = new System.Windows.Forms.Label();
            this.lblxproduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductos1
            // 
            this.lblProductos1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductos1.AutoSize = true;
            this.lblProductos1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos1.Location = new System.Drawing.Point(351, 0);
            this.lblProductos1.Name = "lblProductos1";
            this.lblProductos1.Size = new System.Drawing.Size(156, 26);
            this.lblProductos1.TabIndex = 1;
            this.lblProductos1.Text = "PRODUCTOS";
            // 
            // lblxproduct
            // 
            this.lblxproduct.AutoSize = true;
            this.lblxproduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxproduct.Location = new System.Drawing.Point(0, 0);
            this.lblxproduct.Name = "lblxproduct";
            this.lblxproduct.Size = new System.Drawing.Size(27, 26);
            this.lblxproduct.TabIndex = 2;
            this.lblxproduct.Text = "X";
            this.lblxproduct.Click += new System.EventHandler(this.lblxproduct_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblxproduct);
            this.Controls.Add(this.lblProductos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos1;
        private System.Windows.Forms.Label lblxproduct;
    }
}