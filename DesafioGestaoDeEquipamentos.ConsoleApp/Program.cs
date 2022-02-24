using System;

namespace DesafioGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade, editar;
            bool editarMais;
            char sim;

            Console.Write("Digite a quantidade de equipamentos: ");
            quantidade = Convert.ToInt32((Console.ReadLine()));

            string[] nome = new string[quantidade];
            string[] fabricante = new string[quantidade];

            double[] preco = new double[quantidade];
            string[] nSerie = new string[quantidade];

            int[] dia = new int[quantidade];
            int[] mes = new int[quantidade];
            int[] ano = new int[quantidade];
           // DateTime[] dataFabricacao = new DateTime[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o nome do equipamento " + i + ": ");
                nome[i] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o preço de aquisição do equipamento " + i + ": ");
                preco[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite o numero de série do equipamento " + i + ": ");
                nSerie[i] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o dia de fabricação do equipamento " + i + ": ");
                dia[i] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine();

                Console.Write("Digite o mês de fabricação do equipamento " + i + ": ");
                mes[i] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine();

                Console.Write("Digite o ano de fabricação do equipamento " + i + ": ");
                ano[i] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine();

                Console.Write("Digite o nome do fabricante: ");
                fabricante[i] = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0;i < quantidade; i++)
            {
                Console.Write("Nome do equipamento " + i + ": " + nome[i]);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Numero de série do equipamento " + i + ": " + nSerie[i]);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Nome do fabricante do equipamento " + i + ": " + fabricante[i]);
                Console.WriteLine();
                Console.WriteLine();
            }

            do
            {
                Console.Write("Digite a posição do elemento que deseja editar: ");
                editar = Convert.ToInt32(Console.ReadLine());

                Console.Write("Edite o nome do equipamento: ");
                nome[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o preço de aquisição do equipamento: ");
                preco[editar] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Edite o numero de série do equipamento: ");
                nSerie[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o dia de fabricação do equipamento: ");
                dia[editar] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine();

                Console.Write("Edite o mês de fabricação do equipamento: ");
                mes[editar] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine();

                Console.Write("Edite o ano de fabricação do equipamento: ");
                ano[editar] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine();

                Console.Write("Edite o nome do fabricante: ");
                fabricante[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Nome do equipamento: " + nome[editar]);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Numero de série do equipamento: " + nSerie[editar]);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Nome do fabricante do equipamento: " + fabricante[editar]);
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Deseja editar mais um equipamento? Digite S para sim ou N para não: ");
                sim = Convert.ToChar(Console.ReadLine());

                editarMais = sim == 'S';
            } while (editarMais == true);
        }
    }
}
