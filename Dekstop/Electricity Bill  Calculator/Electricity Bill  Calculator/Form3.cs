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
    public partial class Form3 : Form
    {
        EBC.Service myService;
        double Hasil;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnKembaliJam_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myService = new EBC.Service();
        }

        private void BtnHitungJam_Click(object sender, EventArgs e)
        {
            Hasil = myService.Pemakaian_PerJam(double.Parse(watt.Text), int.Parse(jumlah_jam.Text), double.Parse(tarif_perkwh.Text));
            result.Text = Hasil.ToString();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
