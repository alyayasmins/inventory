using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class FormKaryawanGudang : Form
    {
        Helper helper = new Helper();
        bool sidebarExpand;
        public FormKaryawanGudang()
        {
            InitializeComponent();
        }

        private void FormKaryawanGudang_Load(object sender, EventArgs e)
        {
            dataBarang1.Visible = true;
            dataBarang1.BringToFront();
            user.Text = "Gudang";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBarang1.Visible = true;
            dataBarang1.BringToFront();
            dataBarang1.DataBarang_Load(this, null);
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            dataKeluar1.Visible = true;
            dataKeluar1.BringToFront();
            dataKeluar1.DataKeluar_Load(this, null);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            dataMasuk1.Visible = true;
            dataMasuk1.BringToFront();
            dataMasuk1.DataMasuk_Load(this, null);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            dataBarangRusak1.Visible = true;
            dataBarangRusak1.BringToFront();
            dataBarangRusak1.DataBarangRusak_Load(this, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataLaporan1.Visible = true;
            dataLaporan1.BringToFront();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                Form1 fl = new Form1();
                fl.Show();
                helper.LogActivity("logout");
            }
        }

        private void menuButton_Click_2(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void user_Click_1(object sender, EventArgs e)
        {

        }
    }
}
