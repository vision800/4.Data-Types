using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vision";
            int age = 14;
            bool isTall = false;
            double weight = 25.5;
            Console.WriteLine("Hi " + name + " , you are " + age + " years old and your weght is " + weight);
            Console.WriteLine("True or False you are tall : " + isTall);
            //Freeze console
            Console.ReadLine();
        }
    }
}
