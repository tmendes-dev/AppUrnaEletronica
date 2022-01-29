using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IVotoRepository
    {
        Task<int> BuscarVotosPorCandidatoAsync(int numeroCandidato);

        Task<Voto> CriarVotoAsync(Voto voto);
    }
}