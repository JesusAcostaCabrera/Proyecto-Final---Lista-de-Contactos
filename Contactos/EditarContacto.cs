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
    public partial class EditarContacto : Form
    {
        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection = new SqlConnection(@"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False");

        SqlCommand Command;

        public EditarContacto() // Inicia interfaz Editar Contactos
        {
            InitializeComponent();
        }

        // Función Boton confirmar edición
        private void BT_Editar_Editar_Click(object sender, EventArgs e)
        {
            ClassBll objbll = new ClassBll(); // usar funciones de dicha clase

            if (objbll.EditItems(Datos.Columna, Datos.Imagen, TB_Nombre_Editar.Text, TB_Numero_Editar.Text, TB_Correo_Editar.Text, TB_Direccion_Editar.Text, TB_Nota_Editar.Text))
            {
                //int Id, Image img, string Nombre, string Telefono, string Correo, string Direccion, string Descripcion
                // Datos.Columna
                MessageBox.Show("Bien.");
            }
            else
            {
                MessageBox.Show("Mal.");
            }
            new ListaDeContactos().Show(); // Abre interfaz Lista de Contactos
            this.Hide(); // Cierra interfaz Actual

        }
        
        // Función boton de volver atras
        private void BT_Volver_Editar_Click(object sender, EventArgs e)
        {
            ListaDeContactos Form2 = new ListaDeContactos(); // Abre interfaz Lista de contactos
            Form2.Show();
            this.Hide(); //Cierra interfaz Actual
        }
        
        private void EditarContacto_Load(object sender, EventArgs e)
        {
            // Inicia conexión con base de datos
            connection.Open();
            //Query de la base de datos (Tipo de conexión y datos a modificar)
            Command = new SqlCommand("SELECT * FROM Contactos WHERE Id ='" + Datos.Columna + "' ;", connection);

            using(SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read()) //Lee valores dentro de la base de datos
                {
                    if (reader.HasRows) // Confirma que los valores encontrados tienen datos
                    {
                        //Asigna valores encontrados a los campos anteriores
                        TB_Nombre_Editar.Text = reader["Nombre"].ToString();
                        TB_Numero_Editar.Text = reader["Telefono"].ToString();
                        TB_Correo_Editar.Text = reader["Correo"].ToString();
                        TB_Direccion_Editar.Text = reader["Direccion"].ToString();
                        TB_Nota_Editar.Text = reader["Descripcion"].ToString();
                        PB_Contacto_Editar.Image = Datos.Imagen;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron filas"); // MessageBox con mensaje
                    }
                }
            }
        }

        //Funcionalidad de eliminar Contacto
        private void BT_Eliminar_Editar_Click(object sender, EventArgs e)
        {
            ClassBll objbll = new ClassBll(); // usar funciones de dicha clase

            objbll.DeleteItems(Datos.Columna); // Llama funcion de dicha clase
            new ListaDeContactos().Show(); // Abre interfaz Lista de Contacto
            this.Hide(); // Cierra interfaz Actual
        }

        // Funcionalidad Subir fotos dentro del interfaz editar contactos
        private void BT_Subir_Editar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // Abre caja para buscar foto dentro del computador
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName); 
                PB_Contacto_Editar.Image = image; // Asigna valor de la imagen a PictureBox dentro de la intefaz editar
                Datos.Imagen = image; // Asigna valor de la imagen a Datos.Imagen

            }
        }
    }
}
