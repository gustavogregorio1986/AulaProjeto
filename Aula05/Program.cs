namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------Calculadora Bem simples-------------------");

            Console.WriteLine("Digite o numero 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());



            int sum = number1 + number2;
            int subtracao = number1 - number2;
            int multiplicacao = number1 * number2;
            int division = number2 / number1;
            int modulo = number2 % number1;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + subtracao);
            Console.WriteLine("O valor da multiplicação é: " + multiplicacao);
            Console.WriteLine("O valor da divisão é: " + division);
            Console.WriteLine("O resto da divisao é: " + modulo);

            Console.WriteLine(10 + 30);
        }
    }
}