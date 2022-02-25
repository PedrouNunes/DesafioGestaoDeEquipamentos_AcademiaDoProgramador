using System;

namespace DesafioGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade, editar;
            bool editarMais, registrarNovo;
            char sim, registrar;

            string[] nome = new string[100000];
            string[] fabricante = new string[100000];

            double[] preco = new double[100000];
            string[] nSerie = new string[100000];
            String[] data1 = new string[100000];
            int i = 0;


            do
            {
                Console.Write("Digite o nome do equipamento " + i + ": ");
                nome[i] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o preço de aquisição do equipamento " + i + ": ");
                preco[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite o numero de série do equipamento " + i + ": ");
                nSerie[i] = Console.ReadLine();

                //Console.Write("Digite a data de fabricação do equipamento " + i + ": ");
                //data1[i] = Console.ReadLine();
                //string[] data = data1[i].Split("/");
                //contArrayData = contArrayData + data.Length;

                Console.WriteLine();

                Console.Write("Digite o nome do fabricante: ");
                fabricante[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Nome do equipamento: " + nome[i] + ", numero de série: " + nSerie[i] + ", fabricante: " + fabricante[i]);

                do {
                    Console.WriteLine("Deseja registrar mais um equipamento? Digite S para sim, ou N para não");
                    registrar = Convert.ToChar(Console.ReadLine());
                }while(registrar != 'S' && registrar != 0);

                Console.WriteLine();
                i = i + 1;      
            registrarNovo = registrar == 'S';
            }while (registrarNovo == true);
           
            do
            {
                Console.Write("Digite a posição do elemento que deseja editar (Se não deseja editar nenhum digite 00): ");
                editar = Convert.ToInt32(Console.ReadLine());

                if (editar == 00)
                {
                    break;
                }

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
