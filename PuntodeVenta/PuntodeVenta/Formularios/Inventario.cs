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
            dgrid_inventario.Columns[1].ReadOnly = true;
            dgrid_inventario.Columns[2].ReadOnly = true;
            lbl_cantProductos.Text = (dgrid_inventario.Rows.Count - 1).ToString();
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
            lbl_cantProductos.Text = (dgrid_inventario.Rows.Count - 1).ToString();
        }
        private void modificarInventario()
        {
            reporteInventario.ID_PRODUCTO = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[0].Value);
            reporteInventario.EXISTENCIA = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[3].Value);
            reporteInventario.modificarInventario();
            
        }
        private void eliminarInventario()
        {
            reporteInventario.ID_PRODUCTO = Convert.ToInt32(dgrid_inventario.CurrentRow.Cells[0].Value);
            reporteInventario.eliminarInventario();
            lbl_cantProductos.Text = (dgrid_inventario.Rows.Count - 2).ToString();
            mostrarProductos();
        }
        private void buscarInventario()
        {
            reporteInventario.NOMBRE = txt_buscarProducto.Text;
            dgrid_inventario.DataSource= reporteInventario.buscarProducto();
        }

        private void Btn_agregarInventario_Click(object sender, EventArgs e)
        {
            panelAgregar.Location = new Point(252, 82);
            panelAgregar.Size = new Size(271, 272);
            panelAgregar.Visible = true;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }

        private void Btn_agregar_inventario_Click(object sender, EventArgs e)
        {
            agregarInventario();

        }

        private void Dgrid_inventario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            modificarInventario();
        }

        private void Dgrid_inventario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Dgrid_inventario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (dgrid_inventario.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                }
            }
        }
        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminarInventario();
        }

        private void Txt_buscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            buscarInventario();
        }
    }
}
