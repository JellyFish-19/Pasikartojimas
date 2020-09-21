using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PASIKARTOJIMAS
{
    class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {

        }
        
        public override string NameMetodas()
        {
            var newWord = "";

            foreach (char vowel in Name)
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
        
        public override int NameKodas(int num)
        {
            int toNum = 0;

            foreach (char letter in Name)
            {
                toNum += (int)letter * num;
            }
            return toNum;
        }
    } 
}
