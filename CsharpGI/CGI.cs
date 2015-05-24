using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGI
{
    enum cgiFormResultType
    {
        cgiFormSuccess,
        cgiFormTruncated,
        cgiFormBadType,
        cgiFormEmpty,
        cgiFormNotFound,
        cgiFormConstrained,
        cgiFormNoSuchChoice,
        cgiFormMemory,
        cgiFormNoFileName,
        cgiFormNoContentType,
        cgiFormNotAFile,
        cgiFormOpenFailed,
        cgiFormIO,
        cgiFormEOF
    }
    public static class CGI
    {
        /// <summary>
        /// Set the ContentType
        /// </summary>
        /// <param name="mimeType"></param>
        public static void setCgiHeaderContentType(string mimeType)
        {
            Console.Write("Content-type: {0}\r\n\r\n", mimeType);
        }

        /// <summary>
        /// eg;name=&password=
        /// </summary>
        /// <param name="formType"></param>
        /// <returns>
        /// case 1: not found return null
        /// case 2:found but QueryString have no vale. return ""
        /// case 2:found and return the result
        /// </returns>
        public static string getCgiFormString(string formType)
        {
            string formResult = null;
            // return null when maethod caller pass null or empty
            if (string.IsNullOrEmpty(formType))
                return formResult;

            string cgiFormstring = CGIEnvironmentVariable.CgiQueryString;

            // check the CgiQueryString in case is null
            if (!string.IsNullOrEmpty(cgiFormstring))
            {
                List<string> formStrings = cgiFormstring.Split('&').ToList();
                foreach (var form in formStrings)
                {
                    // we only take first match and return.
                    if (form.Contains(formType))
                    {
                        formResult = form.Split('=')[1];
                        break;
                    }
                }
            }
            return formResult;
        }

        /// <summary>
        /// output html
        /// </summary>
        /// <param name="html"></param>
        public static void cgiPrintf(string html)
        {
            Console.Write(html);
        }
    }
}
