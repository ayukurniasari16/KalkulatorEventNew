using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalkulatorEventNew
{
    public partial class IndukPerhitungan : Form
    {
        public IndukPerhitungan()
        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            Perhitungan perhitungan = new Perhitungan();
            perhitungan.OnKalkulator += OnKalkulator;
            perhitungan.ShowDialog();
        }

        private void OnKalkulator(Kalkulator klk)
        {
            Hasil.Items.Add("Hasil " + klk.nama + " " + klk.a + " " + klk.operasi + " " + klk.b + " " + "=" + " " + klk.hasils);
        }
    }
}
