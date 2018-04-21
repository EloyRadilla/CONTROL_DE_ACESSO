using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CONTROL_DE_ACCESO
{
    public partial class Menu : Form
    {
        string connectionString = @"server=127.0.0.1; database=rfidbd; User id=root; password= ";
        int iddatos = 0;
        public Menu()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)          
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("Agregar_editar",mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_iddatos",iddatos);
                mysqlcmd.Parameters.AddWithValue("_uid", txt_uid.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_nombre", txt_nombre.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_fecharegistro", iddatos);
                mysqlcmd.Parameters.AddWithValue("_apellidopaterno", txt_P.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_apellidomaterno", txt_M.Text.Trim());
                mysqlcmd.Parameters.AddWithValue("_departamento", txt_D.Text.Trim());
                mysqlcmd.ExecuteNonQuery();
                MessageBox.Show("Agregado correctamente"); 
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string entrada = serialPort1.ReadLine();
            serialPort1.Close();
            txt_uid.Text = entrada;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
