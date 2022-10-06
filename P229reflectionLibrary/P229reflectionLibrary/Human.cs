using System;
using System.Collections.Generic;
using System.Text;

namespace P229reflectionLibrary
{
    class Human
    {
        static int _count;
        string Name;
        string SurName;
        byte Age { get; set; }

        void ShowInfo(string str)
        {
            Console.WriteLine($"P229 Hello World {str}");
        }
    }
}
