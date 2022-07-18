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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _Nombre;
        private string _Descripcion;
        private int _Id;

        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; PB_Imagen_UserControl.Image = value; } // Asigna valores de imagen a PictureBox
        }

        [Category("Custom Props")]

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; Lb_Nombre_UserControl.Text = value; } // Asigna valores de nombre a PictureBox
        }

        [Category("Custom Props")]

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; LB_Descripcion_UserControl.Text = value; } // Asigna valores de Descripcion a PictureBox
        }

        [Category("Custom Props")]

        public int Id
        {
            get { return _Id; } // Obtiene valores de Id 
            set { _Id = value; }
        }
        private void ucRequest_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(37, 37, 37); //cambiar back color cuando el mouse este arriba
        }

        private void ucRequest_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50); //volver back color como estaba cuando el mouse no este arriba 
        }

        //private void UserControl1_Click(object sender, EventArgs e)
        //{
        //    new EditarContacto().Show();
        //    this.Hide();
        //}
    }
    }
