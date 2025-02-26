
using CalculatorProject.utility;
using System;
using System.Runtime.CompilerServices;

namespace CalculatorProject.Servers
{
 
    class CommendLineLogic
    {

        static private int chooises = 0;

        static private void Clear()
        {

            // Clear prev answer 
            Console.Write("Will come soon, Press any key to turn mathematical calulator...");
            Console.ReadKey();

        }

        static private void Change()
        {

            // Change type of calculator
            Console.Write("Will come soon, Press any key to turn mathematical calulator...");
            Console.ReadKey();

        }


        static private void CommendLineScreen()
        {

            Console.WriteLine("\t\t\t\t    < Commend Line >\n\n");

            Console.WriteLine("[1] Clear     (Clear result value)");
            Console.WriteLine("[2] Change    (Change Type of calculator)");
            Console.WriteLine("[3] End       (Close Application)");

            Console.WriteLine("------------------------");

            chooises = ReadInput.ReadNumberBetweenRange("Enter your chooise: ", 1, 3);

        }

        static private void PerformChooise(ref bool closeApp) { 
        
            switch(chooises)
            {

                case 1:
                    Clear();
                    break;

                case 2:
                    Change();
                    break;

                case 3:
                    closeApp = true;
                    break;

            }
          
        
        }


        static public void CommendLine(ref bool closeApp) {

            Console.Clear();
            CommendLineScreen();

            PerformChooise(ref closeApp);

        }


    }

    class EpressionLogic
    {

        static private dynamic number1 = 0;
        static private dynamic number2 = 0;
        static private char operator_ = '+';


        static private dynamic HandelDivision()
        {

            if(number2 == 0)
            {

                Console.WriteLine("Undefiend");
                return 0;

            }

            return number1 / number2;

        }

        static private dynamic PerformExpression()
        {

            switch(operator_)
            {

                case '+':
                    return number1 + number2;

                case '-':
                    return number1 - number2;

                case '*':
                    return number1 * number2;

                case '/':
                    return HandelDivision();

                default:
                    Console.WriteLine("Invaild operator");
                    return -1;

            }

        }

        static private void GetInputFromUser()
        {

            number1 = ReadInput.ReadNumber("(Number 1) > ");
            operator_ = ReadInput.ReadLetter("(Operator) > "); 
            number2 = ReadInput.ReadNumber("(Number 2) > ");

        }


        static public void ExpressionStatament()
        {

            GetInputFromUser();
            Console.WriteLine($"\n{number1} {operator_} {number2} = {PerformExpression()}");

            Console.Write("\nPress any key...");
            Console.ReadKey();

        }

    }

    class MathematicalLogic
    {

        static public bool PerformStatament(string statament, ref bool closeApp)
        {

            string text = statament.ToLower();

            if (text.Equals("commend"))
            {

                CommendLineLogic.CommendLine(ref closeApp);
                return true;

            } else if(text.Equals("expression"))
            {

                EpressionLogic.ExpressionStatament();
                return true;

            }


            return false;

        }


    }

}
