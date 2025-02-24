using System;


namespace CalculatorProject.UI
{
    public class MathematicalDesignScreen
    {

        static private void ErrorMessage()
        {

            Console.Write("Wronge Commed/expression. Enter vaild Commed/expression >> ");

        }
        static private void HeaderScreen()
        {

            Console.WriteLine("\t\t\t\t    < Mathematical Calculator >\n\n");

        }

        static private void ExplainScreen()
        {

            Console.WriteLine("To perform Commend line screen write \"Commend\" without quote");
            Console.WriteLine("To perform expression write your expression (Number1) (Operator) (Number2) Then press Enter\n");

        }




        static public void MathematicalCalculatorScreen()
        {

            HeaderScreen();
            ExplainScreen();

            Console.Write("  Enter \"Commend\" or Expression statement \n  >> ");

        }

    }
}

