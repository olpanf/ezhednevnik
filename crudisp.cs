using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace ezhednevnik
{
    internal class crudisp : ICRUD
    {
        public void create(Tip tip)
        {
            string json = JsonConvert.SerializeObject(tip);
            File.AppendAllText("C:\\Users\\polga\\Desktop\\qwe.json",json);
            string text;
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void read()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
