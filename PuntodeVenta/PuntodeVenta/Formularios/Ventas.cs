using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta.Formularios
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            verVenta();
        }
        private void verVenta() 
        {
            classVentas ventas = new classVentas();
            dgridProductos.DataSource = ventas.verVentas();
        }
        private void buscarVenta() 
        {
            classVentas ventas = new classVentas();
            ventas.FECHA = dateTimePicker1.Value.Date;
            ventas.Buscar();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            buscarVenta();
        }

        private void btn_cancelarProductosE_Click(object sender, EventArgs e)
        {
            panel_detallesVentas.Visible = false;
        }

        private void btn_verDetalles_Click(object sender, EventArgs e)
        {
            detalles_ventas detalles = new detalles_ventas();
            detalles.ID_VENTA = Convert.ToInt32(dgridProductos.CurrentRow.Cells[0].Value);
            dgrid_detallesVentas.DataSource = detalles.mostrarDetallesVentas();
            panel_detallesVentas.Visible = true;
            panel_detallesVentas.Size = new Size(710, 419);
            panel_detallesVentas.Location = new Point(119, 12);
        }
    }
}
