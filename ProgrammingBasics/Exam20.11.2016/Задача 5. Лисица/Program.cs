using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5.Лисица
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var Out = 1;
            var In = 2 * n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', Out));
                Console.Write("\\");
                Console.Write(new string('-', In));
                Console.Write("/");
                Console.WriteLine(new string('*', Out));
                Out++;
                In = In - 2;
            }
            Out = n / 2;
            In = n;
            for (int i = 1; i <= n / 3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', Out));
                Console.Write("\\");
                Console.Write(new string('*', In));
                Console.Write("/");
                Console.Write(new string('*', Out));
                Console.WriteLine("|");
                Out++;
                In = In - 2;
            }
            Out = 1;
            In = 2 * n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', Out));
                Console.Write("\\");
                Console.Write(new string('*', In));
                Console.Write("/");
                Console.WriteLine(new string('-', Out));
                Out++;
                In = In - 2;
            }
        }
    }
}
