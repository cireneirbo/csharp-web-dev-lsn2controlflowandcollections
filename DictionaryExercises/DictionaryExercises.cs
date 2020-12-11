using System;

namespace DictionaryExercises
{
    class DictionaryExercises
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID: ");
                    input = Console.ReadLine();
                    double id = double.Parse(input);
                    students.Add(newStudent, id);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<string, double> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                sum += student.Value;
            }
        }
    }
}


/*
 * Make a program similar to GradebookDictionary that does the following:

It takes in student names and ID numbers (as integers) instead of names and grades.
The keys should be the IDs and the values should be the names.
Modify the roster printing code accordingly.
 * */