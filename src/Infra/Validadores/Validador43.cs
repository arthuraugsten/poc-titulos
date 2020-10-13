using Core.Abstracoes;
using Core.Entidades;
using Core.Enums;
using System.Threading.Tasks;

namespace Infra.Validadores
{
    public class Validador43 : IValidador
    {
        public LayoutFebraban Layout => LayoutFebraban.Layout43;

        // Regra de validação do layout 4.4
        public Task<bool> ValidarAsync(Remessa entidade)
            => Task.FromResult(true);
    }
}