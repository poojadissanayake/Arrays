using System;
using System.Threading.Tasks.Dataflow;
using SplashKitSDK;
#nullable disable

namespace Arrays
{
    public class Program
    {
        public static void Main()
        {
            int numberOfValues = ReadInteger("Enter the array length: ");

            double[] values = new double[numberOfValues];
            double sum = 0;

            for(int i = 0; i< numberOfValues; i++){
                values[i] = ReadDouble($"Enter the {i+1}th value: ");
            }

            for(int i = 0; i < values.Length; i++){
                Console.WriteLine($"Array index {i} : {values[i]}");
            }

            for(int i = 0; i < values.Length; i++){
                sum += values[i];
            }
            Console.WriteLine("\n Sum: "+sum);

        }

        public static int ReadInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }

        }

        public static double ReadDouble(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid value");
                }
            }

        }

    }
}
