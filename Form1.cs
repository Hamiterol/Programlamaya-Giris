using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160111010_Emre_Atli
{
    public partial class Form1 : Form
    {
        bool oprdurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void O(object sender, EventArgs e)
        {
            
            if (txtSonuc.Text=="0" || oprdurum )
            {

                txtSonuc.Clear();
            }
            oprdurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void OprHesap(object sender, EventArgs e)
        {
            oprdurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            label1.Text = label1.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;

        }

        private void button14_Click(object sender, EventArgs e)
        {

            txtSonuc.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;
            oprdurum = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            oprdurum = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if (oprdurum)
            {
                txtSonuc.Text = "0";
            }

            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            oprdurum = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSonuc.Text);
            int karesi = sayi * sayi;
            txtSonuc.Text = Convert.ToString(karesi);
        }

        private void txtSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button22_Click(object sender, EventArgs e)
        {
           int fakt = 1;
            int sayi = Convert.ToInt32(txtSonuc.Text);
            for (int i = 1; i <=sayi; i++)
            {
                fakt = fakt * i;
            }
            txtSonuc.Text = Convert.ToString(fakt);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            double karekok = Math.Sqrt( sayi);
            txtSonuc.Text = Convert.ToString(karekok);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text=="-")
            {
                txtSonuc.Text = "+";

            }
            else
            {
                txtSonuc.Text = "-";
            }
        }

        private void btngerisalma_Click(object sender, EventArgs e)
        {
             
            if (txtSonuc.Text.Trim().Length != 0)
            {
                string geriAlinmisText;
                geriAlinmisText = txtSonuc.Text.Substring(0, txtSonuc.Text.Length - 1);
                txtSonuc.Text = geriAlinmisText;
            }
            txtSonuc.Focus();
            txtSonuc.Select(txtSonuc.Text.Length, 0);
        }
    }
}
