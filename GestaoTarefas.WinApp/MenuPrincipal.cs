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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ListagemTarefas = new ListagemTarefas();
            ListagemTarefas.Closed += (s, args) => this.Close();
            ListagemTarefas.Show();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ListagemContatos = new ListagemContatos();
            ListagemContatos.Closed += (s, args) => this.Close();
            ListagemContatos.Show();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ListagemCompromisso = new ListagemCompromisso();
            ListagemCompromisso.Closed += (s, args) => this.Close();
            ListagemCompromisso.Show();
        }
    }
}
