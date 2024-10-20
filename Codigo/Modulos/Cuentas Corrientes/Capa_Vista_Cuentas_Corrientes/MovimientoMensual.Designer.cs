
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class MovimientoMensual
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
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Dgv_movimiento = new System.Windows.Forms.DataGridView();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.Lbl_fechaActual = new System.Windows.Forms.Label();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Lbl_idcliente = new System.Windows.Forms.Label();
            this.Lbl_mesAconsultar = new System.Windows.Forms.Label();
            this.Txt_mesaconsultar = new System.Windows.Forms.TextBox();
            this.Txt_Idcliente = new System.Windows.Forms.TextBox();
            this.Id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(679, 63);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(92, 31);
            this.Btn_buscar.TabIndex = 0;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Location = new System.Drawing.Point(73, 72);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // Dgv_movimiento
            // 
            this.Dgv_movimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_movimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_movimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_cliente,
            this.Fecha,
            this.NoDocumento,
            this.MesConsulta});
            this.Dgv_movimiento.Location = new System.Drawing.Point(234, 221);
            this.Dgv_movimiento.Name = "Dgv_movimiento";
            this.Dgv_movimiento.Size = new System.Drawing.Size(494, 139);
            this.Dgv_movimiento.TabIndex = 3;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(362, 103);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(271, 20);
            this.Txt_fecha.TabIndex = 4;
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(362, 129);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(271, 20);
            this.Txt_documento.TabIndex = 5;
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Location = new System.Drawing.Point(246, 132);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(105, 13);
            this.Lbl_documento.TabIndex = 6;
            this.Lbl_documento.Text = "No. De Documento: ";
            // 
            // Lbl_fechaActual
            // 
            this.Lbl_fechaActual.AutoSize = true;
            this.Lbl_fechaActual.Location = new System.Drawing.Point(246, 110);
            this.Lbl_fechaActual.Name = "Lbl_fechaActual";
            this.Lbl_fechaActual.Size = new System.Drawing.Size(76, 13);
            this.Lbl_fechaActual.TabIndex = 7;
            this.Lbl_fechaActual.Text = "Fecha Actual: ";
            this.Lbl_fechaActual.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Location = new System.Drawing.Point(408, 397);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.Btn_imprimir.TabIndex = 8;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Lbl_idcliente
            // 
            this.Lbl_idcliente.AutoSize = true;
            this.Lbl_idcliente.Location = new System.Drawing.Point(246, 85);
            this.Lbl_idcliente.Name = "Lbl_idcliente";
            this.Lbl_idcliente.Size = new System.Drawing.Size(56, 13);
            this.Lbl_idcliente.TabIndex = 12;
            this.Lbl_idcliente.Text = "ID Cliente:";
            // 
            // Lbl_mesAconsultar
            // 
            this.Lbl_mesAconsultar.AutoSize = true;
            this.Lbl_mesAconsultar.Location = new System.Drawing.Point(246, 158);
            this.Lbl_mesAconsultar.Name = "Lbl_mesAconsultar";
            this.Lbl_mesAconsultar.Size = new System.Drawing.Size(86, 13);
            this.Lbl_mesAconsultar.TabIndex = 11;
            this.Lbl_mesAconsultar.Text = "Mes a Consultar:";
            // 
            // Txt_mesaconsultar
            // 
            this.Txt_mesaconsultar.Location = new System.Drawing.Point(362, 155);
            this.Txt_mesaconsultar.Name = "Txt_mesaconsultar";
            this.Txt_mesaconsultar.Size = new System.Drawing.Size(271, 20);
            this.Txt_mesaconsultar.TabIndex = 10;
            // 
            // Txt_Idcliente
            // 
            this.Txt_Idcliente.Location = new System.Drawing.Point(362, 78);
            this.Txt_Idcliente.Name = "Txt_Idcliente";
            this.Txt_Idcliente.Size = new System.Drawing.Size(271, 20);
            this.Txt_Idcliente.TabIndex = 9;
            // 
            // Id_cliente
            // 
            this.Id_cliente.Frozen = true;
            this.Id_cliente.HeaderText = "ID Cliente";
            this.Id_cliente.Name = "Id_cliente";
            this.Id_cliente.ReadOnly = true;
            this.Id_cliente.ToolTipText = "ID Cliente";
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha Actual";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.ToolTipText = "Fecha";
            // 
            // NoDocumento
            // 
            this.NoDocumento.Frozen = true;
            this.NoDocumento.HeaderText = "Documento";
            this.NoDocumento.Name = "NoDocumento";
            this.NoDocumento.ReadOnly = true;
            this.NoDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NoDocumento.ToolTipText = "Documento";
            // 
            // MesConsulta
            // 
            this.MesConsulta.HeaderText = "Consulta Por Mes";
            this.MesConsulta.Name = "MesConsulta";
            this.MesConsulta.ReadOnly = true;
            this.MesConsulta.ToolTipText = "Mes Consultado";
            // 
            // MovimientoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_idcliente);
            this.Controls.Add(this.Lbl_mesAconsultar);
            this.Controls.Add(this.Txt_mesaconsultar);
            this.Controls.Add(this.Txt_Idcliente);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Lbl_fechaActual);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Txt_documento);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Dgv_movimiento);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.Btn_buscar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "MovimientoMensual";
            this.Text = "MovimientoMensual";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView Dgv_movimiento;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.Label Lbl_fechaActual;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label Lbl_idcliente;
        private System.Windows.Forms.Label Lbl_mesAconsultar;
        private System.Windows.Forms.TextBox Txt_mesaconsultar;
        private System.Windows.Forms.TextBox Txt_Idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesConsulta;
    }
}