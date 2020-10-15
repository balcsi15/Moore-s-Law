using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moores_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            float j = 0;
            Console.WriteLine("Introduceti cresterea puteri de calcul dorite:");
            n = int.Parse(Console.ReadLine());

            while (i < n)
            {

                i = i * 2;
                j = j + 2;
            }

            j = j + (j / 2);
            j = j / 2;
            Console.WriteLine("Timpul necesar este:" + " " + j + " " + "ani");
            Console.ReadLine();
        }
    }
}
