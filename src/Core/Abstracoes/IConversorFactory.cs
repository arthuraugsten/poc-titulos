using Core.Enums;

namespace Core.Abstracoes
{
    public interface IConversorFactory
    {
        IConversor CriarConversor(LayoutFebraban layout);
    }
}