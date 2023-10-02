using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {
        double SalarioBruto, descontoINSS, descontoIRPF, SalarioFam, SalarioLiq;

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_Validated(object sender, EventArgs e)
        {

        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] Numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool temNumero = Numeros.Contains(e.KeyChar);

            if (temNumero)
            {
                MessageBox.Show("O nome não pode ter números!");
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void MskbxSalario_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(mskbxSalario, "");

            if(!double.TryParse(mskbxSalario.Text, out SalarioBruto) || (SalarioBruto <=0))
            {
                MessageBox.Show("Salário inválido!");
                errorProvider1.SetError(mskbxSalario, "Salário inválido");
            }
        }

        private void ButVerificar_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(mskbxSalario.Text, out SalarioBruto) && SalarioBruto > 0)
            {
                //INSS
                if (SalarioBruto <= 800.47)
                {
                    txtAliqINSS.Text = "7,65%";
                    descontoINSS = 0.0765 * SalarioBruto;
                }
                else if (SalarioBruto <= 1050)
                {
                    txtAliqINSS.Text = "8,65%";
                    descontoINSS = 0.0865 * SalarioBruto;
                }
                else if (SalarioBruto <= 1400.77)
                {
                    txtAliqINSS.Text = "9,00%";
                    descontoINSS = 0.9 * SalarioBruto;
                }
                else if (SalarioBruto <= 2801.56)
                {
                    txtAliqINSS.Text = "11,00%";
                    descontoINSS = 0.11 * SalarioBruto;

                }
                else
                {
                    txtAliqINSS.Text = "teto = 308,17";
                    descontoINSS = 308.17;
                }

                //IRPF
                if (SalarioBruto <= 1257.12)
                {
                    txtAliqIRPF.Text = "Isento";
                    descontoIRPF = 0;
                }
                else if (SalarioBruto <= 2512.08)
                {
                    txtAliqIRPF.Text = "15,00%";
                    descontoIRPF = SalarioBruto * 0.15;
                }
                else
                {
                    txtAliqIRPF.Text = "27,50%";
                    descontoIRPF = SalarioBruto * 0.275;
                }

                //SALÁRIO FAMILIA
                if (SalarioBruto <= 435.52)
                {
                    SalarioFam = 22.33 * Convert.ToDouble(nupdFilhos.Value);
                    txtSalFam.Text = Convert.ToString(SalarioFam);
                }
                else if (SalarioBruto <= 654.61)
                {
                    SalarioFam = 15.74 * Convert.ToDouble(nupdFilhos.Value);
                    txtSalFam.Text = Convert.ToString(SalarioFam);
                }
                else
                {
                    txtSalFam.Text = "0";
                    SalarioFam = 0;
                }

                //SALÁRIO LIQUIDO
                SalarioLiq = SalarioBruto - descontoINSS - descontoIRPF + SalarioFam;
                txtSalLiq.Text = Convert.ToString(SalarioLiq);

                txtDescINSS.Text = Convert.ToString(descontoINSS);
                txtDescIRPF.Text = Convert.ToString(descontoIRPF);

            }
        }
    }
}
