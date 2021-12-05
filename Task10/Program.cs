using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner corner = new Corner(120, 45, 10); //создаем экземпляр класса(объект угол), вызываем конструктор с 3 значениями (градусы, минуты, секунды)
            corner.Resault(); //вывод метода Resault - запись информации об угле
            corner.ToRadians(); //вывод метода ToRadians - перевод угла в радианы
            Console.ReadKey();
        }
    }

    class Corner //объявление класса
    {
        int gradus; //поле
        int min; //поле
        int sec; //поле

        public int Gradus //свойство для градусов
        {
            set
            {
                if (value > 0 && value < 360) //условие корректного ввода значения
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градусов не может быть меньше 0 и больше 360");
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min //свойство для минут
        {
            set
            {
                if (value > 0 && value < 60)  //условие корректного ввода значения
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут не может быть меньше 0 и больше 60");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec //свойство для секунд
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение не может быть меньше 0 и больше 60");
                }
            }
            get
            {
                return sec;
            }

        }

        public Corner(int gradus, int min, int sec) //конструктор (аргументы для начальной инициализация полей)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void Resault() //метод
        {
            Console.WriteLine("Угол равен {0}градусов {1} минут {2} секунд", Gradus, Min, Sec);
        }
        public double ToRadians() //метод
        {
            double rad = (Gradus + Min / 60 + Sec / 3600) * Math.PI / 180;
            Console.WriteLine("Угол равен {0:f2} радиан", rad);
            return rad;
        }
    }
}
        
    

