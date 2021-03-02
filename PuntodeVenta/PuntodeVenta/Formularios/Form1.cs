using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PuntodeVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        { }
  

        private void Btn_restaurar_Click(object sender, EventArgs e)
        {
        }

        private void Btn_cancelarUser_Click(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
            btn_ocultarContraseña.Visible = false;
            btn_mostrarContraseña.Visible = false;
        }

        private void Btn_mostrarContraseña_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
            btn_ocultarContraseña.Visible = true;
            btn_mostrarContraseña.Visible = false;
     
        }

        private void Btn_ocultarContraseña_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            btn_mostrarContraseña.Visible = true;
            btn_ocultarContraseña.Visible = false;
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Debes ingresar el usuario y la contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuarios usuarios = new Usuarios();
                usuarios.USUARIO = txt_usuario.Text;
                usuarios.CONTRASEÑA = txt_password.Text;
                if (txt_usuario.Text == "Jacob")
                {
                    Inicio inicio = new Inicio();
                }
                usuarios.iniciarSesion(this);
            }

        }

        private void PanelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
