using System;
using CalculatorProject.Servers;
using CalculatorProject.utility;


namespace CalculatorProject.UI
{
    public class MathematicalDesignScreen
    {

        static private void ErrorMessage()
        {

            Console.Write("\nInvaild Input, Enter \"Commend\" or \"Expression\" >> ");

        }

        static private void HeaderScreen()
        {

            Console.WriteLine("\t\t\t\t    < Mathematical Calculator >\n\n");

        }

        static private void ExplainScreen()
        {

            Console.WriteLine("To perform Commend line write \"Commend\" without quote");
            Console.WriteLine("To perform expression write \"Expression\" without quote\n");

        }




        static public bool MathematicalCalculatorScreen()
        {

            Console.Clear();

            HeaderScreen();
            ExplainScreen();



            bool isVaild = false;
            bool closeApp = false;

            string inputText = ReadInput.ReadText(" Enter \"Commend\" or \"Expression\" \n >> ");
            isVaild = MathematicalLogic.PerformStatament(inputText, ref closeApp);

            while(!isVaild)
            {

                ErrorMessage();
                inputText = ReadInput.ReadText();
                isVaild = MathematicalLogic.PerformStatament(inputText, ref closeApp);

            }



            return closeApp;

        }

    }
}

