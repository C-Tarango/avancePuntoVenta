using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using PuntodeVenta.Formularios;

namespace PuntodeVenta
{
    class classVentas
    {
        private Conexion conexion = new Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private int id_venta, cant_productos;
        private decimal subtotal;
        private string empleado;
        private DateTime fecha;
        public int ID_VENTA { get { return id_venta; } set { id_venta = value; } }
        public int CANT_PRODUCTOS { get { return cant_productos; } set { cant_productos = value; } }
        public decimal SUBTOTAL { get { return subtotal; } set { subtotal = value; } }
        public string EMPLEADO { get { return empleado; } set { empleado = value; } }
        public DateTime FECHA { get { return fecha; } set { fecha = value; } }
        public void agregarVenta() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_VENTAS_INSERTAR";
                comando.Parameters.AddWithValue("@cantidadProductos", cant_productos);
                comando.Parameters.AddWithValue("@subtotal", subtotal);
                comando.Parameters.AddWithValue("@empleado", empleado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                MessageBox.Show("Se realizo la venta de manera exitosa", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la venta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      public DataTable verVentas() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                DataTable tabla = new DataTable();
                comando.CommandText = "SP_VENTAS_MOSTRAR";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las ventas", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable Buscar() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                DataTable tabla = new DataTable();
                comando.CommandText = "SP_VENTAS_BUSCAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@fecha", fecha);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                if (tabla.Rows.Count==0)
                {
                    MessageBox.Show("No existe ningun registro en esa fecha", "Buscar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar la venta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
