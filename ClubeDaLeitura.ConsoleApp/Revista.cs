using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Revista
    {
        public string nome;
        public string colecao;
        public int edicao;
        public DateTime ano;
        public int numeroCaixa;
            

        public Revista cadastrarRevista(Caixa[] caixas)
        {
           
            Revista revista = new Revista();

            Console.WriteLine("Qual o nome da revista: ");
            revista.nome = Console.ReadLine();
            Console.WriteLine("Qual o nome da coleção da revista: ");
            revista.colecao = Console.ReadLine();
            Console.WriteLine("Qual o número da edição da revista: ");
            revista.edicao = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o ano de lançamento da revista: ");
            DateTime.TryParse(Console.ReadLine(), out revista.ano);
            Console.WriteLine("Qual o número da caixa:");
            revista.numeroCaixa = int.Parse(Console.ReadLine());

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i].numero == revista.numeroCaixa)
                {
                    int posicao = caixas[i].ObterPosicao();                   
                    
                    caixas[i].revistas[posicao] = revista;

                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO!!!!!!!!");
                    Console.ResetColor();
                    Console.Clear();
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista registrada!!");
            Console.ResetColor();
            Console.ReadLine();

            return revista;

        }
    }
}
