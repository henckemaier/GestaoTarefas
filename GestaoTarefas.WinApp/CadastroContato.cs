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


            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;
            contato.Telefone = txtTelefone.Text;
        }

        private bool Valido()
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Por favor, insira o nome");
                txtNome.Text = "########";
            }
            else if (txtEmail.Text =="")
            {
                MessageBox.Show("Por favor, insira o Email");
                txtEmail.Text = "########";
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Por favor, insira um telefone");
                txtTelefone.Text = "########";
            }
            return true;
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
