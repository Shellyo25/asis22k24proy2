
namespace CapaVista
{
    partial class frm_filtrocliente
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
            this.btn_mostrar_reporte = new System.Windows.Forms.Button();
            this.txt_filtrocliente = new System.Windows.Forms.TextBox();
            this.lbl_idtrans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mostrar_reporte
            // 
            this.btn_mostrar_reporte.Location = new System.Drawing.Point(140, 132);
            this.btn_mostrar_reporte.Name = "btn_mostrar_reporte";
            this.btn_mostrar_reporte.Size = new System.Drawing.Size(99, 29);
            this.btn_mostrar_reporte.TabIndex = 0;
            this.btn_mostrar_reporte.Text = "Mostrar";
            this.btn_mostrar_reporte.UseVisualStyleBackColor = true;
            this.btn_mostrar_reporte.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_filtrocliente
            // 
            this.txt_filtrocliente.Location = new System.Drawing.Point(126, 72);
            this.txt_filtrocliente.Name = "txt_filtrocliente";
            this.txt_filtrocliente.Size = new System.Drawing.Size(155, 22);
            this.txt_filtrocliente.TabIndex = 1;
            this.txt_filtrocliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_idtrans
            // 
            this.lbl_idtrans.AutoSize = true;
            this.lbl_idtrans.Location = new System.Drawing.Point(12, 72);
            this.lbl_idtrans.Name = "lbl_idtrans";
            this.lbl_idtrans.Size = new System.Drawing.Size(103, 17);
            this.lbl_idtrans.TabIndex = 2;
            this.lbl_idtrans.Text = "ID Transaccion";
            this.lbl_idtrans.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_filtrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(370, 201);
            this.Controls.Add(this.lbl_idtrans);
            this.Controls.Add(this.txt_filtrocliente);
            this.Controls.Add(this.btn_mostrar_reporte);
            this.Name = "frm_filtrocliente";
            this.Text = "frm_filtrocliente";
            this.Load += new System.EventHandler(this.frm_filtrocliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar_reporte;
        private System.Windows.Forms.TextBox txt_filtrocliente;
        private System.Windows.Forms.Label lbl_idtrans;
    }
}