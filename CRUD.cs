using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezhednevnik
{
    internal interface ICRUD
    {
        void delete();
        void create(Tip tip);
        void update();
        void read();

     
    }
}
