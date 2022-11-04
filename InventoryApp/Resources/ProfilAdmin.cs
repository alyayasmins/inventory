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
    public partial class ProfilAdmin : UserControl
    {
        Helper helper = new Helper();
        int id;
        public ProfilAdmin()
        {
            InitializeComponent();
        }

        public void ProfilAdmin_Load(object sender, EventArgs e)
        {
            DataSet dataPengguna = helper.GetData("select * from users");
            dataGridView1.DataSource = dataPengguna.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtnama.Text != "" && txtalamat.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtJabatan.Text != "" && txtTelfon.Text != "")
            {
                if (MessageBox.Show("Apakah anda yakin untuk menyimpan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    helper.SetData("insert into users(nama_user, alamat_user, telfon_user, username, pass, level_user) values('" + txtnama.Text + "', '" + txtalamat.Text + "', '" + txtTelfon.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtJabatan.Text + "')", "Berhasil menambahkan data pengguna.");
                    ProfilAdmin_Load(this, null);
                    ClearAll();
                    helper.LogActivity("Menambah Data User");
                }
            }
            else
            {
                helper.FillAllFields();
            }
        }
        private void ClearAll()
        {
            txtnama.Clear();
            txtalamat.Clear();
            txtTelfon.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtJabatan.Text = "";
            txtJabatan.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtnama.Text != "" && txtalamat.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtJabatan.Text != "" && txtTelfon.Text != "")
            {
                if (MessageBox.Show("Simpan perubahan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    helper.SetData("update users set nama_user='" + txtnama.Text + "', alamat_user='" + txtalamat.Text + "', telfon_user='" + txtTelfon.Text + "', username='" + txtUsername.Text + "', pass='" + txtPassword.Text + "', level_user='" + txtJabatan.Text + "' where id_user='" + id + "'", "Berhasil mengedit data pengguna.");
                    ProfilAdmin_Load(this, null);
                    ClearAll();
                    helper.LogActivity("Mengedit Data User");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk di edit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtnama.Text != "" && txtalamat.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtJabatan.Text != "" && txtTelfon.Text != "")
            {
                if (MessageBox.Show("Anda yakin untuk menghapus data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    helper.SetData("delete from users where id_user='" + id + "'", "Berhasil menghapus data pengguna.");
                    ProfilAdmin_Load(this, null);
                    ClearAll();
                    helper.LogActivity("Menghapus Data User");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk dihapus", "Peringan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtnama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtalamat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelfon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtJabatan.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet data = helper.GetData("select * from users where nama_user like '%" + txtSearch.Text + "%' or alamat_user like '%" + txtSearch.Text + "%' or level_user like '%" + txtSearch.Text + "%'");
            dataGridView1.DataSource = data.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select * from users where tanggal_bergabung='" + theDate + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }

        private void txtTelfon_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtTelfon.Text, "[^0-9]"))
            {
                MessageBox.Show("Data telpon harus diisi dengan nomor", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelfon.Text = txtTelfon.Text.Remove(txtTelfon.Text.Length - 1);
            }
        }
    }
}
