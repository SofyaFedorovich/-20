using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_20
{//Делегаты, лямбды, события
    class Program
    {
        delegate double RadiusDelegate(double r); //объявление делегата
        static void Main(string[] args)
        {
            Console.Write("Введите радиус, в мм R=");
            double r = Convert.ToDouble(Console.ReadLine());

            RadiusDelegate circumferenceDelegate = Circumference;
            if (circumferenceDelegate != null)
            {
                Console.WriteLine("Длина окружности заданного радиуса R={0}мм равна {1:F1}мм", r, circumferenceDelegate(r));
            }

            RadiusDelegate areaDelegate = Area;
            if (areaDelegate != null)
            {
                Console.WriteLine("Площадь круга заданного радиуса R={0}мм равна {1:F2}мм2", r, areaDelegate(r));
            }

            RadiusDelegate volumeDelegate = Volume;
            if (volumeDelegate != null)
            {
                Console.WriteLine("Объём шара радиуса заданного радиуса R={0}мм равен {1:F2}мм3", r, volumeDelegate(r));
            }
            Console.ReadKey();
        }

        static double Circumference(double r) //статический метод для вычисления длины окружности
        {
            double result = 2 * Math.PI * r;
            return result;
        }
        static double Area(double r) // статический метод для вычисления площади круга
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double Volume(double r) //статический метод для вычисления объема шара
        {
            return (4 / 3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
