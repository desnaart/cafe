using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_Cafe_Management
{
    public partial class dashboard_admin : Form
    {
        public dashboard_admin()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupMenu_Admin Menu = new GroupMenu_Admin();
            Menu.Show();
        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Admin Menu = new Menu_Admin();
            Menu.Show();

        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
