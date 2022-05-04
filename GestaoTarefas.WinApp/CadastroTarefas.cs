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
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        private IRepositorioTarefa repositorioTarefa;

        public CadastroTarefas(IRepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
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
                tarefa.Titulo = txtTitulo.Text;
            }
        }

        private bool Valido()
        {
            List<string> titulos = repositorioTarefa.SelecionarTodos().Select(x => x.Titulo).ToList();

            foreach (string titulo in titulos)
            {
                if (txtTitulo.Text.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Por favor, insira um Titulo diferente!");
                    return false;
                }
            }
            if(txtTitulo.Text == "")
            {
                MessageBox.Show("Por favor, insira uma Titulo!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CadastroTarefas_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
