using System;

namespace StringExercises
{
    class StringExercises
    {
        static void Main(string[] args)
        {
            string poem = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] splitPoem = poem.Split(".");

            foreach (string sentence in splitPoem)
            {
                if (sentence != "")
                {
                    Console.WriteLine(sentence.Trim() + ".");
                }
                
            }
            
        }
    }
}

/*
 For this exercise, create a string for the value:

I would not, could not, in a box. I would not, could not with a fox.
I will not eat them in a house. I will not eat them with a mouse.

Use the Split method to divide the string at each space and store the individual words in an array. If you need to review the method syntax, look back at the string methods table.

Print the array of words to verify that your code works. The syntax is:

Console.WriteLine(string.Join(",", arrayName)); //nahhhhh
Repeat steps 2 and 3, but change the delimiter to split the string into separate sentences.
 */
