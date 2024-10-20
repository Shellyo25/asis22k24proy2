
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class FormaPago
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
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_encargado = new System.Windows.Forms.Label();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.Cbo_estatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Cbo_nombre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(668, 193);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(113, 35);
            this.Btn_borrar.TabIndex = 30;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(421, 193);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(113, 35);
            this.Btn_actualizar.TabIndex = 29;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(291, 193);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(113, 35);
            this.Btn_editar.TabIndex = 28;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(29, 193);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(113, 35);
            this.Btn_buscar.TabIndex = 27;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Encargado,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(205, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 191);
            this.dataGridView1.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Encargado
            // 
            this.Encargado.Frozen = true;
            this.Encargado.HeaderText = "Nombre";
            this.Encargado.Name = "Encargado";
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Estatus";
            this.Fecha.Name = "Fecha";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(401, 75);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(133, 20);
            this.Txt_codigo.TabIndex = 36;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(242, 129);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(53, 15);
            this.Lbl_fecha.TabIndex = 34;
            this.Lbl_fecha.Text = "Estatus: ";
            // 
            // Lbl_encargado
            // 
            this.Lbl_encargado.AutoSize = true;
            this.Lbl_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encargado.Location = new System.Drawing.Point(242, 102);
            this.Lbl_encargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_encargado.Name = "Lbl_encargado";
            this.Lbl_encargado.Size = new System.Drawing.Size(58, 15);
            this.Lbl_encargado.TabIndex = 33;
            this.Lbl_encargado.Text = "Nombre: ";
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_documento.Location = new System.Drawing.Point(242, 75);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(49, 15);
            this.Lbl_documento.TabIndex = 32;
            this.Lbl_documento.Text = "Codigo:";
            this.Lbl_documento.Click += new System.EventHandler(this.Lbl_documento_Click);
            // 
            // Cbo_estatus
            // 
            this.Cbo_estatus.FormattingEnabled = true;
            this.Cbo_estatus.Items.AddRange(new object[] {
            "1. Habilitado ",
            "2. Inhabilitado"});
            this.Cbo_estatus.Location = new System.Drawing.Point(401, 137);
            this.Cbo_estatus.Name = "Cbo_estatus";
            this.Cbo_estatus.Size = new System.Drawing.Size(133, 21);
            this.Cbo_estatus.TabIndex = 44;
            this.Cbo_estatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "TIPOS DE PAGO CLIENTE";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(161, 193);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(113, 35);
            this.Btn_guardar.TabIndex = 46;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(549, 193);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(113, 35);
            this.Btn_limpiar.TabIndex = 47;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Cbo_nombre
            // 
            this.Cbo_nombre.FormattingEnabled = true;
            this.Cbo_nombre.Items.AddRange(new object[] {
            "1. Efectivo Quetzales ",
            "2. Efectivo Dolares",
            "3. Tarjeta de Crédito ",
            "4. Cheques",
            "5. Crédito",
            "6. Otros"});
            this.Cbo_nombre.Location = new System.Drawing.Point(401, 102);
            this.Cbo_nombre.Name = "Cbo_nombre";
            this.Cbo_nombre.Size = new System.Drawing.Size(133, 21);
            this.Cbo_nombre.TabIndex = 48;
            // 
            // FormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(787, 438);
            this.Controls.Add(this.Cbo_nombre);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_estatus);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_encargado);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Name = "FormaPago";
            this.Text = "FormaPago";
            this.Load += new System.EventHandler(this.FormaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_encargado;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.ComboBox Cbo_estatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.ComboBox Cbo_nombre;
    }
}