using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpGI;
using System.Windows;

namespace CSharpWebSite
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Windows.Forms.MessageBox.Show("d");
            string queryString = CGIEnvironmentVariable.CgiQueryString;
            CGI.setCgiHeaderContentType("text/html; charset = gbk");
            string btnLoginresult = CGI.getCgiFormString("btnLogin");
            if (!string.IsNullOrEmpty(btnLoginresult))
            {

                string result = CGI.getCgiFormString("name");
                if (string.IsNullOrEmpty(result))
                {
                    CGI.cgiPrintf("input not value");
                }
                else
                {
                    if (result == "admin")
                    {
                        ("input  value is:" + result).toCgiout();
                    }
                    else
                    {
                        "input wrong value".toCgiout();
                    }
                }
            }
            else
            {
                string html = @"<html lang='en' xmlns='http://www.w3.org/1999/xhtml'>
<head>
    <meta charset='utf-8' />
    <title></title>
</head>
<body>
    <form action='CSharpWebSite.cgi'>
        <input type='text' name='name' value='' />
        <input type='text' name='password' />
        <input type='checkbox' name='checkbox' />
        <input type='submit' name='btnLogin' value='test' />

        <input type='radio' name='xingqu' value='nan' />
    </form>

</body>
</html>";
                html.toCgiout();
            }
            // Console.Read();
        }
    }
}
