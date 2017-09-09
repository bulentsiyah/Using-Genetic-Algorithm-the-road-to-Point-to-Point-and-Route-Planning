namespace YolBulma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GrpBxKat1 = new System.Windows.Forms.GroupBox();
            this.KrokiKampus = new System.Windows.Forms.PictureBox();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResimCiz = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblb = new System.Windows.Forms.Label();
            this.lwb = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnGA = new System.Windows.Forms.Button();
            this.lw2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBirey = new System.Windows.Forms.TextBox();
            this.txtNesil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrpBxKat1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KrokiKampus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBxKat1
            // 
            this.GrpBxKat1.Controls.Add(this.KrokiKampus);
            this.GrpBxKat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpBxKat1.Location = new System.Drawing.Point(-2, 2);
            this.GrpBxKat1.Name = "GrpBxKat1";
            this.GrpBxKat1.Size = new System.Drawing.Size(660, 472);
            this.GrpBxKat1.TabIndex = 3;
            this.GrpBxKat1.TabStop = false;
            this.GrpBxKat1.Text = "Kampüs Alanı";
            // 
            // KrokiKampus
            // 
            this.KrokiKampus.BackColor = System.Drawing.Color.White;
            this.KrokiKampus.BackgroundImage = global::YolBulma.Properties.Resources.kroki1;
            this.KrokiKampus.Image = global::YolBulma.Properties.Resources.kroki1;
            this.KrokiKampus.Location = new System.Drawing.Point(6, 19);
            this.KrokiKampus.Name = "KrokiKampus";
            this.KrokiKampus.Size = new System.Drawing.Size(650, 450);
            this.KrokiKampus.TabIndex = 0;
            this.KrokiKampus.TabStop = false;
            // 
            // BtnBasla
            // 
            this.BtnBasla.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBasla.Location = new System.Drawing.Point(6, 76);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(216, 41);
            this.BtnBasla.TabIndex = 6;
            this.BtnBasla.Text = "Yolu Bul";
            this.BtnBasla.UseVisualStyleBackColor = false;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bulunduğun Yer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gidilecek Yer:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btnResimCiz);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.lblb);
            this.groupBox1.Controls.Add(this.lwb);
            this.groupBox1.Controls.Add(this.BtnBasla);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(664, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 417);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kampüste Yer Seç";
            // 
            // btnResimCiz
            // 
            this.btnResimCiz.BackColor = System.Drawing.Color.PowderBlue;
            this.btnResimCiz.Location = new System.Drawing.Point(6, 316);
            this.btnResimCiz.Name = "btnResimCiz";
            this.btnResimCiz.Size = new System.Drawing.Size(216, 37);
            this.btnResimCiz.TabIndex = 15;
            this.btnResimCiz.Text = "Seçili Mesafeyi Çiz";
            this.btnResimCiz.UseVisualStyleBackColor = false;
            this.btnResimCiz.Visible = false;
            this.btnResimCiz.Click += new System.EventHandler(this.btnResimCiz_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Nokta Seç:",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox4.Location = new System.Drawing.Point(98, 49);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(95, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.Color.PowderBlue;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblb.Location = new System.Drawing.Point(3, 132);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(161, 13);
            this.lblb.TabIndex = 13;
            this.lblb.Text = "Bulunan Tüm Güzergahlar :";
            this.lblb.Visible = false;
            // 
            // lwb
            // 
            this.lwb.BackColor = System.Drawing.Color.PowderBlue;
            this.lwb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lwb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwb.GridLines = true;
            this.lwb.Location = new System.Drawing.Point(9, 148);
            this.lwb.Name = "lwb";
            this.lwb.Size = new System.Drawing.Size(213, 162);
            this.lwb.TabIndex = 14;
            this.lwb.UseCompatibleStateImageBehavior = false;
            this.lwb.View = System.Windows.Forms.View.Details;
            this.lwb.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mesafe";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İzlenecek Rota";
            this.columnHeader2.Width = 154;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nokta Seç:",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox2.Location = new System.Drawing.Point(98, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // btnGA
            // 
            this.btnGA.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGA.Location = new System.Drawing.Point(664, 425);
            this.btnGA.Name = "btnGA";
            this.btnGA.Size = new System.Drawing.Size(231, 46);
            this.btnGA.TabIndex = 15;
            this.btnGA.Text = "Program Hakkında Bilgi ve Parametreler";
            this.btnGA.UseVisualStyleBackColor = false;
            this.btnGA.Click += new System.EventHandler(this.button1_Click);
            // 
            // lw2
            // 
            this.lw2.BackColor = System.Drawing.Color.PaleGreen;
            this.lw2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lw2.GridLines = true;
            this.lw2.Location = new System.Drawing.Point(3, 3);
            this.lw2.Name = "lw2";
            this.lw2.Size = new System.Drawing.Size(184, 455);
            this.lw2.TabIndex = 15;
            this.lw2.UseCompatibleStateImageBehavior = false;
            this.lw2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yer";
            this.columnHeader3.Width = 34;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bilgi";
            this.columnHeader4.Width = 147;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBirey);
            this.panel1.Controls.Add(this.txtNesil);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(4, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 139);
            this.panel1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(510, 117);
            this.label12.TabIndex = 14;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Program Hakkında Bilgi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(633, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Populasyon: Kromozomlardan (bireylerden) oluşan \r\n kümedir. ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(633, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kromozom (Birey): Alternatif aday çözümleri gösterirler.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(633, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parametreler Hakkında Bilgi:";
            // 
            // txtBirey
            // 
            this.txtBirey.Location = new System.Drawing.Point(757, 81);
            this.txtBirey.Name = "txtBirey";
            this.txtBirey.Size = new System.Drawing.Size(71, 21);
            this.txtBirey.TabIndex = 5;
            this.txtBirey.Text = "30";
            // 
            // txtNesil
            // 
            this.txtNesil.Location = new System.Drawing.Point(757, 57);
            this.txtNesil.Name = "txtNesil";
            this.txtNesil.Size = new System.Drawing.Size(71, 21);
            this.txtNesil.TabIndex = 4;
            this.txtNesil.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(633, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Populasyon Büyüklüğü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(633, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nesil Sayısı:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.lw2);
            this.panel2.Location = new System.Drawing.Point(910, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 464);
            this.panel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpBxKat1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Genetik Algoritma ile Noktadan Noktaya Yol ve Rota Planlama ( Yapay Zeka Projesi " +
    "| Bülent SİYAH | 2011)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBxKat1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KrokiKampus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox KrokiKampus;
        private System.Windows.Forms.GroupBox GrpBxKat1;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.ListView lwb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnGA;
        private System.Windows.Forms.ListView lw2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBirey;
        private System.Windows.Forms.TextBox txtNesil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnResimCiz;

    }
}

