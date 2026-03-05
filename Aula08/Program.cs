namespace Aula08
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==============Operações Relacionais=============");
            Console.WriteLine("Digite o primeiro numero(x): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero(y): ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //Operadors de Igualdade (==)
            if(x == y)
            {
                result = "x é igual a y.";
            }
            else
            {
                result = "x diferente a y.";
            }

            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de Diferença (!=)
            if(x != y)
            {
                result = "x diferente a y.";
            }
            else
            {
                result = "x é igual a y.";
            }

            Console.WriteLine("\nDiferença (!=): " + result);

            //Opreador amiro que (>)
            if(x > y)
            {
                result = "x é maior que y.";
            }
            else
            {
                result = "x não é maior que y.";
            }

            Console.WriteLine("\nMaior que (>): " + result);

            //Opreador menor que
            if(x < y)
            {
                result = "x é menor que y.";
            }
            else
            {
                result = "x não é menor que y.";
            }

            Console.WriteLine("\nMenor que (<): " + result);

            //Opreador maior ou igual a (>=)
            if (x >= y)
            {
                result = "x é maior ou igual que y.";
            }
            else
            {
                result = "x não é maior que y.";
            }

            Console.WriteLine("\nMaior ou igual que (>=): " + result);

            //Opreador menor ou igual a (>=)
            if (x <= y)
            {
                result = "x é menor que y.";
            }
            else
            {
                result = "x não é menor ou igual que y.";
            }

            Console.WriteLine("\nMenor ou igual que (<=): " + result);
        }
    }
}