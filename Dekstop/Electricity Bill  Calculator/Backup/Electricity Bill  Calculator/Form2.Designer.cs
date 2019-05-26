namespace Electricity_Bill__Calculator
{
    partial class Form2
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
            this.btnKembaliMenit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.watt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jumlah_menit = new System.Windows.Forms.TextBox();
            this.tarif_perkwh = new System.Windows.Forms.TextBox();
            this.btnHitungMenit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKembaliMenit
            // 
            this.btnKembaliMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnKembaliMenit.Location = new System.Drawing.Point(342, 267);
            this.btnKembaliMenit.Name = "btnKembaliMenit";
            this.btnKembaliMenit.Size = new System.Drawing.Size(110, 35);
            this.btnKembaliMenit.TabIndex = 1;
            this.btnKembaliMenit.Text = "Kembali";
            this.btnKembaliMenit.UseVisualStyleBackColor = true;
            this.btnKembaliMenit.Click += new System.EventHandler(this.btnKembaliMenit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menghitung Biaya Listrik Perangkat Elektronik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(165, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pemakaian Per Menit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(59, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Watt                :";
            // 
            // watt
            // 
            this.watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.watt.Location = new System.Drawing.Point(193, 97);
            this.watt.Name = "watt";
            this.watt.Size = new System.Drawing.Size(127, 29);
            this.watt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(59, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jumlah Menit : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(58, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tarif/KWH Rp :";
            // 
            // jumlah_menit
            // 
            this.jumlah_menit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.jumlah_menit.Location = new System.Drawing.Point(193, 139);
            this.jumlah_menit.Name = "jumlah_menit";
            this.jumlah_menit.Size = new System.Drawing.Size(127, 29);
            this.jumlah_menit.TabIndex = 8;
            // 
            // tarif_perkwh
            // 
            this.tarif_perkwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tarif_perkwh.Location = new System.Drawing.Point(193, 177);
            this.tarif_perkwh.Name = "tarif_perkwh";
            this.tarif_perkwh.Size = new System.Drawing.Size(127, 29);
            this.tarif_perkwh.TabIndex = 9;
            this.tarif_perkwh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnHitungMenit
            // 
            this.btnHitungMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHitungMenit.Location = new System.Drawing.Point(342, 175);
            this.btnHitungMenit.Name = "btnHitungMenit";
            this.btnHitungMenit.Size = new System.Drawing.Size(110, 35);
            this.btnHitungMenit.TabIndex = 10;
            this.btnHitungMenit.Text = "Hitung";
            this.btnHitungMenit.UseVisualStyleBackColor = true;
            this.btnHitungMenit.Click += new System.EventHandler(this.btnHitungMenit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(26, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Biaya Pemakaian Per Menit Rp : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.result.Location = new System.Drawing.Point(312, 222);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(166, 29);
            this.result.TabIndex = 12;
            this.result.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHapus.Location = new System.Drawing.Point(242, 267);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(94, 35);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 351);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHitungMenit);
            this.Controls.Add(this.tarif_perkwh);
            this.Controls.Add(this.jumlah_menit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.watt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembaliMenit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembaliMenit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox watt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jumlah_menit;
        private System.Windows.Forms.TextBox tarif_perkwh;
        private System.Windows.Forms.Button btnHitungMenit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnHapus;

    }
}