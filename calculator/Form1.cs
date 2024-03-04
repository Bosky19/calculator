using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{

    public partial class Form1 : Form
    {
        private double prev=0;
        private int op = 0;
        bool cleared = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_afterop()
        {
            if(op!=0 && cleared == false)
            {
                textBox1.Text = "";
                cleared = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double aux=0;
            switch (op)
            {
                case 1:
                    aux = prev + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(aux);
                    break;
                case 2:
                    aux = prev - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(aux);
                    break;
                case 3:
                    aux = prev * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(aux);
                    break;
                case 4:
                    aux = prev / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(aux);
                    break;
                default:
                    break;
            }
            op = 0;
        }

        private void button4_Click(object sender, EventArgs e) // minus
        {
            prev = Convert.ToDouble(textBox1.Text);
            op = 2;
        }

        private void button6_Click(object sender, EventArgs e) // plus
        {
            prev = Convert.ToDouble(textBox1.Text);
            op = 1;
        }

        private void button5_Click(object sender, EventArgs e) // impartire
        {
            prev = Convert.ToDouble(textBox1.Text);
            op = 4;
        }

        private void button1_Click(object sender, EventArgs e) // inmultire
        {
            prev = Convert.ToDouble(textBox1.Text);
            op = 3;
        }

        private void button17_Click(object sender, EventArgs e) // patrat
        {
            prev = Convert.ToDouble(textBox1.Text);
            double aux = prev * prev;
            textBox1.Text = Convert.ToString(aux);
        }

        private void button18_Click(object sender, EventArgs e) //radical
        {
            prev = Convert.ToDouble(textBox1.Text);
            double aux = Math.Sqrt(prev);
            textBox1.Text = Convert.ToString(aux);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clear_afterop();
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "."))
            //{
            //    if (textBox1.Text.Contains("."))
            //    {

            //        //MessageBox.Show("mai e un punct");
            //        //textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            //    }
            //    if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            //    {
            //        MessageBox.Show("Doar numere");
            //        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            //    }
            //}
 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;

            if ("\b".Contains(e.KeyChar))
                   return;
            if (".".Contains(e.KeyChar))
                if (!textBox1.Text.Contains("."))
                    return;
            e.Handled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (textBox1.Text == "")
            {
                prev = 0;
                op = 0;
                cleared = false;
            }
        }
    }
}
