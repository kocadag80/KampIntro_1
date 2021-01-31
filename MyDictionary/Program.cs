using System;
using System.Collections.Generic;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryList<string> sozcukler = new DictionaryList<string>();
           
            sozcukler.Add("Dizi");

            Console.WriteLine(sozcukler.Length);

            sozcukler.Add("Veri");
            
            Console.WriteLine(sozcukler.Length);
            
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");

        }
    }
}
