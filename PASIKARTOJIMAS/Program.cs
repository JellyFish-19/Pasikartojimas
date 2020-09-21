using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PASIKARTOJIMAS
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "mmfghjklkdggama";
            Console.WriteLine(ZodisSuPakeistomisBalsemis(name));

            Console.ReadLine();
        }

        static string ZodisSuPakeistomisBalsemis(string name)
        {
            var changeVowels = "";
            changeVowels = string.Concat(name.Select(c => name.Contains(c) ? 'a' : c));
            return changeVowels;
        }


        static string ZodisBeBalsiu(string name)
        {
            var noVowels = "";
            string vowels = "aeiou";

            noVowels = new string(name.Where(c => !vowels.Contains(c)).ToArray());

            return noVowels;
        }

        static string NameMetodas(string name)
        {
            var newWord = "";

            foreach (char vowel in name)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    newWord += (int)vowel;
                }
                else
                {
                    newWord += vowel;
                }
            }
            return newWord;
        }
    }
}
