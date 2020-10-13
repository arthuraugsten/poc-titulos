using Core.Entidades;
using Core.Enums;
using System.Threading.Tasks;

namespace Core.Abstracoes
{
    public interface IConversor
    {
        LayoutFebraban Layout { get; }

        Task<Remessa> TransformarAsync(IData dados);
    }
}