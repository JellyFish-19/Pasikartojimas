using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASIKARTOJIMAS
{
    interface IZodisKitaip
    {
        string ZodisBeBalsiu();

        string ZodisBePriebalsiu();

        string ZodisSuPakeistomisBalsemis(char ch);

        string ZodisSuPakeistomisPriebalsemis(int num);
    }
}
