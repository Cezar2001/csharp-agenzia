using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    class Program
    {
        static void Main(string[] args)
        {
            Villa v = new Villa(157, 7, 2, "", "Via Dante", 89022, "Cittanova", 220);
            Appartamento a = new Appartamento(2, 1, "", "garibaldi", 89022, "Cittanova", 150);
            Agenzia agenzia = new Agenzia("Odissea Trip");

            agenzia.AddImmobile(v);

            Box box1 = new Box(100, "", "via Roma", 89024, "Polistena", 150);

            agenzia.AddListaImmobili(new List<Immobile>() { v, a });

            List<Immobile> listaImmobili = agenzia.CercaImmobili("Cittanova");

            foreach (Immobile immobile in listaImmobili)
            {
                Console.WriteLine(immobile);
            }
        }
    }
}
