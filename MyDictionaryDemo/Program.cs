using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> menuUrl = new MyDictionary<string, string>();

            menuUrl.Add("Home", "index.php");
            menuUrl.Add("About US", "about-us.php");
            menuUrl.Add("Menu", "menu.php");
            menuUrl.Add("Contact", "contact.php");

            for (int i = 0; i < menuUrl.Count; i++)
            {
                Console.WriteLine("<li><a href=\"{0}\">{1}</a></li>", menuUrl.Value[i], menuUrl.Key[i]);
            }

            Console.WriteLine("Menu Item ({0})", menuUrl.Count);

            Console.ReadKey();
        }
    }
}
