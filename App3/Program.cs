using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите числовой номер");
            //int numInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите имя");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите зп");
            //int summa = Convert.ToInt32(Console.ReadLine());
            //Employee<int> employee1 = new Employee<int>(numInt, name, summa);
            //Console.WriteLine(employee1.GetInfo());

            //Console.WriteLine("Введите строковый номер");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите имя");
            //name = Console.ReadLine();
            //Console.WriteLine("Введите зп");
            //summa = Convert.ToInt32(Console.ReadLine());
            //Employee<string> employee2 = new Employee<string>(numString, name, summa);
            //Console.WriteLine(employee1.GetInfo());

            Employee<int> employee1 = new Employee<int>();
            employee1.Input();
            Console.WriteLine(employee1.GetInfo());

            Employee<string> employee2 = new Employee<string>();
            employee2.Input();
            Console.WriteLine(employee2.GetInfo());

            Console.ReadKey();
        }
    }
}
