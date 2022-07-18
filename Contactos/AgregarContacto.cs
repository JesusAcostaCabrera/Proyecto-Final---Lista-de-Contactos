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
    public partial class AgregarContacto : Form
    {
        public AgregarContacto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ListaDeContactos().Show();
            this.Hide();
        }

        private void AgregarContacto_Load(object sender, EventArgs e)
        {

        }

        private void TB_Nombre_Agregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Numero_Agregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Correo_Agregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Direccion_Agregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Nota_Agregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_Subir_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void BT_Volver_Agregar_Click(object sender, EventArgs e)
        {
            new ListaDeContactos().Show();
            this.Hide();
        }
    }
}
