using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal; 
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        
        public void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            
            if(comboTipoConta.SelectedIndex == 0)
            {
                novaConta = new ContaCorrente();
                MessageBox.Show("Conta Corrente Criada");
            }
            else
            {
                novaConta = new ContaPoupanca();
                MessageBox.Show("Conta Poupanca Criada");
            }
            novaConta.Titular = new Cliente(textoTitular.Text);
          //  novaConta.Numero = Convert.ToInt32(TextoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
                   
               
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            TextoNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
    }

