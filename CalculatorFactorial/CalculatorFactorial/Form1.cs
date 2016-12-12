using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBoxInsert.Text += "0";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxInsert.Text = this.textBoxInsert.Text.Remove(this.textBoxInsert.Text.Length - 1);
            }
            catch
            {
                //if you didn't have any insert
            }
        }

        private void calc_fact_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxResult.Text = "" + do_calcFact(int.Parse(textBoxInsert.Text));
            }
            catch
            {
            }
        }
        public static double do_calcFact(int numberInt)
        {
            if (numberInt == 0)
            {
                return 1;
            }
            return numberInt * do_calcFact(numberInt - 1);
        }
    }
}
