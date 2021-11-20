using System;

namespace ClassWork8_Console
{
    class Program
    {
        static void ForeachTest()
        {
            int size = 3;
            int[,] array = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            int count = 0;
            int jLength = array.GetLength(1);
            foreach (var item in array)
            {
                System.Console.Write(item + " ");
                if (++count % jLength == 0)
                {
                    System.Console.WriteLine();
                }
            }
        }

        static void ReturnTest()
        {
            Console.WriteLine(1);
            return;
            Console.WriteLine(2);

            Console.WriteLine(3);
        }

        static void TryParseWithIf()
        {
            if(!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Bad input!");
                return;
            }

            //StreamWritter.WriteLine(a);
        }

        static void Finally()
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (b != 0)
                {
                    int c = a / b;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Finally called!");
            }
        }

        /// <summary>
        /// Calculate square equation values with coeficients
        /// </summary>
        /// <param name="a">Should not be equal to zero</param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Roots of equation</returns>
        /// <exception cref="DivideByZeroException"/>
        /// <exception cref="ArgumentException"/>
        static (double x1, double x2) SquareEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if(a == 0)
            {
                throw new DivideByZeroException("A is equal to zero!");
            }
            if(d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return (x1, x2);
            }
            else if(d == 0)
            {
                double x1 = -b / (2 * a);
                return (x1, x1);
            }
            else
            {
                throw new ArgumentException("D is lower than zero!");
            }
        }

        static void MainForSquareEquation()
        {
            try
            {
                SquareEquation(0, 2, 3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            SquareEquation(1, 2, 3);
        }
    }
}
