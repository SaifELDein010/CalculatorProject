
using CalculatorProject.UI;

namespace CalculatorProject
{
    class Program
    {
        static void Main()
        {

            bool closeApp = false;

            do
            {

                closeApp = MathematicalDesignScreen.MathematicalCalculatorScreen();

            } while (!closeApp);


            Console.ReadKey();

        }
    }

}
