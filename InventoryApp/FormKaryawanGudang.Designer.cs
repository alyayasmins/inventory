namespace InventoryApp
{
    partial class FormKaryawanGudang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.dataBarang1 = new InventoryApp.Resources.DataBarang();
            this.dataKeluar1 = new InventoryApp.Resources.DataKeluar();
            this.dataMasuk1 = new InventoryApp.Resources.DataMasuk();
            this.dataBarangRusak1 = new InventoryApp.Resources.DataBarangRusak();
            this.dataLaporan1 = new InventoryApp.Resources.DataLaporan();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(131)))), ((int)(((byte)(96)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 546);
            this.sidebar.MinimumSize = new System.Drawing.Size(80, 546);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 546);
            this.sidebar.TabIndex = 0;
            // 
            // dataBarang1
            // 
            this.dataBarang1.Location = new System.Drawing.Point(201, 0);
            this.dataBarang1.Name = "dataBarang1";
            this.dataBarang1.Size = new System.Drawing.Size(766, 546);
            this.dataBarang1.TabIndex = 1;
            // 
            // dataKeluar1
            // 
            this.dataKeluar1.Location = new System.Drawing.Point(201, 0);
            this.dataKeluar1.Name = "dataKeluar1";
            this.dataKeluar1.Size = new System.Drawing.Size(766, 546);
            this.dataKeluar1.TabIndex = 2;
            // 
            // dataMasuk1
            // 
            this.dataMasuk1.Location = new System.Drawing.Point(201, 0);
            this.dataMasuk1.Name = "dataMasuk1";
            this.dataMasuk1.Size = new System.Drawing.Size(766, 546);
            this.dataMasuk1.TabIndex = 3;
            // 
            // dataBarangRusak1
            // 
            this.dataBarangRusak1.Location = new System.Drawing.Point(201, 0);
            this.dataBarangRusak1.Name = "dataBarangRusak1";
            this.dataBarangRusak1.Size = new System.Drawing.Size(766, 546);
            this.dataBarangRusak1.TabIndex = 4;
            // 
            // dataLaporan1
            // 
            this.dataLaporan1.Location = new System.Drawing.Point(201, 0);
            this.dataLaporan1.Name = "dataLaporan1";
            this.dataLaporan1.Size = new System.Drawing.Size(766, 546);
            this.dataLaporan1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 77);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_1rsz_1rsz_1menu;
            this.menuButton.Location = new System.Drawing.Point(18, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(42, 38);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_2);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.Control;
            this.user.Location = new System.Drawing.Point(15, 59);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(34, 15);
            this.user.TabIndex = 27;
            this.user.Text = "User";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user.Click += new System.EventHandler(this.user_Click_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(3, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 50);
            this.panel7.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_printer;
            this.button1.Location = new System.Drawing.Point(4, 6);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(190, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "        Laporan";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 50);
            this.panel3.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_1rsz_box;
            this.button2.Location = new System.Drawing.Point(4, 6);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(187, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "        Data Barang";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 50);
            this.panel4.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_upload;
            this.button3.Location = new System.Drawing.Point(2, 6);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(187, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "       Barang Keluar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(3, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 50);
            this.panel5.TabIndex = 39;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_download;
            this.button4.Location = new System.Drawing.Point(2, 6);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(188, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "       Barang Masuk";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button9);
            this.panel6.Location = new System.Drawing.Point(3, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 50);
            this.panel6.TabIndex = 40;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_1rsz_vector;
            this.button9.Location = new System.Drawing.Point(3, 6);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(189, 41);
            this.button9.TabIndex = 29;
            this.button9.Text = "         Barang Rusak";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button7);
            this.panel8.Location = new System.Drawing.Point(3, 366);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 50);
            this.panel8.TabIndex = 41;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Image = global::InventoryApp.Properties.Resources.rsz_logout;
            this.button7.Location = new System.Drawing.Point(4, 7);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(188, 41);
            this.button7.TabIndex = 30;
            this.button7.Text = "        Keluar";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // FormKaryawanGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 546);
            this.Controls.Add(this.dataLaporan1);
            this.Controls.Add(this.dataBarangRusak1);
            this.Controls.Add(this.dataMasuk1);
            this.Controls.Add(this.dataKeluar1);
            this.Controls.Add(this.dataBarang1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKaryawanGudang";
            this.Text = "FormKaryawanGudang";
            this.Load += new System.EventHandler(this.FormKaryawanGudang_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Resources.DataBarang dataBarang1;
        private Resources.DataKeluar dataKeluar1;
        private Resources.DataMasuk dataMasuk1;
        private Resources.DataBarangRusak dataBarangRusak1;
        private Resources.DataLaporan dataLaporan1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button7;
    }
}