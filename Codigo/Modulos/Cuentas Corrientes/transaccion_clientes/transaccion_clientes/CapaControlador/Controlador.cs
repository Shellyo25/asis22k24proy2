using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        // Instancia de la clase Sentencias (Capa Modelo)
        private readonly Sentencias sentencias = new Sentencias();

        // Método para insertar una transacción
        public void InsertarTransaccion(int cliente, int pais, DateTime fecha, string cuenta,
                                        string cuotas, decimal monto, int pago, string tipoMoneda,
                                        string serie, int estado)
        {
            try
            {
                sentencias.InsertarTransaccion(cliente, pais, fecha, cuenta, cuotas, monto, pago, tipoMoneda, serie, estado);
                Console.WriteLine("Transacción insertada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar transacción: " + ex.Message);
            }
        }

        // Método para actualizar una transacción
        public void ActualizarTransaccion(int id, int cliente, int pais, DateTime fecha,
                                          string cuenta, string cuotas, decimal monto, int pago,
                                          string tipoMoneda, string serie, int estado)
        {
            try
            {
                sentencias.ActualizarTransaccion(id, cliente, pais, fecha, cuenta, cuotas, monto, pago, tipoMoneda, serie, estado);
                Console.WriteLine("Transacción actualizada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar transacción: " + ex.Message);
            }
        }

        // Método para eliminar una transacción por ID
        public void EliminarTransaccion(int id)
        {
            try
            {
                sentencias.EliminarTransaccion(id);
                Console.WriteLine("Transacción eliminada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar transacción: " + ex.Message);
            }
        }

        // Método para obtener todas las transacciones en un DataTable
        public DataTable ObtenerTransacciones()
        {
            try
            {
                return sentencias.ObtenerTransacciones();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener transacciones: " + ex.Message);
                return null;
            }
        }

        // Método para filtrar transacciones por cliente y fecha
        public DataTable FiltrarTransacciones(string cliente, DateTime fechaCorte)
        {
            try
            {
                return sentencias.FiltrarTransacciones(cliente, fechaCorte);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al filtrar transacciones: " + ex.Message);
                return null;
            }
        }
    }
}
