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
    public partial class EditarContacto : Form
    {
        public EditarContacto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ListaDeContactos().Show();
            this.Hide();
        }

        private void BT_Volver_Editar_Click(object sender, EventArgs e)
        {
            new ListaDeContactos().Show();
            this.Hide();
        }
    }
}
