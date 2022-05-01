using GestaoTarefas.Dominio;
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
    public partial class CadastroContatos : Form
    {
        private Contato contato;
        public CadastroContatos()
        {
            InitializeComponent();
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
                txtTelefone.Text = contato.Telefone;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroContatos_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
