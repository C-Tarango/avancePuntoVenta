﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PuntodeVenta
{
    public partial class Productos : Form
    {
        Products productos = new Products();

        public Productos()
        {
            InitializeComponent();
            cbx_categorias_productosA.SelectedIndex = 0;
            cbx_categoriasActualizar.SelectedIndex = 0;
            llenarCombo();
            mostrarProductos();
            lbl_cantidadProductos.Text = (dgridProductos.Rows.Count).ToString();
           
        }
        private void mostrarProductos()
        {
            
            dgridProductos.DataSource = productos.mostrarProductos();
        }
      
        private void llenarCombo()
        {
            
            cbx_categorias_productosA.DataSource = productos.comboCategorias();
            cbx_categorias_productosA.ValueMember = "id_categoria";
            cbx_categorias_productosA.DisplayMember = "nombre";
            cbx_categoriasActualizar.DataSource = productos.comboCategorias();
            cbx_categoriasActualizar.DisplayMember = "nombre";
            cbx_categoriasActualizar.ValueMember = "id_categoria";
        }
        private void agregarProducto()
        {
            
            if (txt_nombre_agregar.Text=="")
            {
                errorProvider1.SetError(txt_nombre_agregar, "Campo obligatorio");
                txt_nombre_agregar.Focus();
                return;
            }
            if (txt_precioCompra_agregar.Text == "")
            {
                errorProvider1.SetError(txt_precioCompra_agregar, "Campo obligatorio");
                txt_precioCompra_agregar.Focus();
                return;
            }
            if (txt_precioVenta_agregar.Text == "")
            {
                errorProvider1.SetError(txt_precioVenta_agregar, "Campo obligatorio");
                txt_precioVenta_agregar.Focus();
                return;
            }
            productos.ID_CATEGORIA = Convert.ToInt32(cbx_categorias_productosA.SelectedValue);
            productos.NOMBRE = txt_nombre_agregar.Text;
            productos.PRECIO_COMPRA = Convert.ToDecimal(txt_precioCompra_agregar.Text);
            productos.PRECIO_VENTA = Convert.ToDecimal(txt_precioVenta_agregar.Text);
            productos.agregarProducto();
            mostrarProductos();
            txt_precioVenta_agregar.Clear();
            txt_precioCompra_agregar.Clear();
            txt_nombre_agregar.Clear();
            cbx_categorias_productosA.SelectedIndex = 0;
            int conteo = dgridProductos.Rows.Count - 1;
            lbl_cantidadProductos.Text = conteo.ToString();
            errorProvider1.SetError(txt_nombre_agregar, "");
            errorProvider1.SetError(txt_precioCompra_agregar, "");
            errorProvider1.SetError(txt_precioVenta_agregar, "");
            dgridProductos.Visible = true;
            panelAgregar.Visible = false;
            iconLupa.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
        }
        private void agregarCategoria()
        {
            productos.NOMBRE = txt_nombreCategoria.Text;
            productos.insertarCategoria();
            llenarCombo();
            dgridProductos.Visible = true;
            panelCategoria.Visible = false;
            iconLupa.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
        }

        private void eliminarProducto()
        {
            if (MessageBox.Show("¿Estás seguro de eliminar el producto?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                productos.ID_PRODUCTO = Convert.ToInt32(dgridProductos.CurrentRow.Cells[0].Value);
                productos.eliminarProductos();
                int conteo = dgridProductos.Rows.Count-1;
                lbl_cantidadProductos.Text = conteo.ToString();
                MessageBox.Show("El producto se elimino exitosamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void veractualizarProductos()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand("SELECT*FROM Productos WHERE id_producto=@id_producto", conexion.abrirConexion());
            SqlDataReader leer;
            comando.Parameters.AddWithValue("@id_producto", dgridProductos.CurrentRow.Cells[0].Value);
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txt_nombreActualizar.Text = leer["nombre"].ToString();
                lbl_id.Text = leer["id_producto"].ToString();
                txt_precioCompra_actualizar.Text = leer["precioCompra"].ToString();
                txt_precioVenta_actualizar.Text = leer["precioVenta"].ToString();
                cbx_categoriasActualizar.SelectedValue = leer["id_categoria"].ToString();
              
            }
            panelActualizar.Size = new Size(433, 370);
            panelActualizar.Location = new Point(178, 70);
            panelActualizar.Visible = true;
            conexion.cerrarConexion();
        }
        private void actualizarProductos()
        {
            if (txt_nombreActualizar.Text=="")
            {
                errorProvider1.SetError(txt_nombreActualizar, "Campo Obligatorio");
                txt_nombreActualizar.Focus();
                return;
            }
            if (txt_precioCompra_actualizar.Text=="")
            {
                errorProvider1.SetError(txt_precioCompra_actualizar, "Campo Obligatorio");
                txt_precioCompra_actualizar.Focus();
                return;
            }
            if (txt_precioVenta_actualizar.Text=="")
            {
                errorProvider1.SetError(txt_precioVenta_actualizar, "Campo Obligatorio");
                txt_precioVenta_actualizar.Focus();
                return;
            }
            productos.ID_PRODUCTO = Convert.ToInt32(lbl_id.Text);
            productos.NOMBRE = txt_nombreActualizar.Text;
            productos.PRECIO_COMPRA = Convert.ToDecimal(txt_precioCompra_actualizar.Text);
            productos.PRECIO_VENTA = Convert.ToDecimal(txt_precioVenta_actualizar.Text);
            productos.ID_CATEGORIA = Convert.ToInt32(cbx_categoriasActualizar.SelectedValue);
            productos.modificarProductos();
            errorProvider1.SetError(txt_nombreActualizar, "");
            errorProvider1.SetError(txt_precioCompra_actualizar, "");
            errorProvider1.SetError(txt_precioVenta_actualizar, "");
            txt_nombreActualizar.Clear();
            txt_precioCompra_actualizar.Clear();
            txt_precioVenta_actualizar.Clear();
            cbx_categoriasActualizar.SelectedIndex = 0;

        }

        private void Btn_agregarProducto_Click(object sender, EventArgs e)
        {
            panelAgregar.Size = new Size(433, 370);
            panelAgregar.Location = new Point(178, 70);
            panelAgregar.Visible = true;
            dgridProductos.Visible = false;
            iconLupa.Visible = false;
            txt_buscarProducto.Visible = false;
            lbl_buscar.Visible = false;
            panelActualizar.Visible = false;
            panelCategoria.Visible = false;

        }

        private void Btn_cancelarProductoA_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
            dgridProductos.Visible = true;
            iconLupa.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
        }

        private void Btn_cancelarProductosE_Click(object sender, EventArgs e)
        {
            panelActualizar.Visible = false;
            dgridProductos.Visible = true;
            iconLupa.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
        }

        private void Btn_editarProducto_Click(object sender, EventArgs e)
        {         
            veractualizarProductos();
            panelAgregar.Visible = false;
            dgridProductos.Visible = false;
            iconLupa.Visible = false;
            txt_buscarProducto.Visible = false;
            lbl_buscar.Visible = false;
            panelActualizar.Visible = true;
            panelCategoria.Visible = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
           
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            panelCategoria.Visible = false;
            dgridProductos.Visible = true;
            iconLupa.Visible = true;
            lbl_buscar.Visible = true;
            txt_buscarProducto.Visible = true;
        }

        private void Btn_agregarProductoA_Click(object sender, EventArgs e)
        {
            agregarProducto();
        }

        private void Txt_precioVenta_agregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_buscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            productos.NOMBRE = txt_buscarProducto.Text;
            dgridProductos.DataSource = productos.buscarProductos();
        }

        private void Btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            eliminarProducto();
            mostrarProductos();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_editarProductos_Click(object sender, EventArgs e)
        {
            actualizarProductos();
            mostrarProductos();
            dgridProductos.Visible = true;
            panelActualizar.Visible = false;
            iconLupa.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panelCategoria.Visible = true;
            panelCategoria.Size = new Size(328, 260);
            panelCategoria.Location = new Point(289, 109);
            panelAgregar.Visible = false;
            dgridProductos.Visible = false;
            iconLupa.Visible = false;
            txt_buscarProducto.Visible = false;
            lbl_buscar.Visible = false;
            panelActualizar.Visible = false;
         
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            agregarCategoria();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreActualizar_FontChanged(object sender, EventArgs e)
        {

        }
    }
}
