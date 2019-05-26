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
    public partial class Form4 : Form
    {
        EBC.Service myService;
        double Hasil;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            myService = new EBC.Service();
        }

        private void btnKembaliHari_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void BtnHitungHari_Click(object sender, EventArgs e)
        {
            Hasil = myService.Pemakaian_PerHari(double.Parse(watt.Text), int.Parse(jumlah_jam.Text), int.Parse(jumlah_menit.Text), double.Parse(tarif_perkwh.Text));
            result.Text = Hasil.ToString();
        }
    }
}
