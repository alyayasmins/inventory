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
    public partial class Dashboard : UserControl
    { 
        Helper helper = new Helper();
        public Dashboard()
        {
            InitializeComponent();
        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user");
            dataGridView2.DataSource = dataLog.Tables[0];
            DataTable totalBaranng = helper.GetOneData("select sum(stok_barang) from barang");
            tl_gudang.Text = totalBaranng.Rows[0][0].ToString() + " Barang";
            DataTable jumlahPegawai = helper.GetOneData("select count(id_user) from users");
            jml_pegawai.Text = jumlahPegawai.Rows[0][0].ToString() + "  Pegawai";
            DataTable totalLogAktifitas = helper.GetOneData("select count(id_log) from log_activity");
            aktivitas.Text = totalLogAktifitas.Rows[0][0].ToString() + " Log";
            DataTable barangMasuk = helper.GetOneData("select count(id_barang) from barang where status_barang = 'Masuk'");
            masuk.Text = barangMasuk.Rows[0][0].ToString() + " Barang";
            DataTable barangKeluar = helper.GetOneData("select count(id_barang) from barang where status_barang = 'Keluar'");
            keluar.Text = barangKeluar.Rows[0][0].ToString() + " Barang";
            DataTable barangRusak = helper.GetOneData("select count(id_barang) from barang where kondisi_barang = 'Rusak'");
            rusak.Text = barangRusak.Rows[0][0].ToString() + " Barang";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user and (nama_user like '%" + txtSearch.Text + "%' or activity like '%" + txtSearch.Text + "%')");
            dataGridView2.DataSource = dataLog.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user and tanggal='" + theDate + "'");
            dataGridView2.DataSource = dataLog.Tables[0];
        }
    }
}
