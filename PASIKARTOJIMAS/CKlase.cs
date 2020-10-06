using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASIKARTOJIMAS
{
    class CKlase : BKlase
    {
        public int Number { get; set; }
        public string Word { get; set; }
        public double DoubleNumber { get; set; }
        public AKlase AObjektas {get; set;}

        public CKlase(string name, int number, string word, double doubleNumber, AKlase aObjektas) : base (name)
        {
            Number = number;
            Word = word;
            DoubleNumber = doubleNumber;
            AObjektas = aObjektas;
        }

        public CKlase(string name, int number) : base(name)
        {
            Number = number;
        }

        public CKlase(string name, int number, string word) : base(name)
        {
            Number = number;
            Word = word;
        }

        public CKlase(string name) : base (name)
        {

        }
    }
}
