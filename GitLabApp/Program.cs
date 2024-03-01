using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение параметра x: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 2 * Math.Cos(x);
            Console.WriteLine($"значение F= {F}.");
            Console.ReadLine();
            
        }
    }
}
