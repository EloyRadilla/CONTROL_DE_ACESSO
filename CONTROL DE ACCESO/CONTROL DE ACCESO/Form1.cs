using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace CONTROL_DE_ACCESO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=rfidbd; User id=root; password= ");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select *from login where nombre = '" + txtnombre.Text + "' and password = '" + txtpass.Text + "'  ");
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read())
            {
                MessageBox.Show("Bienvenido al sistema de control de acceso");
                Menu_Principal llamar = new Menu_Principal();
                llamar.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Contraseña incorrecta ");
            }
            conectar.Close();
        }
    }
}
