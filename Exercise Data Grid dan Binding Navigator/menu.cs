using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Data_Grid_dan_Binding_Navigator
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            datagrid panggil = new datagrid();
            panggil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            navbinding panggil = new navbinding();
            panggil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 panggil = new Form1();
            panggil.Show();
        }
    }
}
