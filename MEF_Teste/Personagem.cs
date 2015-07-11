using MEF_Teste.Interfaces;
using System.ComponentModel.Composition;

namespace MEF_Teste
{
    public class Personagem
    {
        [Import(typeof(IArmadura))]
        private IArmadura armadura = null;

        public string nomeArmadura()
        {
            if (armadura == null)
            {
                return "Armadura não definida";
            }
            else
            {
                return armadura.getNome();
            }
        }
    }
}
