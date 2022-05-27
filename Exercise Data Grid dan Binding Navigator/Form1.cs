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
    public partial class Form1 : Form
    {
        readonly string Username = "annisa";
        readonly string Password = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Username && textBox2.Text == Password)
            {
                this.Hide();
                menu panggil = new menu();
                panggil.Show();
            }else if (textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Mohon memasukkan Username dan Password!");
            }else
            {
                MessageBox.Show("Username dan Password Anda Salah!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
