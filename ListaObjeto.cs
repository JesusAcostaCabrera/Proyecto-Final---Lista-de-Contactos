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
    

    public partial class ListaObjeto : UserControl
    {
        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        public ListaObjeto() // Inicializa lista de objetos
        {
            InitializeComponent();
            ConnectionString = @"Data Source=RESH-PC\SQLEXPRESS;Initial Catalog=Contactos;Integrated Security=True;Context Connection=False";

        }

        // Controles de usuario
        [Category ("Editables")]
        private string _Nombre = "@Nombre"; // Valor de nombre dentro de Flow Layout Pannel

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; LB_Nombre.Text = value; }
        }

        [Category("Editables")]
        private string _Descripcion = "@Descripcion"; // Valor de Descripcion dentro de Flow Layout Pannel

        public  string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; LB_Descripcion.Text = value; }
        }

        [Category("Editables")]
        private Image _Foto = Image.FromFile("/Resources/@imagen"); // Valor de Imagen dentro de Flow Layout Pannel

        public  Image foto
        {
            get { return _Foto; }
            set { _Foto = value; }
        }


    }
}
