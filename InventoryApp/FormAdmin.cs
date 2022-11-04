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
    public partial class FormAdmin : Form
    {
        Helper helper = new Helper();
        bool sidebarExpand;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            DataTable userLevelLabel = helper.GetOneData("select level_user from users where id_user ='" + Form1.id_user + "'");
            if (userLevelLabel.Rows[0][0].ToString() == "Karyawan Gudang")
            {
                user.Text = "Gudang";
            }
            else
            {
                user.Text = userLevelLabel.Rows[0][0].ToString();
            }
            dashboard1.Dashboard_Load(this, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataKeluar1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataMasuk1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void profilAdmin1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            dashboard1.BringToFront();
            dashboard1.Dashboard_Load(this, null);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                Form1 fl = new Form1();
                fl.Show();
                helper.LogActivity("logout");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            profilAdmin1.Visible = true;
            profilAdmin1.BringToFront();
            profilAdmin1.ProfilAdmin_Load(this, null);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            dataLaporan1.Visible = true;
            dataLaporan1.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataBarangRusak1.Visible = true;
            dataBarangRusak1.BringToFront();
            dataBarangRusak1.DataBarangRusak_Load(this, null);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataMasuk1.Visible = true;
            dataMasuk1.BringToFront();
            dataMasuk1.DataMasuk_Load(this, null);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataKeluar1.Visible = true;
            dataKeluar1.BringToFront();
            dataKeluar1.DataKeluar_Load(this, null);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataBarang1.Visible = true;
            dataBarang1.BringToFront();
            dataBarang1.DataBarang_Load(this, null);
        }

        private void user_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10; 
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void profilAdmin1_Load_1(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            dashboard1.BringToFront();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            dashboard1.BringToFront();
        }

        private void dataLaporan1_Load(object sender, EventArgs e)
        {

        }
    }
}
