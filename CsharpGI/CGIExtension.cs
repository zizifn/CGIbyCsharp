using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGI
{
    public static class CGIExtension
    {
        public static void toCgiout(this string str)
        {
            Console.Write(str.ToString());
        }
    }
}
