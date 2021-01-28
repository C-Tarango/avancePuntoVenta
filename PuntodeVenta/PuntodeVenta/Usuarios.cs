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
    class Usuarios
    {
        private string usuario, contraseña;
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        public string USUARIO { get { return usuario; } set { usuario = value; } }
        public string CONTRASEÑA { get { return contraseña; } set { contraseña = value; } }
        public DataTable iniciarSesion(Form1 login)
        {
            try
            {
                DataTable tabla = new DataTable();
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "SP_INICIO_SESION";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();
                tabla.Load(leer);
                leer.Close();
                comando.Connection = conexion.cerrarConexion();
                if (tabla.Rows.Count==1)
                {
                    if (tabla.Rows[0][0].ToString()=="Jacob Fender")
                    {
                        login.Hide();
                        Form1 form = new Form1();
                        form.Hide();
                        Inicio inicio = new Inicio();
                        inicio.Show();
                       
                    }                 
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña son incorrectos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return tabla;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al iniciar sesion","Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
