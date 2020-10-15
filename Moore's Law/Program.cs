using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_s_Law
{
    class Program
    {
        public static void Main(string[] args)
        {
            int  i = 1, n;
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
}         //Luam doua variabile "j" va fi numarul de ani iar "i" va numere de cate ori a crescut puterea de calcul.
          //Crestem prin while puterea de calcul pana ajungem la numarul dorit, iar intre timp numaram cati ani o sa treaca.
          //La final vom avea in "j" numarul anilor necesari daca puterea de calcul se dubleaza in fiecare 2 ani si dupa cu o ecuatie matematica calculam cat timp ne trebuie daca puterea creste din 18-18 luni.
