using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
             Реализовать класс, в котором указанные значения представлены в виде свойств.
             Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки начальных значений, 
             а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
            Console.WriteLine("Введите значение угла");
            Console.Write("Градусы: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus,min,sec);
            angle.ToRadians();
            Console.ReadKey();
        }
    }

    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value<360)
                {
                    if(value>=0)
                    {
                        gradus = value;
                    }
                    else
                    {
                        int temp = value;
                        do
                        {
                            temp += 360;
                        }
                        while (temp < 0);
                        gradus = temp;
                    }
                }
                else
                {
                    int temp = value;
                    do
                    {
                        temp -= 360;
                    }
                    while (temp > 360);
                    gradus = temp;
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value>=0)
                {
                    if (value<60)
                    {
                        min = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение минут должно находится в диапазоне от 0 до 59. По умолчанию принято 0");
                    }
                }
                else
                {
                    Console.WriteLine("Значение минут должно находится в диапазоне от 0 до 59. По умолчанию принято 0");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0)
                {
                    if (value < 60)
                    {
                        sec = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение секунд должно находится в диапазоне от 0 до 59. По умолчанию принято 0");
                    }
                }
                else
                {
                    Console.WriteLine("Значение секунд должно находится в диапазоне от 0 до 59. По умолчанию принято 0");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle (int gradus=0, int min=0, int sec=0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            double radian = (gradus * 3600 + min * 60 + sec)*Math.PI / 648000;
            Console.WriteLine("Угол в радианах составляет {0}",radian);
        }
    }
}
