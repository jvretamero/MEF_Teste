using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEF_Teste
{
    public class Program
    {
        static void Main()
        {
            Personagem p = new Personagem();
                
            Console.WriteLine("Armadura antes: " + p.nomeArmadura());

            AssemblyCatalog catalog = new AssemblyCatalog(@"D:\MEF_Teste.Madeira.dll");
            CompositionContainer container = new CompositionContainer(catalog);

            container.ComposeParts(p);

            Console.WriteLine("Armadura depois: " + p.nomeArmadura());

            Console.ReadKey();
        }
    }
}
