using Core.Enums;

namespace Core.Abstracoes
{
    public interface IValidadorFactory
    {
        IValidador CriarValidador(LayoutFebraban layout);
    }
}