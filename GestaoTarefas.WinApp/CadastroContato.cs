using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroContato : Form
    {
        private Contato contato;

        public CadastroContato()
        {
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
            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor, insira o Nome");
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, insira uma Email");
                return false;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Por favor, insira um Telefone");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool TelefoneEstaValido()
        {
            bool telefoneEstaValido = false;

            // utilizando o método Replace() para remover caracteres especiais da string
            string telefoneProcessado = contato.Telefone.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty);

            if (telefoneProcessado.Length < 9)
                return telefoneEstaValido;

            telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            return telefoneEstaValido;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
