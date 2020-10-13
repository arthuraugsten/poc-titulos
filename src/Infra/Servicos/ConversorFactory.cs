using Core.Abstracoes;
using Core.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Servicos
{
    public class ConversorFactory : IConversorFactory
    {
        private readonly IEnumerable<IConversor> _conversores;

        public ConversorFactory(IEnumerable<IConversor> conversores)
            => _conversores = conversores;

        public IConversor CriarConversor(LayoutFebraban layout)
            => _conversores.Single(t => t.Layout == layout);
    }
}