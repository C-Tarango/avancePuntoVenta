using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class Detalles_Ventas : Form
    {
        public Detalles_Ventas()
        {
            InitializeComponent();
        }

        private void Btn_agregarCliente_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
            panelAgregar.Size = new Size(397, 275);
            panelAgregar.Location = new Point(274, 81);
        }

        private void Btn_editarCliente_Click(object sender, EventArgs e)
        {
            panelActualizar.Visible = true;
            panelActualizar.Size = new Size(397, 275);
            panelActualizar.Location = new Point(274, 81);
        }

        private void Btn_cancelarProductosE_Click(object sender, EventArgs e)
        {
            panelActualizar.Visible = false;
        }

        private void Btn_cancelarProductoA_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }
    }
}
