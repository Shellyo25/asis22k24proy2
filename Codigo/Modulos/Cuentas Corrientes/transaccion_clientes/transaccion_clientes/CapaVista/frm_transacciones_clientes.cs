using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frm_transacciones_clientes : Form
    {
        private readonly Controlador controlador = new Controlador();  // Instancia del Controlador

        public frm_transacciones_clientes()
        {
            InitializeComponent();
        }

        private void btn_reportestrans_Click(object sender, EventArgs e)
        {
            frm_reporte_clientes form2 = new frm_reporte_clientes();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vacío
        }

        // Eliminar una transacción
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo ID contenga un número válido
                if (string.IsNullOrEmpty(txt_Idtrans.Text) || !int.TryParse(txt_Idtrans.Text, out int id))
                {
                    MessageBox.Show("Debe ingresar un ID de transacción válido.");
                    return;
                }

                controlador.EliminarTransaccion(id);
                MessageBox.Show("Transacción eliminada.");
                MostrarTransacciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la transacción: " + ex.Message);
            }
        }

        // Guardar una nueva transacción
        private void btn_guardar_trans_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de txt_transCliente
                if (!int.TryParse(txt_transCliente.Text, out int transCliente))
                {
                    MessageBox.Show("El ID de Cliente debe ser un número válido.");
                    return;
                }

                // Validación de txt_paistrans
                if (!int.TryParse(txt_transpais.Text, out int paisTrans))
                {
                    MessageBox.Show("El ID de País debe ser un número válido.");
                    return;
                }

                // Validación de txt_montotrans
                if (!decimal.TryParse(txt_transmonto.Text, out decimal montoTrans))
                {
                    MessageBox.Show("El monto debe ser un valor decimal válido.");
                    return;
                }

                // Validación de dud_estadotrans
                if (!int.TryParse(dup_estadotrans.Text, out int estadoTrans))
                {
                    MessageBox.Show("El estado debe ser un número válido.");
                    return;
                }

                // Llamada al controlador con los valores validados
                controlador.InsertarTransaccion(
                    transCliente,
                    paisTrans,
                    dtp_fechatrans.Value,
                    "Cuenta",  // Ajusta si es necesario
                    txt_coutastrans.Text,
                    montoTrans,
                    0,  // Asume pago es 0 (ajusta si es necesario)
                    "Moneda",  // Ajusta según el tipo de moneda
                    txt_serietrans.Text,
                    estadoTrans
                );

                MessageBox.Show("Transacción guardada.");

                // Llamada para mostrar las transacciones en el DataGridView
                MostrarTransacciones();

                // Limpieza de los campos después de guardar
                txt_Idtrans.Clear();
                txt_transCliente.Clear();
                txt_transpais.Clear();
                txt_transmonto.Clear();
                txt_coutastrans.Clear();
                txt_serietrans.Clear();
                dup_estadotrans.SelectedIndex = -1;  // Limpia el dropdown
                dtp_fechatrans.Value = DateTime.Now; // Restablece la fecha actual
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        // Método para mostrar las transacciones en el DataGridView
        private void MostrarTransacciones()
        {
            try
            {
                DataTable dt = controlador.ObtenerTransacciones();
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgv_transaccion_cliente.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron transacciones.");
                    dgv_transaccion_cliente.DataSource = null; // Limpiar si no hay datos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar transacciones: " + ex.Message);
            }
        }

        private void btn_buscar_trans_Click(object sender, EventArgs e)
        {
            MostrarTransacciones();  // Muestra todas las transacciones en el DataGridView
        }

        private void dgv_transaccion_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento vacío
        }

        private void btn_borrar_trans_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    // Validación de campos antes de editar
                    if (!int.TryParse(txt_Idtrans.Text, out int id))
                    {
                        MessageBox.Show("Por favor, ingresa un ID válido.");
                        return;
                    }

                    if (!int.TryParse(txt_transCliente.Text, out int transCliente))
                    {
                        MessageBox.Show("El ID de Cliente debe ser un número válido.");
                        return;
                    }

                    if (!int.TryParse(txt_transpais.Text, out int paisTrans))
                    {
                        MessageBox.Show("El ID de País debe ser un número válido.");
                        return;
                    }

                    if (!decimal.TryParse(txt_transmonto.Text, out decimal montoTrans))
                    {
                        MessageBox.Show("El monto debe ser un valor decimal válido.");
                        return;
                    }

                    if (!int.TryParse(dup_estadotrans.Text, out int estadoTrans))
                    {
                        MessageBox.Show("El estado debe ser un número válido.");
                        return;
                    }

                    // Llamada al controlador para actualizar la transacción
                    controlador.ActualizarTransaccion(
                        id,
                        transCliente,
                        paisTrans,
                        dtp_fechatrans.Value,
                        "Cuenta",  // Ajusta si es necesario
                        txt_coutastrans.Text,
                        montoTrans,
                        0,  // Asume pago es 0 (ajusta si es necesario)
                        "Moneda",  // Ajusta según el tipo de moneda
                        txt_serietrans.Text,
                        estadoTrans
                    );

                    MessageBox.Show("Transacción actualizada.");
                    MostrarTransacciones();  // Refresca el DataGridView con los datos actualizados
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar: " + ex.Message);
                }
            }
        }
    }
}
