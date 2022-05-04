using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemContatos : Form
    {
        private RepositorioContato repositorioContato;

        public ListagemContatos()
        {
            repositorioContato = new RepositorioContato();
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            var contatosAgrupados = repositorioContato
                .SelecionarTodos()
                .GroupBy(x => x.Cargo);

            foreach (var contatoAgrupado in contatosAgrupados)
            {
                foreach (Contato contatoCargo in contatos)
                        if(contatoCargo.Cargo == contatoAgrupado.Key)
                        listContatos.Items.Add(contatoCargo);
            }
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            CadastroContato tela = new CadastroContato(repositorioContato);
            tela.Contato =  new Contato();

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato(repositorioContato);

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir?",
                "Exclusão de Contato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
            if(resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        private void ListagemContatos_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MenuPrincipal = new MenuPrincipal();
            MenuPrincipal.Show();
        }

        private void listContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
