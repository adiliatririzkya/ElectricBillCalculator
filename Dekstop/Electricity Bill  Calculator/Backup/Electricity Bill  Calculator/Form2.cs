using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Electricity_Bill__Calculator
{
    public partial class Form2 : Form
    {
        EBC.Service myService;
        double Hasil;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            myService = new EBC.Service();
        }

        private void btnKembaliMenit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnHitungMenit_Click(object sender, EventArgs e)
        {
            Hasil = myService.Pemakaian_PerMenit(double.Parse(watt.Text), int.Parse(jumlah_menit.Text), double.Parse(tarif_perkwh.Text));
            result.Text = Hasil.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls) //Untuk setiap Control di Aplikasi ini
            {
            if (ctl is TextBox) //Jika control adalah textbox maka
            {
            ctl.Text = ""; //Kosongkan Isinya
            }
            }
        }
    }
}
