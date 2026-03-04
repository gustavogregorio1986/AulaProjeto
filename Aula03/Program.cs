namespace Aula03
{
    public class Program
    {
        public static void Main()
        {
            int number = 30;

            number = 20;

            Console.WriteLine("O valor antigo da variável é: " + number);

            number = 10;

            Console.WriteLine(number);

            Console.WriteLine("O valor novo da variável é: " + number);

            string name = "Antonio";

            name = "Antonio Rocha";

            Console.WriteLine(name);

            const int number1 = 1000;

            Console.WriteLine(number1);

            Console.WriteLine("O valor da constantel é: " + number1);

            string variable = "None";

            Console.WriteLine("O valor da variável é: " + variable);

            dynamic variable1 = 30;

            variable1 = "Antonio";

            Console.WriteLine(variable1);
        }
    }
}