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
                Clear();
                GrindFill();
            }


        }

        void GrindFill ()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection (connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mysqlda = new MySqlDataAdapter("Buscar", mysqlcon);
                mysqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbrfid = new DataTable();
                mysqlda.Fill(dtbrfid);
                dataGridView1.DataSource = dtbrfid;
                dataGridView1.Columns[0].Visible = false;


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
            Clear();
            GrindFill();
        }

        void Clear ()
        {
            txt_nombre.Text = txt_uid.Text = txt_P.Text = txt_M.Text = txt_D.Text = "";
            iddatos = 0;
            Agregar.Text = "Guardar";
            Eliminar.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                txt_uid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_nombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_P.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_M.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_D.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                iddatos = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Agregar.Text = "Actualizar";
                Eliminar.Enabled = Enabled;


            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mysqlda = new MySqlDataAdapter("Buscarvalor", mysqlcon);
                mysqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                mysqlda.SelectCommand.Parameters.AddWithValue("_buscarvalor", txt_B.Text);
                DataTable dtbrfid = new DataTable();
                mysqlda.Fill(dtbrfid);
                dataGridView1.DataSource = dtbrfid;
                dataGridView1.Columns[0].Visible = false;


            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connectionString))
            {
                mysqlcon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("Eliminarporid", mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_iddatos", iddatos);
                mysqlcmd.ExecuteNonQuery();
                MessageBox.Show("Eliminado correctamente");
                Clear();
                GrindFill();
            }
        }
    }
}
