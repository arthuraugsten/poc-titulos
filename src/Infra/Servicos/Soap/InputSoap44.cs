using Core.Abstracoes;
using Core.Enums;

namespace Infra.Servicos.Soap
{
    // Conversar sobre essas classes ficarem na Infra ou na Api do respectivo tipo.
    public class InputSoap44 : IData
    {
        public LayoutFebraban Layout { get; }
    }
}