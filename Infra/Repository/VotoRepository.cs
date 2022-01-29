using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class VotoRepository : IVotoRepository
    {
        public Task<int> BuscarVotosPorCandidatoAsync(int numeroCandidato)
        {
            throw new NotImplementedException();
        }

        public Task<Voto> CriarVotoAsync(Voto voto)
        {
            throw new NotImplementedException();
        }
    }
}