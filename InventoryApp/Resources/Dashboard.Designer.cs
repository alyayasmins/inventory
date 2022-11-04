namespace InventoryApp.Resources
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jml_pegawai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tl_gudang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rusak = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.aktivitas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.masuk = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.keluar = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.jml_pegawai);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(26, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 110);
            this.panel1.TabIndex = 1;
            // 
            // jml_pegawai
            // 
            this.jml_pegawai.AutoSize = true;
            this.jml_pegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.jml_pegawai.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jml_pegawai.ForeColor = System.Drawing.Color.White;
            this.jml_pegawai.Location = new System.Drawing.Point(84, 47);
            this.jml_pegawai.Name = "jml_pegawai";
            this.jml_pegawai.Size = new System.Drawing.Size(53, 18);
            this.jml_pegawai.TabIndex = 1;
            this.jml_pegawai.Text = "label13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Jumlah Pegawai";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.panel5.Controls.Add(this.tl_gudang);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(273, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 110);
            this.panel5.TabIndex = 2;
            // 
            // tl_gudang
            // 
            this.tl_gudang.AutoSize = true;
            this.tl_gudang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.tl_gudang.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl_gudang.ForeColor = System.Drawing.Color.White;
            this.tl_gudang.Location = new System.Drawing.Point(75, 46);
            this.tl_gudang.Name = "tl_gudang";
            this.tl_gudang.Size = new System.Drawing.Size(55, 18);
            this.tl_gudang.TabIndex = 2;
            this.tl_gudang.Text = "label14";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Barang Gudang (Stok)";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.panel8.Controls.Add(this.rusak);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(547, 421);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 105);
            this.panel8.TabIndex = 2;
            // 
            // rusak
            // 
            this.rusak.AutoSize = true;
            this.rusak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.rusak.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rusak.ForeColor = System.Drawing.Color.White;
            this.rusak.Location = new System.Drawing.Point(67, 48);
            this.rusak.Name = "rusak";
            this.rusak.Size = new System.Drawing.Size(53, 18);
            this.rusak.TabIndex = 3;
            this.rusak.Text = "label15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Barang Rusak";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.panel9.Controls.Add(this.aktivitas);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(518, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(230, 110);
            this.panel9.TabIndex = 2;
            // 
            // aktivitas
            // 
            this.aktivitas.AutoSize = true;
            this.aktivitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.aktivitas.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktivitas.ForeColor = System.Drawing.Color.White;
            this.aktivitas.Location = new System.Drawing.Point(83, 49);
            this.aktivitas.Name = "aktivitas";
            this.aktivitas.Size = new System.Drawing.Size(54, 18);
            this.aktivitas.TabIndex = 4;
            this.aktivitas.Text = "label16";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(2, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total Aktivitas";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.panel10.Controls.Add(this.masuk);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Location = new System.Drawing.Point(547, 181);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 105);
            this.panel10.TabIndex = 3;
            // 
            // masuk
            // 
            this.masuk.AutoSize = true;
            this.masuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.masuk.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuk.ForeColor = System.Drawing.Color.White;
            this.masuk.Location = new System.Drawing.Point(69, 48);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(54, 18);
            this.masuk.TabIndex = 5;
            this.masuk.Text = "label17";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.label12.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Barang Masuk";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 350);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Activity";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.date,
            this.activity});
            this.dataGridView2.Location = new System.Drawing.Point(7, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(490, 281);
            this.dataGridView2.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "nama_user";
            this.name.HeaderText = "Nama Pengguna";
            this.name.Name = "name";
            // 
            // date
            // 
            this.date.DataPropertyName = "activity";
            this.date.HeaderText = "Aktifitas";
            this.date.Name = "date";
            // 
            // activity
            // 
            this.activity.DataPropertyName = "tanggal";
            this.activity.HeaderText = "Tanggal";
            this.activity.Name = "activity";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.panel11.Controls.Add(this.keluar);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Location = new System.Drawing.Point(547, 301);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 105);
            this.panel11.TabIndex = 6;
            // 
            // keluar
            // 
            this.keluar.AutoSize = true;
            this.keluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.keluar.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.ForeColor = System.Drawing.Color.White;
            this.keluar.Location = new System.Drawing.Point(70, 52);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(54, 18);
            this.keluar.TabIndex = 5;
            this.keluar.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(186)))), ((int)(((byte)(153)))));
            this.label19.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(4, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 18);
            this.label19.TabIndex = 4;
            this.label19.Text = "Barang Keluar";
            // 
            // Dashboard
            // 
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(766, 546);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label jml_pegawai;
        private System.Windows.Forms.Label tl_gudang;
        private System.Windows.Forms.Label rusak;
        private System.Windows.Forms.Label aktivitas;
        private System.Windows.Forms.Label masuk;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label keluar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity;
    }
}
