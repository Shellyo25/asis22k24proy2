using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace CapaModelo
{
    public class Sentencias
    {
        private readonly Conexion conexion = new Conexion();  // Instancia de la clase Conexion

        // Método para insertar una nueva transacción
        public void InsertarTransaccion(int cliente, int pais, DateTime fecha, string cuenta,
                                        string cuotas, decimal monto, int pago, string tipoMoneda,
                                        string serie, int estado)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                string query = @"INSERT INTO Tbl_Transaccion_cliente 
                                (Fk_id_cliente, Fk_id_pais, transaccion_fecha, transaccion_cuenta, 
                                transaccion_cuotas, transaccion_monto, Fk_id_pago, 
                                transaccion_tipo_moneda, transaccion_serie, transaccion_estado) 
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", cliente);
                cmd.Parameters.AddWithValue("?", pais);
                cmd.Parameters.AddWithValue("?", fecha);
                cmd.Parameters.AddWithValue("?", cuenta);
                cmd.Parameters.AddWithValue("?", cuotas);
                cmd.Parameters.AddWithValue("?", monto);
                cmd.Parameters.AddWithValue("?", pago);
                cmd.Parameters.AddWithValue("?", tipoMoneda);
                cmd.Parameters.AddWithValue("?", serie);
                cmd.Parameters.AddWithValue("?", estado);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para actualizar una transacción
        public void ActualizarTransaccion(int id, int cliente, int pais, DateTime fecha,
                                          string cuenta, string cuotas, decimal monto, int pago,
                                          string tipoMoneda, string serie, int estado)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                string query = @"UPDATE Tbl_Transaccion_cliente 
                                SET Fk_id_cliente = ?, Fk_id_pais = ?, transaccion_fecha = ?, 
                                    transaccion_cuenta = ?, transaccion_cuotas = ?, transaccion_monto = ?, 
                                    Fk_id_pago = ?, transaccion_tipo_moneda = ?, transaccion_serie = ?, 
                                    transaccion_estado = ? 
                                WHERE Pk_id_transaccion = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", cliente);
                cmd.Parameters.AddWithValue("?", pais);
                cmd.Parameters.AddWithValue("?", fecha);
                cmd.Parameters.AddWithValue("?", cuenta);
                cmd.Parameters.AddWithValue("?", cuotas);
                cmd.Parameters.AddWithValue("?", monto);
                cmd.Parameters.AddWithValue("?", pago);
                cmd.Parameters.AddWithValue("?", tipoMoneda);
                cmd.Parameters.AddWithValue("?", serie);
                cmd.Parameters.AddWithValue("?", estado);
                cmd.Parameters.AddWithValue("?", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar una transacción
        public void EliminarTransaccion(int id)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                string query = "DELETE FROM Tbl_Transaccion_cliente WHERE Pk_id_transaccion = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener todas las transacciones
        public DataTable ObtenerTransacciones()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.conexion())
            {
                string query = "SELECT * FROM Tbl_Transaccion_cliente";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Método para filtrar transacciones por cliente y fecha
        public DataTable FiltrarTransacciones(string cliente, DateTime fechaCorte)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.conexion())
            {
                string query = @"SELECT * FROM Tbl_Transaccion_cliente 
                                 INNER JOIN Tbl_clientes ON Tbl_Transaccion_cliente.Fk_id_cliente = Tbl_clientes.Pk_id_cliente 
                                 WHERE Tbl_clientes.cliente_nombre LIKE ? AND transaccion_fecha <= ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", "%" + cliente + "%");
                cmd.Parameters.AddWithValue("?", fechaCorte);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
