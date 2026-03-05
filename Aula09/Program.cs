namespace Aula09
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=====Opreadores logicos===========");

            bool isLogged = true;
            bool isAdminAcess = false;

            Console.WriteLine("\nInforme do usuário: ");
            Console.WriteLine("Iusuario logado: " + isLogged);
            Console.WriteLine("Acesso de admin: " + isAdminAcess);

            //Opreador (&&) - E
            if (isLogged && isAdminAcess)
            {
                Console.WriteLine("Acesso ao painel de administrador concebido");
            }
            else
            {
                Console.WriteLine("Acesso ao painel de administrador negado");
            }

            //Operador (||) - OU
            if (isLogged || isAdminAcess)
            {
                Console.WriteLine("Acesso ao painel de administrador concebido");
            }
            else
            {
                Console.WriteLine("Acesso ao painel de administrador negado");
            }

            //Opreador (!) - "Não..."
            if (!isLogged)
            {
                Console.WriteLine("Usuário não esta logado");
            }
            else
            {
                Console.WriteLine("Usuário esta logado");
            }
        }
    }
}