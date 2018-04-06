using Modelo.DAO;
using Modelo.PN;
using System;
using System.Windows.Forms;

namespace Desk
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            Pessoa par = pnAgenda.Pesquisar(p.Email);

            if ((par != null) && p.Nome.Equals(par.Nome) && (p.Idade == par.Idade))
            {
                
                    if (pnAgenda.Excluir(p))
                    {
                        MessageBox.Show("Excluido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Algo ocorreu errado");
                    }
                
                
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada!");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p = pnAgenda.Pesquisar(txtEmail.Text);

            if (p != null)
            {
                p.Idade = Convert.ToInt32(txtIdade.Text);
                p.Nome = txtNome.Text;
                pnAgenda.Alterar(p);
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada!");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            if (!pnAgenda.Inserir(p))
            {
                MessageBox.Show("E-mail já cadastrado!");
            }
            else
            {
                MessageBox.Show("Inserido com sucesso!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p = pnAgenda.Pesquisar(txtEmail.Text);  

            if (p!=null)
            {
                txtEmail.Text = p.Email;
                txtIdade.Text = p.Idade.ToString();
                txtNome.Text = p.Nome;
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada!");
            }
        }

    }
}
