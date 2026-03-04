namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("===========Operadores de Agtribuição ==================");

            //Inicializar a variável
            int x = 30;
            Console.WriteLine("Valor Inicial da Variável de x: " + x);

            //Operadores de Atribuição Simples (=)
            x = 20;
            Console.WriteLine("\n Atribuição Simples (=)");
            Console.WriteLine("Valor de x: " + x);

            //Atribuição Composta  (incremento) (++)
            x++; //Equivale x= x + 1
            Console.WriteLine("\n Atribuição composta de Incremento");
            Console.WriteLine("Novo Valor de x: (++) " + x);

            x+=10; //Equivale x= x + 1
            Console.WriteLine("\n Atribuição composta (+=)");
            Console.WriteLine("Novo Valor de x: (++) " + x);
        }
    }
}