using Core.Entidades;
using Core.Enums;
using System.Threading.Tasks;

namespace Core.Abstracoes
{
    public interface IValidador
    {
        LayoutFebraban Layout { get; }

        Task<bool> ValidarAsync(Remessa entidade);
    }
}