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
            int toNum = 0;

            foreach (char letter in Name)
            {
                toNum += (int)letter - num;
            }
            return toNum;
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
            var changeVowels = "";
            changeVowels = string.Concat(Name.Select(c => Name.Contains(c) ? 'a' : c));
            return changeVowels;
        }

        public string ZodisSuPakeistomisPriebalsemis(int num)
        {
            throw new NotImplementedException();
        }
    }
}
