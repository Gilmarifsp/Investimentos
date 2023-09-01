using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investimentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(textBox1.Text);
            float number2 = float.Parse(textBox2.Text);

            float sum = number1 + number2;
            string text = "Somar" + number1 + "com" + number2 + "é igaul a " + sum;

            MessageBox.Show(text, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(textBox1.Text);
            float number2 = float.Parse(textBox2.Text);

            float sub = number1 - number2;
            string text = "Subtrair" + number1 + "com" + number2 + "é igaul a " + sub;

            MessageBox.Show(text, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(textBox1.Text);
            float number2 = float.Parse(textBox2.Text);

            float mult = number1 * number2;
            string text = "multiplicar" + number1 + "com" + number2 + "é igaul a " + mult;

            MessageBox.Show(text, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(textBox1.Text);
            float number2 = float.Parse(textBox2.Text);

            float div = number1 / number2;
            string text = "dividir" + number1 + "com" + number2 + "é igaul a " + div;

            MessageBox.Show(text, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
