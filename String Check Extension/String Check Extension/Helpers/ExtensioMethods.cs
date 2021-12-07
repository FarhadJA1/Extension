using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace String_Check_Extension.Helpers
{
    public static class ExtensioMethods
    {
        public static int StringCheck(this string text, string pattern)
        {
            int count = 0;
            if (Regex.IsMatch (text, pattern))
            {
                count++;
            }

            return count;






           
          
        }
    }
}
