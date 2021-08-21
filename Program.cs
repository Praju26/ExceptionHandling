using System;

namespace ExceptionHandling
{
    class Program
    {
            static void Main()
            {
            //Any number devide by zero
                int a = 20;
                int b = 0;
                int c;
            Console.WriteLine("A VALUE = " + a);
                Console.WriteLine("B VALUE = " + b);
                  c = a / b;
                Console.WriteLine("Error in Program , any number can not be divisible by 0" );
                Console.ReadLine();

            // int[ ]arr = {1}; arr[1]=100;

         
                // Declare an array of max index 4
                int[] arr = { 1 };

                // Display values of array elements
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                try
                {
                    Console.WriteLine(arr[7]);
                }
                catch (IndexOutOfRangeException Length)
                {
                    Console.WriteLine("An Exception has occurred : {0}", Length.Message);
                }
            }

        }
        
    }


