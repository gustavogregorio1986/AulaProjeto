namespace Aula16
{
    public class Program
    {
        public static void Main()
        {
            string separator = "---------------------";

            //1. Declãração de Array
            string[] fruits = { "Maçã", "Banana", "Caju", "Manga" };

            Console.WriteLine(separator);

            //2. Acessar os valores
            Console.WriteLine(fruits[1]);

            Console.WriteLine(fruits[0]);

            Console.WriteLine(separator);

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //3. Contagem de Índices
            Console.WriteLine("Quantidade de Índices: " + fruits.Length);

            //4. Alterar os valores
            Console.WriteLine(separator);
            fruits[1] = "Abacaxi";

            Console.WriteLine(fruits[1]);

            //5. Declaração sem inicalizar

            int[] numbers = new int[4];

            Console.WriteLine(separator);

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}