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
    public partial class Perhitungan : Form
    { 

        public delegate void CreateKalkulator(Kalkulator klk);
        public event CreateKalkulator OnKalkulator;
        private Kalkulator klk;

        public Perhitungan()
        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            klk = new Kalkulator();
            klk.nama = this.Operasi.Text.ToLower();
            klk.operasi = string.Empty;
            klk.hasils = 0;
            klk.a = Double.Parse(this.NilaiA.Text);
            klk.b = Double.Parse(this.NilaiB.Text);


            if (this.Operasi.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan Pilih Dulu Operasinya!!!");
            }
            else if (this.Operasi.SelectedIndex == 0)
            {
                klk.hasils = klk.a + klk.b;
                klk.operasi = "+";

            }
            else if (this.Operasi.SelectedIndex == 1)
            {
                klk.hasils = klk.a - klk.b;
                klk.operasi = "-";
            }
            else if (this.Operasi.SelectedIndex == 2)
            {
                klk.hasils = klk.a * klk.b;
                klk.operasi = "*";
            }
            else if (this.Operasi.SelectedIndex == 3)
            {
                klk.hasils = klk.a / klk.b;
                klk.operasi = "/";
            }

            this.OnKalkulator(klk);
        }
    }
}
