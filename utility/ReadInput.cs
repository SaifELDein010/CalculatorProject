

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorProject.utility
{
    
    class ReadInput
    {


        static public string ReadText(string message)
        {

            string text = "";

            Console.Write(message);
            text = Console.ReadLine();

            return text;

        }


        static public int ReadNumber(string message)
        {

            Console.Write(message);
            string stringNumber = Console.ReadLine();
            int number = 0;

            while (!(int.TryParse(stringNumber, out number)))
            {

                Console.Write($"this is not vaild \"{stringNumber}\" number. Please, Enter vaild number > ");
                stringNumber = Console.ReadLine();

            }

            number = Convert.ToInt32(stringNumber);

            return number;

        }


        static public bool IsNumber(string digit)
        {
            int number = 0;
            if(!(int.TryParse(digit, out number)))
            {
                return false;
            }

            return true;

        }



    }

}
