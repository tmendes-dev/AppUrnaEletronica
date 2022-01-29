using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ICandidatoRepository
    {
        Task<IEnumerable<Candidato>> BuscarCandidatosAsync();
        Task<Candidato> CriarAsync(Candidato candidato);
        Task<Candidato> AtualizarAsync(Candidato candidato);
        Task<Candidato> RemoverAsync(Candidato candidato);
    }
}
