namespace Aula11
{
    public class Program
    {
        public static void Main()
        {
            //Ex1
            //int number = 1;

            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Number is 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Number is 2");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 1 or 2");
            //        break;
            //}

            //Ex2
            //bool boolValue = true;

            //switch (boolValue)
            //{
            //    case true:
            //        Console.WriteLine("O valor é true");
            //        break;
            //    case false:
            //        Console.WriteLine("O valor é false");
            //        break;

            //}

            //Ex3
            //Console.WriteLine("==========Dia da semana==============");
            //Console.WriteLine("Digite um numero de 1 a 7: ");
            //int dayOfWeek = int.Parse(Console.ReadLine());

            //switch (dayOfWeek) { 
            //     case 1:
            //        Console.WriteLine("O dia da semana é: Domingo");
            //        break;
            //      case 2:
            //        Console.WriteLine("O dia da semana é: Segunda-feira");
            //        break;
            //      case 3:
            //        Console.WriteLine("O dia da semana é: Terça-feira");
            //        break;
            //      case 4:
            //        Console.WriteLine("O dia da semana é: Quarta-feira");
            //        break;
            //      case 5:
            //        Console.WriteLine("O dia da semana é: Quinta-feira");
            //        break;
            //      case 6:
            //        Console.WriteLine("O dia da semana é: Sexta-feira");
            //        break;
            //      case 7:
            //        Console.WriteLine("O dia da semana é: Sabado");
            //        break;
            //      default:
            //        Console.WriteLine("Dia inválido. Por favor, digite um número de 1 a 7.");
            //        break;

            //}

            //ex4
            Console.WriteLine("=============Desempenho escolar==============");
            Console.WriteLine("Digite a nota: ");
            int score = int.Parse(Console.ReadLine());

            switch (score) { 
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("Desempenho: Excelente");
                    break;
                case int n when (n >= 80 && n < 90):
                    Console.WriteLine("Desempenho: Bom");
                    break;
                case int n when (n >= 70 && n < 80):
                    Console.WriteLine("Desempenho: Regular");
                    break;
                default:
                    Console.WriteLine("Desempenho: Insuficiente");
                    break;
            }


        }
    }
}