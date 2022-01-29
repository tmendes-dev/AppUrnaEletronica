using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public  class CandidatoRepository : ICandidatoRepository
    {
        public Task<Candidato> AtualizarAsync(Candidato candidato)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidato>> BuscarCandidatosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Candidato> CriarAsync(Candidato candidato)
        {
            throw new NotImplementedException();
        }

        public Task<Candidato> RemoverAsync(Candidato candidato)
        {
            throw new NotImplementedException();
        }
    }
}