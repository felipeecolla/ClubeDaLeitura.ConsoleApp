using System;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa[] caixas = new Caixa[100];

            Caixa caixa = new Caixa();

            while (true)
            {
                MenuPrincipal();
                string opcaoMenu = Console.ReadLine();
                SubMenuRevistas(opcaoMenu,ref caixas);
                SubMenuEmprestimos(opcaoMenu);
                SubMenuAmigos(opcaoMenu);
                Console.Clear();
                if (opcaoMenu == "s")
                {
                    break;
                }
                if (opcaoMenu == "4")
                {
                    Console.Clear();

                   

                    caixas[0] = caixa.cadastrarCaixa();
                   
                }
            }
        }

        private static void SubMenuAmigos(string opcaoMenu)
        {
            if (opcaoMenu == "3") //SubMenu amigo
            {
                Console.Clear();

                Amigo amigo = new Amigo();

                Console.WriteLine("CADASTRAR AMIGO");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("Informe o nome do amigo: ");
                amigo.nome = Console.ReadLine();
                Console.WriteLine("Informe o nome do responsável: ");
                amigo.nomeResposavel = Console.ReadLine();
                Console.WriteLine("Informe o telefone do amigo: ");
                amigo.telefone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o endereço do amigo: ");
                amigo.endereco = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Amigo registrado!!");
                Console.ResetColor();
                Console.ReadLine();
            }
        }

        private static void SubMenuEmprestimos(string opcaoMenu)
        {
            if (opcaoMenu == "2") //SubMenu empréstimos
            {
                Console.Clear();

                Console.WriteLine("CADASTRAR EMPRÉSTIMO");
                Console.WriteLine("-------------------------------------------");

                Emprestimo emprestimo = new Emprestimo();

                Console.WriteLine("Informe o amigo que pegou a revista: ");
                emprestimo.amigoEmprestimo = Console.ReadLine();
                Console.WriteLine("Informe a revista emprestada: ");
                emprestimo.nome = Console.ReadLine();
                Console.WriteLine("Informe a data do empréstimo: ");
                emprestimo.data = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a data de devolução: ");
                emprestimo.dataDevolucao = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Empréstimo registrado!!");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void SubMenuRevistas(string opcaoMenu, ref Caixa[]caixas)
        {
            if (opcaoMenu == "1") // SubMenu de revistas
            {
                Revista revista = new Revista();

                revista.cadastrarRevista(caixas);

                
            }
        }

        private static void MenuPrincipal()
        {
            Console.WriteLine("CLUBE DA LEITURA 1.0"); //Menu principal
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Selecione alguma das opções abaixo:");
            Console.WriteLine("\n");
            Console.WriteLine("Digite 1 para Cadastrar Revista");
            Console.WriteLine("Digite 2 para Cadastrar Empréstimo");
            Console.WriteLine("Digite 3 para Cadastrar Amigo");
            Console.WriteLine("Digite 4 para Cadastrar Caixa");
            Console.WriteLine("Digite s para sair");
        }
    }  
}
