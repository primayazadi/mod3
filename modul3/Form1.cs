using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3
{
    public partial class Form1 : Form
    {
        private object label1;

        public Form1()
        {
            InitializeComponent();
        }

        int angka1 = 0;
        int angka2 = 0;
        int hasil;


        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text += "5";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(label2.Text);
            label2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka2= int.Parse(label2.Text);
            hasil = angka2 + angka1;
            label2.Text = hasil.ToString();
        }
    }
}
