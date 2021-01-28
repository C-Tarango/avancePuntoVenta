using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace PuntodeVenta
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private IconButton currentbtn;
        private Form currentFormularioHijo;
        private void cambiarIcono(object senderbtn)
        {
            if (senderbtn!=null)
            {
                currentbtn = (IconButton)senderbtn;
                btn_Home.IconChar = currentbtn.IconChar;
                lbl_Inicio.Text = currentbtn.Text;
            }
        }
        private void AbrirFormulario(Form formularioHijo)
        {
            if (currentFormularioHijo!=null)
            {
                currentFormularioHijo.Close();
            }
            currentFormularioHijo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
            lbl_Inicio.Text = formularioHijo.Text;
        }

        private void IconButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void Btn_productos_Click(object sender, EventArgs e)
        {
            cambiarIcono(sender);
            AbrirFormulario(new Productos());
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            cambiarIcono(sender);
            AbrirFormulario(new Ventas());
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            cambiarIcono(sender);
            AbrirFormulario(new Detalles_Ventas());
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            cambiarIcono(sender);
            AbrirFormulario(new Inventario());
        }

        private void Btn_empleados_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            btn_Home.IconChar = IconChar.Home;
            lbl_Inicio.Text = "Inicio";
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
