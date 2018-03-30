using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_DE_ACCESO
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Control de puerta 1");
            CONTROL_DE_ACCESO.Menu llamar = new CONTROL_DE_ACCESO.Menu();
            llamar.Show();
            this.Hide();
        }
    }
}
