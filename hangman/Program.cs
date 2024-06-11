using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    public class Program
    {
        static void Main(string[] args)
        {

            var slowa = new List<string>()
            {
                "kot", "pies", "krokodyl", "lew", "tygrys", "słoń", "żyrafa", "wąż", "kangur",
                "hipopotam", "nosorożec", "antylopa", "szympans", "goryl", "pawian", "pingwin",
                "strus", "orzeł", "jaszczurka", "żółw", "aligator", "lama", "wielbłąd", "koń",
                "krowa", "owca", "koza", "świnia", "kurczak", "kaczka", "gęś", "indyk", "zebra",
                "panda", "koala", "borsuk", "lis", "wilk", "jeż", "szop", "bóbr", "wydra", "świstak",
                "foka", "delfin", "rekin", "mors", "kałamarnica", "ośmiornica", "krab", "homar"
            };
            Random rnd = new Random();
            var slowo = slowa[rnd.Next(slowa.Count)];
            var ilosc_liter = slowo.Length;
            var haslo = "";
            for (int i = 0; i < ilosc_liter; i++)
            {
                haslo = haslo + "_";
            }
            Console.WriteLine(haslo);
            char[] array_haslo = haslo.ToCharArray();
            var drawing = new drawing();
            var fails = 0;
            var good = false;
            while (true)
            {
                good = false;
                Console.WriteLine("Wpisz literę:");
                var input = Console.ReadLine();
                if (input.Length != 1)
                {
                    Console.WriteLine("Wpisałeś za dużo znaków");
                    Console.WriteLine(haslo);
                    continue;
                }
                var litera = Convert.ToChar(input);
                for (int i = 0; i < ilosc_liter; i++)
                {
                    if (slowo[i] == litera)
                    {
                        array_haslo[i] = litera;
                        good = true;
                    }
                    haslo = new string(array_haslo);
                }
                if (!good)
                {
                    drawing.draw(fails);
                    if (fails == 6)
                    {
                        Console.WriteLine("Przegrałeś");
                        Console.WriteLine("Hasłem było słowo: "+ slowo);
                        break;
                    }
                    fails++;
                }
                Console.WriteLine(haslo);
                if (haslo == slowo)
                {
                    Console.WriteLine("Brawo wygrałeś");
                    break;
                }
                
            }
        }
    }
}