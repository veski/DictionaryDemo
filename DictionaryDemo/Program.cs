using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakalar = new MyDictionary<int, string>();
            plakalar.Add(1, "Adana");
            Console.WriteLine("Adana ili eklendi");
            
            plakalar.Add(2, "Adıyaman");
            Console.WriteLine("Adıyaman ili eklendi");

            plakalar.List();

            

        }

    }
}
