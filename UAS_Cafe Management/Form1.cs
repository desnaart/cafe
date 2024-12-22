using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UAS_Cafe_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=restaurant_dummy;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; // Ambil input dari TextBox1
            string password = textBox2.Text; // Ambil input dari TextBox2

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Login berhasil!\nUsername: {username}", "Info");
            }
            else
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text; // Ambil input dari TextBox1
            string password = textBox2.Text; // Ambil input dari TextBox2

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Pindah ke Form2
                Beranda_Bavarage form2 = new Beranda_Bavarage();
                form2.Show();
                this.Hide(); // Sembunyikan Form1
            }
            else
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Bavarage beranda = new Beranda_Bavarage();
            beranda.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda berhasil sign up!", "Info");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            dashboard_admin Item = new dashboard_admin();
            Item.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Hapus placeholder ketika TextBox1 (email) aktif
            if (textBox1.Text == "Enter your email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Kembalikan placeholder jika TextBox1 kosong
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter your email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Kembalikan placeholder jika TextBox1 kosong
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter your email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            // Hapus placeholder dan aktifkan karakter password ketika TextBox2 (password) aktif
            if (textBox2.Text == "Enter your password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true; // Ubah input menjadi password character
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            // Kembalikan placeholder jika TextBox2 kosong
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Enter your password";
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false; // Placeholder terlihat
            }
        }
    }
}