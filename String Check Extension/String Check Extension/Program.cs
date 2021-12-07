using System;
using static String_Check_Extension.Helpers.ExtensioMethods;
namespace String_Check_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Salam Cavid. Necəsən Cavid";
            Console.WriteLine(text.StringCheck(@"Cavid"));
        }

    }
}
