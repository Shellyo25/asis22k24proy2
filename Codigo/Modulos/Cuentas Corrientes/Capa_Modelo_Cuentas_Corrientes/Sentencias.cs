using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Modelo_Cuentas_Corrientes
{
    public class Sentencias
    {
       string sTabla_transaccion = "Tbl_Transaccion_cliente";
        Conexion conexion = new Conexion();
        public OdbcDataAdapter DisplayTransacciones()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT PK_id_transaccion, Fk_id_clientes, Fk_id_pais, fecha_transaccion, cuenta_transaccion, cuotas_transaccion, Fk_id_deuda" +
                "monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion FROM " 
                + sTabla_transaccion + " WHERE Pk_id_transaccion IS NOT NULL AND Pk_id_transaccion != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }
            return dataTable;
        }

        public int getMaxIdTransaccion()
        {
            int iPk_id_transaccion = 0;
            string sSql = "SELECT max(Pk_id_transaccion) FROM " + sTabla_transaccion + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_transaccion = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_transaccion);
            }
            return iPk_id_transaccion;
        }

        public List<string> getDeudas()
        {
            string sQuery = "SELECT Pk_id_deuda, estado_deuda FROM Tbl_Deudas_Clientes;";
            List<string> deudasCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_deuda"].ToString().Equals("1"))
                    {
                        string sCodigoDeuda = row["Pk_id_deuda"].ToString();
                        deudasCodes.Add(sCodigoDeuda);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return deudasCodes;
        }
        public List<string> getPagos()
        {
            string sQuery = "SELECT Pk_id_pago, estado_pago FROM Tbl_tipodepago;";
            List<string> pagosCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_pago"].ToString().Equals("1"))
                    {
                        string sCodigoPago = row["Pk_id_pago"].ToString();
                        pagosCodes.Add(sCodigoPago);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return pagosCodes;
        }

        public List<string> getClientes()
        {
            string sQuery = "SELECT Pk_id_cliente, estado_cliente FROM Tbl_clientes;";
            List<string> clientesCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_cliente"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["Pk_id_cliente"].ToString();
                        clientesCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return clientesCodes;
        }

        public List<string> getPais()
        {
            string sQuery = "SELECT Pk_id_pais, estatus_pais FROM Tbl_paises;";
            List<string> paisCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estatus_pais"].ToString().Equals("1"))
                    {
                        string sCodigoPais = row["Pk_id_pais"].ToString();
                        paisCodes.Add(sCodigoPais);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return paisCodes;
        }

        public void registrarTransaccion (string Pk_id_transaccion, string Fk_id_clientes, string Fk_id_pais, string fecha_transaccion, 
            string cuenta_transaccion, string cuotas_transaccion, string Fk_id_deuda, string monto_deuda, string monto_transaccion, 
            string saldo_pendiente, string Fk_id_pago, string tipo_moneda, string serie_transaccion, string estado_transaccion )
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "PK_id_transaccion, Fk_id_clientes, Fk_id_pais, fecha_transaccion, cuenta_transaccion, cuotas_transaccion, Fk_id_deuda" +
                "monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion";
                string sSql = "INSERT INTO " + sTabla_transaccion + " (" + sCampos + ") VALUES ('" + Pk_id_transaccion + "', '" + Fk_id_clientes + "', '" 
                    + Fk_id_pais + "', '" + fecha_transaccion + "', '" + cuenta_transaccion + "', '" + cuotas_transaccion + "', '" + Fk_id_deuda + "'" +
                    ", '" + monto_deuda + "', '" + monto_transaccion + "', '" + saldo_pendiente + "', '" + Fk_id_pago + "', '" + tipo_moneda + "', '" + serie_transaccion + "', '" + estado_transaccion + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_transaccion);
            }
        }

        public OdbcDataAdapter DisplayCobradores()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT Pk_id_cobrador, nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador FROM " + Tbl_cobrador + " WHERE Pk_id_cobrador IS NOT NULL AND Pk_id_cobrador != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + Tbl_cobrador);
            }
            return dataTable;
        }

        string Tbl_cobrador = "Tbl_cobrador";
        public void registrarCobrador(string idCobrador, string sNombre, string sDireccion, string sTelefono, string sDepartamento, string sEstado)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "Pk_id_cobrador, nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador";
                string sSql = "INSERT INTO " + Tbl_cobrador + " (" + sCampos + ") VALUES ('" + idCobrador + "', '" + sNombre + "', '" + sDireccion + "', '" + sTelefono + "', '" + sDepartamento + "', '" + sEstado + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + Tbl_cobrador);
            }
        }

        public OdbcDataAdapter queryCobrador(string sQuery)
        {
            string sql = "SELECT  Pk_id_cobrador, nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador FROM "
                + Tbl_cobrador + " WHERE nombre_cobrador LIKE '%" + sQuery + "%' OR nombre_cobrador LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public int getMaxIdCobrador()
        {
            int iPk_id_paises = 0;
            string sSql = "SELECT max(Pk_id_cobrador) FROM " + Tbl_cobrador + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_paises = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + Tbl_cobrador);
            }
            return iPk_id_paises;
        }

        public void eliminarcobrador(string sId_cobrador)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + Tbl_cobrador + " where Pk_id_cobrador = " + sId_cobrador + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_cobrador + " en la tabla " + Tbl_cobrador);
            }
        }

        public int getMaxIdFrmPago()
        {
            int iPk_id_paises = 0;
            string sSql = "SELECT max(Pk_id_pago) FROM " + Tbl_tipodepago + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_paises = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + Tbl_tipodepago);
            }
            return iPk_id_paises;
        }

        string Tbl_tipodepago = "Tbl_tipodepago";
        public void registrarFrmpago(string idFormaPago, string sNombreFrmPago, string sMoneda, string sEstadoFrmPago)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCamposFrmPago = "Pk_id_pago, nombre_pago, tipo_moneda, estado_pago";
                string sSql = "INSERT INTO " + Tbl_tipodepago + " (" + sCamposFrmPago + ") VALUES ('" + idFormaPago + "', '" + sNombreFrmPago + "', '" + sMoneda + "', '" + sEstadoFrmPago + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + Tbl_cobrador);
            }
        }

        public OdbcDataAdapter DisplayFrmPago()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT Pk_id_pago, nombre_pago, tipo_moneda, estado_pago FROM " + Tbl_tipodepago + " WHERE Pk_id_pago IS NOT NULL AND Pk_id_pago != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + Tbl_cobrador);
            }
            return dataTable;
        }

        public OdbcDataAdapter queryFrmPago(string sQuery)
        {
            string sql = "SELECT  Pk_id_pago, nombre_pago, tipo_moneda, estado_pago FROM "
                + Tbl_tipodepago + " WHERE Pk_id_pago LIKE '%" + sQuery + "%' OR pk_id_pago LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarFrmPago(string sPk_id_pago)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + Tbl_tipodepago + " where Pk_id_pago = " + sPk_id_pago + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sPk_id_pago + " en la tabla " + Tbl_tipodepago);
            }
        }
    }
}
