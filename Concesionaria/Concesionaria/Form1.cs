using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Concesionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection Conexion = new SqlConnection("Server=192.168.56.101;Database=Hola;User Id=AdminConcesionaria;Password=42558986@Gknoll;");
            Conexion.Open();
            MessageBox.Show("Se establecio la conexion.");
        }

    }
}
