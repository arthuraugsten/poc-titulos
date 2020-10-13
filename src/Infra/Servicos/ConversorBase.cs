using Core.Abstracoes;
using System;

namespace Infra.Servicos
{
    public abstract class ConversorBase<TInput> where TInput : IData
    {
        public TInput Converter(IData dados)
        {
            if (!(dados is TInput)) throw new ArgumentException(nameof(dados));

            return (TInput)dados;
        }
    }
}