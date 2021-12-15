using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол, состоящий из целочисленнных значений в диапазоне: градусы(0-360), минуты(0-60), секунды(0-60)");
            Console.Write(" угловой градус = ");
            int Input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" минуты = ");
            int Input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" секунды = ");
            int Input3 = Convert.ToInt32(Console.ReadLine());
            Test newtest = new Test(Input1, Input2, Input3);
            newtest.Toradian(Input1, Input2, Input3);
            Console.WriteLine(" радианы = {0}", newtest.toradian);
            Console.ReadKey();
        }

        class Test
        {
            private int grad;
            private int min;
            public int sek;
            public double toradian;

            public int Grad
            {
                get
                {
                    return grad;
                }
                set
                {
                    if (value < 0 || value > 360)
                    {
                        Console.WriteLine("Ошибка ввода данных!Угловые градусы - диапазон 0-360");

                    }
                    else
                    {
                        grad = value;
                    }
                }
            }
            public int Min

            {
                get
                {
                    return min;
                }
                set
                {
                    if (value < 0 || value > 60)
                    {
                        Console.WriteLine("Ошибка ввода данных!Угловые минуты - диапазон 0-60");

                    }
                    else
                    {
                        min = value;
                    }
                }
            }
            public int Sek

            {
                get
                {
                    return sek;
                }
                set
                {
                    if (value < 0 || value > 60)
                    {
                        Console.WriteLine("Ошибка ввода данных!Угловые секунды - диапазон 0-60");

                    }
                    else
                    {
                        sek = value;
                    }
                }
            }
            public Test(int grad, int min, int sek)
            {
                this.Grad = grad;
                this.Min = min;
                this.Sek = sek;
            }
            public void Toradian(int grad, int min, int sek)
            {
              toradian = (grad + (min / 60) + (sek/3600))* (Math.PI/180);       
            }
        }
    }

}

    
                    
           