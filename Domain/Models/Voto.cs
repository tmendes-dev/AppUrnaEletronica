using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Voto
    {
        public Voto(int cargo, int numeroCanditado, long tituloEleitor)
        {
            Cargo = cargo;
            NumeroCanditado = numeroCanditado;
            TituloEleitor = tituloEleitor;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Cargo { get; set; }

        [Required]
        public int NumeroCanditado { get; set; }

        [Required]
        public long TituloEleitor { get; set; }
    }
}