using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGI
{
    public static class CGIEnvironmentVariable
    {
        public static string CgiQueryString
        {
            get
            {
                return Environment.GetEnvironmentVariable("QUERY_STRING");
            }
        }

        public static string getEnvironmentVariable(string variable)
        {
            return Environment.GetEnvironmentVariable(variable);
        }
    }
}
