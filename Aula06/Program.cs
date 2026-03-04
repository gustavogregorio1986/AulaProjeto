namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==============Verificador de Numeros pares ou Impares=========");
            Console.WriteLine("Digite o numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int result = numero % 2;

            if(result == 0)  
            {
               Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
    }
}