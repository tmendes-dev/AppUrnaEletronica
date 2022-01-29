using Domain.Models;
using System;

namespace Domain.Models
{
    public class Candidato
    {
        public Candidato(Cargo cargo, string nome, int numero)
        {
            Cargo = cargo;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Numero = numero;
        }

        public int Id { get; set; }
        public Cargo Cargo { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
    }
}
