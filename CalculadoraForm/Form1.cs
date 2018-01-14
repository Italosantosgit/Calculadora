using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        double resulato = 0;
        char operacao;

        Calculadora cal = new Calculadora();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "0";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            resulato = 0;
            textBox1.Text = string.Empty;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Escolha um número", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cal.OperacaoEscolhida(Operacao.Soma);
                cal.valor1 = Double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Empty;
            }
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Escolha um número", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cal.OperacaoEscolhida(Operacao.Subtracao);
                cal.valor1 = Double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Empty;
            }
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Escolha um número", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cal.OperacaoEscolhida(Operacao.Multiplcacao);
                cal.valor1 = Double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Empty;               
            }
            
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Escolha um número", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cal.OperacaoEscolhida(Operacao.Divisao);
                cal.valor1 = Double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Empty;
            }
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Não a Operação", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cal.valor2 = Double.Parse(this.textBox1.Text);
                this.textBox1.Text = cal.Resultado().ToString();
            }
            /*if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                double valor = Double.Parse(this.textBox1.Text);
                
                switch(operacao)
                {
                    case '+':
                        resulato += valor;
                        break;
                    case '-':
                        resulato -= valor;
                        break;
                    case '*':
                        resulato *= valor;
                        break;
                    case '/':
                        resulato /= valor;
                        break;
                }
                this.textBox1.Text = resulato.ToString();
            }
             */
        }
    }
}
