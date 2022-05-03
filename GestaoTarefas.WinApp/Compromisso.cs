using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class Compromisso
    {
        public Compromisso()
        {
        }

        public Compromisso(int n, string assunto, string local, string data, string horaInicio, string horaTermino)
        {
            Numero = n;
            Assunto = assunto;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }

        public override string ToString()
        {
            return $"Assunto: {Assunto}, Local: {Local}, Data: {Data}, Horário de Início: {HoraInicio}, Horário de Término: {HoraTermino}";
        }
    }
}
