
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class ClienteNuevo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_id_vendedor = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Txt_id_vendedor = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_saldo = new System.Windows.Forms.Label();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Dgv_cliente_nuevo = new System.Windows.Forms.DataGridView();
            this._cliente = new System.Windows.Forms.Label();
            this.Txt_id_cliente = new System.Windows.Forms.TextBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombe_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cliente_nuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(199, 51);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(209, 22);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Creacion de Cliente Nuevo";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Titulo.UseMnemonic = false;
            this.Lbl_Titulo.Click += new System.EventHandler(this.Lbl_Titulo_Click);
            // 
            // Lbl_id_vendedor
            // 
            this.Lbl_id_vendedor.AutoSize = true;
            this.Lbl_id_vendedor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_vendedor.Location = new System.Drawing.Point(45, 168);
            this.Lbl_id_vendedor.Name = "Lbl_id_vendedor";
            this.Lbl_id_vendedor.Size = new System.Drawing.Size(91, 18);
            this.Lbl_id_vendedor.TabIndex = 1;
            this.Lbl_id_vendedor.Text = "Id Vendedor: ";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(45, 205);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(63, 18);
            this.Lbl_nombre.TabIndex = 2;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(45, 272);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(99, 18);
            this.Lbl_estado.TabIndex = 4;
            this.Lbl_estado.Text = "Estado Cliente:";
            // 
            // Txt_id_vendedor
            // 
            this.Txt_id_vendedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_vendedor.Location = new System.Drawing.Point(236, 168);
            this.Txt_id_vendedor.Name = "Txt_id_vendedor";
            this.Txt_id_vendedor.Size = new System.Drawing.Size(279, 26);
            this.Txt_id_vendedor.TabIndex = 5;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(236, 205);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(279, 26);
            this.Txt_nombre.TabIndex = 6;
            // 
            // Lbl_saldo
            // 
            this.Lbl_saldo.AutoSize = true;
            this.Lbl_saldo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldo.Location = new System.Drawing.Point(45, 245);
            this.Lbl_saldo.Name = "Lbl_saldo";
            this.Lbl_saldo.Size = new System.Drawing.Size(92, 18);
            this.Lbl_saldo.TabIndex = 9;
            this.Lbl_saldo.Text = "Saldo Actual: ";
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_saldo.Location = new System.Drawing.Point(236, 241);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(279, 26);
            this.Txt_saldo.TabIndex = 10;
            this.Txt_saldo.TextChanged += new System.EventHandler(this.TxtNit_TextChanged);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Location = new System.Drawing.Point(117, 585);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(109, 36);
            this.Btn_guardar.TabIndex = 13;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Location = new System.Drawing.Point(338, 585);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(97, 36);
            this.Btn_editar.TabIndex = 14;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(441, 585);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(92, 36);
            this.Btn_actualizar.TabIndex = 15;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(539, 585);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(100, 36);
            this.Btn_eliminar.TabIndex = 16;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Dgv_cliente_nuevo
            // 
            this.Dgv_cliente_nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_cliente_nuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cliente_nuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.id_vendedor,
            this.nombe_cliente,
            this.saldo_actual,
            this.estado_cliente});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_cliente_nuevo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_cliente_nuevo.Location = new System.Drawing.Point(48, 335);
            this.Dgv_cliente_nuevo.Name = "Dgv_cliente_nuevo";
            this.Dgv_cliente_nuevo.Size = new System.Drawing.Size(703, 222);
            this.Dgv_cliente_nuevo.TabIndex = 18;
            // 
            // _cliente
            // 
            this._cliente.AutoSize = true;
            this._cliente.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cliente.Location = new System.Drawing.Point(45, 136);
            this._cliente.Name = "_cliente";
            this._cliente.Size = new System.Drawing.Size(71, 18);
            this._cliente.TabIndex = 19;
            this._cliente.Text = "Id Cliente:";
            // 
            // Txt_id_cliente
            // 
            this.Txt_id_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_cliente.Location = new System.Drawing.Point(236, 132);
            this.Txt_id_cliente.Name = "Txt_id_cliente";
            this.Txt_id_cliente.Size = new System.Drawing.Size(202, 26);
            this.Txt_id_cliente.TabIndex = 20;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.Cbo_estado.Location = new System.Drawing.Point(236, 272);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(202, 30);
            this.Cbo_estado.TabIndex = 21;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(232, 585);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(100, 36);
            this.Btn_buscar.TabIndex = 22;
            this.Btn_buscar.Text = "Buscar ";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // id_cliente
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_cliente.HeaderText = "Id Cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // id_vendedor
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_vendedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_vendedor.HeaderText = "Id Vendedor";
            this.id_vendedor.Name = "id_vendedor";
            // 
            // nombe_cliente
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombe_cliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombe_cliente.HeaderText = "Nombre";
            this.nombe_cliente.Name = "nombe_cliente";
            // 
            // saldo_actual
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo_actual.DefaultCellStyle = dataGridViewCellStyle4;
            this.saldo_actual.HeaderText = "Saldo Actual";
            this.saldo_actual.Name = "saldo_actual";
            // 
            // estado_cliente
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_cliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.estado_cliente.HeaderText = "Estado Cliente";
            this.estado_cliente.Name = "estado_cliente";
            this.estado_cliente.ReadOnly = true;
            // 
            // ClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(778, 651);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_cliente);
            this.Controls.Add(this._cliente);
            this.Controls.Add(this.Dgv_cliente_nuevo);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Txt_saldo);
            this.Controls.Add(this.Lbl_saldo);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Txt_id_vendedor);
            this.Controls.Add(this.Lbl_estado);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Lbl_id_vendedor);
            this.Controls.Add(this.Lbl_Titulo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ClienteNuevo";
            this.Text = "ClientesNuevo";
            this.Load += new System.EventHandler(this.ClienteNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cliente_nuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_id_vendedor;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.TextBox Txt_id_vendedor;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_saldo;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView Dgv_cliente_nuevo;
        private System.Windows.Forms.Label _cliente;
        private System.Windows.Forms.TextBox Txt_id_cliente;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombe_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_cliente;
    }
}