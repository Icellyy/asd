using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задача1
            Edition journalist1 = new Edition();
            Console.WriteLine($"{journalist1.ToString()}\n");
            Edition journalist2 = new Edition("Известия", "Янишевский");
            Console.WriteLine($"{journalist2.ToString()}\n");
            Edition journalist3 = new Edition("Ведомости", "Томайлы", 2022);
            Console.WriteLine($"{journalist3.ToString()}\n");
            ///Задача2
            //Sortware sortware1 = new Sortware("Access","Microsoft","Бесплатно");
            //Console.WriteLine($"{sortware1.ShowInfo()}\n");
            //Sortware sortware2 = new Sortware("Word", "Microsoft", 159);
            //Console.WriteLine($"{sortware2.ShowInfo()}\n");
            //Sortware sortware3 = new Sortware("Excel", "Microsoft", 215, "Бесплатно");
            //Console.WriteLine($"{sortware3.ShowInfo()}\n");
            Console.Read();




        }
    }
}
