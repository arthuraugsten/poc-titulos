using Core.Abstracoes;

namespace Core.Commands
{
    public class ImportarRemessaCommand
    {
        public ImportarRemessaCommand(IData remessa)
            => Remessa = remessa;

        public IData Remessa { get; }
    }
}