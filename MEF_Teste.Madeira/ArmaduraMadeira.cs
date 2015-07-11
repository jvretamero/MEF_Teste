using MEF_Teste.Interfaces;
using System.ComponentModel.Composition;

namespace MEF_Teste.Madeira
{
    [Export(typeof(IArmadura))]
    public class ArmaduraMadeira : IArmadura
    {
        public string getNome()
        {
            return "Armadura de madeira";
        }
    }
}
