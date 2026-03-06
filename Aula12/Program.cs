namespace Aula11
{
    public class Program
    {
        public static void Main()
        {
            //int i = 0;

            //while (i < 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            double budget = 100;

            while (budget > 0)
            {
                Console.WriteLine(budget);
                budget--;
            }

            Console.WriteLine("Atenção! Saldo Insuficiente");
        }
    }
}