using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayoutFlow.BLL;

using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Proyecto_Final___Frontend
{
    
    public partial class ListaDeContactos : Form
    {

        public ListaDeContactos()
        {
            InitializeComponent(); // Inicializar Interfaz
        }

        // Funcionalidad para mover a interfaz agregar contactos
        private void button1_Click(object sender, EventArgs e) 
        {
            AgregarContacto Form2 = new AgregarContacto(); // Abre interfaz agregar contacto
            Form2.Show();
            this.Hide(); // Cierra interfaz anterior
        }

        // Funcionalidad de preguntar confirmación para cerrar aplicación
        private void ListaDeContactos_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if(MessageBox.Show("Estas seguro de que deseas cerrar la aplicación?", "Contactos",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // Función generar Lista de contactos (Flow Layout Panel)
        private void ListaDeContactos_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
        

        // Esquema de Lista de Contactos (Flow Layout Panel)
        private void GenerateDynamicUserControl()
        {

            flowLayoutPanel1.Controls.Clear(); // Reinicia los controles del panel

            ClassBll objbll = new ClassBll(); // Llama clase Bll

            DataTable dt = objbll.GetItems(); // Crea tabla con los valores de la tabla Contactos, llamando la clase Bll

            if (dt != null) // Si la tabla existe
            {
                if (dt.Rows.Count > 0) // Si la tabla tiene valores
                {

                    UserControl1[] listItems = new UserControl1[dt.Rows.Count]; // Crea controles de usuarios en base a la cantidad de filas existentes
                    for (int i = 0; i < 1; i++) //Valores para determinar objetos
                    {
                        foreach (DataRow row in dt.Rows) 
                        {
                            
                            listItems[i] = new UserControl1(); // Creación de control de usuario

                            // Convierte de Byte a Bitmap
                            MemoryStream ms = new MemoryStream((byte[])row["imagen"]); 
                            listItems[i].Icon = new Bitmap(ms);

                            // Asigna valores a los diferentes controles de usuarios
                            listItems[i].Nombre = row["Nombre"].ToString(); // Nombre
                            listItems[i].Descripcion = row["Descripcion"].ToString(); // Descripcion
                            listItems[i].Id = Convert.ToInt32(row["Id"]); // Id (No se muestra)
                            flowLayoutPanel1.Controls.Add(listItems[i]); // Agrega controles de usuarios al Flow Layout Panel

                            listItems[i].Click += new System.EventHandler(this.UserControl_Click); //  Trasladar valores de control de usuario especifico

                        }

                    }

                }
            }
        }

        // Barra de Busqueda Error = ???
        private void Buscar(string Busqueda)
        {
            flowLayoutPanel1.Controls.Clear();

            ClassBll objbll = new ClassBll();

            DataTable dt = objbll.GetItems();

            char[] Letras = Busqueda.ToCharArray();
            bool Success = false;

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                    UserControl1[] listItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            char[] Palabra = listItems[i].Nombre.ToCharArray();

                            for (int j = 0; j < Letras.Length; j++)
                            {
                                if (Palabra.Contains(Letras[j]))
                                {
                                    listItems[i] = new UserControl1();

                                    MemoryStream ms = new MemoryStream((byte[])row["imagen"]);
                                    listItems[i].Icon = new Bitmap(ms);

                                    listItems[i].Nombre = row["Nombre"].ToString();
                                    listItems[i].Descripcion = row["Descripcion"].ToString();
                                    listItems[i].Id = Convert.ToInt32(row["Id"]);
                                    flowLayoutPanel1.Controls.Add(listItems[i]);

                                    listItems[i].Click += new System.EventHandler(this.UserControl_Click);
                                }

                                if (Success == true)
                                    break;
                            }


                        }

                    }

                }
            }
        }
        
        // Funcionalidad para Editar Control de usuario en especifico
        void UserControl_Click(object sender, EventArgs e)
        {
            UserControl1 obj = (UserControl1)sender; // Envia datos de Control de usuario seleccionado
            
            Datos.Columna = Convert.ToInt32(obj.Id); // Datos.Columna obtiene el valor del id unico del control de usuario
            Datos.Imagen = obj.Icon; // Datos.Imagen obtiene el valor de la imagen unica del control de usuario

            new EditarContacto().Show(); // Abre Interfaz Editar Contacto del Control de usuario en especifico
            this.Hide(); // Cierra interfaz actual
        }

    }
}
