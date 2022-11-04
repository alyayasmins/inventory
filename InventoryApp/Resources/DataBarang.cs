using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.Resources
{
    public partial class DataBarang : UserControl
    {
        Helper helper = new Helper();
        int id;
        public DataBarang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtStokBarang.Text, "[^0-9]"))
            {
                MessageBox.Show("Data stok harus di isi dengan nomor ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStokBarang.Text = txtStokBarang.Text.Remove(txtStokBarang.Text.Length - 1);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DataBarang_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = helper.GetData("select id_barang, nama_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang, users where barang.id_user = users.id_user");
            dataGridView1.DataSource = dataBarang.Tables[0];
        }

        private void ClearAll()
        {
            txtKodeBarang.Clear();
            txtNamaBarang.Clear();
            txtStatusBarang.Text = "";
            txtStatusBarang.SelectedIndex = -1;
            txtStokBarang.Clear();
            txtKondisiBarang.Text = "";
            txtKondisiBarang.SelectedIndex = -1;
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtStatusBarang.Text != "" && txtStokBarang.Text != "" && txtKondisiBarang.Text != "")
            {
                if (MessageBox.Show("Anda yakin untuk menambahkan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    helper.SetData("insert into barang(id_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang) values('" + Form1.id_user + "', '" + txtKodeBarang.Text + "','" + txtNamaBarang.Text + "','" + txtStatusBarang.Text + "','" + txtStokBarang.Text + "','" + txtKondisiBarang.Text + "')", "Berhasil menambahkan data barang.");
                    DataBarang_Load(this, null);
                    ClearAll();
                    helper.LogActivity("Menambahkan Data Barang");
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Simpan perubahan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                helper.SetData("update barang set kode_barang='"+ txtKodeBarang.Text + "', nama_barang='" + txtNamaBarang.Text + "', status_barang='" + txtStatusBarang.Text + "', stok_barang='" + txtStokBarang.Text + "', kondisi_barang='" + txtKondisiBarang.Text + "' where id_barang='" + id + "'", "Berhasil mengedit data barang.");
                DataBarang_Load(this, null);
                ClearAll();
                helper.LogActivity("Mengedit Data Barang");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtStatusBarang.Text != "" && txtStokBarang.Text != "" && txtKondisiBarang.Text != "")
            {
                if (MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    helper.SetData("delete from barang where id_barang = '" + id + "'", "Berhasil Menghapus Data Barang");
                    DataBarang_Load(this, null);
                    ClearAll();
                    helper.LogActivity("Menghapus Data Barang");
                }
                else
                {
                    MessageBox.Show("Pilih data untuk di hapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                }
            }  
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet data = helper.GetData("select id_barang, nama_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang, users where barang.id_user = users.id_user and (nama_barang like '%%" + txtSearch.Text + "%' or kode_barang like '%" + txtSearch.Text + "%')");
            dataGridView1.DataSource = data.Tables[0]; 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select id_barang, nama_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang, users where barang.id_user = users.id_user and tanggal_barang='" + theDate + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtKodeBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNamaBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStatusBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStokBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtKondisiBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
