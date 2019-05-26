namespace Electricity_Bill__Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPindah1 = new System.Windows.Forms.Button();
            this.btnPindah2 = new System.Windows.Forms.Button();
            this.btnPindah3 = new System.Windows.Forms.Button();
            this.btnPindah4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(81, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENGHITUNG BIAYA LISTRIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "PERANGKAT ELEKTRONIK RUMAH TANGGA";
            // 
            // btnPindah1
            // 
            this.btnPindah1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPindah1.Location = new System.Drawing.Point(149, 100);
            this.btnPindah1.Name = "btnPindah1";
            this.btnPindah1.Size = new System.Drawing.Size(217, 48);
            this.btnPindah1.TabIndex = 2;
            this.btnPindah1.Text = "Pemakaian Per Menit";
            this.btnPindah1.UseVisualStyleBackColor = true;
            this.btnPindah1.Click += new System.EventHandler(this.btnPindah1_Click_1);
            // 
            // btnPindah2
            // 
            this.btnPindah2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPindah2.Location = new System.Drawing.Point(149, 157);
            this.btnPindah2.Name = "btnPindah2";
            this.btnPindah2.Size = new System.Drawing.Size(217, 48);
            this.btnPindah2.TabIndex = 3;
            this.btnPindah2.Text = "Pemakaian Per Jam";
            this.btnPindah2.UseVisualStyleBackColor = true;
            this.btnPindah2.Click += new System.EventHandler(this.btnPindah2_Click);
            // 
            // btnPindah3
            // 
            this.btnPindah3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPindah3.Location = new System.Drawing.Point(149, 215);
            this.btnPindah3.Name = "btnPindah3";
            this.btnPindah3.Size = new System.Drawing.Size(217, 48);
            this.btnPindah3.TabIndex = 4;
            this.btnPindah3.Text = "Pemakaian Per Hari ";
            this.btnPindah3.UseVisualStyleBackColor = true;
            this.btnPindah3.Click += new System.EventHandler(this.btnPindah3_Click);
            // 
            // btnPindah4
            // 
            this.btnPindah4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPindah4.Location = new System.Drawing.Point(149, 273);
            this.btnPindah4.Name = "btnPindah4";
            this.btnPindah4.Size = new System.Drawing.Size(217, 48);
            this.btnPindah4.TabIndex = 5;
            this.btnPindah4.Text = "Pemakaian Per Bulan";
            this.btnPindah4.UseVisualStyleBackColor = true;
            this.btnPindah4.Click += new System.EventHandler(this.btnPindah4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 368);
            this.Controls.Add(this.btnPindah4);
            this.Controls.Add(this.btnPindah3);
            this.Controls.Add(this.btnPindah2);
            this.Controls.Add(this.btnPindah1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPindah1;
        private System.Windows.Forms.Button btnPindah2;
        private System.Windows.Forms.Button btnPindah3;
        private System.Windows.Forms.Button btnPindah4;
    }
}

