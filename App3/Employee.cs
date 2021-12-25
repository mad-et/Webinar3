using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Employee<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }

        //public Employee(T num, string name, int summa)
        //{
        //    Num = num;
        //    Name = name;
        //    Summa = summa;
        //}

        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите зп");
            Summa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
