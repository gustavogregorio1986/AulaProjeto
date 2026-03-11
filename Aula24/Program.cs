using Aula24.Entidade;

namespace Aula24
{
    public class Program
    {
        public static void Main()
        {
            //1. Criar instãncia da classe Person
            Person person = new Person();
            person.Name = "";

            //2. Métodos
            Console.WriteLine("Digite uma Idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primeira forma correta");

            var IfLegalPersoon = person.IfLegalPersoon(age);
            
            if(IfLegalPersoon == true)
            {
                Console.WriteLine("A pessoa é maior de idade");
            }
            else
            {
                Console.WriteLine("A pessoa é menor de idade");
            }

            Console.WriteLine("Segunda forma correta");

            //3  Chamando o método e guardando o resultado
            string response = person.IfLegalPersoonRefactor(age);
            Console.WriteLine(response);

            string response1 = person.IfLegalPersoonRefactorName(age, person.Name);
            Console.WriteLine(response1);
        }
    }
}