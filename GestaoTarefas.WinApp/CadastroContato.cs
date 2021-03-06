using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//<-valida telefone

namespace GestaoTarefas.WinApp
{
    public partial class CadastroContato : Form
    {
        private Contato contato;

        private RepositorioContato repositorioContato;

        public CadastroContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CadastroContato_Load(object sender, EventArgs e)
        {

        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNumero.Text = contato.Numero.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
                txtTelefone.Text = contato.Telefone;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Valido();

            if (Valido() == false)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;
                contato.Empresa = txtEmpresa.Text;
                contato.Cargo = txtCargo.Text;
                contato.Telefone = txtTelefone.Text;
            }
        }

        private bool Valido()
        {
            Regex Telefone = new Regex(@"\(\d{2}\)\d{5}-\d{4}");

            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor, insira o Nome!");
                return false;
            }

            List<string> nomes = repositorioContato.SelecionarTodos().Select(x => x.Nome).ToList();
            List<string> emails = repositorioContato.SelecionarTodos().Select(x => x.Email).ToList();
            List<string> telefones = repositorioContato.SelecionarTodos().Select(x => x.Telefone).ToList();

            foreach (string telefone in telefones)
            {
                if (txtTelefone.Text.Equals(telefone, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Por favor, insira um Telefone diferente!");
                    return false;
                }
            }

            foreach (string email in emails)
            {
                if (txtEmail.Text.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Por favor, insira um Email diferente!");
                    return false;
                }
            }

            foreach (string nome in nomes)
            {
                if (txtNome.Text.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Por favor, insira um Nome diferente!");
                    return false;
                }
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, insira uma Email!");
                return false;
            }
            if (Telefone.IsMatch(txtTelefone.Text) == false)
            {
                MessageBox.Show("Por favor, insira um Telefone válido! Ex. (99)99999-9999");
                return false;
            }        
            else
            {
                return true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
