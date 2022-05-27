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
    public partial class navbinding : Form
    {
        public navbinding()
        {
            InitializeComponent();
        }

        private void navbinding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu panggil = new menu();
            panggil.Show();
        }
    }
}
