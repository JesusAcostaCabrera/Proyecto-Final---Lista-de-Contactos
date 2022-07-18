using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayoutFlow.DAL;

namespace LayoutFlow.BLL
{
    class ClassBll
    {
        // Función para guardar datos dentro de la base de datos
        public bool SaveItems(Image img, string Nombre, string Telefono, string Correo, string Direccion, string Descripcion)
        {

            try
            {

                ClassDAL objdal = new ClassDAL(); // Llamar Clase DAL
                return objdal.AddItemsToTable(img, Nombre, Telefono, Correo, Direccion, Descripcion); // Guarda datos dentro de la base de datos


            }
            catch (Exception e) // Por si sucede un error y no cierre de manera abrupta
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        // Función para borrar datos dentro de la base de datos
        public bool DeleteItems(int Id)
        {

            try
            {

                ClassDAL objdal = new ClassDAL(); // Llamara clase Dal
                return objdal.DeleteItemsFromTable(Id); // Borra datos dentro de la base de datos


            }
            catch (Exception e)  // Por si sucede de un error y no cierre de manera abrupta
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }

        // Función para editar datos dentro de la base de datos
        public bool EditItems(int Id, Image img, string Nombre, string Telefono, string Correo, string Direccion, string Descripcion)
        {
            try
            {

                ClassDAL objdal = new ClassDAL(); // Llamar clase Dal
                return objdal.EditItemsFromTable(Id, img, Nombre, Telefono, Correo, Direccion, Descripcion); // Edita datos dentro de la base de datos


            }
            catch (Exception e) // Por si sucede de un error y no cierre de manera abrupta
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        // Función identifcar objetos
        public DataTable GetItems()
        {

            try
            {

                ClassDAL objdal = new ClassDAL(); // Llamar clase Dal
                return objdal.ReadItemsTable(); // Obtener datos de tablas


            }
            catch (Exception e) // Por si sucede de un error y no cierre de manera abrupta
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }

        }
    }
}