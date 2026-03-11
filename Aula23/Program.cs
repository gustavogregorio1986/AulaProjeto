

using Aula23.Entidade;

namespace Aula23
{
    public class Program
    {
        public static void Main()
        {
            //1. Criara a instância bank
            var bankPraiano = new Bank();

            bankPraiano.Name = "Banco Praiano";
            bankPraiano.id = 82545;

            //2. Chamando Método Metodos de instaância da classe Bank
            bankPraiano.RequestNewCard();
        }
    }
}