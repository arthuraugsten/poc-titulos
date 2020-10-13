using System.Collections.Generic;
using System.Linq;

namespace Core.Entidades
{
    public class Remessa
    {
        public IEnumerable<Titulo> Titulos { get; set; } = Enumerable.Empty<Titulo>();
    }
}