using System;
using System.Collections.Generic;

namespace ListExercises
{
    class ListExercises
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i*3);
            }

            string poem = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> words = new List<string>();

            string[] poemArray = poem.Split(" ");
            foreach(string word in poemArray)
            {
                words.Add(word);
            }


            static string findEvenNumbers(List<int> numbersList)
            {
                int sum = 0;
                foreach(int number in numbersList)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }
                }

                return sum.ToString();
            }

            static string findWords(List<string> wordsList)
            {
                List<string> words = new List<string>();
                Console.Write("Please enter and integer: ");
                string input = Console.ReadLine();
                int queryLength = int.Parse(input);

                foreach (string word in wordsList)
                {
                    char[] charArray = word.ToCharArray();
                    int wordLength = 0;
                    foreach(char letter in charArray)
                    {
                        if (letter != '.' && letter != ',')
                        {
                            wordLength += 1;
                        }
                    }

                    if (wordLength == queryLength)
                    {
                        words.Add(word);
                        Console.WriteLine(word);
                    }
                }
                return words.ToString();

              
            }

            Console.WriteLine(findEvenNumbers(numbers));
            Console.WriteLine();
            findWords(words);
        }
    }
}

    
/*
Write a static method to find the sum of all the even numbers in a List.
Within Main, create a list with at least 10 integers and call your method on the list.
Write a static method to print out each word in a list that has exactly 5 letters.
Modify your code to prompt the user to enter the word length for the search. 
 */