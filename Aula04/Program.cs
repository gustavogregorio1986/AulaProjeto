namespace Aula04
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("----------CADASTRO DE USUÁRIO-----------");

            //Solicitar o nome do Usuario
            Console.WriteLine("Digite o nome: ");
            string name = Console.ReadLine();

            //Solicitar a Identidade do usario
            Console.WriteLine("Digite Sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Nome do Usuário: " + name);
            Console.WriteLine("Age do Usuário: " + age);
        }
    }
}