using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class RepositorioCompromisso
    {
        private const string arquivoCompromissos = @"C:\Users\eduhe\Desktop\compromisso.bin";
        List<Compromisso> compromissos;
        private int contador = 0;

        public RepositorioCompromisso()
        {
            compromissos = CarregarTarefasDoArquivo();

            if(compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }

        public List<Compromisso> SelecionarTodos()
        {            
            return compromissos;
        }        

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;
            compromissos.Add(novoCompromisso);

            GravarCompromissosEmArquivo();
        }       

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.Data = compromisso.Data;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    break;
                }
            }
            GravarCompromissosEmArquivo();
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            GravarCompromissosEmArquivo();
        }

        private void GravarCompromissosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, compromissos);

            byte[] bytesCompromissos = ms.ToArray();

            File.WriteAllBytes(arquivoCompromissos, bytesCompromissos);
        }

        private List<Compromisso> CarregarTarefasDoArquivo()
        {
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] bytesCompromissos = File.ReadAllBytes(arquivoCompromissos);

            MemoryStream ms = new MemoryStream(bytesCompromissos);
            return (List<Compromisso>)serializador.Deserialize(ms);
        }
    }
}

