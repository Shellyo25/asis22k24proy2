
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
            this.CmbBoxNombre = new System.Windows.Forms.ComboBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBoxEstado = new System.Windows.Forms.ComboBox();
            this.Txt_id_pago = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_encargado = new System.Windows.Forms.Label();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.CmbBoxMoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvFormaPago = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBoxNombre
            // 
            this.CmbBoxNombre.FormattingEnabled = true;
            this.CmbBoxNombre.Items.AddRange(new object[] {
            "1. Efectivo Quetzales ",
            "2. Efectivo Dolares",
            "3. Tarjeta de Crédito ",
            "4. Cheques",
            "5. Crédito",
            "6. Otros"});
            this.CmbBoxNombre.Location = new System.Drawing.Point(568, 145);
            this.CmbBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbBoxNombre.Name = "CmbBoxNombre";
            this.CmbBoxNombre.Size = new System.Drawing.Size(176, 24);
            this.CmbBoxNombre.TabIndex = 62;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(164, 294);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(151, 43);
            this.Btn_guardar.TabIndex = 60;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "TIPOS DE PAGO CLIENTE";
            // 
            // CmbBoxEstado
            // 
            this.CmbBoxEstado.FormattingEnabled = true;
            this.CmbBoxEstado.Items.AddRange(new object[] {
            "1. Habilitado ",
            "2. Inhabilitado"});
            this.CmbBoxEstado.Location = new System.Drawing.Point(568, 215);
            this.CmbBoxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbBoxEstado.Name = "CmbBoxEstado";
            this.CmbBoxEstado.Size = new System.Drawing.Size(176, 24);
            this.CmbBoxEstado.TabIndex = 58;
            // 
            // Txt_id_pago
            // 
            this.Txt_id_pago.Location = new System.Drawing.Point(568, 112);
            this.Txt_id_pago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_id_pago.Name = "Txt_id_pago";
            this.Txt_id_pago.Size = new System.Drawing.Size(176, 22);
            this.Txt_id_pago.TabIndex = 57;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(356, 214);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(63, 18);
            this.Lbl_fecha.TabIndex = 56;
            this.Lbl_fecha.Text = "Estado: ";
            // 
            // Lbl_encargado
            // 
            this.Lbl_encargado.AutoSize = true;
            this.Lbl_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encargado.Location = new System.Drawing.Point(356, 145);
            this.Lbl_encargado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_encargado.Name = "Lbl_encargado";
            this.Lbl_encargado.Size = new System.Drawing.Size(70, 18);
            this.Lbl_encargado.TabIndex = 55;
            this.Lbl_encargado.Text = "Nombre: ";
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_documento.Location = new System.Drawing.Point(356, 112);
            this.Lbl_documento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(61, 18);
            this.Lbl_documento.TabIndex = 54;
            this.Lbl_documento.Text = "ID Pago";
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(841, 294);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(151, 43);
            this.Btn_borrar.TabIndex = 52;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Btn_actualizar.Location = new System.Drawing.Point(669, 294);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(151, 43);
            this.Btn_actualizar.TabIndex = 51;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(496, 294);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(151, 43);
            this.Btn_editar.TabIndex = 50;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(322, 294);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(151, 43);
            this.Btn_buscar.TabIndex = 49;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // CmbBoxMoneda
            // 
            this.CmbBoxMoneda.FormattingEnabled = true;
            this.CmbBoxMoneda.Items.AddRange(new object[] {
            "1.  Quetzal ",
            "2.  Dolar"});
            this.CmbBoxMoneda.Location = new System.Drawing.Point(568, 182);
            this.CmbBoxMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbBoxMoneda.Name = "CmbBoxMoneda";
            this.CmbBoxMoneda.Size = new System.Drawing.Size(176, 24);
            this.CmbBoxMoneda.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Moneda: ";
            // 
            // DgvFormaPago
            // 
            this.DgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFormaPago.Location = new System.Drawing.Point(164, 359);
            this.DgvFormaPago.Name = "DgvFormaPago";
            this.DgvFormaPago.RowHeadersWidth = 51;
            this.DgvFormaPago.RowTemplate.Height = 24;
            this.DgvFormaPago.Size = new System.Drawing.Size(828, 235);
            this.DgvFormaPago.TabIndex = 65;
            // 
            // FormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1147, 628);
            this.Controls.Add(this.DgvFormaPago);
            this.Controls.Add(this.CmbBoxMoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbBoxNombre);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBoxEstado);
            this.Controls.Add(this.Txt_id_pago);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_encargado);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_buscar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaPago";
            this.Text = "FormaPago";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBoxNombre;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBoxEstado;
        private System.Windows.Forms.TextBox Txt_id_pago;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_encargado;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.ComboBox CmbBoxMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvFormaPago;
    }
}