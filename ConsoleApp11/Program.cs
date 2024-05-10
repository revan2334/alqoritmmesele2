using System.ComponentModel.Design;
using Microsoft.VisualBasic.FileIO;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task6
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    if (x % i == 0) 
            //    Console.WriteLine(i);


            //}
            #endregion
            #region task7
            //double x = double.Parse(Console.ReadLine());
            //for (double i = 10; i < 100; i++)
            //{

            //        Console.WriteLine(x/i);

            //}
            #endregion
            #region task8
            //int x=int.Parse(Console.ReadLine());
            //int s = 0;

            //if (x < 500)
            //{
            //    s = s + x * 5;
            //    Console.WriteLine(s);
            //}
            //else if (x > 499) 
            //{
            //    s = s + (499 * 5) + (x - 499) * 3;
            //    Console.WriteLine(s);
            //}
            #endregion
            #region task9(yarim)
            //int x=int.Parse(Console.ReadLine());
            //int s = 0;
            //for (int i = 0; i < 5; i++) 
            //{
            //    int q = x % 10;
            //}
            #endregion
            #region task13 error
            //int x = int.Parse(Console.ReadLine());
            //int s = 0;
            //while (x > 0) ;
            //{
            //    int q = x % 10;
            //    if (q == 0) 
            //    {
            //        s++;
            //        x = x / 10;

            //    }


            //}
            #endregion
            #region task12
            //int x = int.Parse(Console.ReadLine());
            //int q = x / 4;
            //int p = x % 4;
            //if (x % 4 == 0)
            //{
            //    Console.WriteLine($"{x}=4*{q}");
            //}
            //else if (x % 4 != 0) 
            //{
            //    Console.WriteLine($"{x}=4*{q}+{p}");
            //}
            #endregion
            int s = 1;
            for (int i = 1; i < 25; i += 3) 
            s = s * 2;
            {
               
                Console.WriteLine(s);
                
            }
            
        }
    }
}