using System;
using System.Collections.Generic;

namespace GestaoTarefas.WinApp
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();
        private int contador = 0;
        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);
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
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }
    }
}
