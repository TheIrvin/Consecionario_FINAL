namespace ConsecionarioTecs
{
    partial class Evaluar_compraCliente
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
            this.chkBox_motorMoto = new System.Windows.Forms.CheckBox();
            this.chkBox_noReportada = new System.Windows.Forms.CheckBox();
            this.chkBox_enRegla = new System.Windows.Forms.CheckBox();
            this.chkBox_sinMultas = new System.Windows.Forms.CheckBox();
            this.chkBox_klmt = new System.Windows.Forms.CheckBox();
            this.chkBox_sinFugas = new System.Windows.Forms.CheckBox();
            this.pnl_evaluarCompra = new System.Windows.Forms.Panel();
            this.pnl_compraRechazada_enFondo = new System.Windows.Forms.Panel();
            this.chkBox_todo_en_ORDEN = new System.Windows.Forms.CheckBox();
            this.btn_rechazarCompra_a_Cliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ComprarMoto_a_Cliente = new System.Windows.Forms.Button();
            this.pnl_evaluarCompra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBox_motorMoto
            // 
            this.chkBox_motorMoto.AutoSize = true;
            this.chkBox_motorMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_motorMoto.Location = new System.Drawing.Point(31, 168);
            this.chkBox_motorMoto.Name = "chkBox_motorMoto";
            this.chkBox_motorMoto.Size = new System.Drawing.Size(261, 29);
            this.chkBox_motorMoto.TabIndex = 6;
            this.chkBox_motorMoto.Text = "Motor en buen estado";
            this.chkBox_motorMoto.UseVisualStyleBackColor = true;
            this.chkBox_motorMoto.CheckedChanged += new System.EventHandler(this.chkBox_motorMoto_CheckedChanged);
            // 
            // chkBox_noReportada
            // 
            this.chkBox_noReportada.AutoSize = true;
            this.chkBox_noReportada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_noReportada.Location = new System.Drawing.Point(31, 310);
            this.chkBox_noReportada.Name = "chkBox_noReportada";
            this.chkBox_noReportada.Size = new System.Drawing.Size(224, 29);
            this.chkBox_noReportada.TabIndex = 7;
            this.chkBox_noReportada.Text = "Moto no reportada";
            this.chkBox_noReportada.UseVisualStyleBackColor = true;
            this.chkBox_noReportada.CheckedChanged += new System.EventHandler(this.chkBox_noReportada_CheckedChanged);
            // 
            // chkBox_enRegla
            // 
            this.chkBox_enRegla.AutoSize = true;
            this.chkBox_enRegla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_enRegla.Location = new System.Drawing.Point(31, 355);
            this.chkBox_enRegla.Name = "chkBox_enRegla";
            this.chkBox_enRegla.Size = new System.Drawing.Size(209, 29);
            this.chkBox_enRegla.TabIndex = 8;
            this.chkBox_enRegla.Text = "Papeles en regla";
            this.chkBox_enRegla.UseVisualStyleBackColor = true;
            this.chkBox_enRegla.CheckedChanged += new System.EventHandler(this.chkBox_enRegla_CheckedChanged);
            // 
            // chkBox_sinMultas
            // 
            this.chkBox_sinMultas.AutoSize = true;
            this.chkBox_sinMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_sinMultas.Location = new System.Drawing.Point(31, 211);
            this.chkBox_sinMultas.Name = "chkBox_sinMultas";
            this.chkBox_sinMultas.Size = new System.Drawing.Size(245, 29);
            this.chkBox_sinMultas.TabIndex = 9;
            this.chkBox_sinMultas.Text = "Sin deudas o multas";
            this.chkBox_sinMultas.UseVisualStyleBackColor = true;
            this.chkBox_sinMultas.CheckedChanged += new System.EventHandler(this.chkBox_sinMultas_CheckedChanged);
            // 
            // chkBox_klmt
            // 
            this.chkBox_klmt.AutoSize = true;
            this.chkBox_klmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_klmt.Location = new System.Drawing.Point(31, 124);
            this.chkBox_klmt.Name = "chkBox_klmt";
            this.chkBox_klmt.Size = new System.Drawing.Size(327, 29);
            this.chkBox_klmt.TabIndex = 11;
            this.chkBox_klmt.Text = "kilometraje menos de 75000";
            this.chkBox_klmt.UseVisualStyleBackColor = true;
            this.chkBox_klmt.CheckedChanged += new System.EventHandler(this.chkBox_klmt_CheckedChanged);
            // 
            // chkBox_sinFugas
            // 
            this.chkBox_sinFugas.AutoSize = true;
            this.chkBox_sinFugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_sinFugas.Location = new System.Drawing.Point(31, 261);
            this.chkBox_sinFugas.Name = "chkBox_sinFugas";
            this.chkBox_sinFugas.Size = new System.Drawing.Size(241, 29);
            this.chkBox_sinFugas.TabIndex = 12;
            this.chkBox_sinFugas.Text = "Sin fugas de aceite ";
            this.chkBox_sinFugas.UseVisualStyleBackColor = true;
            this.chkBox_sinFugas.CheckedChanged += new System.EventHandler(this.chkBox_sinFugas_CheckedChanged);
            // 
            // pnl_evaluarCompra
            // 
            this.pnl_evaluarCompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_evaluarCompra.Controls.Add(this.pnl_compraRechazada_enFondo);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_todo_en_ORDEN);
            this.pnl_evaluarCompra.Controls.Add(this.btn_rechazarCompra_a_Cliente);
            this.pnl_evaluarCompra.Controls.Add(this.panel2);
            this.pnl_evaluarCompra.Controls.Add(this.btn_ComprarMoto_a_Cliente);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_klmt);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_sinFugas);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_motorMoto);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_noReportada);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_sinMultas);
            this.pnl_evaluarCompra.Controls.Add(this.chkBox_enRegla);
            this.pnl_evaluarCompra.Location = new System.Drawing.Point(1, 0);
            this.pnl_evaluarCompra.Name = "pnl_evaluarCompra";
            this.pnl_evaluarCompra.Size = new System.Drawing.Size(866, 503);
            this.pnl_evaluarCompra.TabIndex = 13;
            this.pnl_evaluarCompra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_evaluarCompra_Paint);
            // 
            // pnl_compraRechazada_enFondo
            // 
            this.pnl_compraRechazada_enFondo.BackColor = System.Drawing.Color.Silver;
            this.pnl_compraRechazada_enFondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_compraRechazada_enFondo.Name = "pnl_compraRechazada_enFondo";
            this.pnl_compraRechazada_enFondo.Size = new System.Drawing.Size(863, 503);
            this.pnl_compraRechazada_enFondo.TabIndex = 17;
            this.pnl_compraRechazada_enFondo.Visible = false;
            // 
            // chkBox_todo_en_ORDEN
            // 
            this.chkBox_todo_en_ORDEN.AutoSize = true;
            this.chkBox_todo_en_ORDEN.Enabled = false;
            this.chkBox_todo_en_ORDEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_todo_en_ORDEN.Location = new System.Drawing.Point(31, 400);
            this.chkBox_todo_en_ORDEN.Name = "chkBox_todo_en_ORDEN";
            this.chkBox_todo_en_ORDEN.Size = new System.Drawing.Size(268, 29);
            this.chkBox_todo_en_ORDEN.TabIndex = 16;
            this.chkBox_todo_en_ORDEN.Text = "¿Todo Esta en Orden?";
            this.chkBox_todo_en_ORDEN.UseVisualStyleBackColor = true;
            this.chkBox_todo_en_ORDEN.CheckedChanged += new System.EventHandler(this.chkBox_todo_en_ORDEN_CheckedChanged);
            // 
            // btn_rechazarCompra_a_Cliente
            // 
            this.btn_rechazarCompra_a_Cliente.BackColor = System.Drawing.Color.Silver;
            this.btn_rechazarCompra_a_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechazarCompra_a_Cliente.Location = new System.Drawing.Point(471, 332);
            this.btn_rechazarCompra_a_Cliente.Name = "btn_rechazarCompra_a_Cliente";
            this.btn_rechazarCompra_a_Cliente.Size = new System.Drawing.Size(171, 74);
            this.btn_rechazarCompra_a_Cliente.TabIndex = 15;
            this.btn_rechazarCompra_a_Cliente.Text = "Rechazar";
            this.btn_rechazarCompra_a_Cliente.UseVisualStyleBackColor = false;
            this.btn_rechazarCompra_a_Cliente.Click += new System.EventHandler(this.btn_rechazarCompra_a_Cliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 54);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluando la Moto";
            // 
            // btn_ComprarMoto_a_Cliente
            // 
            this.btn_ComprarMoto_a_Cliente.BackColor = System.Drawing.Color.Silver;
            this.btn_ComprarMoto_a_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ComprarMoto_a_Cliente.Location = new System.Drawing.Point(471, 166);
            this.btn_ComprarMoto_a_Cliente.Name = "btn_ComprarMoto_a_Cliente";
            this.btn_ComprarMoto_a_Cliente.Size = new System.Drawing.Size(171, 74);
            this.btn_ComprarMoto_a_Cliente.TabIndex = 13;
            this.btn_ComprarMoto_a_Cliente.Text = "Enviar Info al Dueño";
            this.btn_ComprarMoto_a_Cliente.UseVisualStyleBackColor = false;
            this.btn_ComprarMoto_a_Cliente.Click += new System.EventHandler(this.btn_ComprarMoto_a_Cliente_Click);
            // 
            // Evaluar_compraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 501);
            this.Controls.Add(this.pnl_evaluarCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluar_compraCliente";
            this.Text = "Evaluar_compraCliente";
            this.pnl_evaluarCompra.ResumeLayout(false);
            this.pnl_evaluarCompra.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkBox_motorMoto;
        private System.Windows.Forms.CheckBox chkBox_noReportada;
        private System.Windows.Forms.CheckBox chkBox_enRegla;
        private System.Windows.Forms.CheckBox chkBox_sinMultas;
        private System.Windows.Forms.CheckBox chkBox_klmt;
        private System.Windows.Forms.CheckBox chkBox_sinFugas;
        private System.Windows.Forms.Panel pnl_evaluarCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ComprarMoto_a_Cliente;
        private System.Windows.Forms.Button btn_rechazarCompra_a_Cliente;
        private System.Windows.Forms.CheckBox chkBox_todo_en_ORDEN;
        private System.Windows.Forms.Panel pnl_compraRechazada_enFondo;
    }
}