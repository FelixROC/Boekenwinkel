using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBoekenWinkel;

namespace BoekenWinkelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Afmeting af = new Afmeting(2, 5, 2);
            var B1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "de isbn", 20, 5);
            var B2 = new Boek("SneeuwWitje", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "de isbn", 20, 5);
            var B3 = new Boek("Hunger games", "Het oosten", Enum_Taal.Engels, af, 12, 25.50m, "de druk", "de isbn", 20, 5);
            var B4 = new Boek("IT", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "de isbn", 20, 5);

            Console.ReadLine();

        }
    }
}
