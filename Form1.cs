using MICRUD.modelo;
using MICRUD.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_cedula.Text = "";
            txt_telefono.Text = "";
            txt_documento.Text = "";
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if(txt_nombre.Text.Trim() == "" || txt_direccion.Text.Trim() == "" || txt_cedula.Text.Trim() == "" || txt_telefono.Text.Trim() == "")// Verificar si los campos estan vacios o no
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            else
            {
                try
                {
                    personaAD per = new personaAD();
                    persona p = new persona();

                    p.Nombres = txt_nombre.Text;//Le pasamos la informacion de lo que hay en los campos a la clase persona.
                    p.Direccion = txt_direccion.Text;
                    p.Cedula = txt_cedula.Text;
                    p.Telefono = txt_telefono.Text;
                    if (per.insertar(p)){//le pasamos por parametro el objeto de la clase persona con las informaciones integradas.

                        llenarGrid();
                        MessageBox.Show("Datos guardados correctamente");
                        limpiarCampos();
                        
                    }
                    else
                    {
                        MessageBox.Show("No se guardaron los datos");
                        limpiarCampos();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (txt_documento.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de documento");
            }
            else
            {
                persona p = personaAD.consultar(txt_documento.Text);
                if(p == null)
                {
                    MessageBox.Show("No existe el documento " + txt_documento.Text);
                }
                else
                {
                    txt_nombre.Text = p.Nombres;
                    txt_direccion.Text = p.Direccion;
                    txt_cedula.Text = p.Cedula;
                    txt_telefono.Text = p.Telefono;
                }
            }
        }
        private void llenarGrid()
        {
            DataTable datos = personaAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataView.DataSource = datos.DefaultView;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(txt_documento.Text == "")
            {
                MessageBox.Show("debe ingresar el documento a actualizar");
            }
            else if (txt_nombre.Text.Trim() == "" || txt_direccion.Text.Trim() == "" || txt_cedula.Text.Trim() == "" || txt_telefono.Text.Trim() == "")// Verificar si los campos estan vacios o no
            {
                MessageBox.Show("Es necesario llenar todos los campos para actualizar");
            }
            else
            {
                try
                {
                    personaAD per = new personaAD();
                    persona p = new persona();

                    p.Nombres = txt_nombre.Text;//Le pasamos la informacion de lo que hay en los campos a la clase persona.
                    p.Direccion = txt_direccion.Text;
                    p.Cedula = txt_cedula.Text;
                    p.Telefono = txt_telefono.Text;
                    if (per.actualizar(p))
                    {//le pasamos por parametro el objeto de la clase persona con las informaciones integradas.

                        llenarGrid();
                        MessageBox.Show("Datos actualizados correctamente");
                        limpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("No se actualizaron los datos");
                        limpiarCampos();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_documento.Text == "")
            {
                MessageBox.Show("debe ingresar el documento a eliminar");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "Realmente desea eliminar el documento?", "Confirmacion", MessageBoxButtons.YesNo))
            {
                try
                {
                    personaAD per = new personaAD();
                    if (per.eliminar(txt_documento.Text.Trim()))
                    {//le pasamos por parametro el objeto de la clase persona con las informaciones integradas.

                        llenarGrid();
                        MessageBox.Show("Datos eliminados correctamente");
                        limpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("No se eliminaron los datos");
                        limpiarCampos();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
