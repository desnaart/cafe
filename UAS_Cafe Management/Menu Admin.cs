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

namespace UAS_Cafe_Management
{
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
            LoadMenuData();
        }

        private void LoadMenuData()
        {
            string query = "SELECT m.id, m.menu_name, m.capital, m.price, m.menu_img, m.info, g.group_name " +
                           "FROM menu m " +
                           "LEFT JOIN `group` g ON m.group_id = g.id";

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table; // Bind data to DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMenu(int menuId)
        {
            string query = "DELETE FROM menu WHERE id = @menuId";

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@menuId", menuId);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Menu berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMenuData(); // Refresh data setelah menghapus
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menghapus data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int menuId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value); // Ambil ID dari kolom "id"

                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus menu ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteMenu(menuId);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int menuId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value); // Ambil ID dari kolom "id"

                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus menu ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteMenu(menuId);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupMenu_Admin Menu = new GroupMenu_Admin();
            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard_admin dashboard = new dashboard_admin();
            dashboard.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderan_admincs orderan = new orderan_admincs();
            orderan.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string menuName = textBox1.Text;
            string group = comboBox2.SelectedItem?.ToString();
            string beliPrice = textBox2.Text;
            string jualPrice = textBox3.Text;
            string menuImg = textBox5.Text; 
            string keterangan = textBox6.Text;

            if (string.IsNullOrEmpty(menuName) || string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Menu Name dan Group wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO menu (menu_name, group_id, price, capital, menu_img, info) " +
                           "VALUES (@menuName, @group, @beliPrice, @jualPrice, @menuImg, @keterangan)";

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@menuName", menuName);
                        command.Parameters.AddWithValue("@group", group);
                        command.Parameters.AddWithValue("@beliPrice", beliPrice);
                        command.Parameters.AddWithValue("@jualPrice", jualPrice);
                        command.Parameters.AddWithValue("@menuImg", menuImg); 
                        command.Parameters.AddWithValue("@keterangan", keterangan);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil disimpan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Ambil data dari DataGridView
                int menuId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value);
                string menuName = dataGridView1.Rows[selectedRowIndex].Cells["menu_name"].Value.ToString();
                string capital = dataGridView1.Rows[selectedRowIndex].Cells["capital"].Value.ToString();
                string price = dataGridView1.Rows[selectedRowIndex].Cells["price"].Value.ToString();
                string menuImg = dataGridView1.Rows[selectedRowIndex].Cells["menu_img"].Value.ToString();
                string info = dataGridView1.Rows[selectedRowIndex].Cells["info"].Value.ToString();

                // Isi form input dengan data yang dipilih
                textBox1.Text = menuName;  // Nama Menu
                textBox2.Text = capital;   // Modal
                textBox3.Text = price;     // Harga
                textBox4.Text = menuImg;   // Path Gambar
                textBox5.Text = info;      // Keterangan

                // Simpan ID menu yang sedang diedit ke variabel (misalnya, property `EditingMenuId`)
                EditingMenuId = menuId;
            }
            else
            {
                MessageBox.Show("Pilih menu yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Harap isi semua kolom wajib!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil metode untuk memperbarui data
            UpdateMenu();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
