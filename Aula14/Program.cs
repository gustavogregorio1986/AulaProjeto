namespace Aula14
{
    public class Program
    {
        public static void Main()
        {
            /*
            
             for(condicao 1; condicao 2; condicao 3)
             {
                  //code que será executado
             }

              Declaração 1 é executada (uma vez) antes da execução de bloco de código

              Declaração 2 define a condição para executar o bloco do código

             Declaração  3 é executada (todas aqs vezes) após o bloco do codgio ter sido executadç

             */

            //Ex1
            for(int i  = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Ex2
            Console.WriteLine("========Tabela de multiplicação============");
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,10}");
                }
                Console.WriteLine();
            }
        }
    }
}