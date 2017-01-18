//John Pietrangelo 9am CIS340
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPietrangelo6MathProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = true;
            //string input = Console.ReadLine();
            double number1;
            double number2;
            Random number = new Random();
            Random random = new Random();
            
            Console.WriteLine("\t **Math Problem**");

            int i = 0;
            while(correct)

            {
                i++;
                number1 = number.Next(1,101);
                number2 = number.Next(1,101);
                char[] operators = { '+', '-', '*', '/' };
                int randomOperator = random.Next(operators.Length);
                char op = operators[randomOperator];
                Console.Write("Answer The Folowing Problem#{3}: {0} {1} {2} = ",number1,op,number2,i);
                string input = Console.ReadLine();
                input = input.Trim();
                double answer = Convert.ToDouble(input);
                double correctAnswer;
                int ptEarned = 0;
                int ptTotal = 0;
                
                
                switch (op)
                {
                    case '+':
                        correctAnswer = number1 + number2;
                        break;

                    case '-':
                        correctAnswer = number1 - number2;
                        break;
                    case '*':
                        correctAnswer = number1 * number2;
                        break;
                    case '/':
                        correctAnswer = number1 / number2;
                        break;
                }
                if (randomOperator == 0 && number1 + number2 == answer)

                    Console.WriteLine("points Earned:{0}\t Point Total{1}\t avg{2:p}",(ptEarned + 1),(ptTotal + 1), (ptEarned/ptTotal));
                else if (randomOperator == 1 && number1 - number2 == answer)
                    Console.WriteLine("points Earned:{0}\t Point Total{1}\tavg{2:p}", (ptEarned + 1), (ptTotal + 1), (ptEarned / ptTotal));
                else if (randomOperator == 2 && number1 * number2 == answer)
                    Console.WriteLine("points Earned:{0}\t Point Total{1}\tavg{2:p}", (ptEarned + 1), (ptTotal + 1),(ptEarned / ptTotal));
                else if (randomOperator == 3 && number2 != 0 && number1 / number2 == answer)
                    Console.WriteLine("points Earned:{0}\t Point Total{1}\tavg{2:p}", (ptEarned + 1), (ptTotal + 1), (ptEarned / ptTotal));
                else
                    Console.WriteLine("points Earned:{0}\t Point Total{1}\t{2:p}", (ptEarned), (ptTotal + 1), (ptEarned / ptTotal));
            }
            Console.Clear();
           // while (correct)
            {
               /* number1 = number.Next(1,101);
                number2 = number.Next(1,101);
                

                Console.Write("Answer The Folowing Problem: {0} + {1} = ",number1,number2);
                input = Console.ReadLine();
                input = input.Trim();

                if (input.Length == 0 || input.Length > 3)
                {
                    correct= false;
                    Console.WriteLine("Wrong entery, too short or too long of an entery");
                }
                else if (input != answer.ToString())
                {
                    correct = false;
                    Console.WriteLine("False");
                }
                else
                * */

                    Console.WriteLine("correct");

            }
           

            Console.ReadLine();
        }
    }
}
