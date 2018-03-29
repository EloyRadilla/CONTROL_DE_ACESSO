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
        public Menu()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = string.Format("INSERT INTO `rfidbd`.`datos`(`uid`,`nombre`,`fechaderegistro`)VALUES('{0}','{1}','{2}');", txt_uid.Text, txt_nombre.Text, DateTime.Now.ToString("dd-MM-yyyy"));
                string cadenaConexion = @"server=127.0.0.1; database=rfidbd; User id=root; password="";";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cadenaConexion);
                MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                MessageBox.Show("Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = string.Format("SELECT * FROM rfidbd.datos where uid = '{0}'", txt_uid.Text);
                string cadenaConexion = @"server=127.0.0.1; database=rfidbd; User id=root; password=;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cadenaConexion);
                MySqlCommandBuilder comando = new MySqlCommandBuilder(adaptador);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                MessageBox.Show(string.Format("id: {0} uid: {1} nombre: {2} fecha: {3}", dt.Rows[0].ItemArray[0].ToString(), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), dt.Rows[0].ItemArray[3].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string entrada = serialPort1.ReadLine();
            serialPort1.Close();
            txt_uid.Text = entrada;
        }
    }
}
