using System;

namespace Aplicacao
{
    public class Cidade
    {
        public Cidade(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Cidade(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }
    }
}