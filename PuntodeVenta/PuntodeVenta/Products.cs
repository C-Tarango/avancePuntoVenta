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
    class Products
    {
        private Conexion conexion = new Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private int id_producto, id_categoria;
        private decimal precioCompra, precioVenta;
        private string nombre;
        public int ID_PRODUCTO { get { return id_producto; } set { id_producto = value; } }
        public int ID_CATEGORIA { get { return id_categoria; } set { id_categoria = value; } }
        public decimal PRECIO_COMPRA { get { return precioCompra; } set { precioCompra = value; } }
        public decimal PRECIO_VENTA { get { return precioVenta; } set { precioVenta = value; } }
        public string NOMBRE { get { return nombre; } set { nombre = value; } }
        public void agregarProducto()
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_PRODUCTOS_INSERTAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precioCompra", precioCompra);
                comando.Parameters.AddWithValue("@precioVenta", precioVenta);
                comando.Parameters.AddWithValue("id_categoria", id_categoria);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                MessageBox.Show("Producto agregado exitosamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void eliminarProductos()
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_PRODUCTOS_ELIMINAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();             
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modificarProductos()
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de modificar el producto?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    comando.Connection = conexion.abrirConexion();
                    comando.CommandText = "SP_PRODUCTOS_MODIFICAR";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_producto", id_producto);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@precioCompra", precioCompra);
                    comando.Parameters.AddWithValue("@precioVenta", precioVenta);
                    comando.Parameters.AddWithValue("@id_categoria", id_categoria);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    comando.Connection = conexion.cerrarConexion();
                    MessageBox.Show("El producto se modifico exitosamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable comboProductos()
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
                MessageBox.Show("Error al cargar el combo productos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable buscarProductos()
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_PRODUCTOS_BUSCAR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                if (tabla.Rows.Count==0)
                {
                    MessageBox.Show("El producto que desea buscar no existe", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable mostrarProductos()
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_PRODUCTOS_MOSTRAR";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los productos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void insertarCategoria()
        {
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_INSERTAR_CATEGORIA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.Connection = conexion.cerrarConexion();
                MessageBox.Show("Se agrego la categoria de manera exitosa", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        public DataTable comboCategorias()
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_LLENAR_COMBO_CATEGORIAS";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Connection = conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las categorias", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
