namespace Aula17
{
    public class Program
    {
        public static void Main()
        {
            string separator = "-----------------------------";

            //1. Declaração com incialização de valores
            List<string> fruits = new List<string>() 
            { 
                   "Manga",
                   "Abacate",
                   "Pera"
            };

            //2. Acessar os valores
            Console.WriteLine(fruits[2]);

            Console.WriteLine(separator);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //3. Adicionar elemntos
            fruits.Add("Limão");
            fruits.Add("Laranja");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //4. Remover Elementos
            fruits.Remove("limão");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            Console.WriteLine("Quantidade de Frutas: " + fruits.Count);

            //6. Modificar um elemento
            fruits[2] = "Maracauja";

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //7. Limpar a lista
            fruits.Clear();

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine(separator);

            //8. Declarar sem incializar

            List<int> numbrs = new List<int>();

            numbrs.Add(1);
            numbrs.Add(50);
            numbrs.Add(70);

            foreach (int number in numbrs)
            {
                Console.WriteLine(number);
            }
        }
    }
}