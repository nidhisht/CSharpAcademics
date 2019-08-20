using System;
using System.Text;

namespace BubbleSort
{
    /*
     Sample Inputs:

     int[] numbers = { 5, 1, 4, 2, 8 };
     int[] numbers = { 100, 15, 11, 12, 10, -1, 0 };
     int[] numbers = { 9,8,7,6,5,4,3,2,1,0};
     int[] numbers = { 9, 8, 7, 6, 675, 4, 3, 2, 1, 0 };
     int[] numbers = { 5,8,10,4,14,2,7,19,1,20};
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 89,76, 45, 92, 67,12, 99 };
            int temp;

            PrintNumbers("Before Bubble sort", numbers);

            for (int i=0; i<numbers.Length -1; i ++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }            

            PrintNumbers("After Bubble sort", numbers);
            Console.Read();
        }

        private static void PrintNumbers(string message, int[] numbers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int number in numbers)
            {
                stringBuilder.Append(number);
                stringBuilder.Append(" ");
            }
            Console.WriteLine(message + ":" + stringBuilder.ToString());
        }
    }
}
