using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula24.Entidade
{
    public class Person
    {
        //1. Atributos
        public string Name;
        public int Age;

        //2. Métodos
        public bool IfLegalPersoon(int age)
        {
            if(age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string IfLegalPersoonRefactor(int age)
        {
            string resiult = string.Empty;

            if (age >= 18)
            {
                resiult = "A pessoa é maior de Idade!";
                return resiult;
            }
            else
            {
                resiult = "A pessoa é menor de Idade!";
                return resiult;
            }
        }

        public string IfLegalPersoonRefactorName(int age, string name)
        {
            string resiult = string.Empty;

            if (age >= 18)
            {
                resiult = "O(a) " +  name + "é maior de Idade!";
                return resiult;
            }
            else
            {
                resiult = "O(a) " + name + "é menor de Idade!";
                return resiult;
            }
        }
    }
}
