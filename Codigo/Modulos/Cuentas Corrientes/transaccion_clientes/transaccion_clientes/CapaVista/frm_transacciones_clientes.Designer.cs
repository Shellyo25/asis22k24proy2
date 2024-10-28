
namespace CapaVista
{
    partial class frm_transacciones_clientes
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
            this.components = new System.ComponentModel.Container();
            this.dgv_transaccion_cliente = new System.Windows.Forms.DataGridView();
            this.txt_Idtrans = new System.Windows.Forms.TextBox();
            this.txt_transCliente = new System.Windows.Forms.TextBox();
            this.txt_transpais = new System.Windows.Forms.TextBox();
            this.txt_transmonto = new System.Windows.Forms.TextBox();
            this.txt_serietrans = new System.Windows.Forms.TextBox();
            this.txt_coutastrans = new System.Windows.Forms.TextBox();
            this.dtp_fechatrans = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dup_estadotrans = new System.Windows.Forms.DomainUpDown();
            this.btn_reportestrans = new System.Windows.Forms.Button();
            this.btn_editar_trans = new System.Windows.Forms.Button();
            this.btn_buscar_trans = new System.Windows.Forms.Button();
            this.btn_guardar_trans = new System.Windows.Forms.Button();
            this.btn_eliminar_trans = new System.Windows.Forms.Button();
            this.mGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.mEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.mModificar = new System.Windows.Forms.ToolTip(this.components);
            this.mBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.mRep = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaccion_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transaccion_cliente
            // 
            this.dgv_transaccion_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaccion_cliente.Location = new System.Drawing.Point(78, 525);
            this.dgv_transaccion_cliente.Name = "dgv_transaccion_cliente";
            this.dgv_transaccion_cliente.RowHeadersWidth = 51;
            this.dgv_transaccion_cliente.RowTemplate.Height = 24;
            this.dgv_transaccion_cliente.Size = new System.Drawing.Size(898, 114);
            this.dgv_transaccion_cliente.TabIndex = 0;
            this.dgv_transaccion_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaccion_cliente_CellContentClick);
            // 
            // txt_Idtrans
            // 
            this.txt_Idtrans.Location = new System.Drawing.Point(199, 139);
            this.txt_Idtrans.Name = "txt_Idtrans";
            this.txt_Idtrans.Size = new System.Drawing.Size(176, 22);
            this.txt_Idtrans.TabIndex = 5;
            // 
            // txt_transCliente
            // 
            this.txt_transCliente.Location = new System.Drawing.Point(199, 199);
            this.txt_transCliente.Name = "txt_transCliente";
            this.txt_transCliente.Size = new System.Drawing.Size(176, 22);
            this.txt_transCliente.TabIndex = 6;
            // 
            // txt_transpais
            // 
            this.txt_transpais.Location = new System.Drawing.Point(199, 266);
            this.txt_transpais.Name = "txt_transpais";
            this.txt_transpais.Size = new System.Drawing.Size(176, 22);
            this.txt_transpais.TabIndex = 7;
            // 
            // txt_transmonto
            // 
            this.txt_transmonto.Location = new System.Drawing.Point(199, 330);
            this.txt_transmonto.Name = "txt_transmonto";
            this.txt_transmonto.Size = new System.Drawing.Size(176, 22);
            this.txt_transmonto.TabIndex = 8;
            // 
            // txt_serietrans
            // 
            this.txt_serietrans.Location = new System.Drawing.Point(648, 266);
            this.txt_serietrans.Name = "txt_serietrans";
            this.txt_serietrans.Size = new System.Drawing.Size(176, 22);
            this.txt_serietrans.TabIndex = 10;
            // 
            // txt_coutastrans
            // 
            this.txt_coutastrans.Location = new System.Drawing.Point(648, 199);
            this.txt_coutastrans.Name = "txt_coutastrans";
            this.txt_coutastrans.Size = new System.Drawing.Size(176, 22);
            this.txt_coutastrans.TabIndex = 11;
            // 
            // dtp_fechatrans
            // 
            this.dtp_fechatrans.Location = new System.Drawing.Point(648, 137);
            this.dtp_fechatrans.Name = "dtp_fechatrans";
            this.dtp_fechatrans.Size = new System.Drawing.Size(266, 22);
            this.dtp_fechatrans.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Coutas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Serie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado";
            // 
            // dup_estadotrans
            // 
            this.dup_estadotrans.Items.Add("0");
            this.dup_estadotrans.Items.Add("1");
            this.dup_estadotrans.Location = new System.Drawing.Point(642, 333);
            this.dup_estadotrans.Name = "dup_estadotrans";
            this.dup_estadotrans.Size = new System.Drawing.Size(154, 22);
            this.dup_estadotrans.TabIndex = 21;
            // 
            // btn_reportestrans
            // 
            this.btn_reportestrans.BackColor = System.Drawing.Color.White;
            this.btn_reportestrans.Image = global::CapaVista.Properties.Resources.reporte;
            this.btn_reportestrans.Location = new System.Drawing.Point(904, 1);
            this.btn_reportestrans.Name = "btn_reportestrans";
            this.btn_reportestrans.Size = new System.Drawing.Size(72, 66);
            this.btn_reportestrans.TabIndex = 22;
            this.mRep.SetToolTip(this.btn_reportestrans, "Ver Reporte");
            this.btn_reportestrans.UseVisualStyleBackColor = false;
            this.btn_reportestrans.Click += new System.EventHandler(this.btn_reportestrans_Click);
            // 
            // btn_editar_trans
            // 
            this.btn_editar_trans.BackColor = System.Drawing.Color.White;
            this.btn_editar_trans.Image = global::CapaVista.Properties.Resources.convenio;
            this.btn_editar_trans.Location = new System.Drawing.Point(532, 435);
            this.btn_editar_trans.Name = "btn_editar_trans";
            this.btn_editar_trans.Size = new System.Drawing.Size(72, 66);
            this.btn_editar_trans.TabIndex = 4;
            this.mModificar.SetToolTip(this.btn_editar_trans, "Modificar Registro de Transaccion\r\n");
            this.btn_editar_trans.UseVisualStyleBackColor = false;
            this.btn_editar_trans.Click += new System.EventHandler(this.btn_borrar_trans_Click);
            // 
            // btn_buscar_trans
            // 
            this.btn_buscar_trans.BackColor = System.Drawing.Color.White;
            this.btn_buscar_trans.Image = global::CapaVista.Properties.Resources.buscar;
            this.btn_buscar_trans.Location = new System.Drawing.Point(642, 435);
            this.btn_buscar_trans.Name = "btn_buscar_trans";
            this.btn_buscar_trans.Size = new System.Drawing.Size(72, 66);
            this.btn_buscar_trans.TabIndex = 3;
            this.mBuscar.SetToolTip(this.btn_buscar_trans, "Buscar un Registro de Transacción");
            this.btn_buscar_trans.UseVisualStyleBackColor = false;
            this.btn_buscar_trans.Click += new System.EventHandler(this.btn_buscar_trans_Click);
            // 
            // btn_guardar_trans
            // 
            this.btn_guardar_trans.BackColor = System.Drawing.Color.White;
            this.btn_guardar_trans.Image = global::CapaVista.Properties.Resources.ahorrar__1_;
            this.btn_guardar_trans.Location = new System.Drawing.Point(303, 435);
            this.btn_guardar_trans.Name = "btn_guardar_trans";
            this.btn_guardar_trans.Size = new System.Drawing.Size(72, 66);
            this.btn_guardar_trans.TabIndex = 2;
            this.mGuardar.SetToolTip(this.btn_guardar_trans, "Guardar Registro de Transacción ");
            this.btn_guardar_trans.UseVisualStyleBackColor = false;
            this.btn_guardar_trans.Click += new System.EventHandler(this.btn_guardar_trans_Click);
            // 
            // btn_eliminar_trans
            // 
            this.btn_eliminar_trans.BackColor = System.Drawing.Color.White;
            this.btn_eliminar_trans.Image = global::CapaVista.Properties.Resources.borrar4;
            this.btn_eliminar_trans.Location = new System.Drawing.Point(415, 435);
            this.btn_eliminar_trans.Name = "btn_eliminar_trans";
            this.btn_eliminar_trans.Size = new System.Drawing.Size(72, 66);
            this.btn_eliminar_trans.TabIndex = 1;
            this.mEliminar.SetToolTip(this.btn_eliminar_trans, "Eliminar Registro Transacción");
            this.btn_eliminar_trans.UseVisualStyleBackColor = false;
            this.btn_eliminar_trans.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_transacciones_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1073, 651);
            this.Controls.Add(this.btn_reportestrans);
            this.Controls.Add(this.dup_estadotrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fechatrans);
            this.Controls.Add(this.txt_coutastrans);
            this.Controls.Add(this.txt_serietrans);
            this.Controls.Add(this.txt_transmonto);
            this.Controls.Add(this.txt_transpais);
            this.Controls.Add(this.txt_transCliente);
            this.Controls.Add(this.txt_Idtrans);
            this.Controls.Add(this.btn_editar_trans);
            this.Controls.Add(this.btn_buscar_trans);
            this.Controls.Add(this.btn_guardar_trans);
            this.Controls.Add(this.btn_eliminar_trans);
            this.Controls.Add(this.dgv_transaccion_cliente);
            this.Name = "frm_transacciones_clientes";
            this.Text = "frm_transacciones_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaccion_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaccion_cliente;
        private System.Windows.Forms.Button btn_eliminar_trans;
        private System.Windows.Forms.Button btn_guardar_trans;
        private System.Windows.Forms.Button btn_buscar_trans;
        private System.Windows.Forms.Button btn_editar_trans;
        private System.Windows.Forms.TextBox txt_Idtrans;
        private System.Windows.Forms.TextBox txt_transCliente;
        private System.Windows.Forms.TextBox txt_transpais;
        private System.Windows.Forms.TextBox txt_transmonto;
        private System.Windows.Forms.TextBox txt_serietrans;
        private System.Windows.Forms.TextBox txt_coutastrans;
        private System.Windows.Forms.DateTimePicker dtp_fechatrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown dup_estadotrans;
        private System.Windows.Forms.Button btn_reportestrans;
        private System.Windows.Forms.ToolTip mGuardar;
        private System.Windows.Forms.ToolTip mModificar;
        private System.Windows.Forms.ToolTip mEliminar;
        private System.Windows.Forms.ToolTip mBuscar;
        private System.Windows.Forms.ToolTip mRep;
    }
}