using Aula22.Entidade;

namespace Aula22
{
    public class Program
    {
        //Aplicação Console - Ela vai começar aqui
        public static void Main()
        {
            //1. Instancia (objeto) da Classe Cake - 'New'
            Cake cakeStramberry = new Cake();

            //1. Setar as informações do nosso bolo de morango
            cakeStramberry.Id = 472;
            cakeStramberry.Name = "Bolo de Morango Recheado";
            cakeStramberry.Decription = "Intelorante a lactose, não consumir";
            cakeStramberry.Value = 30;
            cakeStramberry.Isfilling = true;

            //3. Mostrar ao Usuario

            // var test = cakeStramberry.Id;

            //Console.WriteLine('Id: ' + test);
            Console.WriteLine("Id: " + cakeStramberry.Id);
            Console.WriteLine("Nome: " + cakeStramberry.Name);
            Console.WriteLine("Description: " + cakeStramberry.Decription);
            Console.WriteLine("Value: " + cakeStramberry.Value);
            Console.WriteLine("É recheado: " + cakeStramberry.Isfilling);

            //----------------------------------------------

            //4. Instancia de objeto
            Cake chocolate = new Cake();
            chocolate.Id = 472;
            chocolate.Name = "Bolo de Chocolate";
            chocolate.Decription = "Cacu meio amargo 30%";
            chocolate.Value = 45;
            chocolate.Isfilling = false;

            Console.WriteLine("Id: " + cakeStramberry.Id);
            Console.WriteLine("Nome: " + cakeStramberry.Name);
            Console.WriteLine("Description: " + cakeStramberry.Decription);
            Console.WriteLine("Value: " + cakeStramberry.Value);
            Console.WriteLine("É recheado: " + cakeStramberry.Isfilling);

            //Lisras de Bolo
            List<Cake> cakeList = new List<Cake>();
            cakeList.Add(cakeStramberry);
            cakeList.Add(chocolate);
            cakeList.Add(chocolate);

            //6. Visualizar
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Lista de Boloso - Criação de Lista");

            foreach (Cake cake in cakeList)
            {
                Console.WriteLine("Id: " + cake.Id);
                Console.WriteLine("Nome: " + cake.Name);
                Console.WriteLine("Description: " + cake.Decription);
                Console.WriteLine("Value: " + cake.Value);
                Console.WriteLine("É recheado: " + cake.Isfilling);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}