namespace Aula10
{
    public class Program
    {
        public static void Main()
        {
            bool continuar;

            do
            {
                Console.WriteLine("============Calculadora Simples===============");
                Console.WriteLine("Digite o primeiro numero: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                //Selecionar o tipo de operação
                Console.WriteLine("\nEscolha uma opção: ");
                Console.WriteLine("1 - Adição (+)");
                Console.WriteLine("2 - Subtração (-)");
                Console.WriteLine("3 - Multiplicação (*)");
                Console.WriteLine("4 - Divisão (/)");
                Console.WriteLine("Digite o numero da operação");
                int operaqtion = Convert.ToInt32(Console.ReadLine());

                //Condições
                if (operaqtion == 1)
                {
                    Console.WriteLine($"O resultado da adição é: {num1 + num2}");
                }
                else if (operaqtion == 2)
                {
                    Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
                }
                else if (operaqtion == 3)
                {
                    Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}");
                }
                else if (operaqtion == 4)
                {
                    if (num2 != 0)
                    {
                        Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma operação válida.");
                }

                // Perguntar se deseja repetir
                Console.WriteLine("\nDeseja realizar outra operação? (s/n)");
                string resposta = Console.ReadLine().ToLower();
                continuar = (resposta == "s");

            } while (continuar);

            Console.WriteLine("Programa encerrado. Obrigado por usar a calculadora!");
        }
    }
}