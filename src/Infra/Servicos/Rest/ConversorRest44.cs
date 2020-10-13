using Core.Abstracoes;
using Core.Entidades;
using Core.Enums;
using System.Threading.Tasks;

namespace Infra.Servicos.Rest
{
    // Conversar sobre essas classes ficarem na Infra ou na Api do respectivo tipo.
    public class ConversorRest44 : ConversorBase<InputRest44>, IConversor
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