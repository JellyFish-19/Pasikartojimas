using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASIKARTOJIMAS
{
    class BKlase : BaseClass, IZodisKitaip
    {
        public BKlase(string name) : base(name)
        {

        }

        public override int NameKodas(int num)
        {
            throw new NotImplementedException();
        }

        public override string NameMetodas()
        {
            throw new NotImplementedException();
        }


        //------------------------------------------------------------------
        public string ZodisBeBalsiu()
        {
            var noVowels = "";
            string vowels = "aeiou";
            noVowels = new string(Name.Where(c => !vowels.Contains(c)).ToArray());
            return noVowels;
        }

        public string ZodisBePriebalsiu()
        {
            var noConsonants = "";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            noConsonants = new string(Name.Where(c => !consonants.Contains(c)).ToArray());
            return noConsonants;
        }

        public string ZodisSuPakeistomisBalsemis(char ch)
        {
            var changedVowels = "";

            foreach (char vowel in Name)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    changedVowels += ch;
                }
                else
                {
                    changedVowels += vowel;
                }
            }
            return changedVowels;
        }

        public string ZodisSuPakeistomisPriebalsemis(int num)
        {
             var changedConst = "";          

            foreach (char constant in Name)
            {
                if (constant == 'b' || constant == 'c' || constant == 'd' || constant == 'f' || constant == 'g'|| constant == 'h' || 
                    constant == 'j' || constant == 'k' || constant == 'l' || constant == 'm' || constant == 'n'|| constant == 'p' ||
                    constant == 'q' || constant == 'r' || constant == 's' || constant == 't' || constant == 'v'|| constant == 'w' ||
                    constant == 'x' || constant == 'y' || constant == 'z') 
                {
                    changedConst += num;
                }
                else
                {
                    changedConst += constant;
                }
            }
            return changedConst;
        }
    }
}
