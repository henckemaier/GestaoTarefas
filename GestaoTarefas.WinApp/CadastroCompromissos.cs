using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            if(Valido() == false)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            compromisso.Data = txtData.Text;
            compromisso.HoraInicio = txtHoraInicio.Text;
            compromisso.HoraTermino = txtHoraTermino.Text;
            }
        }

        private void CadastroCompromissos_Load(object sender, EventArgs e)
        {

        }

        private bool Valido()
        {
            Regex Data = new Regex(@"\d{2}/\d{2}/\d{4}");

            Regex Hora = new Regex(@"\d{2}:\d{2}:\d{2}");

            if (txtAssunto.Text == "")
            {
                MessageBox.Show("Por favor, insira o assunto!");
                return false;
            }
            if (txtLocal.Text == "")
            {
                MessageBox.Show("Por favor, insira um local!");
                return false;
            }
            if (Data.IsMatch(txtData.Text) == false)
            {
                MessageBox.Show("Por favor, insira uma data válida!");
                return false;
            }           
            if (Hora.IsMatch(txtHoraInicio.Text) == false)
            {
                MessageBox.Show("Por favor, insira uma hora inicial válida!");
                return false;
            }
            if (Hora.IsMatch(txtHoraTermino.Text) == false)
            {
                MessageBox.Show("Por favor, insira uma hora final válida!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
