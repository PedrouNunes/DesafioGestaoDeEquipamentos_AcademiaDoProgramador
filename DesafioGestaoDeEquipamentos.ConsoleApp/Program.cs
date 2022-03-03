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
                        Console.WriteLine("Nome do equipamento: " + j + " " + nome[j] + ", numero de série: " + nSerie[j] + ", fabricante: " + fabricante[j]);
                        Console.WriteLine();
                    }
                }
            }
            static void lerChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string dataChamado, ref int nEquipamento, int i)
            {
                Console.WriteLine("Digite o título do chamado " + i + ": ");
                tituloChamado[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Digite a posição do equipamento equivalente ao chamado " + i + ": ");
                nEquipamento = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine("Digite a descrição do equipamento equivalente ao chamado " + i + ": ");
                descricaoChamado[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Digite a data de abertura do chamado " + i + ": ");
                dataChamado = Console.ReadLine();

                Console.WriteLine();
            }
            static void alterarChamado(ref int posicao, ref string[] titulo, ref string data, ref string[] descricaoChamado, int alterarChamado)
            {
                Console.WriteLine("Edite o título do chamado " + alterarChamado + ": ");
                titulo[posicao] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Edite a descrição do equipamento equivalente ao chamado " + alterarChamado + ": ");
                descricaoChamado[posicao] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Edite a posição do equipamento equivalente ao chamado " + alterarChamado + ": ");
                posicao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine("Edite a data de abertura do chamado " + alterarChamado + ": ");
                data = Console.ReadLine();         
            }
            static void excluirChamado(ref int posicao, ref string[] titulo, ref string data, ref string[] descricaoChamado,  int posicaoChamado)
            {
                Console.WriteLine("Digite a posição do chamado que deseja excluir: ");
                int excluir = Convert.ToInt32(Console.ReadLine());
                int posicaoParaRemover = 0, j = 0;

                for (int k = 0; k < titulo.Length; k++)
                {
                    if (k == excluir)
                    {
                        posicaoParaRemover = posicaoParaRemover + 1;
                    }
                }
                string[] tituloExcluir = new string[titulo.Length - posicaoParaRemover];
                string[] descricaoExcluir = new string[titulo.Length - posicaoParaRemover];

                for (int l = 0; l < titulo.Length; l++)
                {
                    if (l != excluir)
                    {
                        tituloExcluir[j] = titulo[l];
                        descricaoExcluir[j] = descricaoChamado[l];
                        data = null;
                        j = j + 1;
                    }
                }
                titulo = tituloExcluir;
                descricaoChamado = descricaoExcluir;
            }


            #region Declaração de Variáveis
            int   nEquipamento = 0, dia, mes, ano, dia2, mes2, ano2, menu, posicaoChamado, posicaoChamado2;
            char sairOuContinuar;
            

            string[] nome = new string[1000];
            string[] fabricante = new string[1000];

            double[] preco = new double[1000];
            string[] nSerie = new string[1000];
            string[] data1 = new string[1000];
            string dataChamado = "";

            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];
            int i = 0;
            int c = 0;

            #endregion

            do
            {
                do
                {
                    Console.WriteLine("Digite 1 para adicionar um equipamento: ");
                    Console.WriteLine("Digite 2 para editar um equipamento: ");
                    Console.WriteLine("Digite 3 para excluir um equipamento: ");
                    Console.WriteLine("Digite 4 para ver os equipamentos: ");
                    Console.WriteLine("Digite 5 para controle de chamados: ");
                    Console.WriteLine("Digite 6 para editar um chamado: ");
                    Console.WriteLine("Digite 7 para excluir um chamado: ");              
                    menu = Convert.ToInt32(Console.ReadLine());
                } while (menu != 1 && menu != 2 && menu != 3 && menu != 4 && menu != 5 && menu != 6 && menu != 7);

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
                    Console.Write("Digite a posição do elemento que deseja editar (Se não deseja editar nenhum digite 00): ");
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

                    lerChamado(ref tituloChamado, ref descricaoChamado, ref dataChamado, ref nEquipamento, c);

                    string[] dataQuebrada = dataChamado.Split("/");

                    dia = Convert.ToInt32(dataQuebrada[c]);
                    mes = Convert.ToInt32(dataQuebrada[c + 1]);
                    ano = Convert.ToInt32(dataQuebrada[c + 2]);

                    DateTime dataAberturaChamado = new DateTime(ano, mes, dia);

                    TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                    double dias = diasAberto.TotalDays;

                    Console.WriteLine("Titulo do chamado: " + tituloChamado[nEquipamento] + ", nome do equipamento editado: " + nome[nEquipamento] + ", data de abertura do chamado: " + dataChamado + ", numero de dias que o chamado está aberto: " + dias);

                    c = c + 1;
                    #endregion
                }
                if (menu == 6)
                {
                    Console.WriteLine("Digite a posição do chamado para ser alterado: ");
                    posicaoChamado = Convert.ToInt32(Console.ReadLine());  
                    #region editar chamado

                    alterarChamado(ref nEquipamento, ref tituloChamado, ref dataChamado, ref descricaoChamado, posicaoChamado);

                    string[] dataQuebrada2 = dataChamado.Split("/");

                    dia2 = Convert.ToInt32(dataQuebrada2[nEquipamento]);
                    mes2 = Convert.ToInt32(dataQuebrada2[nEquipamento + 1]);
                    ano2 = Convert.ToInt32(dataQuebrada2[nEquipamento + 2]);

                    DateTime dataAberturaChamado2 = new DateTime(ano2, mes2, dia2);

                    TimeSpan diasAberto2 = DateTime.Today - dataAberturaChamado2;

                    double dias2 = diasAberto2.TotalDays;

                    Console.WriteLine("Titulo do chamado: " + tituloChamado[nEquipamento] + ", nome do equipamento editado: " + nome[nEquipamento] + ", data de abertura do chamado: " + dataChamado + ", numero de dias que o chamado está aberto: " + dias2);

                    #endregion
                }
                if (menu == 7)
                {
                    #region Exluir Chamado
                    Console.WriteLine("Digite a posição do chamado para ser excluida: ");
                    posicaoChamado2 = Convert.ToInt32(Console.ReadLine());
                    excluirChamado(ref nEquipamento, ref tituloChamado, ref dataChamado, ref descricaoChamado, posicaoChamado2);
                    #endregion
                }
 
                do {
                    Console.WriteLine("Deseja continuar? Digite 'C' para continuar ou 'S' para sair: ");
                    sairOuContinuar = Convert.ToChar(Console.ReadLine());

                }while (sairOuContinuar != 'C' && sairOuContinuar != 'S');

                i = i + 1;
            } while (sairOuContinuar == 'C');
        }
    }
}
