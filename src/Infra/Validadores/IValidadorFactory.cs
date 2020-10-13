using Core.Abstracoes;
using Core.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Validadores
{
    public class ValidadorFactory : IValidadorFactory
    {
        private readonly IEnumerable<IValidador> _validadores;

        public ValidadorFactory(IEnumerable<IValidador> validadores)
            => _validadores = validadores;

        public IValidador CriarValidador(LayoutFebraban layout)
            => _validadores.Single(t => t.Layout == layout);
    }
}