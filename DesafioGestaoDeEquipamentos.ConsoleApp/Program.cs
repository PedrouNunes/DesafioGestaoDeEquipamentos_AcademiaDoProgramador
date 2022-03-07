using System;

namespace DesafioGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void lerEquipamento(ref string[] nome, ref string[] fabricante, ref double[] preco, ref string[] nSerie, ref string[] data1, int i) {
                do {
                    Console.Write("Digite o nome do equipamento " + i + ": ");
                    nome[i] = Console.ReadLine();
                } while (nome[i].Length < 6);

                Console.WriteLine();

                do
                {
                    Console.Write("Digite o preço de aquisição do equipamento " + i + ": ");
                    preco[i] = Convert.ToDouble(Console.ReadLine());
                } while (preco[i] == 0 && preco[i] < 0);

                Console.WriteLine();

                do
                {
                    Console.Write("Digite o numero de série do equipamento " + i + ": ");
                    nSerie[i] = Console.ReadLine();
                } while (nSerie[i] == null);

                Console.WriteLine();

                if (i > 0)
                {
                    do
                    {
                        Console.Write("Digite a data de fabricação do equipamento " + i + ": ");
                        data1[i] = Console.ReadLine();
                    } while (data1[i].Length == 0 && data1[i] != data1[i-1]);
                }
                else
                {
                    do
                    {
                        Console.Write("Digite a data de fabricação do equipamento " + i + ": ");
                        data1[i] = Console.ReadLine();
                    } while (data1[i].Length == 0);
                }
  

                Console.WriteLine();

                do { 
                    Console.Write("Digite o nome do fabricante: ");
                    fabricante[i] = Console.ReadLine();
                Console.WriteLine();
                 }while (fabricante[i] == null);
            }
            static void alterarEquipamento(ref string[] nome, ref string[] fabricante, ref double[] preco, ref string[] nSerie, ref string[] data1)
            {
                int editar;
                Console.Write("Digite a posição do elemento que deseja editar: ");
                editar = Convert.ToInt32(Console.ReadLine());

                do {
                    Console.Write("Edite o nome do equipamento " + editar + ": ");
                    nome[editar] = Console.ReadLine();
                }while(nome[editar].Length < 6);

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
            static void removerEquipamento(string[] nome, string[] fabricante, double[] preco, string[] nSerie, string[] data1, int[] posicao)
            {
                Console.WriteLine("Digite a posição do equipamento que deseja excluir: ");
                int excluir = Convert.ToInt32(Console.ReadLine());
                int j = 0;
               
                for (int l = 0; l < nome.Length; l++)
                {
                    if (excluir == posicao[l])
                    {
                        Console.WriteLine("Este equipamento está vinculado a um chamado, ele não pode ser excluido!");
                        break;
                    }
                    else
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
            }
            static void exibir(string[] nome, string[] fabricante, double[] preco, string[] nSerie, string[] data1)
            {
                for (int j = 0; j < nome.Length; j++)
                {
                    if (nome[j] != null && nSerie[j] != null && fabricante[j] != null && data1[j] != null && preco[j] != -1)
                    {
                        Console.WriteLine("Nome do equipamento " + j + ": " + nome[j] + ", numero de série: " + nSerie[j] + ", fabricante: " + fabricante[j]);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
            static void lerChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] dataChamado, ref int[] nEquipamento, int c, ref double[] dias, ref int[] nID, ref int[] equipamentosMaisProblematicos, ref char[] chamadoFechado)
            {
                Console.Write("Digite o título do chamado " + c + ": ");
                tituloChamado[c] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite a posição do equipamento equivalente ao chamado " + c + ": ");
                nEquipamento[c] = Convert.ToInt32(Console.ReadLine());

                equipamentosMaisProblematicos[nEquipamento[c]] = equipamentosMaisProblematicos[nEquipamento[c]] + 1;

                Console.WriteLine();

                Console.Write("Digite a descrição do equipamento equivalente ao chamado " + c + ": ");
                descricaoChamado[c] = Console.ReadLine();        

                Console.WriteLine();

                Console.Write("Digite a data de abertura do chamado " + c + ": ");
                dataChamado[c] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Registre o numero de ID do solicitante do chamado " + c + ": ");
                nID[c] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Deseja alterar a situação do chamado para fechado?Digite S para sim e N para não: ");
                chamadoFechado[c] = Convert.ToChar(Console.ReadLine());

                Console.WriteLine();

                DateTime dataAberturaChamado = Convert.ToDateTime(dataChamado[c]);

                TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                dias[c] = diasAberto.TotalDays;
            }
            static void alterarChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] dataChamado, ref int[] nEquipamento, ref double[] dias, ref int[] nID, ref char[] chamadoFechado)
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

                Console.Write("Registre o numero de ID do solicitant do chamado " + alterarChamado + ": ");
                nID[alterarChamado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

               Console.Write("Deseja alterar a situação do chamado para fechado?Digite S para sim e N para não: ");
               chamadoFechado[alterarChamado] = Convert.ToChar(Console.ReadLine());

                Console.WriteLine();

                DateTime dataAberturaChamado = Convert.ToDateTime(dataChamado[alterarChamado]);

                TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                dias[alterarChamado] = diasAberto.TotalDays;
            }
            static void excluirChamado(ref string[] titulo, ref string[] descricaoChamado, ref int[] posicao, ref string[]data, ref int[] nID)
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
                        nID[l] = -1;
                    }
                }
            }
            static void exibirChamado(ref string[] titulo, ref string[] descricaoChamado, ref int[] posicao, ref string[] data, ref double[] dias, ref string[] nome, ref string[] nomeSolicitante,  ref int[] nID, ref char[] chamadoFechado)
            {
                Console.WriteLine("Chamados fechados: ");
                for (int l = 0; l < titulo.Length; l++)
                {
                    if (chamadoFechado[l] == 'S')
                    {
                        if (titulo[l] != null && descricaoChamado[l] != null && data[l] != null && posicao[l] != -1 && nID[l] != -1)
                        {
                            Console.WriteLine("Titulo do chamado: " + titulo[l] + ", nome do equipamento: " + nome[l] + ", data de abertura do chamado: " + data[l] + ", numero de dias que o chamado está aberto: " + dias[l] + ", nome do solicitante: " + nomeSolicitante[nID[l]]);
                            Console.WriteLine();
                        }
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Chamados abertos: ");
                for (int l = 0; l < titulo.Length; l++)
                {
                    if (chamadoFechado[l] == 'N')
                    {
                        if (titulo[l] != null && descricaoChamado[l] != null && data[l] != null && posicao[l] != -1 && nID[l] != -1)
                        {
                            Console.WriteLine("Titulo do chamado: " + titulo[l] + ", nome do equipamento: " + nome[l] + ", data de abertura do chamado: " + data[l] + ", numero de dias que o chamado está aberto: " + dias[l] + ", nome do solicitante: " + nomeSolicitante[nID[l]]);
                            Console.WriteLine();
                        }
                    }
                }

            }
            static void lerSolicitante(ref string[] nomeSolicitante, ref string[] email, ref string[] telefone , int s) {
                do
                {
                    Console.Write("Digite o nome do solicitante " + s + ": ");
                    nomeSolicitante[s] = Console.ReadLine();
                }while(nomeSolicitante.Length < 6);

                Console.WriteLine();

                Console.Write("Digite o email do solicitante " + s + ": ");
                email[s] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o telefone do solicitante " + s + ": ");
                telefone[s] = Console.ReadLine();
            }
            static void alterarSolicitante(ref string[] nomeSolicitante, ref string[] email, ref string[] telefone)
            {
                Console.Write("Digite o id do solicitante que deseja editar: ");
                int editar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                do
                {
                    Console.Write("Edite o nome do solicitante " + editar + ": ");
                    nomeSolicitante[editar] = Console.ReadLine();
                } while (nomeSolicitante.Length < 6);

                Console.WriteLine();

                Console.Write("Edite o email do solicitante " + editar + ": ");
                email[editar] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Edite o telefone do solicitante " + editar + ": ");
                telefone[editar] = Console.ReadLine();

                Console.WriteLine();
            }
            static void excluirSolicitante(string[] nomeSolicitante, string[] email, string[] telefone) {
               
                Console.Write("Digite o ID do solicitante que deseja excluir: ");
                int excluir = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                for (int i = 0; i < nomeSolicitante.Length; i++)
                {
                    if (i == excluir)
                    {
                        nomeSolicitante [i] = null;
                        email [i] = null;
                        telefone [i] = null;
                    }
                }

            }
            static void exibirSolicitante(string[] nomeSolicitante, string[] email, string[] telefone)
            {
                for (int i = 0; i < nomeSolicitante.Length; i++)
                {
                    if (nomeSolicitante[i] != null && email[i] != null && telefone[i] != null)
                    {
                        Console.Write("ID do solicitante: " + i + ", nome do solicitante: " + nomeSolicitante[i]);
                        Console.WriteLine();
                        Console.Write("Email do solicitante: " + email[i] + ", numero de telefone do solicitante: " + telefone[i]);
                        Console.WriteLine();
                    }
                }
            }
            
            static void equipamentosQueMaisApresentaramProblemasEmOrdemDecrescente(int[] equipamentosMaisProblematicos, int c)
            {
                for (int i = 0; i <= c; i++)
                {
                    
                }
            }
            #region Declaração de Variáveis
            int menu;
            char sairOuContinuar;
            int i = 0;
            int c = 0;
            int s = 0;

            string[] nome = new string[1000];
            string[] fabricante = new string[1000];

            double[] preco = new double[1000];
            string[] nSerie = new string[1000];
            string[] data1 = new string[1000];
            string[] dataChamado = new string[1000];

            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];
            int[] nEquipamento = new int[1000];
            double[] dias = new double[1000];

            string[] nomeSolicitante = new string[1000];
            string[] email = new string[1000];
            string[] nTelefone = new string[1000];
            int[] nID = new int[1000];

            char[] chamadoFechado = new char[1000];
            int[] equipamentosMaisProblematicos = new int[1000];
            #endregion

            do
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite o numero correspondente a função que você deseja executar: ");
                    Console.WriteLine(" 1 - adicionar um equipamento. ");
                    Console.WriteLine(" 2 - editar um equipamento. ");
                    Console.WriteLine(" 3 - excluir um equipamento. ");
                    Console.WriteLine(" 4 - visualizar os equipamentos. ");
                    Console.WriteLine(" 5 - controle de chamados. ");
                    Console.WriteLine(" 6 - editar um chamado. ");
                    Console.WriteLine(" 7 - excluir um chamado. ");
                    Console.WriteLine(" 8 - visualizar os chamados. ");
                    Console.WriteLine(" 9 - registrar solicitante. ");
                    Console.WriteLine(" 10 - editar solicitante. ");
                    Console.WriteLine(" 11 - excluir solicitante. ");
                    Console.WriteLine(" 12 - visualizar solicitante. ");
                    Console.WriteLine();
                    Console.Write("Resposta: ");

                    menu = Convert.ToInt32(Console.ReadLine());
                } while (menu != 1 && menu != 2 && menu != 3 && menu != 4 && menu != 5 && menu != 6 && menu != 7 && menu != 8 && menu != 9 && menu != 10 && menu != 11 && menu != 12);

                Console.WriteLine();

                #region Solicitante
                if (menu == 9)
                {
                    lerSolicitante(ref nomeSolicitante, ref email, ref nTelefone, s);
                    s = s + 1;
                    Console.WriteLine();
                }

                if (menu == 10)
                {
                    alterarSolicitante(ref nomeSolicitante, ref email, ref nTelefone);
                    Console.WriteLine();
                }

                if (menu == 11)
                {
                    excluirSolicitante(nomeSolicitante, email, nTelefone);
                    Console.WriteLine();
                }

                if (menu == 12)
                {
                    exibirSolicitante(nomeSolicitante, email, nTelefone);
                    Console.WriteLine();
                }
                #endregion

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

                    alterarEquipamento(ref nome, ref fabricante, ref preco, ref nSerie, ref data1);

                    #endregion
                }

                if (menu == 3)
                {
                    #region excluir equipamento 

                    removerEquipamento(nome, fabricante, preco, nSerie, data1, nEquipamento);

                    #endregion
                }

                if (menu == 4)
                {
                    exibir(nome, fabricante, preco, nSerie, data1);
                }
                #endregion

                #region Chamado
                if (menu == 5)
                {
                    #region ler dados do chamado

                    lerChamado(ref tituloChamado, ref descricaoChamado, ref dataChamado, ref nEquipamento, c, ref dias, ref nID, ref equipamentosMaisProblematicos, ref chamadoFechado);
                     c = c + 1;
                    #endregion
                }
                if (menu == 6)
                {
                    alterarChamado(ref tituloChamado, ref descricaoChamado, ref dataChamado, ref nEquipamento, ref dias, ref nID, ref chamadoFechado);
                }
                if (menu == 7)
                {
                    excluirChamado(ref tituloChamado, ref descricaoChamado, ref nEquipamento, ref dataChamado, ref nID);
                }
                if (menu == 8)
                {
                    exibirChamado(ref tituloChamado, ref descricaoChamado, ref nEquipamento, ref dataChamado, ref dias, ref nome, ref nomeSolicitante, ref nID, ref chamadoFechado);
                }
                #endregion

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Deseja chamar o menu novamente? Digite 'C' para continuar ou 'S' para sair: ");
                    sairOuContinuar = Convert.ToChar(Console.ReadLine());

                }while (sairOuContinuar != 'C' && sairOuContinuar != 'S');

                i = i + 1;
            } while (sairOuContinuar == 'C');
        }
    }
}
