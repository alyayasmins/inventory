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
    public partial class DataMasuk : UserControl
    {
        Helper helper = new Helper();
        public DataMasuk()
        {
            InitializeComponent();
        }

        public void DataMasuk_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = helper.GetData("select id_barang, nama_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang, users where barang.id_user = users.id_user and status_barang = 'Masuk'");
            dataGridView1.DataSource = dataBarang.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet data = helper.GetData("select id_barang, nama_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang, users where barang.id_user = users.id_user and status_barang='Masuk' and (nama_barang like '%" + txtSearch.Text + "%' or kode_barang like '%" + txtSearch.Text + "%')");
            dataGridView1.DataSource = data.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select id_barang, nama_user, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from  barang, users where barang.id_user = users.id_user and status_barang = 'Masuk' and tanggal_barang='" + theDate + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }
    }
}
