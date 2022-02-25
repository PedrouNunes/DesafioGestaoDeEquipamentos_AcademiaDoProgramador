using System;

namespace DesafioGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void alterarEquipamento(ref string[] nome, ref string[] fabricante, double[] preco, ref string[] nSerie, String[] data1, int editar)
            {
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
                data1[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o nome do fabricante: ");
                fabricante[editar] = Console.ReadLine();

                Console.WriteLine(); 
            }
            static void removerEquipamento(string[] nome, string[] fabricante, double[] preco, string[] nSerie, String[] data1, int excluir)
            {
                int posicaoParaRemover = 0, j = 0;

                for (int k = 0; k < nome.Length; k++)
                {
                    if (k == excluir)
                    {
                        posicaoParaRemover = posicaoParaRemover + 1;
                    }
                }
                string[] nomeExcluir = new string[nome.Length - posicaoParaRemover];
                string[] fabricanteExcluir = new string[nome.Length - posicaoParaRemover];

                double[] precoExcluir = new double[nome.Length - posicaoParaRemover];
                string[] nSerieExcluir = new string[nome.Length - posicaoParaRemover];
                String[] data1Excluir = new string[nome.Length - posicaoParaRemover];
                for (int l = 0; l < nome.Length; l++)
                {
                    if (l != excluir)
                    {
                        nomeExcluir[j] = nome[l];
                        precoExcluir[j] = preco[l];
                        nSerieExcluir[j] = nSerie[l];
                        fabricanteExcluir[j] = fabricante[l];
                        data1Excluir[j] = data1[l];
                        j = j + 1;
                    }
                }
                nome = nomeExcluir;
                preco = precoExcluir;
                nSerie = nSerieExcluir;
                fabricante = fabricanteExcluir;
                data1 = data1Excluir;
            }



            int  editar, excluir, nEquipamento, dia, mes, ano;
            bool editarMais, registrarNovo, excluirEquipamento, novoChamado;
            char sim, registrar, excluir2, chamado;
            

            string[] nome = new string[1000];
            string[] fabricante = new string[1000];

            double[] preco = new double[1000];
            string[] nSerie = new string[1000];
            String[] data1 = new string[1000];
            String dataChamado;

            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];

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

                Console.WriteLine();

                Console.Write("Digite a data de fabricação do equipamento " + i + ": ");
                data1[i] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o nome do fabricante: ");
                fabricante[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Nome do equipamento: " + nome[i] + ", numero de série: " + nSerie[i] + ", fabricante: " + fabricante[i]);
                Console.WriteLine();

                do
                {
                  Console.WriteLine("Deseja registrar mais um equipamento? Digite S para sim, ou N para não");
                  registrar = Convert.ToChar(Console.ReadLine());
                } while (registrar != 'S' && registrar != 'N');

                registrarNovo = registrar == 'S';

                i = i + 1;
            } while (registrarNovo == true);

            do
            {
                Console.Write("Digite a posição do elemento que deseja editar (Se não deseja editar nenhum digite 00): ");
                editar = Convert.ToInt32(Console.ReadLine());

                if (editar == 00)
                {
                    break;
                }

                alterarEquipamento(ref nome, ref fabricante, preco, ref nSerie, data1, editar);
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


            do
            {
                Console.WriteLine("Digite a posição do equipamento que deseja excluir: ");
                excluir = Convert.ToInt32(Console.ReadLine());

                if (excluir == 00)
                {
                    break;
                }


                removerEquipamento(nome, fabricante, preco, nSerie, data1, excluir);
    
            Console.Write("Deseja excluir mais um equipamento? Digite S para sim ou N para não: ");
            excluir2 = Convert.ToChar(Console.ReadLine());
            excluirEquipamento = excluir2 == 'S';
            } while (excluirEquipamento == true);

            Console.WriteLine();
            i = 0;
            Console.WriteLine("Registro de chamados");
            do
            {
                Console.WriteLine("Digite o título do chamado: ");
                tituloChamado[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Digite a posição do equipamento equivalente ao chamado: ");
                nEquipamento = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Digite a data de abertura do chamado: ");
                dataChamado = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Título do chamado: " + tituloChamado[i]);

                Console.WriteLine();

                Console.WriteLine("Equipamento: " + nome[nEquipamento]);

                Console.WriteLine();

                String[] dataQuebrada = dataChamado.Split("/");

                dia = Convert.ToInt32(dataQuebrada[i]);
                mes = Convert.ToInt32(dataQuebrada[i + 1]);
                ano = Convert.ToInt32(dataQuebrada[i + 2]);

                DateTime dataAberturaChamado = new DateTime(ano, mes, dia);

                Console.WriteLine("Data de abertura do chamado: " + dataAberturaChamado.ToShortDateString());

                Console.WriteLine();

                TimeSpan diasAberto  = DateTime.Today - dataAberturaChamado;

                double dias = diasAberto.TotalDays;

                Console.WriteLine("Numero de dias que o chamado está aberto: " + dias);

                i = i + 1;

                Console.WriteLine("Deseja adicionar mais um chamado? Digite S para sim ou N para não: ");
                chamado = Convert.ToChar(dataQuebrada[i]);

                novoChamado = chamado == 'S';
            } while (novoChamado == true);



        }
    }
}
