using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFR
{
    public partial class Calculadora : Form
    {

        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreem.Text);
            tbxScreem.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "3";
        }

        private void btN1_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "0";
        }

        private void btN2_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "1";
        }

        private void btN3_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "2";
        }

        private void btN5_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "4";
        }

        private void btN6_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "5";
        }

        private void btN7_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "6";
        }

        private void btN8_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "7";
        }

        private void btN9_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "8";
        }

        private void btN10_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + ".";
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreem.Text);
            tbxScreem.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreem.Text);
            tbxScreem.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreem.Text);
            tbxScreem.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreem.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreem.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    tbxScreem.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    tbxScreem.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    tbxScreem.Text = Div.ToString();
                    break;
            }
        }
    }
}
