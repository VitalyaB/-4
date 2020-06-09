using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4
{
    class Health
    {
        private int temp;
        public int Temp
        {
            get
            {
                return temp;
            }
            set
            {
                if (value < 34)
                    temp = 34;
                else if (value > 41)
                    temp = 41;
                else temp = value;
            }
        }
    }
    class Book
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1940)
                    year = 1940;
                else if (value > 2020)
                    year = 2020;
                else year = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Health h1 = new Health();
            Console.Write("Введите температуру: ");
            h1.Temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Температура равна " + h1.Temp);
            Console.WriteLine();

            Book b1 = new Book();
            Console.Write("Введите год выпуска: ");
            b1.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Год выпуска равен " + b1.Year);
            Console.ReadKey();
        }
    }
}
