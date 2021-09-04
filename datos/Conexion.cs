using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MICRUD.datos
{
    class Conexion
    {
        SqlConnection conexion;
        

        //Primero que todo es la conexion
        public Conexion()
        {
            conexion = new SqlConnection("Server=localhost;Database=Crud;integrated security=true");
        }
        
        public SqlConnection conectar()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
