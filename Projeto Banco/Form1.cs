using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Banco
{
    public partial class Frm_Banco : Form
    {
        public Frm_Banco()
        {
            InitializeComponent();
        }
        Conta_Bancaria conta = new Conta_Bancaria();
        int contador_saque, contador_deposito; //Declarando variáveis para contar saque e depósito

        private void Btn_X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Banco_Load(object sender, EventArgs e)
        {
            Txt_SaldoDisponivel.Text = conta.saldo.ToString();
        }

        private void Txt_Agencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Condição para aceitar somente números e as teclas de controle
            {
              e.Handled = true; //Verificando se o que foi digitado é número

                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
            if (e.KeyChar == 13) //Condição do uso da tecla Enter
            {
                if (Txt_Agencia.TextLength == 4) //Condição para verificar se foi colocado 4 digitos
                {
                    Txt_NdaConta.Focus(); //Posicionando o cursor para a próxima informação
                }
                else //Caso contrério se não for digitado os 4 digitos
                {
                    MessageBox.Show("Complete a Agência com 4 digitos!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_NdaConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Condição para aceitar somente números e as teclas de controle
            {
                e.Handled = true; //Verificando se o que foi digitado é número

                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Condição do uso da tecla Enter
            {
                if (Txt_NdaConta.TextLength == 5) //Condição para verificar se foi colocado 5 digitos
                {
                    Txt_TitularDaConta.Focus(); //Posicionando o cursor para a próxima informação
                }
                else //Caso contrério se não for digitado os 5 digitos
                {
                    MessageBox.Show("Complete o Número da conta com 5 digitos!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_TitularDaConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar)) //Condição para aceitar somente letras e as teclas de controle e barra de espaço
            {
                e.Handled= true; //Verificando se o que foi digitado é letra

                MessageBox.Show("Somente Letras!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Condição do uso da tecla Enter
            {
                if (Txt_TitularDaConta.TextLength >= 3) //Condição para verificar se foi colocado no mínimo 3 letras
                {
                    Txt_Idade.Focus(); //Posicionando o cursor para a próxima informação
                }
                else //Caso contrério se não for digitado no mínimo 3 letras
                {
                    MessageBox.Show("Minimo de 3 letras!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;

                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Valor.Text != "") //Condição para digitar o valor
                {
                    MessageBox.Show("Utilize os Botões de Saque e Depósito!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Informe o Valor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hcj(object sender, EventArgs e)
        {

        }

        private void Btn_Saque_Click(object sender, EventArgs e)
        {
            if (Txt_Agencia.TextLength == 4 && Txt_NdaConta.TextLength == 5 && Txt_TitularDaConta.TextLength >= 3 && Txt_Valor.Text != "") //Condição para verificar se todas as informações foram preenchidas
            {
                //Armazenando todas as informações que foram digitadas para as Variáveis da Classe

                conta.agencia = int.Parse(Txt_Agencia.Text); 
                conta.numero_conta = int.Parse(Txt_NdaConta.Text);
                conta.titular = (Txt_TitularDaConta.Text);
                conta.valor = double.Parse(Txt_Valor.Text);

                if (conta.saldo >= conta.valor) //Condição para realizar o saque
                {
                    conta.Sacar(); //Usando o Metódo da Classe
                    Txt_SaldoDisponivel.Text = conta.saldo.ToString(); //Atualizando o saldo após o saque
                    contador_saque++; //Fazer a contagem do saque, um a um
                    Lbl_Saque.Text = contador_saque.ToString(); //Mostrando a contagem do saque

                    MessageBox.Show("Saque Realizado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Caso contrário se não tiver saldo suficiente
                {
                    MessageBox.Show("Saldo Insuficiente!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //Se as informações não foram digitadas
            {
                MessageBox.Show("Preencha Todas as Informações!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Valor_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Lbl_Mes_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Condição para aceitar somente números e as teclas de controle
            {
                e.Handled = true; //Verificando se o que foi digitado é número

                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Condição do uso da tecla Enter
            {
                if (Txt_Idade.Text !="") //Condição para verificar se a idade foi digitada
                {
                    conta.idade = int.Parse(Txt_Idade.Text); //Armazendo a idade digitada
                    
                    if (conta.idade >= 18) //Condição para verificar se é, maior de idade
                    {
                        Txt_Mes.Focus(); //Posicionando o cursor para a próxima informação  
                    }
                    else
                    {
                        MessageBox.Show("Somente Maior de Idade!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Idade.Clear();
                        Txt_Idade.Focus();
                    }
                }
                else //Caso contrério se não for digitado a idade
                {
                    MessageBox.Show("Digite a sua idade!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_Mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Condição para aceitar somente números e as teclas de controle
            {
                e.Handled = true; //Verificando se o que foi digitado é número

                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Condição do uso da tecla Enter
            {
                if (Txt_Mes.Text !="") //Condição para verificar se o número do mês foi digitado
                {
                    conta.mes = int.Parse(Txt_Mes.Text); //Armazendo a idade digitada

                    if (conta.mes >= 1 && conta.mes <= 12) //Condição para entrar somete até 12
                    {
                        Txt_Valor.Focus(); //Posicionando o cursor para a próxima informação
                    }
                    else //Se for fora do número do mês
                    {
                        MessageBox.Show("Informe o mês de 1 a 12!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Idade.Clear();
                        Txt_Idade.Focus();
                    }
                }
                else //Caso contrário se o mês não for digitado 
                {
                    MessageBox.Show("Informe o mês!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Deposito_Click(object sender, EventArgs e)
        {
            if (Txt_Agencia.TextLength == 4 && Txt_NdaConta.TextLength == 5 && Txt_TitularDaConta.TextLength >= 3 && Txt_Valor.Text != "") //Condição para verificar se todas as informações foram preenchidas
            {
                conta.agencia = int.Parse(Txt_Agencia.Text);
                conta.numero_conta = int.Parse(Txt_NdaConta.Text);
                conta.titular = (Txt_TitularDaConta.Text);
                conta.valor = double.Parse(Txt_Valor.Text);

                conta.Depositar(); //Usando o método da classe
                Txt_SaldoDisponivel.Text = conta.saldo.ToString(); //Atualizando o saldo após o depósito
                contador_deposito++; //Fazer a contagem do Depósito, um a um
                Lbl_Deposito.Text = contador_deposito.ToString(); //Mostrando a contagem do Depósito


                MessageBox.Show("Depósito Realizado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else //Se as informações não foram digitadas
            {
                MessageBox.Show("Preencha Todas as Informações!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
