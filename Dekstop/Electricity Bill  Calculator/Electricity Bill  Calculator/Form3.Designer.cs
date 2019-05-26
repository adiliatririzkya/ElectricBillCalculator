namespace Electricity_Bill__Calculator
{
    partial class Form3
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
            this.btnKembaliJam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.watt = new System.Windows.Forms.TextBox();
            this.jumlah_jam = new System.Windows.Forms.TextBox();
            this.tarif_perkwh = new System.Windows.Forms.TextBox();
            this.BtnHitungJam = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKembaliJam
            // 
            this.btnKembaliJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnKembaliJam.Location = new System.Drawing.Point(348, 268);
            this.btnKembaliJam.Name = "btnKembaliJam";
            this.btnKembaliJam.Size = new System.Drawing.Size(96, 36);
            this.btnKembaliJam.TabIndex = 0;
            this.btnKembaliJam.Text = "Kembali";
            this.btnKembaliJam.UseVisualStyleBackColor = true;
            this.btnKembaliJam.Click += new System.EventHandler(this.btnKembaliJam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menghitung Biaya Listrik Perangkat Elektronik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(171, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pemakaian Per Jam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(62, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Watt               :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(58, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jumlah Jam   : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(56, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tarif/KWH Rp :";
            // 
            // watt
            // 
            this.watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.watt.Location = new System.Drawing.Point(193, 97);
            this.watt.Name = "watt";
            this.watt.Size = new System.Drawing.Size(126, 29);
            this.watt.TabIndex = 9;
            // 
            // jumlah_jam
            // 
            this.jumlah_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.jumlah_jam.Location = new System.Drawing.Point(193, 138);
            this.jumlah_jam.Name = "jumlah_jam";
            this.jumlah_jam.Size = new System.Drawing.Size(126, 29);
            this.jumlah_jam.TabIndex = 10;
            // 
            // tarif_perkwh
            // 
            this.tarif_perkwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tarif_perkwh.Location = new System.Drawing.Point(193, 175);
            this.tarif_perkwh.Name = "tarif_perkwh";
            this.tarif_perkwh.Size = new System.Drawing.Size(126, 29);
            this.tarif_perkwh.TabIndex = 11;
            // 
            // BtnHitungJam
            // 
            this.BtnHitungJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnHitungJam.Location = new System.Drawing.Point(348, 172);
            this.BtnHitungJam.Name = "BtnHitungJam";
            this.BtnHitungJam.Size = new System.Drawing.Size(96, 36);
            this.BtnHitungJam.TabIndex = 12;
            this.BtnHitungJam.Text = "Hitung";
            this.BtnHitungJam.UseVisualStyleBackColor = true;
            this.BtnHitungJam.Click += new System.EventHandler(this.BtnHitungJam_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(33, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Biaya Pemakaian Per Jam Rp : ";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.result.Location = new System.Drawing.Point(304, 221);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(173, 29);
            this.result.TabIndex = 14;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 355);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnHitungJam);
            this.Controls.Add(this.tarif_perkwh);
            this.Controls.Add(this.jumlah_jam);
            this.Controls.Add(this.watt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembaliJam);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembaliJam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox watt;
        private System.Windows.Forms.TextBox jumlah_jam;
        private System.Windows.Forms.TextBox tarif_perkwh;
        private System.Windows.Forms.Button BtnHitungJam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox result;
    }
}