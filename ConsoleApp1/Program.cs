using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static double Quotient(double numerator, double denumerator)
        {
            if (numerator == 0)
            {
                throw new ArgumentException();
            }
            if (denumerator == 0)
            {
                throw new ArgumentNullException();
            }
            return numerator / denumerator;
        }
        private static void FirstTarget()
        {
            try
            {
                Console.WriteLine(Quotient(5, 0));
            }
            catch (ArgumentNullException excpt)
            {
                Console.WriteLine("Error: " + excpt.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            Console.ReadLine();
            Console.Clear();
        }


        private static void SecondTarget()
        {
            Random randomizer = new Random();
            const int solidSize = 5;
            int[] Size = new int [solidSize];
            for (int i = 0, i< solidSize; i++)
            {
                Size[i] = randomizer.Next();
                Console.WriteLine(Size[i]);
            }

            Console.Write("Please, write a index in size:");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Error, Please write a corect variable:");
                Console.Clear();
            }
            try
            {
                Console.WriteLine(Size[index]); 
            }
            catch(IndexOutOfRangeException excpt)
            {
                Console.WriteLine("Error:" + excpt.Message);
            }
            finally
            {
                Console.WriteLine("Congratulations! Processing completed!");
                Console.Clear();
            }
        }
             
        static void Main(string[] args)
        {

        }
    }
}
