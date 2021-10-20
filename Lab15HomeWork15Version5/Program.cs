using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15HomeWork15Version5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Установите первое число арифмитической прогрессии = ");
            int ap1 = Convert.ToInt32(Console.ReadLine());

            ArithProgession arith = new ArithProgession();
            arith.setStart(ap1);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее значение = " + arith.getNext());
            }
            Console.WriteLine("\nВыполняем сбросс к начальному значению.");
            arith.reset();

            Console.Write("\nЗаново установите первое число арифмитической прогрессии =");
            int ap2 = Convert.ToInt32(Console.ReadLine());
            arith.setStart(ap2);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее значение = " + arith.getNext());
            }

            Console.Write("\nУстановите первое число геометрической прогрессии = ");
            int gp1 = Convert.ToInt32(Console.ReadLine());
            GeomProgression geom = new GeomProgression();
            geom.setStart(gp1);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее значение = " + geom.getNext());
            }
            Console.WriteLine("\nВыполняем сбросс к начальному значению.");
            geom.reset();
            Console.Write("\nЗаново установите первое число геометрической прогрессии = ");
            int gp2 = Convert.ToInt32(Console.ReadLine());
            geom.setStart(gp2);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее значение = " + geom.getNext());
            }

            Console.ReadLine();

        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgession : ISeries
    {
        int first;
        int second;

        public ArithProgession()
        {
            first = 0;
            second = 0;
        }
        public int getNext()
        {
            second += 2;
            return second;
        }
        public void reset()
        {
            second = first;
        }
        public void setStart(int x)
        {
            first = x;
            second = first;
        }
    }
    class GeomProgression : ISeries
    {
        private int first;
        private int second;

        public int First
        {
            set
            {
                if (value != 0)
                {
                    first = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Первый член геометрической последовательности не может быть равен 0 !");
                    Console.WriteLine("Принимаем по умолчанию первый член геометрической последовательности = 1");
                    first = 1;
                }
            }
            get
            {
                return first;
            }
        }
        public int Second
        {
            set
            {
                if (value != 0)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Первый член геометрической последовательности не может быть равен 0 !");
                    Console.WriteLine("Принимаем по умолчанию первый член геометрической последовательности = 1");
                    second = 1;
                }
            }
            get
            {
                return second;
            }
        }
        public GeomProgression()
        {
            first = 1;
            second = 1;
        }
        public int getNext()
        {
            second *= 2;
            return second;
        }
        public void reset()
        {
            second = first;
        }
        public void setStart(int x)
        {
            First = x;
            Second = First;
        }
    }

}
