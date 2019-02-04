using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCsharp
{
    public partial class Form1 : Form
    {
        double n1, n2, total;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtvalor01.Text);
            n2 = Convert.ToDouble(txtvalor02.Text);

            total = n1 - n2;

            txtotal.Text = total.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtvalor01.Text);
            n2 = Convert.ToDouble(txtvalor02.Text);

            total = n1 / n2;

            txtotal.Text = total.ToString();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtvalor01.Text);
            n2 = Convert.ToDouble(txtvalor02.Text);

            total = n1 * n2;

            txtotal.Text = total.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtvalor01.Clear();
            txtvalor02.Clear();
            txtotal.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtvalor01.Text);
            n2 = Convert.ToDouble(txtvalor02.Text);

            total = n1 + n2;

            txtotal.Text = total.ToString();
        }
    }
}
