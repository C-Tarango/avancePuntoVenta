using System;
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
    public partial class Inventario : Form
    {
        Reporte_inventario reporteInventario = new Reporte_inventario();
        public Inventario()
        {
            InitializeComponent();
            panelAgregar.Visible = false;
            mostrarProductos();
            llenarCombo();
            dgrid_inventario.Columns[0].ReadOnly = true;
            dgrid_inventario.Columns[1].ReadOnly = true;
            dgrid_inventario.Columns[2].ReadOnly = true;
            lbl_cantProductos.Text = (dgrid_inventario.Rows.Count).ToString();
        }
        private void mostrarProductos()
        {
            dgrid_inventario.DataSource = reporteInventario.mostrarProductos();
        }
        private void llenarCombo()
        {
            cbx_productos.DataSource = reporteInventario.llenarCombo();
            cbx_productos.DisplayMember = "nombre";
            cbx_productos.ValueMember = "id_producto";
        }
        private void agregarInventario()
        {
            if (txt_existencia.Text=="")
            {
                errorProvider1.SetError(txt_existencia, "Campo Obligatorio");
                txt_existencia.Focus();
                return;
            }
            reporteInventario.ID_PRODUCTO = Convert.ToInt32(cbx_productos.SelectedValue);
            reporteInventario.EXISTENCIA = Convert.ToInt32(txt_existencia.Text);
            reporteInventario.agregarInventario();
            mostrarProductos();
            errorProvider1.SetError(txt_existencia, "");
            lbl_cantProductos.Text = (dgrid_inventario.Rows.Count).ToString();
            panelAgregar.Visible = false;
            dgrid_inventario.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
            dgrid_inventario.Visible = true;
            iconlupa.Visible = true;

        }
        private void modificarInventario()
        {
            reporteInventario.ID_PRODUCTO = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[0].Value);
            reporteInventario.EXISTENCIA = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[3].Value);
            reporteInventario.modificarInventario();
            
        }
        private void eliminarInventario()
        {
            if (MessageBox.Show("¿Quieres eliminar el producto?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                reporteInventario.ID_PRODUCTO = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[0].Value);
                reporteInventario.eliminarInventario();
                lbl_cantProductos.Text = (dgrid_inventario.Rows.Count-1).ToString();
                mostrarProductos();
                MessageBox.Show("Se ha eliminado el producto de manera exitosa", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buscarInventario()
        {
            reporteInventario.NOMBRE = txt_buscarProducto.Text;
            dgrid_inventario.DataSource= reporteInventario.buscarProducto();
        }

        private void Btn_agregarInventario_Click(object sender, EventArgs e)
        {
            panelAgregar.Location = new Point(219, 79);
            panelAgregar.Size = new Size(352, 313);
            panelAgregar.Visible = true;
            txt_buscarProducto.Visible = false;
            iconlupa.Visible = false;
            dgrid_inventario.Visible = false;
            lbl_buscar.Visible = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
            dgrid_inventario.Visible = true;
            txt_buscarProducto.Visible = true;
            lbl_buscar.Visible = true;
            iconlupa.Visible = true;
        }

        private void Btn_agregar_inventario_Click(object sender, EventArgs e)
        {
            agregarInventario();

        }

        private void Dgrid_inventario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            modificarInventario();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminarInventario();
        }

        private void Txt_buscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            buscarInventario();
        }

        private void dgrid_inventario_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            int existencia = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[3].Value);
            int id = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[0].Value);
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand("UPDATE Inventario SET existencia=@existencia WHERE id_producto=@id_producto", conexion.abrirConexion());
            comando.Parameters.AddWithValue("@existencia", existencia);
            comando.Parameters.AddWithValue("@id_producto", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
        }
    }
}
