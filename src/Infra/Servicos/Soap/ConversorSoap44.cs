using Core.Abstracoes;
using Core.Entidades;
using Core.Enums;
using System.Threading.Tasks;

namespace Infra.Servicos.Soap
{
    // Conversar sobre essas classes ficarem na Infra ou na Api do respectivo tipo.
    public class ConversorSoap44 : ConversorBase<InputSoap44>, IConversor
    {
        public LayoutFebraban Layout => LayoutFebraban.Layout44;

        public Task<Remessa> TransformarAsync(IData dados)
        {
            var input = Converter(dados);

            // Lógica de mapeamento
            return Task.FromResult(new Remessa());
        }
    }
}