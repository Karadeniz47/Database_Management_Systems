namespace WindowsFormsApp1
{
    partial class Kullanici_Ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Ad = new System.Windows.Forms.TextBox();
            this.textBox2_Soyad = new System.Windows.Forms.TextBox();
            this.textBox3_Sifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre";
            // 
            // textBox1_Ad
            // 
            this.textBox1_Ad.Location = new System.Drawing.Point(175, 52);
            this.textBox1_Ad.Name = "textBox1_Ad";
            this.textBox1_Ad.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Ad.TabIndex = 3;
            // 
            // textBox2_Soyad
            // 
            this.textBox2_Soyad.Location = new System.Drawing.Point(175, 117);
            this.textBox2_Soyad.Name = "textBox2_Soyad";
            this.textBox2_Soyad.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Soyad.TabIndex = 4;
            // 
            // textBox3_Sifre
            // 
            this.textBox3_Sifre.Location = new System.Drawing.Point(175, 177);
            this.textBox3_Sifre.Name = "textBox3_Sifre";
            this.textBox3_Sifre.Size = new System.Drawing.Size(100, 22);
            this.textBox3_Sifre.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kullanici_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3_Sifre);
            this.Controls.Add(this.textBox2_Soyad);
            this.Controls.Add(this.textBox1_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanici_Ekle";
            this.Text = "Kullanici_Ekle";
            this.Load += new System.EventHandler(this.Kullanici_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_Ad;
        private System.Windows.Forms.TextBox textBox2_Soyad;
        private System.Windows.Forms.TextBox textBox3_Sifre;
        private System.Windows.Forms.Button button1;
    }
}