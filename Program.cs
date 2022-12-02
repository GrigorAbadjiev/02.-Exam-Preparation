using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxBadGradesCount = int.Parse(Console.ReadLine());
            int currentBadGradesCount = 0;
            string LastProblemName = "";
            int solvedProblems = 0;
            int gradesSum = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Enough")
                {
                    break;
                }

                LastProblemName = command;
                solvedProblems++;
                int grade = int.Parse(Console.ReadLine());
                gradesSum += grade;
               
                if (grade <= 4)
                {
                    currentBadGradesCount++;
                }

                if (maxBadGradesCount == currentBadGradesCount)
                {
                    break;
                }
            }

            if (maxBadGradesCount == currentBadGradesCount)
            {
                Console.WriteLine($"You need a break, {currentBadGradesCount} poor grades.");
            }
            else
            {
                double averageGrade = gradesSum * 1.0 / solvedProblems;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {LastProblemName}");
            }
        }
    } 
}
