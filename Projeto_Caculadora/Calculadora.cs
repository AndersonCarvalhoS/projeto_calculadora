using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Caculadora
{
    public partial class Calculadora : Form
    {
        double primeiro = 0;
        double segundo = 0;
        string operador = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        function.clSoma soma = new function.clSoma();
        function.clDividir divi = new function.clDividir();
        function.clMuti multi = new function.clMuti();
        function.clSub subt = new function.clSub();
        function.clPorce porc = new function.clPorce();
        function.clFatori fatori = new function.clFatori();
        function.clLog l = new function.clLog();
        function.clConseno con = new function.clConseno();
        function.clSeno sen = new function.clSeno();
        function.clTangete tan = new function.clTangete();

        private void B_1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void B_2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void B_3_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += "3";
        }

        private void B_4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void B_5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void B_6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void B_7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void B_8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void B_9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void B_0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void B_virgula_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ",";
        }

        private void B_adisao_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void B_subetracao_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void B_mutiplicacao_Click(object sender, EventArgs e)
        {
            operador = "x";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();

        }

        private void B_divisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void B_porcentagem_Click(object sender, EventArgs e)
        {
            operador = "%";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void B_log_Click(object sender, EventArgs e)
        {
            operador = "log";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();

        }

        private void B_in_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado = Math.Log(primeiro);
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("valor invalido!");
            }
        }

        private void B_inversao_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                if (primeiro == 0 || richTextBox1.Text == string.Empty)
                {
                    throw new InvalidCastException();
                }
                else
                {
                    double resultado;
                    resultado = 1 / primeiro;
                    richTextBox1.Text = resultado.ToString();
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("valor tem que ser diferente de 0");
            }
        }

        private void B_rqa_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = Math.Sqrt(primeiro);
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor valido!");
            }
        }

        private void B_quadrado_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = primeiro * primeiro;
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("informe um valor valido!");
            }
        }

        private void B_cubo_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = primeiro * primeiro * primeiro;
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("informe valor valido!");
            }
        }

        private void B_fatorial_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = fatori.fatorial(primeiro);
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("informe valore maior que '0' ");
            }

        }

        private void B_sen_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = sen.seno(primeiro);
                richTextBox1.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("valor ivalido!");
            }

        }

        private void B_cos_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = con.coseno(primeiro);
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("valor invalido!");
            }
        }

        private void B_tg_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Convert.ToDouble(richTextBox1.Text);
                double resultado;
                resultado = tan.tangente(primeiro);
                richTextBox1.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("valor invalido!");
            }
        }

        private void B_polinomio_Click(object sender, EventArgs e)
        {
            operador = "p(X)";
            primeiro = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void B_ce_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void B_resultado_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(richTextBox1.Text);

            double resultado = 0;

            switch (operador)
            {
                case "+":
                    try
                    {
                        resultado = soma.soma(primeiro, segundo);
                        richTextBox1.Text = resultado.ToString();
                        resultado = 0;
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("valor invalido!");
                        break;
                    }

                case "/":
                    try
                    {
                        resultado = divi.dividir(primeiro, segundo);
                        richTextBox1.Text = resultado.ToString();
                        resultado = 0;
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("valor invalido!");
                        break;
                    }

                case "x":
                    try
                    {
                        resultado = multi.mutiplicar(primeiro, segundo);
                        richTextBox1.Text = resultado.ToString();
                        resultado = 0; break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("valor invalido!");
                        break;
                    }
                case "-":
                    try
                    {
                        resultado = subt.subtrair(primeiro, segundo);
                        richTextBox1.Text = resultado.ToString();
                        resultado = 0;
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("valor invalido!");
                        break;
                    }

                case "%":
                    try
                    {
                        resultado = porc.porcentagem(segundo);
                        double resul = primeiro * resultado;
                        richTextBox1.Text = resultado.ToString("f2");
                        resultado = 0;
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("valor invalido!");
                        break;
                    }
                case "log":
                    try
                    {
                        resultado = l.log(segundo, primeiro);
                        richTextBox1.Text = resultado.ToString();
                        resultado = 0;
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("valor invalido!");
                        break;
                    }

            }

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
                int inicio = Convert.ToInt32(textBox6.Text);
                int fim = Convert.ToInt32(textBox8.Text);
                int passo = Convert.ToInt32(textBox7.Text);
                double y = 0;
                String arquivo = string.Empty;
                string escrever = string.Empty;

                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double d = Convert.ToDouble(textBox4.Text);
                double E = Convert.ToDouble(textBox5.Text);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    arquivo += saveFileDialog1.FileName;

                using(StreamWriter sw = new StreamWriter(@arquivo, true))
                {
                    for (int x = inicio; x < fim; x += passo)
                    {
                        y = a * Math.Pow(x,5) + b * Math.Pow(x,4) + c * Math.Pow(x,3) + d * Math.Pow(x,2) + E * x + x;

                        chart1.Series[0].Points.AddXY(x, y);
                        escrever = y.ToString();
                        sw.Write(escrever+"\n");
                    }
                }
                
        }
    }
}
