using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayoutFlow.BLL;

using System.Configuration;
using System.Data.SqlClient;


namespace LayoutFlow.DAL
{
    class ClassDAL
    {
        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        // Función agregar datos a tabla dentro de la base de datos
        public bool AddItemsToTable(Image img, string Nombre, string Telefono, string Correo, string Direccion, string Descripcion)
        {

            try
            {

                // Ip de servidor
                ConnectionString = @"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False";

                //Query de la base de datos (Tipo de conexión y datos a modificar)
                using (connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO  Contactos(Nombre, Telefono, Correo, Direccion, imagen, Descripcion) VALUES(@Nombre, @Telefono, @Correo, @Direccion, @imagen, @Descripcion)", connection))
                {

                    connection.Open(); // Abrir conexión a la base de datos

                    // Insertar valores respectivamente
                    command.Parameters.AddWithValue("@Nombre", Nombre.Trim()); // Elimina espacios
                    command.Parameters.AddWithValue("@Telefono", Telefono.Trim());
                    command.Parameters.AddWithValue("@Correo", Correo.Trim());
                    command.Parameters.AddWithValue("@Direccion", Direccion.Trim());
                    command.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());

                    // Convierte imagen en byte
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    command.Parameters.AddWithValue("@imagen", ms.ToArray());

                    command.ExecuteScalar();

                    MessageBox.Show("Contacto Creado"); // Muestra MessageBox con mensaje

                }

                return true;
            }
            catch
            {

                throw;
            }

        }
        
        //Función Eliminar datos dentro de la base de datos
        public bool DeleteItemsFromTable(int Id)
        {
            try
            {
                // Ip del servidor
                ConnectionString = @"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False";

                using (connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM Contactos WHERE Id = @Id ", connection))
                {
                    // Abre conexión hacia el servidor
                    connection.Open();

                    command.Parameters.AddWithValue("@Id", Id); //@Id fuese el id que obtenemos cuando le damos click al user control

                    command.ExecuteScalar();

                }
                return true;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //Función Editar datos dentro de la base de datos
        public bool EditItemsFromTable(int Id, Image img, string Nombre, string Telefono, string Correo, string Direccion, string Descripcion)
        {
            try
            {
                // Ip del servidor
                ConnectionString = @"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False";

                //Query de la base de datos (Tipo de conexión y datos a modificar)
                using (connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("UPDATE Contactos SET Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, Descripcion = @Descripcion, Imagen = @Imagen WHERE Id =@Id", connection))
                {
                    
                    connection.Open(); // Conecta base de datos

                    // Asigna nuevos valores a la base de datos
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Nombre", Nombre.Trim());
                    command.Parameters.AddWithValue("@Telefono", Telefono.Trim());
                    command.Parameters.AddWithValue("@Correo", Correo.Trim());
                    command.Parameters.AddWithValue("@Direccion", Direccion.Trim());
                    command.Parameters.AddWithValue("@Descripcion", Descripcion.Trim());
                    
                    //Cambia a bytes
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    command.Parameters.AddWithValue("@imagen", ms.ToArray());

                    command.ExecuteScalar();

                    MessageBox.Show("Contacto Editado"); // Abre MessageBox

                }

                return true;
            }
            catch
            {

                throw;
            }            
        }

        // Funciön leer objetos dentro de tabla
        public DataTable ReadItemsTable()
        {


            try
            {
                // Ip de base de datos
                ConnectionString = @"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False";

                //Query de la base de datos (Tipo de conexión y datos a modificar)
                using (connection = new SqlConnection(ConnectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Contactos", connection))
                {

                    DataTable dt = new DataTable(); // Nueva tabla de datos con datos de contactos
                    adapter.Fill(dt);

                    return dt;

                }
            }
            catch
            {
                throw;
            }



        }

    }

}