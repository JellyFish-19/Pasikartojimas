using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASIKARTOJIMAS
{
    abstract class BaseClass
    {
        public string Name { get; set; }

        public BaseClass(string name)
        {
            Name = name;
        }

        abstract public string NameMetodas();

        abstract public int NameKodas(int num);
    }
}
