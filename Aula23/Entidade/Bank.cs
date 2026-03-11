using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula23.Entidade
{
    public class Bank
    {
        //1. Atributo
        public int Ifd { get; set; }
        public string Name { get; set; }

        //2. Métodos (sem retorno)
        public void RequestNewCard()
        {
            //logica
            Console.WriteLine("Enviando Enmail..... (Solucite um novo cartão, ligando paar o numero: 8888-8888)");
        }

    }
}
