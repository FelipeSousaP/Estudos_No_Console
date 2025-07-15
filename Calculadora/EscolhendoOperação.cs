using System.Collections.Generic;
using Calculo;

namespace Calculo.Escolha
{
    public class EscolhendoOperação
    {
        public Operações operações1 { get; set; }
        public Dictionary<string, Operações> Escolhas {  get; set; }
        public void EscolherOperação()
        {
            operações1 = new Operações();
        }
    }
}
