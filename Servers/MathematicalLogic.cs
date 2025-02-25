
using CalculatorProject.utility;

namespace CalculatorProject.Servers
{
 
    
    class CommendLineLogic
    {

        static private int chooises = 0;

        static private void Clear()
        {

            // Clear prev answer 
            Console.Write("Press any key to turn mathematical calulator...");
            Console.ReadKey();

        }

        static private void Change()
        {

            // Change type of calculator
            Console.Write("Press any key to turn mathematical calulator...");
            Console.ReadKey();

        }

        static private void End(ref bool closeApp) { 
        
            closeApp = true; 
        
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
                    End(ref closeApp);
                    break;

            }
          
        
        }


        static public void CommendLine(ref bool closeApp) {

            Console.Clear();
            CommendLineScreen();

            PerformChooise(ref closeApp);

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

            } 


            return false;

        }


    }


}
