using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PuntodeVenta
{
    public partial class realizarVenta : Form
    {
        public realizarVenta()
        {
            InitializeComponent();
            dgrid_idDetalleVenta.DataSource = ultimoIdDetallesVentas();
            int id = Convert.ToInt32(dgrid_idDetalleVenta.Rows[0].Cells[0].Value);
            lbl_idDetalleVenta.Text = (id + 1).ToString();
            dgrid_idVenta.DataSource = ultimoIdVenta();
            int idVenta = Convert.ToInt32(dgrid_idVenta.Rows[0].Cells[0].Value);
            lbl_numVenta.Text = (idVenta + 1).ToString();

        }
        private DataTable ultimoIdDetallesVentas()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand("SELECT MAX(id_eliminar) FROM Detalles", conexion.abrirConexion());
                DataTable tabla = new DataTable();
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }
        private DataTable ultimoIdVenta() 
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand("SELECT MAX(id_venta) FROM Ventas", conexion.abrirConexion());
                DataTable tabla = new DataTable();
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.cerrarConexion();
                return tabla;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        private void identificarProducto() 
        {
            Conexion conexion = new Conexion();
            SqlDataReader leer2;
            SqlCommand comando2 = new SqlCommand("SELECT*FROM Productos WHERE id_producto=@id_producto", conexion.abrirConexion());
            comando2.Parameters.AddWithValue("@id_producto", txt_codigo.Text);
            leer2 = comando2.ExecuteReader();
            if (leer2.Read())
            {
                txt_producto.Text = leer2["nombre"].ToString();
                lbl_precio.Text = leer2["precioVenta"].ToString();
            }
            conexion.cerrarConexion();
        }
        private void identificarExistencia() 
        {
            Conexion conexion = new Conexion();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand("SELECT*FROM Inventario WHERE id_producto=@id", conexion.abrirConexion());
            comando.Parameters.AddWithValue("@id", txt_codigo.Text);
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txt_existencia.Text = leer["existencia"].ToString();            
                identificarProducto();

            }
            else
            {
                MessageBox.Show("El producto no existe");
            }         
            conexion.cerrarConexion();
        }
        private void Btn_historial_Click(object sender, EventArgs e)
        {
           
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregarVentas_Click(object sender, EventArgs e)
        {
            añadirCarrito();
        }
        private void disminuirExistencia() 
        {
            int codigo, cantidad, existencia;
            codigo = int.Parse(txt_codigo.Text);
            cantidad = int.Parse(txt_cantidad.Text);
            existencia = int.Parse(txt_existencia.Text);
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand("UPDATE Inventario SET existencia=existencia-@cantidad WHERE id_producto=@id_producto", conexion.abrirConexion());
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@id_producto", codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
            int disminuir = existencia - cantidad;
            txt_existencia.Text = disminuir.ToString();
        }
        private void Realizar_Venta() 
        {
            classVentas venta = new classVentas();
            string empleado = "Josue Jacob Luna Estrada";
            decimal subtotal, pago, cambio;
            subtotal = Convert.ToDecimal(lbl_totalPagar.Text);
            pago = Convert.ToDecimal(txt_pago.Text);
            cambio = pago - subtotal;
            venta.CANT_PRODUCTOS = Convert.ToInt32(lbl_cantProductos.Text);
            venta.SUBTOTAL = subtotal;
            venta.EMPLEADO = empleado;
            if (pago < subtotal)
            {
                MessageBox.Show("El pago es insuficiente", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                venta.agregarVenta();
                lbl_TotalFinal.Text = subtotal.ToString();
                lbl_PagoFinal.Text = pago.ToString();
                lbl_CambioFinal.Text = cambio.ToString();
                int id, idSiguiente;
                id = Convert.ToInt32(lbl_numVenta.Text);
                idSiguiente = id + 1;
                lbl_numVenta.Text = idSiguiente.ToString();
                panelRealizarVenta.Visible = false;
            }

        }
        private void agregarDetallesVentas() 
        {
            detalles_ventas detalles = new detalles_ventas();
            decimal total, precio;
            int cantidad;
            cantidad = Convert.ToInt32(txt_cantidad.Text);
            precio = Convert.ToDecimal(lbl_precio.Text);
            total = precio * cantidad;
            detalles.ID_VENTA = Convert.ToInt32(lbl_numVenta.Text);
            detalles.ID_PRODUCTO = Convert.ToInt32(txt_codigo.Text);
            detalles.CANTIDAD = cantidad;
            detalles.TOTAL = total;
            detalles.ID_ELIMINAR = Convert.ToInt32(lbl_idDetalleVenta.Text);
            detalles.agregarDetalleVenta();
        }
        private void añadirCarrito()
        {
            bool status = false;
            int codigo, cantidad, id, idSiguiente;
            int existencia;
            string producto = txt_producto.Text;
            id = int.Parse(lbl_idDetalleVenta.Text);
            if (!int.TryParse(txt_codigo.Text, out codigo))
            {
                errorProvider1.SetError(txt_codigo, "Debes ingresar el codigo del producto");
                txt_codigo.Focus();
                return;
            }
            if (!int.TryParse(txt_existencia.Text, out existencia))
            {
                errorProvider1.SetError(txt_existencia, "Debes buscar un producto");
                txt_existencia.Focus();
                return;
            }
            if (!int.TryParse(txt_cantidad.Text, out cantidad))
            {
                errorProvider1.SetError(txt_cantidad, "Debes ingresar la cantidad de productos");
                txt_cantidad.Focus();
                return;
            }
            if (existencia == 0)
            {
                MessageBox.Show("No hay productos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cantidad > existencia)
            {
                MessageBox.Show("Solo hay " + existencia + " en existencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow fila in dgridVentas.Rows)
                {
                    string nombre = fila.Cells[1].Value.ToString();
                    if (producto == nombre)
                    {
                        fila.Cells[3].Value = int.Parse(fila.Cells[3].Value.ToString()) + cantidad;
                        fila.Cells[4].Value = float.Parse(fila.Cells[2].Value.ToString()) * float.Parse(fila.Cells[3].Value.ToString());
                        disminuirExistencia();
                        status = true;
                    }
                }
                if (status == false)
                {
                    Conexion conexion = new Conexion();
                    SqlCommand comando = new SqlCommand("SELECT*FROM Productos WHERE id_producto=@id_producto", conexion.abrirConexion());
                    comando.Parameters.AddWithValue("@id_producto", codigo);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        decimal precio = decimal.Parse(leer["precioVenta"].ToString());
                        dgridVentas.Rows.Add(codigo, producto, precio, cantidad,0, id);
                        foreach (DataGridViewRow row in dgridVentas.Rows)
                        {
                            row.Cells[4].Value = decimal.Parse(row.Cells[2].Value.ToString()) * decimal.Parse(row.Cells[3].Value.ToString());
                        }
                        disminuirExistencia();
                        agregarDetallesVentas();
                    }
                    comando.Parameters.Clear();
                    conexion.cerrarConexion();
                }
                calcularTotal();

            }
            errorProvider1.SetError(txt_codigo, "");
            errorProvider1.SetError(txt_cantidad, "");
            errorProvider1.SetError(txt_existencia, "");
            int cantProductos = Convert.ToInt32(dgridVentas.Rows.Count);
            lbl_cantProductos.Text = cantProductos.ToString();
            idSiguiente = id + 1;
            lbl_idDetalleVenta.Text = idSiguiente.ToString();
        }
        private void cobrar() 
        {
            
        }
        private void calcularTotal() 
        {
            decimal suma = 0;
            foreach (DataGridViewRow fila in dgridVentas.Rows)
            {
                suma += decimal.Parse(fila.Cells[4].Value.ToString());
            }
            lbl_total.Text = suma.ToString();
        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)(Keys.Enter))
            {
                identificarExistencia();
                
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelRealizarVenta.Size = new Size(219, 229);
            panelRealizarVenta.Location = new Point(379, 94);
            panelRealizarVenta.Visible = true;
            lbl_totalPagar.Text = lbl_total.Text;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panelRealizarVenta.Visible = false;
        }
        private void editarCantidad() 
        {
            Conexion conexion = new Conexion();
            int cantidad = Convert.ToInt32(dgridVentas.CurrentRow.Cells[3].Value);
            int id = Convert.ToInt32(dgridVentas.CurrentRow.Cells[0].Value);
            SqlCommand comando2 = new SqlCommand("SELECT*FROM Inventario WHERE id_producto=@id", conexion.abrirConexion());
            comando2.Parameters.AddWithValue("@id", id);
            SqlDataReader leer;
            leer = comando2.ExecuteReader();
            if (leer.Read())
            {
               
                lbl.Text = leer["existencia"].ToString();
                int existencia = Convert.ToInt32(lbl.Text);
                if (cantidad>existencia)
                {
                    MessageBox.Show("Solo hay " + existencia + " en existencia");
                }
                else
                {

                    ejemplo();
                }
            }
          

        }
        private void QuitarFila() 
        {
            int pos, id, cantidad, numProductos;
            id = Convert.ToInt32(dgridVentas.CurrentRow.Cells[0].Value);
            cantidad = Convert.ToInt32(dgridVentas.CurrentRow.Cells[3].Value);
            pos = dgridVentas.CurrentRow.Index;
            decimal suma = 0;
            Conexion conexion = new Conexion();                 
            if (pos!=-1)
            {
                if (MessageBox.Show("Quieres quitar el producto del carrito?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    numProductos = dgridVentas.Rows.Count;
                    lbl_cantProductos.Text = numProductos.ToString();
                    detalles_ventas detalles = new detalles_ventas();
                    detalles.ID_ELIMINAR = Convert.ToInt32(dgridVentas.CurrentRow.Cells[5].Value);
                    detalles.eliminarDetalleVenta();
                    foreach (DataGridViewRow fila in dgridVentas.Rows)
                    {
                        suma = suma + Convert.ToDecimal(fila.Cells[4].Value.ToString());
                        lbl_total.Text = suma.ToString();
                    }
                    SqlCommand comando = new SqlCommand("UPDATE Inventario SET existencia= existencia+@cantidad WHERE id_producto=@id", conexion.abrirConexion());
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    conexion.cerrarConexion();
                    dgridVentas.Rows.RemoveAt(pos);                
                }
                else
                {
                    MessageBox.Show("Debes seleccionar la fila", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ejemplo() 
        {
            Conexion conexion = new Conexion();
            int cantidad = Convert.ToInt32(dgridVentas.CurrentRow.Cells[3].Value);
            int id = Convert.ToInt32(dgridVentas.CurrentRow.Cells[0].Value);
            SqlCommand comando = new SqlCommand("UPDATE Inventario SET existencia=existencia-@cantidad WHERE id_producto=@id_producto", conexion.abrirConexion());
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@id_producto", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
            int pos = dgridVentas.CurrentRow.Index;
            int can;
            decimal subtotal, precio;
            can = int.Parse(dgridVentas.Rows[pos].Cells[3].Value.ToString());
            precio = int.Parse(dgridVentas.CurrentRow.Cells[2].Value.ToString());
            subtotal = can * precio;
            dgridVentas.Rows[pos].Cells[4].Value = subtotal;
            lbl_total.Text = subtotal.ToString();
        }

        private void dgridVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            editarCantidad();
        }

        private void btn_eliminarVentas_Click(object sender, EventArgs e)
        {
            QuitarFila();
            calcularTotal();
        }

        private void btn_realizarVenta_Click(object sender, EventArgs e)
        {
            Realizar_Venta();           
        }

        private void lbl_precio_Click(object sender, EventArgs e)
        {

        }
    }
}
