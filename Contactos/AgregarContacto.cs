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
    public partial class AgregarContacto : Form
    {
        public AgregarContacto() // Inicia interfaz
        {
            InitializeComponent();
        }
        private void BT_Subir_Agregar_Click(object sender, EventArgs e) //Funcionalidad de agregar imagen dentro del interfaz de Agregar contacto
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName); // Abre una caja dando la oportunidad de seleccionar una foto dentro del computador
                PB_Contacto_Agregar.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Funcionalidad para guardar los datos del contacto en la base de datos
        {
            ClassBll objbll = new ClassBll(); // Llama la clase BLL

            if (objbll.SaveItems(PB_Contacto_Agregar.Image, TB_Nombre_Agregar.Text, TB_Numero_Agregar.Text, TB_Correo_Agregar.Text, TB_Direccion_Agregar.Text, TB_Nota_Agregar.Text))
            // Llama un metodo dentro de la clase bll (SaveItems)
            {
                MessageBox.Show("Bien."); //Test
            }
            else
            {
                MessageBox.Show("Mal."); //Test
            }
            new ListaDeContactos().Show(); // Abre nuevamente Lista de Contactos
            this.Hide(); // Cierra interfaz actual
        }
        private void BT_Volver_Agregar_Click(object sender, EventArgs e) // Funcionalidad de volver sin haber agregado un contacto
        {
            new ListaDeContactos().Show(); // Abre nuevamente Lista de Contactos
            this.Hide(); // Cierra interfaz actual
        }
    }
}
