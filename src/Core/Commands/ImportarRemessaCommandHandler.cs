using Core.Abstracoes;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class ImportarRemessaCommandHandler
    {
        private readonly IConversorFactory _fabricaConversor;
        private readonly IValidadorFactory _fabricaValidador;

        public ImportarRemessaCommandHandler(IConversorFactory fabricaConversor,
            IValidadorFactory fabricaValidador)
        {
            _fabricaConversor = fabricaConversor;
            _fabricaValidador = fabricaValidador;
        }

        public async Task Handle(ImportarRemessaCommand requisicao, CancellationToken tokenCancelamento)
        {
            // Gerar conversor de acordo com layout identificado e o tipo com o que foi injetado na DI.
            var remessa = await _fabricaConversor.CriarConversor(requisicao.Remessa.Layout).TransformarAsync(requisicao.Remessa);

            // Criar validador de acordo com o layout Febraban
            var validador = _fabricaValidador.CriarValidador(requisicao.Remessa.Layout);

            // restante do fluxo ....
        }
    }
}