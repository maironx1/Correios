using CorreiosData.Classes;
using System.Collections.Generic;

namespace Correios.Interface
{
    public interface IMaisCurto
    {
        public List<string> BuscaResultado(string[] trechoLines, string[] encomendaLines);
    }
}
