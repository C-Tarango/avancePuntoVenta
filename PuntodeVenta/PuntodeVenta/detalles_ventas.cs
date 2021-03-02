using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class detalles_ventas
    {
        private Conexion conexion = new Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private int id_venta, cantidad, id_eliminar, id_producto;
        private decimal total;
        public int ID_VENTA { get { return id_venta; } set { id_venta = value; } }
        public int ID_ELIMINAR { get { return id_eliminar; } set { id_eliminar = value; } }
        public int CANTIDAD { get { return cantidad; } set { cantidad = value; } }
        public int ID_PRODUCTO { get { return id_producto; } set { id_producto = value; } }
        public decimal TOTAL { get { return total; } set { total = value; } }
        public void agregarDetalleVenta() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_DETALLES_INSERTAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_venta", id_venta);
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@id_eliminar", id_eliminar);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la venta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable mostrarDetallesVentas() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                DataTable tabla = new DataTable();
                comando.CommandText = "SP_DETALLES_VER";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_venta", id_venta);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los detalles de venta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void eliminarDetalleVenta() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_DETALLES_ELIMINAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_eliminar", id_eliminar);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
