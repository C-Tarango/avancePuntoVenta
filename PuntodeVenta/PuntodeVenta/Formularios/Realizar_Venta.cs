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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            dgridVentas.Rows[0].Cells[0].Value = "1";
            dgridVentas.Rows[0].Cells[1].Value = "Coca-Cola";
            dgridVentas.Rows[0].Cells[2].Value = "14.00";
            dgridVentas.Rows[0].Cells[3].Value = "2";
            dgridVentas.Rows[0].Cells[4].Value = "28.00";
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
    }
}
