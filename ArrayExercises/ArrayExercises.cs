using System;

namespace ArrayExercises
{
    class ArrayExercises
    {
        static void Main(string[] args)
        {
            int arrayLength = 6;
            int[] numbers = { 1, 1, 2, 3, 5, 8 };
            
            for(int i = 0; i < arrayLength; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }
        }
    }
}



/*
 * Create and initialize an array with the following values in a single line:

1, 1, 2, 3, 5, 8
Loop through the array and print out each value.

Modify the loop to only print the odd numbers from the array
 * 
 */