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
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;
        public CadastroCompromissos()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;

                txtNumero.Text = compromisso.Numero.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtData.Text = compromisso.Data;
                txtHoraInicio.Text = compromisso.HoraInicio;
                txtHoraTermino.Text = compromisso.HoraTermino;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Valido();


            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            compromisso.Data = txtData.Text;
            compromisso.HoraInicio = txtHoraInicio.Text;
            compromisso.HoraTermino = txtHoraTermino.Text;
        }

        private void CadastroCompromissos_Load(object sender, EventArgs e)
        {

        }

        private bool Valido()
        {
            if (txtAssunto.Text == "")
            {
                MessageBox.Show("Por favor, insira o assunto");
                txtAssunto.Text = "########";
            }
            else if (txtData.Text == "")
            {
                MessageBox.Show("Por favor, insira uma data");
                txtData.Text = "########";
            }
            else if (txtLocal.Text == "")
            {
                MessageBox.Show("Por favor, insira um local");
                txtLocal.Text = "########";
            }
            return true;
        }
    }
}
