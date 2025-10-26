using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        string Display, Display2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "1";
            Display = txtDisplay.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "2";
            Display = txtDisplay.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "3";
            Display = txtDisplay.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "4";
            Display = txtDisplay.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "5";
            Display = txtDisplay.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "6";
            Display = txtDisplay.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "7";
            Display = txtDisplay.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "8";
            Display = txtDisplay.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "9";
            Display = txtDisplay.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + "0";
            Display = txtDisplay.Text;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtDisplayFront.Text = Display2+Display+"+";
            Display2 = txtDisplayFront.Text;
            txtDisplay.Text = "";
            Display = txtDisplay.Text;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtDisplayFront.Text = Display2 + Display + "-";
            Display2 = txtDisplayFront.Text;
            txtDisplay.Text = "";
            Display = txtDisplay.Text;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtDisplayFront.Text = Display2 + Display + "*";
            Display2 = txtDisplayFront.Text;
            txtDisplay.Text = "";
            Display = txtDisplay.Text;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtDisplayFront.Text = Display2 + Display + "/";
            Display2 = txtDisplayFront.Text;
            txtDisplay.Text = "";
            Display = txtDisplay.Text;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Display + ".";
            Display = txtDisplay.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
        }
    }
}
