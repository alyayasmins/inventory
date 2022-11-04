namespace InventoryApp
{
    partial class FormAdmin
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel14 = new System.Windows.Forms.Panel();
            this.dataLaporan1 = new InventoryApp.Resources.DataLaporan();
            this.profilAdmin1 = new InventoryApp.Resources.ProfilAdmin();
            this.dataBarangRusak1 = new InventoryApp.Resources.DataBarangRusak();
            this.dataMasuk1 = new InventoryApp.Resources.DataMasuk();
            this.dataKeluar1 = new InventoryApp.Resources.DataKeluar();
            this.dataBarang1 = new InventoryApp.Resources.DataBarang();
            this.dashboard1 = new InventoryApp.Resources.Dashboard();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(174, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            this.panel5.TabIndex = 3;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(131)))), ((int)(((byte)(96)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 546);
            this.sidebar.MinimumSize = new System.Drawing.Size(80, 546);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 546);
            this.sidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 77);
            this.panel1.TabIndex = 0;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.Control;
            this.user.Location = new System.Drawing.Point(18, 53);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(34, 15);
            this.user.TabIndex = 18;
            this.user.Text = "User";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user.Click += new System.EventHandler(this.user_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_1rsz_1rsz_1menu;
            this.menuButton.Location = new System.Drawing.Point(18, 8);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(42, 38);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 50);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::InventoryApp.Properties.Resources.rsz_rsz_home;
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(191, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "       Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 50);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_1rsz_box;
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(191, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "       Data Barang";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 50);
            this.panel4.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_upload;
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(191, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "      Barang Keluar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(3, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 50);
            this.panel6.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_download;
            this.button4.Location = new System.Drawing.Point(3, 6);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(191, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "      Barang Masuk";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Location = new System.Drawing.Point(3, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 50);
            this.panel7.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_1rsz_vector;
            this.button5.Location = new System.Drawing.Point(3, 6);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(191, 41);
            this.button5.TabIndex = 14;
            this.button5.Text = "        Barang Rusak";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.button6);
            this.panel8.Location = new System.Drawing.Point(3, 366);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 50);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 50);
            this.panel9.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_printer;
            this.button6.Location = new System.Drawing.Point(3, 6);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(191, 41);
            this.button6.TabIndex = 15;
            this.button6.Text = "       Laporan";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel15);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.button7);
            this.panel10.Location = new System.Drawing.Point(3, 422);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(197, 50);
            this.panel10.TabIndex = 7;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(18, 50);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 30);
            this.panel15.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(0, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(197, 50);
            this.panel11.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Image = global::InventoryApp.Properties.Resources.rsz_1rsz_user;
            this.button7.Location = new System.Drawing.Point(3, 6);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(191, 41);
            this.button7.TabIndex = 16;
            this.button7.Text = "       Profil";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.button8);
            this.panel12.Location = new System.Drawing.Point(3, 478);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(197, 50);
            this.panel12.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(0, 50);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(197, 50);
            this.panel13.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Image = global::InventoryApp.Properties.Resources.rsz_logout;
            this.button8.Location = new System.Drawing.Point(3, 6);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(191, 41);
            this.button8.TabIndex = 17;
            this.button8.Text = "       Keluar";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dataLaporan1);
            this.panel14.Controls.Add(this.profilAdmin1);
            this.panel14.Controls.Add(this.dataBarangRusak1);
            this.panel14.Controls.Add(this.dataMasuk1);
            this.panel14.Controls.Add(this.dataKeluar1);
            this.panel14.Controls.Add(this.dataBarang1);
            this.panel14.Controls.Add(this.dashboard1);
            this.panel14.Location = new System.Drawing.Point(198, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(766, 546);
            this.panel14.TabIndex = 5;
            // 
            // dataLaporan1
            // 
            this.dataLaporan1.Location = new System.Drawing.Point(2, 0);
            this.dataLaporan1.Name = "dataLaporan1";
            this.dataLaporan1.Size = new System.Drawing.Size(766, 546);
            this.dataLaporan1.TabIndex = 6;
            this.dataLaporan1.Load += new System.EventHandler(this.dataLaporan1_Load);
            // 
            // profilAdmin1
            // 
            this.profilAdmin1.Location = new System.Drawing.Point(0, 0);
            this.profilAdmin1.Name = "profilAdmin1";
            this.profilAdmin1.Size = new System.Drawing.Size(766, 546);
            this.profilAdmin1.TabIndex = 5;
            // 
            // dataBarangRusak1
            // 
            this.dataBarangRusak1.Location = new System.Drawing.Point(-1, 0);
            this.dataBarangRusak1.Name = "dataBarangRusak1";
            this.dataBarangRusak1.Size = new System.Drawing.Size(766, 546);
            this.dataBarangRusak1.TabIndex = 4;
            // 
            // dataMasuk1
            // 
            this.dataMasuk1.Location = new System.Drawing.Point(-1, 0);
            this.dataMasuk1.Name = "dataMasuk1";
            this.dataMasuk1.Size = new System.Drawing.Size(766, 546);
            this.dataMasuk1.TabIndex = 3;
            // 
            // dataKeluar1
            // 
            this.dataKeluar1.Location = new System.Drawing.Point(0, 0);
            this.dataKeluar1.Name = "dataKeluar1";
            this.dataKeluar1.Size = new System.Drawing.Size(766, 546);
            this.dataKeluar1.TabIndex = 2;
            // 
            // dataBarang1
            // 
            this.dataBarang1.Location = new System.Drawing.Point(0, 0);
            this.dataBarang1.Name = "dataBarang1";
            this.dataBarang1.Size = new System.Drawing.Size(766, 546);
            this.dataBarang1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(-1, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(766, 546);
            this.dashboard1.TabIndex = 0;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 546);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel14;
        private Resources.Dashboard dashboard1;
        private Resources.DataLaporan dataLaporan1;
        private Resources.ProfilAdmin profilAdmin1;
        private Resources.DataBarangRusak dataBarangRusak1;
        private Resources.DataMasuk dataMasuk1;
        private Resources.DataKeluar dataKeluar1;
        private Resources.DataBarang dataBarang1;
        private System.Windows.Forms.Panel panel15;
    }
}