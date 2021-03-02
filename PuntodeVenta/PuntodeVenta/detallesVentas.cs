using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PuntodeVenta
{
    class detallesVentas
    {
        private Conexion conexion = new Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private int id_detalle_venta, id_venta, cantidad;
        private decimal total;
        private string producto;
        public int ID_DETALLE_VENTA { get { return id_detalle_venta; } set { id_detalle_venta = value; }}
        public int ID_VENTA { get { return id_venta; } set { id_venta = value; } }
        public int CANTIDAD { get { return cantidad; } set { cantidad = value; } }
        public decimal TOTAL { get { return total; } set { total = value; } }
        public string PRODUCTO { get { return producto; } set { producto = value; } }
        public void agregarVenta() 
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_DETALLES_VENTAS_INSERTAR";
                comando.Parameters.AddWithValue("@id_venta", id_venta);
                comando.Parameters.AddWithValue("@producto", producto);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@total", total);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la venta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
