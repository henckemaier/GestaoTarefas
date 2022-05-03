using System;

namespace GestaoTarefas.WinApp
{
    [Serializable]
    public class Contato
    {
        public Contato()
        {
        }

        public Contato(int n, string nome, string email, string telefone, string empresa, string cargo)
        {
            Numero = n;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return $"Cargo: {Cargo},Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa: {Empresa}";
        }

    }
}
