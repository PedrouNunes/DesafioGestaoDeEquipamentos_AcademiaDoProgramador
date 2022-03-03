using System;

namespace DesafioGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void lerEquipamento(ref string[] nome, ref string[] fabricante, ref double[] preco, ref string[] nSerie, ref string[] data1, int i) {
                
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
            }
            static void alterarEquipamento(ref string[] nome, ref string[] fabricante, ref double[] preco, ref string[] nSerie, ref string[] data1, int editar)
            {    

                Console.Write("Edite o nome do equipamento " + editar + ": ");
                nome[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o preço de aquisição do equipamento " + editar + ": ");
                preco[editar] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Edite o numero de série do equipamento " + editar + ": ");
                nSerie[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o dia de fabricação do equipamento " + editar + ": ");
                data1[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o nome do fabricante " + editar + ": ");
                fabricante[editar] = Console.ReadLine();

                Console.WriteLine(); 
            }
            static void removerEquipamento(string[] nome, string[] fabricante, double[] preco, string[] nSerie, string[] data1)
            {
                Console.WriteLine("Digite a posição do equipamento que deseja excluir: ");
                int excluir = Convert.ToInt32(Console.ReadLine());
                int j = 0;
               
                for (int l = 0; l < nome.Length; l++)
                {
                    if (l == excluir)
                    {
                         nome[l] = null;
                         preco[l] = -1;
                         nSerie[l] = null;
                         fabricante[l] = null;
                         data1[l] = null;
                        j = j + 1;
                    }
                }
            }
            static void exibir(string[] nome, string[] fabricante, double[] preco, string[] nSerie, string[] data1)
            {
                for (int j = 0; j < nome.Length; j++)
                {
                    if (nome[j] != null && nSerie[j] != null && fabricante[j] != null && data1[j] != null && preco[j] != -1)
                    {
                        Console.WriteLine("Nome do equipamento " + j + ": " + nome[j] + ", numero de série: " + nSerie[j] + ", fabricante: " + fabricante[j]);
                        Console.WriteLine();
                    }
                }
            }
            static void lerChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] dataChamado, ref int[] nEquipamento, int c, double[] dias)
            {
                Console.Write("Digite o título do chamado " + c + ": ");
                tituloChamado[c] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite a posição do equipamento equivalente ao chamado " + c + ": ");
                nEquipamento[c] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite a descrição do equipamento equivalente ao chamado " + c + ": ");
                descricaoChamado[c] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite a data de abertura do chamado " + c + ": ");
                dataChamado[c] = Console.ReadLine();

                Console.WriteLine();

                DateTime dataAberturaChamado = Convert.ToDateTime(dataChamado[c]);

                TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                dias[c] = diasAberto.TotalDays;
            }
            static void alterarChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] dataChamado, ref int[] nEquipamento, ref double[] dias)
            {
                Console.Write("Digite a posição do chamado que você deseja alterar: ");
                int alterarChamado = Convert.ToInt32(Console.ReadLine());

                Console.Write("Edite o título do chamado " + alterarChamado + ": ");
                tituloChamado[alterarChamado] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite a posição do equipamento equivalente ao chamado " + alterarChamado + ": ");
                nEquipamento[alterarChamado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Edite a descrição do equipamento equivalente ao chamado " + alterarChamado + ": ");
                descricaoChamado[alterarChamado] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite a data de abertura do chamado " + alterarChamado + ": ");
                dataChamado[alterarChamado] = Console.ReadLine();

                Console.WriteLine();

                DateTime dataAberturaChamado = Convert.ToDateTime(dataChamado[alterarChamado]);

                TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                dias[alterarChamado] = diasAberto.TotalDays;
            }
            static void excluirChamado(ref string[] titulo, ref string[] descricaoChamado, ref int[] posicao, ref string[]data)
            {
                Console.Write("Digite a posição do chamado que deseja excluir: ");
                int excluir = Convert.ToInt32(Console.ReadLine());
                
                for (int l = 0; l < titulo.Length; l++)
                {
                    if (l == excluir)
                    {
                        titulo[l] = null;
                        posicao[l] = -1;
                        descricaoChamado[l] = null;
                        data[l] = null;
                    }
                }
            }
            static void exibirChamado(ref string[] titulo, ref string[] descricaoChamado, ref int[] posicao, ref string[] data, ref double[] dias, ref string[] nome)
            {
                for (int l = 0; l < titulo.Length; l++)
                {
                    if (titulo[l] != null && descricaoChamado[l] != null && data[l] != null && posicao[l] != -1)
                    {
                    Console.WriteLine("Titulo do chamado: " + titulo[l] + ", nome do equipamento: " + nome[l] + ", data de abertura do chamado: " + data[l] + ", numero de dias que o chamado está aberto: " + dias[l]);
                    }
                }
            }

            #region Declaração de Variáveis
            int menu;
            char sairOuContinuar;
            

            string[] nome = new string[1000];
            string[] fabricante = new string[1000];

            double[] preco = new double[1000];
            string[] nSerie = new string[1000];
            string[] data1 = new string[1000];
            string[] dataChamado = new string[1000];

            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];
            int i = 0;
            int c = 0;
            int[] nEquipamento = new int[1000];
            double[] dias = new double[1000]; 
            #endregion

            do
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para adicionar um equipamento: ");
                    Console.WriteLine("Digite 2 para editar um equipamento: ");
                    Console.WriteLine("Digite 3 para excluir um equipamento: ");
                    Console.WriteLine("Digite 4 para ver os equipamentos: ");
                    Console.WriteLine("Digite 5 para controle de chamados: ");
                    Console.WriteLine("Digite 6 para editar um chamado: ");
                    Console.WriteLine("Digite 7 para excluir um chamado: ");
                    Console.WriteLine("Digite 8 para ver os chamados: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                } while (menu != 1 && menu != 2 && menu != 3 && menu != 4 && menu != 5 && menu != 6 && menu != 7 && menu != 8);

                Console.WriteLine();
                #region Equipamento
                if (menu == 1)
                {
                    #region ler os dados do equipamento
                    lerEquipamento(ref nome, ref fabricante, ref preco, ref nSerie, ref data1, i);
                    #endregion
                }
                if (menu == 2)
                {
                    #region editar equipamento
                    int editar;
                    Console.Write("Digite a posição do elemento que deseja editar: ");
                    editar = Convert.ToInt32(Console.ReadLine());

                    alterarEquipamento(ref nome, ref fabricante, ref preco, ref nSerie, ref data1, editar);

                    #endregion
                }

                if (menu == 3)
                {
                    #region excluir equipamento 

                    removerEquipamento(nome, fabricante, preco, nSerie, data1);

                    #endregion
                }

                if (menu == 4)
                {
                    exibir(nome, fabricante, preco, nSerie, data1);
                }
                #endregion

                if (menu == 5)
                {
                    #region ler dados do chamado

                    lerChamado(ref tituloChamado, ref descricaoChamado, ref dataChamado, ref nEquipamento, c, dias);
                     c = c + 1;
                    #endregion
                }
                if (menu == 6)
                {
                    alterarChamado(ref tituloChamado, ref descricaoChamado, ref dataChamado, ref nEquipamento, ref dias);
                }
                if (menu == 7)
                {
                    excluirChamado(ref tituloChamado, ref descricaoChamado, ref nEquipamento, ref dataChamado);
                }
                if (menu == 8)
                {
                    exibirChamado(ref tituloChamado, ref descricaoChamado, ref nEquipamento, ref dataChamado, ref dias, ref nome);
                }
                do {
                    Console.WriteLine("Deseja chamar o menu novamente? Digite 'C' para continuar ou 'S' para sair: ");
                    sairOuContinuar = Convert.ToChar(Console.ReadLine());

                }while (sairOuContinuar != 'C' && sairOuContinuar != 'S');

                i = i + 1;
            } while (sairOuContinuar == 'C');
        }
    }
}
