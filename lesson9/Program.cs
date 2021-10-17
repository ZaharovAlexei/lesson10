using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Филя","черный",6);
            cat.Say();
            Console.ReadKey();
        }
    }
    class Cat
    {
        string Name { get; set; }
        string Color { get; set; }
        int age;

        public int Age
        {
            set
            {
                if (value>0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст не может быть отрицательным");
                }
            }
            get
            {
                return age;
            }

        }

        public Cat (string name, string color="серый", int age=1)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public void Say()
        {
            Console.WriteLine("Мяу. Меня зовут {0}. У меня {1} цвет. Мне {2} лет.", Name, Color, Age);
        }
    }
}
