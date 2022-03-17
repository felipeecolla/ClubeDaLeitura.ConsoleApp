using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Caixa
    {
        public string cor;
        public int numero;
        public int etiqueta;
        public Revista[] revistas = new Revista[100];

        public Caixa cadastrarCaixa()
        {
            Caixa novaCaixa = new Caixa();
            Console.WriteLine("Informe a cor da caixa:");
            novaCaixa.cor = Console.ReadLine();
            Console.WriteLine("Informe o número da caixa:");
            novaCaixa.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número da etiqueta:");
            novaCaixa.etiqueta = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Caixa registrado!!");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            return novaCaixa;
        }
        public int ObterPosicao()
        {
            int posicao = 0;

            for(int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null)
                {
                    posicao = i;

                    break;
                }


            }
            return posicao;
        }
    }
}
