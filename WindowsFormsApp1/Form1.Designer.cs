namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_baslangic_noktasi = new System.Windows.Forms.TextBox();
            this.textBox_varis_noktasi = new System.Windows.Forms.TextBox();
            this.textBox_kalkis_yeri = new System.Windows.Forms.TextBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ara = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.sil_textbox = new System.Windows.Forms.TextBox();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.textBox_guncelle = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.silinen_kayitlar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1_kullanici = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_kullanici_sil = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(854, 73);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(72, 28);
            this.button_listele.TabIndex = 0;
            this.button_listele.Text = "listele";
            this.button_listele.UseVisualStyleBackColor = true;
            this.button_listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 272);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(141, 14);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 22);
            this.textBox_ad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "soyad";
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(141, 67);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(100, 22);
            this.textBox_soyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "baslangic_tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "bitis_tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "baslangic_noktasi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "varis_noktasi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "ulasim_araci";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "kalkis_tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "kalkis_yeri";
            // 
            // textBox_baslangic_noktasi
            // 
            this.textBox_baslangic_noktasi.Location = new System.Drawing.Point(403, 61);
            this.textBox_baslangic_noktasi.Name = "textBox_baslangic_noktasi";
            this.textBox_baslangic_noktasi.Size = new System.Drawing.Size(100, 22);
            this.textBox_baslangic_noktasi.TabIndex = 16;
            // 
            // textBox_varis_noktasi
            // 
            this.textBox_varis_noktasi.Location = new System.Drawing.Point(403, 118);
            this.textBox_varis_noktasi.Name = "textBox_varis_noktasi";
            this.textBox_varis_noktasi.Size = new System.Drawing.Size(100, 22);
            this.textBox_varis_noktasi.TabIndex = 17;
            // 
            // textBox_kalkis_yeri
            // 
            this.textBox_kalkis_yeri.Location = new System.Drawing.Point(632, 124);
            this.textBox_kalkis_yeri.Name = "textBox_kalkis_yeri";
            this.textBox_kalkis_yeri.Size = new System.Drawing.Size(100, 22);
            this.textBox_kalkis_yeri.TabIndex = 21;
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(15, 200);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(72, 22);
            this.button_sil.TabIndex = 22;
            this.button_sil.Text = "sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(257, 200);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(72, 23);
            this.button_ara.TabIndex = 23;
            this.button_ara.Text = "ara";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(854, 20);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(75, 23);
            this.button_ekle.TabIndex = 25;
            this.button_ekle.Text = "ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(494, 197);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(75, 27);
            this.button_guncelle.TabIndex = 26;
            this.button_guncelle.Text = "guncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(353, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(632, 68);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker3.TabIndex = 29;
            // 
            // sil_textbox
            // 
            this.sil_textbox.Location = new System.Drawing.Point(110, 200);
            this.sil_textbox.Name = "sil_textbox";
            this.sil_textbox.Size = new System.Drawing.Size(100, 22);
            this.sil_textbox.TabIndex = 30;
            this.sil_textbox.Enter += new System.EventHandler(this.sil_textbox_Enter);
            this.sil_textbox.Leave += new System.EventHandler(this.sil_textbox_Leave);
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(353, 201);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(100, 22);
            this.textBox_ara.TabIndex = 31;
            this.textBox_ara.Enter += new System.EventHandler(this.textBox_ara_Enter);
            this.textBox_ara.Leave += new System.EventHandler(this.textBox_ara_Leave);
            // 
            // textBox_guncelle
            // 
            this.textBox_guncelle.Location = new System.Drawing.Point(588, 200);
            this.textBox_guncelle.Name = "textBox_guncelle";
            this.textBox_guncelle.Size = new System.Drawing.Size(100, 22);
            this.textBox_guncelle.TabIndex = 32;
            this.textBox_guncelle.Enter += new System.EventHandler(this.textBox_guncelle_Enter);
            this.textBox_guncelle.Leave += new System.EventHandler(this.textBox_guncelle_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(632, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // silinen_kayitlar
            // 
            this.silinen_kayitlar.Location = new System.Drawing.Point(979, 14);
            this.silinen_kayitlar.Name = "silinen_kayitlar";
            this.silinen_kayitlar.Size = new System.Drawing.Size(125, 53);
            this.silinen_kayitlar.TabIndex = 34;
            this.silinen_kayitlar.Text = "silinen kayitlari goruntule";
            this.silinen_kayitlar.UseVisualStyleBackColor = true;
            this.silinen_kayitlar.Click += new System.EventHandler(this.silinen_kayitlar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(979, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 53);
            this.button2.TabIndex = 36;
            this.button2.Text = "guncellenen kayitlari goruntule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(979, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 50);
            this.button3.TabIndex = 37;
            this.button3.Text = "kullanicilari goruntule";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1_kullanici
            // 
            this.button1_kullanici.Location = new System.Drawing.Point(854, 119);
            this.button1_kullanici.Name = "button1_kullanici";
            this.button1_kullanici.Size = new System.Drawing.Size(75, 50);
            this.button1_kullanici.TabIndex = 38;
            this.button1_kullanici.Text = "kullanici ekle";
            this.button1_kullanici.UseVisualStyleBackColor = true;
            this.button1_kullanici.Click += new System.EventHandler(this.button1_kullanici_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "kullanici sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1_kullanici_sil
            // 
            this.textBox1_kullanici_sil.Location = new System.Drawing.Point(843, 198);
            this.textBox1_kullanici_sil.Name = "textBox1_kullanici_sil";
            this.textBox1_kullanici_sil.Size = new System.Drawing.Size(110, 22);
            this.textBox1_kullanici_sil.TabIndex = 40;
            this.textBox1_kullanici_sil.Enter += new System.EventHandler(this.textBox1_kullanici_sil_Enter);
            this.textBox1_kullanici_sil.Leave += new System.EventHandler(this.textBox1_kullanici_sil_Leave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 51);
            this.button4.TabIndex = 41;
            this.button4.Text = "gun sayisi hesapla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(217, 105);
            this.dataGridView2.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 189);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gun Sayisi Hesapla";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(284, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 183);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sehir Sayisi Hesapla";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 78);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(220, 99);
            this.dataGridView3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 51);
            this.button5.TabIndex = 0;
            this.button5.Text = "Sehir sayısı hesapla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(553, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 189);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanici Sayisi Hesapla";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 89);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(219, 94);
            this.dataGridView4.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 51);
            this.button6.TabIndex = 0;
            this.button6.Text = "Hesapla";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(917, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 189);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayitlarda Sehir Ara";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            this.textBox3.MouseEnter += new System.EventHandler(this.textBox3_MouseEnter);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 46);
            this.button7.TabIndex = 0;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1281, 704);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1_kullanici_sil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_kullanici);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.silinen_kayitlar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_guncelle);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.sil_textbox);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.textBox_kalkis_yeri);
            this.Controls.Add(this.textBox_varis_noktasi);
            this.Controls.Add(this.textBox_baslangic_noktasi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_listele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_baslangic_noktasi;
        private System.Windows.Forms.TextBox textBox_varis_noktasi;
        private System.Windows.Forms.TextBox textBox_kalkis_yeri;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox sil_textbox;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.TextBox textBox_guncelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button silinen_kayitlar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1_kullanici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_kullanici_sil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
    }
}

