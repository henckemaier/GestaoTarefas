using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestaoTarefas.WinApp
{
    public class RepositorioContato
    {
        private const string arquivoContatos = @"C:\Users\eduhe\Desktop\contatos.bin";
        List<Contato> contatos;
        private int contador = 0;

        public RepositorioContato()
        {
            contatos = CarregarContatosDoArquivo();

            if(contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {            
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);

            GravarContatosEmArquivo();
        }        

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    item.Telefone = contato.Telefone;
                    break;
                }
            }

            GravarContatosEmArquivo();
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            GravarContatosEmArquivo();
        }

        private void GravarContatosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, contatos);

            byte[] bytesContatos = ms.ToArray();

            File.WriteAllBytes(arquivoContatos, bytesContatos);
        }

        private List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] bytesContatos = File.ReadAllBytes(arquivoContatos);

            MemoryStream ms = new MemoryStream(bytesContatos);

            return (List<Contato>)serializador.Deserialize(ms);
        }
    }
}
