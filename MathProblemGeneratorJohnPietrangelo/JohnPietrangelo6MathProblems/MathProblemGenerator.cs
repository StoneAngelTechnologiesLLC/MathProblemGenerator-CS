//John Pietrangelo 9am CIS340
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPietrangelo6MathProblems
{
    class MathProblemGenerator
    {
        static void Main(string[] args)
        {
            bool entery = true;
            double number1, number2, correctAnswer, usersAnswer, average;
            double ptEarned = 0;
            double ptTotal = 0;
            int fn;
            int i = 0;
            Random number = new Random();
            string input = ("");
            string function = ("");
            string finalDecision = ("");
            
            do
            {   // Displays Application header.
                Console.WriteLine("\t\t   ** Math Problem **\n");
                
                // To iterate problem number 
                i++;

                // To generate and store random number and functions for problems.
                number1 = number.Next(1, 101);
                number2 = number.Next(1, 101);
                fn = number.Next(0, 4);

                // To calculate correct answers for math problems.
                switch (fn)
                {
                    case 0:
                        function = "+";
                        correctAnswer = number1 + number2;
                        break;
                    case 1:
                        function = "-";
                        correctAnswer = number1 - number2;
                        break;
                    case 2:
                        function = "*";
                        correctAnswer = number1 * number2;
                        break;
                    case 3:
                        function = "/";
                        correctAnswer = number1 / number2;
                        break;
                    default:
                        correctAnswer = 0;
                        break;
                }
              
                // Displays math problem.
                Console.Write("    Answer The Following Problem #{0}: {1} {2} {3} = ", i, number1, function, number2);
              
                // Gets answer from user.
                input = Console.ReadLine();
                input = input.Trim();
                
                // Converts users input from string to double data type.
                usersAnswer = Convert.ToDouble(input);

                // Adds points to both totals if answer is correct and displays totals & average of correct answers.
                if (Convert.ToInt32(input) == correctAnswer)
                {
                    ptEarned = ptEarned + 1;
                    ptTotal = ptTotal + 1;
                    average = ptEarned / ptTotal;
                    Console.WriteLine("\n\t\t  Correct, Great Job!!!\n");
                    Console.WriteLine("\n       Points Earned: {0}\t Out of Total Points Possible: {1}\n", ptEarned, ptTotal);
                    Console.WriteLine("  Avgerage Number of Questions Answered Correctly: {0:p}", average);
                }
                //Adds points only to possible point total. Displays correct answer, totals & average percentage of correct answers.
                else
                {
                    ptTotal = ptTotal + 1;
                    average = ptEarned / ptTotal;
                    Console.WriteLine("\n    Double check your math.  The correct answer is: {0}\n", correctAnswer);
                    Console.WriteLine("\n    Points Earned: {0}\t Out of Total Points Possible: {1}\n", ptEarned, ptTotal);
                    Console.WriteLine(" Avgerage Number of Questions Answered Correctly: {0:p}", average);
                }
                // Asks user if they would like another problem or to exit application.
                Console.Write("\n\n\n     Enter 'Q' to Quit or Any Other Key to Continue.");
                finalDecision = (Console.ReadLine().ToLower());

                if (finalDecision == "q")
                {
                    entery = false;
                }
                //To clear screen for each following problem that is requested.
                else
                {   
                    Console.Clear();
                }
            } while (entery);
        } 
    }
 }
