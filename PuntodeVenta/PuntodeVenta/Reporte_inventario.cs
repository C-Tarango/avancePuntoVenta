using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PuntodeVenta
{
    class Reporte_inventario
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        private int id_producto, existencia;
        private string nombre;
        public int ID_PRODUCTO { get { return id_producto; } set { id_producto = value; } }
        public int EXISTENCIA { get { return existencia; } set { existencia = value; } }
        public string NOMBRE { get { return nombre; } set { nombre = value; } }
        public void agregarInventario()
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_INVENTARIO_INSERTAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@existencia", existencia);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                MessageBox.Show("Se ha agregado el producto al inventario de manera exitosa", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modificarInventario()
        {
            try
            {              
                 comando.Connection = conexion.abrirConexion();
                 comando.CommandText = "SP_INVENTARIO_MODIFICAR";
                 comando.CommandType = CommandType.StoredProcedure;
                 comando.Parameters.AddWithValue("@id_producto", id_producto);
                 comando.Parameters.AddWithValue("@existencia", existencia);
                 comando.ExecuteNonQuery();
                 comando.Parameters.Clear();
                 comando.Connection = conexion.cerrarConexion();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void eliminarInventario()
        {
            try
            {
                if (MessageBox.Show("¿Quieres eliminar el producto?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    comando.Connection = conexion.abrirConexion();
                    comando.CommandText = "SP_INVENTARIO_ELIMINAR";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_producto", id_producto);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    comando.Connection = conexion.cerrarConexion();
                    MessageBox.Show("Se ha eliminado el producto de manera exitosa", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable buscarProducto()
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_INVENTARIO_BUSCAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                if (tabla.Rows.Count==0)
                {
                    MessageBox.Show("El producto que desea buscar no existe", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                return tabla;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable mostrarProductos()
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_INVENTARIO_MOSTRAR";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar los productos", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable llenarCombo()
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_LLENAR_COMBO_PRODUCTOS";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al llenar los productos", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
