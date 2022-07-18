using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___Frontend
{
    
    public partial class ListaDeContactos : Form
    {
        public ListaDeContactos()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            new AgregarContacto().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TS_Detalles_Contactos_Click(object sender, EventArgs e)
        {
            new EditarContacto().Show();
            this.Hide();
        }

        private void TB_Nombre_Agregar_TextChanged(object sender, EventArgs e)
        {
        }

        private void TB_Busqueda_Contacto_Click(object sender, EventArgs e)
        {
            TB_Busqueda_Contacto.Text = "";
        }

        private void ListaDeContactos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Estas seguro de que deseas cerrar la aplicación?", "Contactos",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
