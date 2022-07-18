using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Proyecto_Final___Frontend
{
    public partial class Login : Form
    {
        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        public Login()
        {
            InitializeComponent();

            //Conexión al servidor de la base de datos
            ConnectionString = @"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string ID = TB_Usuario.Text; // Usuario - TextBox (Texto)
            string PIN = TB_Contraseña.Text; // Contraseña - TextBox (Texto)

            //using para no detener que dispose al final
            using (connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario = '" + ID + "' AND Contraseña COLLATE Latin1_General_CS_AS = '" + PIN + "'", connection))
                //Query para seleccionar todos los valores de la tabla Usuarios dentro de la base de datos
            {
                try
                {

                    DataTable dtable = new DataTable(); // Llenando tabla de datos con los datos de la tabla usuarios
                    adapter.Fill(dtable);

                    if (dtable.Rows.Count > 0) //Sucede si existen los valores introducidos en los campos dentro de la tabla usuarios
                    {

                        ListaDeContactos Form2 = new ListaDeContactos(); // Abre el interfaz de Lista de Contactos
                        Form2.Show();
                        this.Hide(); //Cierra el interfaz anterior

                    }
                    else
                    {
                        MessageBox.Show("Incorrecto");
                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("Error");
                }
                finally
                {

                }

            }


        }
    }
}
