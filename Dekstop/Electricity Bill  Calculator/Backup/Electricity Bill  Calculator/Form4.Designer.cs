namespace Electricity_Bill__Calculator
{
    partial class Form4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.watt = new System.Windows.Forms.TextBox();
            this.jumlah_jam = new System.Windows.Forms.TextBox();
            this.jumlah_menit = new System.Windows.Forms.TextBox();
            this.tarif_perkwh = new System.Windows.Forms.TextBox();
            this.BtnHitungHari = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.btnKembaliHari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menghitung Biaya Listrik Perangkat Elektronik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(164, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pemakaian Per Hari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Watt                 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(52, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jumlah Jam    : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(51, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jumlah Menit  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(50, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tarif/KWH Rp  :";
            // 
            // watt
            // 
            this.watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.watt.Location = new System.Drawing.Point(190, 97);
            this.watt.Name = "watt";
            this.watt.Size = new System.Drawing.Size(139, 29);
            this.watt.TabIndex = 11;
            // 
            // jumlah_jam
            // 
            this.jumlah_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.jumlah_jam.Location = new System.Drawing.Point(190, 138);
            this.jumlah_jam.Name = "jumlah_jam";
            this.jumlah_jam.Size = new System.Drawing.Size(139, 29);
            this.jumlah_jam.TabIndex = 12;
            // 
            // jumlah_menit
            // 
            this.jumlah_menit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.jumlah_menit.Location = new System.Drawing.Point(190, 182);
            this.jumlah_menit.Name = "jumlah_menit";
            this.jumlah_menit.Size = new System.Drawing.Size(139, 29);
            this.jumlah_menit.TabIndex = 13;
            // 
            // tarif_perkwh
            // 
            this.tarif_perkwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tarif_perkwh.Location = new System.Drawing.Point(190, 221);
            this.tarif_perkwh.Name = "tarif_perkwh";
            this.tarif_perkwh.Size = new System.Drawing.Size(139, 29);
            this.tarif_perkwh.TabIndex = 14;
            // 
            // BtnHitungHari
            // 
            this.BtnHitungHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnHitungHari.Location = new System.Drawing.Point(358, 219);
            this.BtnHitungHari.Name = "BtnHitungHari";
            this.BtnHitungHari.Size = new System.Drawing.Size(92, 35);
            this.BtnHitungHari.TabIndex = 15;
            this.BtnHitungHari.Text = "Hitung";
            this.BtnHitungHari.UseVisualStyleBackColor = true;
            this.BtnHitungHari.Click += new System.EventHandler(this.BtnHitungHari_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(27, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Biaya Pemakaian Per Hari Rp : ";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.result.Location = new System.Drawing.Point(294, 268);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(187, 29);
            this.result.TabIndex = 17;
            // 
            // btnKembaliHari
            // 
            this.btnKembaliHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnKembaliHari.Location = new System.Drawing.Point(358, 310);
            this.btnKembaliHari.Name = "btnKembaliHari";
            this.btnKembaliHari.Size = new System.Drawing.Size(92, 38);
            this.btnKembaliHari.TabIndex = 18;
            this.btnKembaliHari.Text = "Kembali";
            this.btnKembaliHari.UseVisualStyleBackColor = true;
            this.btnKembaliHari.Click += new System.EventHandler(this.btnKembaliHari_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 367);
            this.Controls.Add(this.btnKembaliHari);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnHitungHari);
            this.Controls.Add(this.tarif_perkwh);
            this.Controls.Add(this.jumlah_menit);
            this.Controls.Add(this.jumlah_jam);
            this.Controls.Add(this.watt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox watt;
        private System.Windows.Forms.TextBox jumlah_jam;
        private System.Windows.Forms.TextBox jumlah_menit;
        private System.Windows.Forms.TextBox tarif_perkwh;
        private System.Windows.Forms.Button BtnHitungHari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnKembaliHari;
    }
}