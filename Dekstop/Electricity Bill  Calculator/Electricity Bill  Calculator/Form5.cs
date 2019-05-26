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
    public partial class Form5 : Form
    {
        EBC.Service myService;
        double Hasil;

        public Form5()
        {
            InitializeComponent();
        }

        private void btnKembaliBulan_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            myService = new EBC.Service();
        }

        private void BtnHitungBulan_Click(object sender, EventArgs e)
        {
            Hasil = myService.Pemakaian_PerBulan(double.Parse(watt.Text), int.Parse(jumlah_jam.Text), int.Parse(jumlah_menit.Text), double.Parse(tarif_perkwh.Text), int.Parse(hari.Text));
            result.Text = Hasil.ToString();
        }
    }
}
