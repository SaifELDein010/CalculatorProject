

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

        static public string ReadText()
        {

            string text = "";
            text = Console.ReadLine();

            return text;

        }

        public static dynamic ReadNumber()
        {

            string stringNumber = Console.ReadLine();
            dynamic number = 0;

            while (!(int.TryParse(stringNumber, out int num1)) && !(double.TryParse(stringNumber, out double num2)))
            {

                Console.Write($"this is not vaild \"{stringNumber}\" number. Please, Enter vaild number > ");
                stringNumber = Console.ReadLine();

            }

            if((int.TryParse(stringNumber, out int i)))
            {
                number = Convert.ToInt32(stringNumber);
            }
            else
            {
                number = Convert.ToDouble(stringNumber);
            }

            return number;

        }

        public static dynamic ReadNumber(string message)
        {

            Console.Write(message);
            return ReadNumber();

        }

        static public bool IsNumber(string digit)
        {
            dynamic number = 0;
            if(!(int.TryParse(digit, out int numb1)) && !(double.TryParse(digit, out double num2)))
            {
                return false;
            }

            return true;

        }

        static public dynamic ReadNumberBetweenRange(string message, dynamic from, dynamic to)
        {

            dynamic number = ReadNumber(message);

            while(number < from || number > to)
            {

                Console.WriteLine("Number is out of range");
                number = ReadNumber(message);

            }

            return number;
        }


        static public char ReadLetter()
        {

            char letter = ' ';

            letter = Convert.ToChar(Console.ReadLine());

            return letter;

        }

        static public char ReadLetter(string message)
        {

            Console.Write(message);
            return ReadLetter();

        }


    }

}
