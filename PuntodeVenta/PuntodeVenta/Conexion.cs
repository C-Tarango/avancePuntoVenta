using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PuntodeVenta
{
    class Conexion
    {
        static private string cadena = "Data Source=LAPTOP-FSBULS12;Initial Catalog=Punto_de_Venta;Integrated Security=True";
        private SqlConnection conexion = new SqlConnection(cadena);
        public SqlConnection abrirConexion()
        {
            try
            {
                if (conexion.State==ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión...no es posible abrir una conexión con la base de datos", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {
            try
            {
                if (conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conexion;
        }
    }
}
