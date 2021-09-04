using MICRUD.datos;
using MICRUD.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICRUD
{
    class personaAD
    {
        public bool insertar(persona p)
        {
            try
            {
                Conexion cn = new Conexion();
                string consulta = "INSERT INTO Persona(nombre, direccion, cedula, telefono)VALUES('" + p.Nombres + "','" + p.Direccion + "','" + p.Cedula + "','" + p.Telefono + "')";
                SqlCommand comando = new SqlCommand(consulta, cn.conectar());
                int cantidad = comando.ExecuteNonQuery();// variable para verificar si alguna fila fue afectada
                if (cantidad == 1)
                {//Si una fila fue afectada pues que desconecte la conexion
                    cn.desconectar();
                    return true;
                }
                else
                {
                    cn.desconectar();
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }

        public static persona consultar(string documento)
        {
            try
            {
                Conexion cn = new Conexion();
                string query = "SELECT * FROM Persona WHERE id = '" + documento + "';";
                SqlCommand comando = new SqlCommand(query, cn.conectar());
                SqlDataReader dataR = comando.ExecuteReader();// Este objeto ejecuta y lee lo que le pasamos al comando
                persona p = new persona();
                if (dataR.Read())//Si el data reader lee los datos.
                {
                    p.Documento = dataR["id"].ToString();//Transferimos los datos a las variables de la clase persona
                    p.Nombres = dataR["nombre"].ToString();
                    p.Direccion = dataR["direccion"].ToString();
                    p.Cedula = dataR["cedula"].ToString();
                    p.Telefono = dataR["telefono"].ToString();
                    cn.desconectar();
                    return p;
                }
                else
                {
                    cn.desconectar();
                    return null;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public bool actualizar(persona p)
        {
            try
            {
                Conexion cn = new Conexion();
                string query = "UPDATE Persona SET nombre='" + p.Nombres + "', direccion='"+ p.Direccion + "', cedula='"+ p.Cedula +"', telefono='"+ p.Telefono +"' WHERE id='" + p.Documento + "'";
                SqlCommand comando = new SqlCommand(query, cn.conectar());
                int cantidad = comando.ExecuteNonQuery();// variable para verificar si alguna fila fue afectada
                if (cantidad == 1)
                {//Si una fila fue afectada pues que desconecte la conexion
                    cn.desconectar();
                    return true;
                }
                else
                {
                    cn.desconectar();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public static DataTable listar()
        {
            try
            {
                //Conectar el datagrid view para que muestre los datos de la base de datos
                Conexion cn = new Conexion();
                string query = "SELECT * FROM Persona";
                SqlCommand comando = new SqlCommand(query, cn.conectar());
                SqlDataReader dataR = comando.ExecuteReader(CommandBehavior.CloseConnection/*esto cierra la conexion de inmediato al momento de leer*/);
                DataTable datatable = new DataTable();//se crea una instancia de DataTable para cargar los datos
                datatable.Load(dataR);

                cn.desconectar();
                return datatable;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
