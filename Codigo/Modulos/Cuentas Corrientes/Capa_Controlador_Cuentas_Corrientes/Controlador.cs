using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Cuentas_Corrientes
{
    public class Controlador
    {
        Capa_Modelo_Cuentas_Corrientes.Sentencias sentencias = new Capa_Modelo_Cuentas_Corrientes.Sentencias();

        public DataTable MostrarTransacciones()
        {
            OdbcDataAdapter data = sentencias.DisplayTransacciones();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextId()
        {
            int nextId = sentencias.getMaxIdTransaccion();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public List<string> listadoDeuda()
        {
            List<string> deudasCodes = sentencias.getDeudas();
            return deudasCodes;
        }

        public List<string> listadoPagos()
        {
            List<string> pagosCodes = sentencias.getPagos();
            return pagosCodes;
        }

        public List<string> listadoClientes()
        {
            List<string> clientesCodes = sentencias.getClientes();
            return clientesCodes;
        }

        public List<string> listadoPais()
        {
            List<string> paisCodes = sentencias.getPais();
            return paisCodes;
        }
        public int guardarTransaccion(TextBox PK_id_transaccion, string sFk_id_clientes, string sFk_id_pais, string sfecha_transaccion,
            string scuenta_transaccion, string scuotas_transaccion, string sFk_id_deuda, string smonto_deuda, string smonto_transaccion,
            string ssaldo_pendiente, string sFk_id_pago, string stipo_moneda, string sserie_transaccion, string sestado_transaccion)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(PK_id_transaccion.Text) || string.IsNullOrEmpty(sFk_id_clientes) || string.IsNullOrEmpty(sFk_id_pais) ||
                string.IsNullOrEmpty(sfecha_transaccion) || string.IsNullOrEmpty(scuenta_transaccion) || string.IsNullOrEmpty(scuotas_transaccion) ||
                string.IsNullOrEmpty(sFk_id_deuda) || string.IsNullOrEmpty(smonto_deuda) || string.IsNullOrEmpty(smonto_transaccion) ||
                string.IsNullOrEmpty(ssaldo_pendiente) || string.IsNullOrEmpty(sFk_id_pago) || string.IsNullOrEmpty(stipo_moneda) ||
                string.IsNullOrEmpty(sserie_transaccion) || string.IsNullOrEmpty(sestado_transaccion))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarTransaccion(PK_id_transaccion.Text, sFk_id_clientes, sFk_id_pais, sfecha_transaccion,
            scuenta_transaccion, scuotas_transaccion, sFk_id_deuda, smonto_deuda, smonto_transaccion,
            ssaldo_pendiente, sFk_id_pago, stipo_moneda, sserie_transaccion, sestado_transaccion);
                return 1;
            }
        }

        public DataTable MostrarCobrador()
        {
            OdbcDataAdapter data = sentencias.DisplayCobradores();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public int guardarCobrador(TextBox idCobrador, string sNombre, string sDireccion, TextBox sTelefono, string sDepartamento, string sEstado)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idCobrador.Text) || string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sDireccion) ||
                string.IsNullOrEmpty(sTelefono.Text) || string.IsNullOrEmpty(sDepartamento) || string.IsNullOrEmpty(sEstado))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarCobrador(idCobrador.Text, sNombre, sDireccion, sTelefono.Text, sDepartamento, sEstado);
                return 1;
            }
        }

        public DataTable queryCobrador(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryCobrador(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }
        public String getNextIdC()
        {
            int nextId = sentencias.getMaxIdCobrador();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public int borrarCobrador(TextBox Pk_id_cobrador)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_cobrador.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el cobrador #" + Pk_id_cobrador.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarcobrador(Pk_id_cobrador.Text);
                    return 1;
                }
            }
        }

        public int guardarFormaPago(TextBox idFormaPago, string sNombreFrmPago, string sMoneda, string sEstadoFrmPago)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idFormaPago.Text) || string.IsNullOrEmpty(sNombreFrmPago) || string.IsNullOrEmpty(sMoneda) ||
                string.IsNullOrEmpty(sEstadoFrmPago))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarFrmpago(idFormaPago.Text, sNombreFrmPago, sMoneda, sEstadoFrmPago);
                return 1;
            }
        }

        public String getNextIdF()
        {
            int nextId = sentencias.getMaxIdFrmPago();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public DataTable MostrarFrmPago()
        {
            OdbcDataAdapter data = sentencias.DisplayFrmPago();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public DataTable queryFrmPago(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryFrmPago(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public int borrarFrmPago(TextBox Pk_id_pago)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_pago.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el cobrador #" + Pk_id_pago.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarFrmPago(Pk_id_pago.Text);
                    return 1;
                }
            }
        }
    }

}

