
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sistema_do_Mercadinho
{
    class Program
    {
        struct Fornecedor //Registro
        {
            public string Nome_Fornec, End_Fornec, Tel_Fornec, Emp_Fornec, Cod_Fornec;
        }
        struct Mercadoria
        {
            public string Nome_Prod;
            public int Quant_Prod, Cod_Prod;
            public double Preco_Prod;
        }
        //===========================================================================================================
        //Menu principal
        //===========================================================================================================
        static void Main(string[] args)
        {
            Console.Title = "Sistema do Mercadinho";

            Fornecedor Fornec = new Fornecedor();
            Mercadoria Prod = new Mercadoria();

            Console.SetWindowSize(120, 30);

            string Cmn_Fornec = "Fornec.txt";//<-------------verificação  do arquivo fornec.txt
            if (!Verificar(Cmn_Fornec))
            {

            }
            string Cmn_Prod = "Produtos.dat";//<-------------verificação  do arquivo Produtos.dat
            if (!Verificar1(Cmn_Prod))
            {

            }

            int op, N;

            do
            {
                N = 8;
                op = 0;

                Console.Clear();
                Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t├┼──────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t││                                              ││");
                Console.WriteLine("\t\t\t\t││      ─────────────────────────────────       ││");
                Console.WriteLine("\t\t\t\t││            Sistema do Mercadinho             ││");
                Console.WriteLine("\t\t\t\t││      ─────────────────────────────────       ││");
                Console.WriteLine("\t\t\t\t││                                              ││");
                Console.WriteLine("\t\t\t\t├┼──────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────┴┘");

                Console.WriteLine("\n\t\t\t\t\t  ┌┬────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t\t  ├┼────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t\t  ││       Menu Principal       ││");
                Console.WriteLine("\t\t\t\t\t  ││       ──────────────       ││");
                Console.WriteLine("\t\t\t\t\t  ││                            ││");
                Console.WriteLine("\t\t\t\t\t  ││  1 - Cadastrar             ││");
                Console.WriteLine("\t\t\t\t\t  ││  2 - Exibir Lista          ││");
                Console.WriteLine("\t\t\t\t\t  ││  3 - Procurar Produto      ││");
                Console.WriteLine("\t\t\t\t\t  ││  4 - Alterar               ││");
                Console.WriteLine("\t\t\t\t\t  ││  5 - Excluir               ││");
                Console.WriteLine("\t\t\t\t\t  ||  6 - Comprar Produtos      ||");
                Console.WriteLine("\t\t\t\t\t  ││  7 - Vender Produtos       ││");
                Console.WriteLine("\t\t\t\t\t  ││  8 - Sair                  ││");
                Console.WriteLine("\t\t\t\t\t  ││                            ││");
                Console.WriteLine("\t\t\t\t\t  ├┼────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t\t  └┴────────────────────────────┴┘");

                Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t\t││   Digite a opção desejada:     ││");
                Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────┴┘");
                Console.SetCursorPosition(70, 27);
                bool valido;
                valido = Int32.TryParse(Console.ReadLine(), out op);//<-------------------validação para n deixar o usario digitar qualquer coisa !!!
                while (!valido || op < 0 || op > N)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t├┼─────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t││                                             ││");
                    Console.WriteLine("\t\t\t\t││      ─────────────────────────────────      ││");
                    Console.WriteLine("\t\t\t\t││      Opcao Inválida! Digite novamente:      ││");
                    Console.WriteLine("\t\t\t\t││      ─────────────────────────────────      ││");
                    Console.WriteLine("\t\t\t\t││                                             ││");
                    Console.WriteLine("\t\t\t\t├┼─────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────┴┘");

                    Console.WriteLine("\n\t\t\t\t\t  ┌┬────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t\t  ├┼────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t\t  ││       Menu Principal       ││");
                    Console.WriteLine("\t\t\t\t\t  ││       ──────────────       ││");
                    Console.WriteLine("\t\t\t\t\t  ││                            ││");
                    Console.WriteLine("\t\t\t\t\t  ││  1 - Cadastrar             ││");
                    Console.WriteLine("\t\t\t\t\t  ││  2 - Exibir Lista          ││");
                    Console.WriteLine("\t\t\t\t\t  ││  3 - Procurar Produto      ││");
                    Console.WriteLine("\t\t\t\t\t  ││  4 - Alterar               ││");
                    Console.WriteLine("\t\t\t\t\t  ││  5 - Excluir               ││");
                    Console.WriteLine("\t\t\t\t\t  ||  6 - Comprar Produtos      ||");
                    Console.WriteLine("\t\t\t\t\t  ││  7 - Vender Produtos       ││");
                    Console.WriteLine("\t\t\t\t\t  ││  8 - Sair                  ││");
                    Console.WriteLine("\t\t\t\t\t  ││                            ││");
                    Console.WriteLine("\t\t\t\t\t  ├┼────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t\t  └┴────────────────────────────┴┘");

                    Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t\t││   Digite a opção desejada:     ││");
                    Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────┴┘");
                    Console.SetCursorPosition(70, 27);
                    valido = Int32.TryParse(Console.ReadLine(), out op);//<-------------------validação para n deixar o usario digitar qualquer coisa !!!
                }
                Console.Clear();

                switch (op)
                {
                    case 1:
                        {
                            N = 3;
                            Cadastrar_Prod_Fornec(Prod, Fornec, op, N, Cmn_Fornec, Cmn_Prod);
                            break;
                        }

                    case 2:
                        {
                            N = 3;
                            Exibir_Cadastro(N, Prod, Fornec, op, Cmn_Prod, Cmn_Fornec);
                            break;
                        }

                    case 3:
                        {
                            Procurar_Produto(Prod, Cmn_Prod);
                            break;
                        }

                    case 4:
                        {
                            N = 3;
                            Alterar(Prod, Fornec, op, N, Cmn_Fornec, Cmn_Prod);
                            break;
                        }
                    case 5:
                        {
                            Deletar_produto(Cmn_Prod);
                            break;
                        }
                    case 6:
                        {
                            Compras_Prod(Cmn_Prod, Prod);
                            break;
                        }
                    case 7:
                        {
                            N = 3;
                            Menu_Vendas(Prod, Cmn_Prod, op, N);
                            break;
                        }
                }

            } while (op != N);

            Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");

            Console.ReadKey();
        }
        //===========================================================================================================
        //Menu de pesquisa de produto
        //===========================================================================================================
        static void Procurar_Produto(Mercadoria Prod, string Cmn_Prod)
        {
            string caminho = "Produtos.dat";

            FileStream relatorio = new FileStream(caminho, FileMode.Open, FileAccess.Read);

            BinaryReader ag = new BinaryReader(relatorio);

            Console.Clear();
            Console.WriteLine("\t\t\t\t┌┬───────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t││        ────────────────       ││");
            Console.WriteLine("\t\t\t\t││        Menu de Pesquisa       ││");
            Console.WriteLine("\t\t\t\t││        ────────────────       ││");
            Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t└┴───────────────────────────────┴┘");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("\t\t┌┬───────────────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t││ Digite o código do Produto que deseja pesquisar:          ││");
            Console.WriteLine("\t\t└┴───────────────────────────────────────────────────────────┴┘");
            Console.SetCursorPosition(68, 11);

            int busca;
            bool valido;
            valido = int.TryParse(Console.ReadLine(), out busca);//<-------------------validação para n deixar o usario digitar qualquer coisa !!!
            while (!valido || busca < 0)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││                                                                            ││");
                Console.WriteLine("\t\t\t││      ────────────────────────────────────────────────────────────────      ││");
                Console.WriteLine("\t\t\t││      Opcao Inválida! Digite o código do Produto que deseja pesquisar:      ││");
                Console.WriteLine("\t\t\t││      ────────────────────────────────────────────────────────────────      ││");
                Console.WriteLine("\t\t\t││                                                                            ││");
                Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(96, 4);
                valido = int.TryParse(Console.ReadLine(), out busca);
                Console.Clear();
            }

            while (ag.PeekChar() != -1)
            {
                Prod.Cod_Prod = ag.ReadInt32();
                Prod.Nome_Prod = ag.ReadString();
                Prod.Preco_Prod = ag.ReadDouble();
                Prod.Quant_Prod = ag.ReadInt32();

                if (busca == Prod.Cod_Prod)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t┌┬───────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t├┼───────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t││        ────────────────       ││");
                    Console.WriteLine("\t\t\t││        Menu de Pesquisa       ││");
                    Console.WriteLine("\t\t\t││        ────────────────       ││");
                    Console.WriteLine("\t\t\t├┼───────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t└┴───────────────────────────────┴┘");

                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t\t┌┬────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\tCodigo: {0}", Prod.Cod_Prod);
                    Console.WriteLine("\t\t\t\tProduto: {0}", Prod.Nome_Prod);
                    Console.WriteLine("\t\t\t\tPreco: {0}", Prod.Preco_Prod);
                }
            }

            ag.Close();
            relatorio.Close();

            Console.WriteLine("\t\t\t┌┬────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴────────────────────────────────┴┘");
            Console.WriteLine("\n\n\t\t   ┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t   ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t   ││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t   ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t   └┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        //Sub-Rotina de Opcao/ Verificação
        //===========================================================================================================
        static int Opcao(int op, int N)                              //Sub de Opção
        {
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("\t\t\t\t┌┬────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t││   Digite a opção desejada:     ││");
            Console.WriteLine("\t\t\t\t└┴────────────────────────────────┴┘");
            Console.SetCursorPosition(62, 24);
            bool valido;
            valido = Int32.TryParse(Console.ReadLine(), out op);
            while (!valido || op <= 0 || op > N)
            {
                Console.WriteLine("");
                Console.WriteLine("\t\t          ┌┬─────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t          ├┼─────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t          ││                                             ││");
                Console.WriteLine("\t\t          ││      ─────────────────────────────────      ││");
                Console.WriteLine("\t\t          ││      Opcao Inválida! Digite novamente       ││");
                Console.WriteLine("\t\t          ││      ─────────────────────────────────      ││");
                Console.WriteLine("\t\t          ││                                             ││");
                Console.WriteLine("\t\t          ├┼─────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t          └┴─────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(62, 24);
                valido = Int32.TryParse(Console.ReadLine(), out op);
            }
            Console.Clear();
            return op;
        }
        //===========================================================================================================
        //Menu para exibir lista de produtos e fornecedores
        //===========================================================================================================
        static void Exibir_Cadastro(int N, Mercadoria Prod, Fornecedor Fornec, int op, string Cmn_Prod, string Cmn_Fornec)//Relatorio geral e pesquisa por Produto ou Fornecedor
        {

            do
            {
                N = 3;
                op = 0;

                Console.Clear();
                Console.WriteLine("\t\t\t\t┌┬───────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││        ────────────────       ││");
                Console.WriteLine("\t\t\t\t││        Menu de Exibição       ││");
                Console.WriteLine("\t\t\t\t││        ────────────────       ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││ 1- Relatorio de produtos      ││");
                Console.WriteLine("\t\t\t\t││ 2- Relatorio de fornecedores  ││");
                Console.WriteLine("\t\t\t\t││ 3- Retornar ao Menu Principal ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t└┴───────────────────────────────┴┘");
                Console.Write("\n");
                op = Opcao(op, N);

                switch (op)
                {
                    case 1:
                        {
                            N = 3;
                            Relat_Prod(Prod, Cmn_Prod);
                            break;
                        }

                    case 2:
                        {
                            N = 3;
                            Relat_Fornec(Fornec, Cmn_Fornec);
                            break;
                        }
                }
            } while (op != 3);


        }
        //===========================================================================================================
        //Menu de cadastro
        //===========================================================================================================
        static void Cadastrar_Prod_Fornec(Mercadoria Prod, Fornecedor Fornec, int op, int N, string Cmn_Fornec, string Cmn_Prod)//Cadastro de Produtos e Fornecedores
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t┌┬───────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││        ────────────────       ││");
                Console.WriteLine("\t\t\t\t││        Menu de Cadastro       ││");
                Console.WriteLine("\t\t\t\t││        ────────────────       ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││ 1- Cadastrar Produto          ││");
                Console.WriteLine("\t\t\t\t││ 2- Cadastrar Fornecedor       ││");
                Console.WriteLine("\t\t\t\t││ 3- Retornar ao Menu Principal ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t└┴───────────────────────────────┴┘");
                Console.Write("\n");
                op = Opcao(op, N);

                switch (op)
                {
                    case 1:
                        {
                            Cadastrar_Produto(Prod, Cmn_Prod);
                            break;
                        }
                    case 2:
                        {
                            Cadastrar_Fornecedor(Fornec, Cmn_Fornec);
                            break;
                        }
                }
            } while (op != 3);
        }
        //fim das sub-rotinas Principal

        //inicio sub-rotinas do sub menu
        //===========================================================================================================
        //Cadastrar produtos
        //===========================================================================================================
        static void Cadastrar_Produto(Mercadoria Prod, string Cmn_Prod)
        {
            Console.Clear();
            string Op_SN;
            string Cad = "Codigo.dat";
            int Codigo = 0;

            do
            {
                Console.WriteLine("\t\t\t\t┌┬───────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││       ─────────────────       ││");
                Console.WriteLine("\t\t\t\t││       Cadastrar Produto       ││");
                Console.WriteLine("\t\t\t\t││       ─────────────────       ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t└┴───────────────────────────────┴┘");
                Console.WriteLine("\n\n");

                Console.WriteLine("\t\t\t┌┬──────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼──────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││  Deseja cadastrar novo produto?(S ou N) [ ]  ││");
                Console.WriteLine("\t\t\t├┼──────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴──────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(68, 14);
                Op_SN = Console.ReadLine();
                Console.Clear();

                while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
                {
                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t││                                                                        ││");
                    Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t││      Opcao Inválida! Deseja cadastrar novo produto?(S ou N) [ ]        ││");
                    Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t││                                                                        ││");
                    Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────────────────────────┴┘");
                    Console.SetCursorPosition(88, 4);
                    Op_SN = Console.ReadLine();
                    Console.Clear();
                }

                if (Op_SN == "S" || Op_SN == "s")
                {
                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\tDescrição do produto: ");
                    Console.SetCursorPosition(53, 2);
                    Prod.Nome_Prod = Console.ReadLine();

                    Console.WriteLine("\t\t\t\tDigite Preço: ");
                    Console.SetCursorPosition(45, 3);
                    Prod.Preco_Prod = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────┴┘");
                    Console.WriteLine("\n\n");
                    while (Prod.Preco_Prod <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t││                                                                        ││");
                        Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                        Console.WriteLine("\t\t\t││              Preço do produto inválido!Digite novamente:               ││");
                        Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                        Console.WriteLine("\t\t\t││                                                                        ││");
                        Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────────────────────────┴┘");
                        Console.SetCursorPosition(84, 4);
                        Prod.Preco_Prod = double.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    Verificar3(Cad);
                    FileStream Cad_Cod = new FileStream(Cad, FileMode.Open, FileAccess.Read);
                    BinaryReader sr = new BinaryReader(Cad_Cod);

                    while (sr.PeekChar() != -1)
                    {
                        Codigo = sr.ReadInt32();
                    }

                    Codigo++;

                    sr.Close();
                    Cad_Cod.Close();

                    Console.WriteLine("\t\t\t   ┌┬────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t   └┴────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\t    Codigo: {0}", Codigo);
                    Console.WriteLine("\t\t\t\t    Produto: {0}", Prod.Nome_Prod);
                    Console.WriteLine("\t\t\t\t    Preco: {0:C}", Prod.Preco_Prod);
                    Console.WriteLine("\t\t\t   ┌┬────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t   └┴────────────────────────────────┴┘");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t││                                                    ││");
                    Console.WriteLine("\t\t\t││      ──────────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t││      Deseja cadastrar esse produto?(S ou N) [ ]    ││");
                    Console.WriteLine("\t\t\t││      ──────────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t││                                                    ││");
                    Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────┴┘");
                    Console.SetCursorPosition(72, 23);
                    Op_SN = Console.ReadLine();
                    while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t││                                                                        ││");
                        Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                        Console.WriteLine("\t\t\t││      Opcao Inválida! Deseja cadastrar novo produto?(S ou N) [ ]        ││");
                        Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                        Console.WriteLine("\t\t\t││                                                                        ││");
                        Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────────────────────────┴┘");
                        Console.SetCursorPosition(88, 4);
                        Op_SN = Console.ReadLine();
                    }
                    Console.Clear();

                    if (Op_SN == "S" || Op_SN == "s")
                    {
                        FileStream Cad_Cod1 = new FileStream(Cad, FileMode.Open, FileAccess.Read);
                        BinaryReader sr1 = new BinaryReader(Cad_Cod1);

                        while (sr1.PeekChar() != -1)
                        {
                            Prod.Cod_Prod = sr1.ReadInt32();
                        }

                        Prod.Cod_Prod++;

                        sr1.Close();
                        Cad_Cod.Close();

                        FileStream Cad_Cod2 = new FileStream(Cad, FileMode.Create, FileAccess.Write);
                        BinaryWriter bw2 = new BinaryWriter(Cad_Cod2);

                        bw2.Write(Prod.Cod_Prod);

                        bw2.Close();
                        Cad_Cod.Close();

                        FileStream Prod_arq = new FileStream(Cmn_Prod, FileMode.Append, FileAccess.Write);
                        BinaryWriter bw = new BinaryWriter(Prod_arq);
                        Prod.Quant_Prod = 0;


                        bw.Write(Prod.Cod_Prod);
                        bw.Write(Prod.Nome_Prod);
                        bw.Write(Prod.Preco_Prod);
                        bw.Write(Prod.Quant_Prod);

                        bw.Close();
                        Prod_arq.Close();
                        Console.WriteLine("\t\t\t  Produto cadastrado com Sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t  Produto nao foi cadastrado!");
                    }
                }
                Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t└┴───────────────────────────────────────────┴┘");
                Console.WriteLine("\n\n\t\t\t┌┬─────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
                Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
                Console.ReadKey();
                Console.Clear();

            } while (Op_SN == "S" || Op_SN == "s");
        }
        //===========================================================================================================
        //Cadastrar fornecedores
        //===========================================================================================================
        static void Cadastrar_Fornecedor(Fornecedor Fornec, string Cmn_Fornec)
        {
            Console.Clear();
            string Op_SN;
            string Cad = "Cod_Fornec.dat";
            int Codigo = 0;

            FileStream Fornec_arq = new FileStream(Cmn_Fornec, FileMode.Append, FileAccess.Write);
            StreamWriter fn = new StreamWriter(Fornec_arq);

            do
            {
                Console.WriteLine("\t\t\t┌┬────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││      ────────────────────      ││");
                Console.WriteLine("\t\t\t││      Cadastrar Fornecedor      ││");
                Console.WriteLine("\t\t\t││      ────────────────────      ││");
                Console.WriteLine("\t\t\t├┼────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴────────────────────────────────┴┘");
                Console.WriteLine("\n\n");

                Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼─────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││  Deseja cadastrar novo Fornecedor?(S ou N) [ ]  ││");
                Console.WriteLine("\t\t\t├┼─────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(71, 12);
                Op_SN = Console.ReadLine();
                Console.Clear();
                while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
                {
                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t││                                                                        ││");
                    Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t││      Opcao Inválida! Deseja cadastrar novo produto?(S ou N) [ ]        ││");
                    Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t││                                                                        ││");
                    Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────────────────────────┴┘");
                    Console.SetCursorPosition(88, 4);
                    Op_SN = Console.ReadLine();
                    Console.Clear();
                }

                if (Op_SN == "S" || Op_SN == "s")
                {
                    Verificar3(Cad);
                    FileStream Cad_Cod = new FileStream(Cad, FileMode.Open, FileAccess.Read);
                    BinaryReader sr = new BinaryReader(Cad_Cod);

                    while (sr.PeekChar() != -1)
                    {
                        Codigo = sr.ReadInt32();
                    }

                    Codigo++;

                    sr.Close();
                    Cad_Cod.Close();

                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────────┴┘");

                    Console.Write("\t\t\t\tNome do fornecedor: ");
                    Console.SetCursorPosition(52, 2);
                    Fornec.Nome_Fornec = Console.ReadLine();

                    Console.Write("\t\t\t\tDigite o nome da empresa: ");
                    Console.SetCursorPosition(58, 3);
                    Fornec.Emp_Fornec = Console.ReadLine();

                    Console.Write("\t\t\t\tDigite endereço: ");
                    Console.SetCursorPosition(49, 4);
                    Fornec.End_Fornec = Console.ReadLine();

                    Console.Write("\t\t\t\tDigite o telefone para contato: ");
                    Console.SetCursorPosition(64, 5);
                    Fornec.Tel_Fornec = Console.ReadLine();

                    Console.WriteLine("\t\t\t┌┬────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────────────┴┘");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("\t\t\t┌┬─────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴─────────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t  Codigo: " + Codigo);
                    Console.WriteLine("\t\t\t  Nome: " + Fornec.Nome_Fornec);
                    Console.WriteLine("\t\t\t  Empresa: " + Fornec.Emp_Fornec);
                    Console.WriteLine("\t\t\t  Endereco: " + Fornec.End_Fornec);
                    Console.WriteLine("\t\t\t  Telefone: " + Fornec.Tel_Fornec);
                    Console.WriteLine("\t\t\t┌┬────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴────────────────────────────────┴┘");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t││  Deseja cadastrar esse fornecedor?(S ou N) [ ]  ││");
                    Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────┴┘");
                    Console.SetCursorPosition(71, 24);
                    Op_SN = Console.ReadLine();
                    Console.Clear();
                    while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
                    {
                        Console.WriteLine("\t\t\t┌┬────────────────────────────────────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t││                                                                        ││");
                        Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                        Console.WriteLine("\t\t\t││      Opcao Inválida! Deseja cadastrar novo fornecedor?(S ou N) [ ]     ││");
                        Console.WriteLine("\t\t\t││      ──────────────────────────────────────────────────────────────    ││");
                        Console.WriteLine("\t\t\t││                                                                        ││");
                        Console.WriteLine("\t\t\t├┼────────────────────────────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t└┴────────────────────────────────────────────────────────────────────────┴┘");
                        Console.SetCursorPosition(91, 4);
                        Op_SN = Console.ReadLine();
                        Console.Clear();
                    }

                    Codigo--;

                    if (Op_SN == "S" || Op_SN == "s")
                    {
                        FileStream Cad_Cod1 = new FileStream(Cad, FileMode.Open, FileAccess.Read);
                        BinaryReader sr1 = new BinaryReader(Cad_Cod1);

                        while (sr1.PeekChar() != -1)
                        {
                            Codigo = sr1.ReadInt32();
                        }

                        Codigo++;

                        string Codigo1 = Convert.ToString(Codigo);

                        Fornec.Cod_Fornec = Codigo1;

                        sr1.Close();
                        Cad_Cod.Close();

                        FileStream Cad_Cod2 = new FileStream(Cad, FileMode.Open, FileAccess.Write);
                        BinaryWriter bw2 = new BinaryWriter(Cad_Cod2);


                        Codigo = Convert.ToInt32(Codigo1);
                        bw2.Write(Codigo);

                        bw2.Close();
                        Cad_Cod.Close();

                        fn.Write(Fornec.Cod_Fornec + ";");
                        fn.Write(Fornec.Nome_Fornec + ";");
                        fn.Write(Fornec.Emp_Fornec + ";");
                        fn.Write(Fornec.End_Fornec + ";");
                        fn.WriteLine(Fornec.Tel_Fornec + ";");
                        Console.WriteLine("\t\t\t  Fornecedor cadastrado com Sucesso!");
                    }
                    else
                    {
                        Codigo--;
                        Console.WriteLine("\t\t\t  Fornecedor nao foi cadastrado!");
                    }
                    Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴───────────────────────────────────────────┴┘");
                    Console.WriteLine("\n\n\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
                    Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (Op_SN == "S" || Op_SN == "s");

            fn.Close();
            Fornec_arq.Close();
        }
        //===========================================================================================================
        //Relatorio de produtos
        //===========================================================================================================
        static void Relat_Prod(Mercadoria Prod, string Cmn_Prod)
        {
            Console.Clear();

            FileStream Relat = new FileStream(Cmn_Prod, FileMode.Open, FileAccess.Read);
            BinaryReader rd = new BinaryReader(Relat);

            Console.WriteLine("\t\t\t\t┌┬───────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t├┼───────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t││   Relatório de Produtos!  ││");
            Console.WriteLine("\t\t\t\t├┼───────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t└┴───────────────────────────┴┘");
            Console.WriteLine("\n\n");

            while (rd.PeekChar() != -1)
            {
                Prod.Cod_Prod = rd.ReadInt32();
                Prod.Nome_Prod = rd.ReadString();
                Prod.Preco_Prod = rd.ReadDouble();
                Prod.Quant_Prod = rd.ReadInt32();


                Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t└┴───────────────────────────────────────────┴┘");
                Console.WriteLine("\t\t\t           Código: {0}", Prod.Cod_Prod);
                Console.WriteLine("\t\t\t           Produto: {0}", Prod.Nome_Prod);
                Console.WriteLine("\t\t\t           Preço: {0:C}", Prod.Preco_Prod);
                Console.WriteLine("\t\t\t           Quantidade: {0}", Prod.Quant_Prod);

            }
            rd.Close();
            Relat.Close();
            Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴───────────────────────────────────────────┴┘");
            Console.WriteLine("\n\n\t\t\t┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        //Relatorio de fornecedores
        //===========================================================================================================
        static void Relat_Fornec(Fornecedor Fornec, string Cmn_Fornec)
        {
            Console.Clear();

            FileStream Relat = new FileStream(Cmn_Fornec, FileMode.Open, FileAccess.ReadWrite);
            StreamReader rd = new StreamReader(Relat);

            Console.WriteLine("\t\t\t       ┌┬──────────────────────────────┬┐");
            Console.WriteLine("\t\t\t       ├┼──────────────────────────────┼┤");
            Console.WriteLine("\t\t\t       ││  Relatório de Fornecedores!  ││");
            Console.WriteLine("\t\t\t       ├┼──────────────────────────────┼┤");
            Console.WriteLine("\t\t\t       └┴──────────────────────────────┴┘");
            Console.WriteLine("\n\n");
            while (rd.Peek() != -1)
            {
                string linha = rd.ReadLine();
                int pos1 = linha.IndexOf(";");

                pos1 = linha.IndexOf(";") + 1;
                int pos2 = linha.IndexOf(";", pos1) + 1;
                int pos3 = linha.IndexOf(";", pos2) + 1;
                int pos4 = linha.IndexOf(";", pos3) + 1;
                int pos5 = linha.IndexOf(";", pos4) + 1;

                Fornec.Cod_Fornec = linha.Substring(0, pos1 - 1);
                Fornec.Nome_Fornec = linha.Substring(pos1, pos2 - pos1 - 1);
                Fornec.Emp_Fornec = linha.Substring(pos2, pos3 - pos2 - 1);
                Fornec.End_Fornec = linha.Substring(pos3, pos4 - pos3 - 1);
                Fornec.Tel_Fornec = linha.Substring(pos4, pos5 - pos4 - 1);

                Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
                Console.WriteLine("\t\t\t    Codigo: " + Fornec.Cod_Fornec);
                Console.WriteLine("\t\t\t    Nome: " + Fornec.Nome_Fornec);
                Console.WriteLine("\t\t\t    Empresa: " + Fornec.Emp_Fornec);
                Console.WriteLine("\t\t\t    Endereco: " + Fornec.End_Fornec);
                Console.WriteLine("\t\t\t    Telefone: " + Fornec.Tel_Fornec);

            }
            rd.Close();
            Relat.Close();
            Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
            Console.WriteLine("\n\n\t\t\t┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        //Alterar produtos
        //============================================================================================================
        static void Alt_Prod(string Cmn_Prod)
        {
            Console.Clear();

            FileStream arqprod = new FileStream(Cmn_Prod, FileMode.Open, FileAccess.Read);
            BinaryReader ag = new BinaryReader(arqprod);

            string alterar = "Alteres caminheste.back";
            if (File.Exists(alterar))
            {
                System.IO.File.Delete("Alteres caminheste.back");
            }
            FileStream altprod = new FileStream(alterar, FileMode.CreateNew, FileAccess.ReadWrite);
            BinaryWriter alt = new BinaryWriter(altprod);

            Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────────┴┘");
            Console.Write("\t\t\t    Entre com o codigo do produto que queira alterar: ");
            Console.SetCursorPosition(78, 2);
            int Alprod;
            bool valida;
            valida = Int32.TryParse(Console.ReadLine(), out Alprod);// <---------------Validação para n deixar o usario digitar qualquer coisa!!
            while (!valida)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t  Erro codigo invalido!!");
                Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────────┴┘");
                Console.Write("\t\t\t    Entre com o codigo do produto que queira alterar: ");
                Console.SetCursorPosition(78, 3);
                valida = Int32.TryParse(Console.ReadLine(), out Alprod);
                Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────────┴┘");
                Console.Clear();
            }
            Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────────┴┘");

            while (ag.PeekChar() != -1)
            {

                int codigo = ag.ReadInt32();
                string nomeprod = ag.ReadString();
                double preco = ag.ReadDouble();
                int quant = ag.ReadInt32();

                if (Alprod == codigo)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t     ┌┬────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t     └┴────────────────────────────────────────────┴┘");
                    Console.Write("\t\t\t\t       Entre com o novo codigo: ");
                    Console.SetCursorPosition(64, 4);
                    valida = Int32.TryParse(Console.ReadLine(), out codigo);
                    while (!valida)
                    {
                        Console.WriteLine("\n\n\t\t\t     ┌┬────────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t     └┴────────────────────────────────────────────┴┘");
                        Console.Write("\t\t\t\t Erro! Entre com o novo codigo: ");
                        Console.SetCursorPosition(64, 9);
                        valida = Int32.TryParse(Console.ReadLine(), out codigo);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t     ┌┬────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t     └┴────────────────────────────────────────────┴┘");
                    Console.Write("\t\t\t\t  Entre com o novo nome do produto: ");
                    Console.SetCursorPosition(68, 4);
                    nomeprod = Console.ReadLine();

                    Console.Write("\t\t\t\t       Entre com o novo preco: ");
                    Console.SetCursorPosition(63, 5);
                    valida = double.TryParse(Console.ReadLine(), out preco);

                    while (!valida || preco < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("┌┬─────────────────────────────────────────┬┐");
                        Console.WriteLine("└┴─────────────────────────────────────────┴┘");
                        Console.Write("Preço invalido! Digite novamente o novo preco: ");
                        valida = double.TryParse(Console.ReadLine(), out preco);
                    }

                    alt.Write(codigo);
                    alt.Write(nomeprod);
                    alt.Write(preco);
                    alt.Write(quant);
                }
                else
                {
                    alt.Write(codigo);
                    alt.Write(nomeprod);
                    alt.Write(preco);
                    alt.Write(quant);
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t  ┌┬─────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t  ├┼─────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t  ││  Produto alterado com sucesso!  ││");
            Console.WriteLine("\t\t\t\t  ├┼─────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t  └┴─────────────────────────────────┴┘");

            ag.Close();
            alt.Close();
            arqprod.Close();
            System.IO.File.Delete(Cmn_Prod);
            System.IO.File.Move(alterar, Cmn_Prod);
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t       ┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t       ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t       ││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t       ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t       └┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        //Alterar fornecedor
        //===========================================================================================================
        static void Alt_Fornec(string Cmn_Fornec, Fornecedor Fornec)
        {
            FileStream arqfornec = new FileStream(Cmn_Fornec, FileMode.Open, FileAccess.Read);
            StreamReader ag = new StreamReader(arqfornec);
            bool exists = false; //<---------------------validação para verificar se o arquivo existe!!!
            string alterarFornec = "Soparaalterar.dat";
            if (File.Exists(alterarFornec))
            {
                System.IO.File.Delete("Soparaalterar.dat");
            }
            FileStream arqsla = new FileStream(alterarFornec, FileMode.CreateNew, FileAccess.Write);
            StreamWriter ag1 = new StreamWriter(arqsla);

            Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴───────────────────────────────────────────────────┴┘");
            Console.Write("\t\t\t  Entre com o nome do fornecedor que deseja alterar: ");
            string busca = Console.ReadLine();
            Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t└┴───────────────────────────────────────────────────┴┘");

            while (ag.Peek() != -1)//<----------------fazer varredura do arquivo!!
            {

                string linha = ag.ReadLine();
                int pos1 = linha.IndexOf(";");

                pos1 = linha.IndexOf(";") + 1;
                int pos2 = linha.IndexOf(";", pos1) + 1;
                int pos3 = linha.IndexOf(";", pos2) + 1;
                int pos4 = linha.IndexOf(";", pos3) + 1;
                int pos5 = linha.IndexOf(";", pos4) + 1;

                Fornec.Cod_Fornec = linha.Substring(0, pos1 - 1);
                Fornec.Nome_Fornec = linha.Substring(pos1, pos2 - pos1 - 1);
                Fornec.Emp_Fornec = linha.Substring(pos2, pos3 - pos2 - 1);
                Fornec.End_Fornec = linha.Substring(pos3, pos4 - pos3 - 1);
                Fornec.Tel_Fornec = linha.Substring(pos4, pos5 - pos4 - 1);
                if (busca == Fornec.Nome_Fornec)
                {
                    exists = true;//<----------------flag para verificar se o fornecedor existe no arquivo!!
                    Console.Write("\n\n");
                    Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.Write("\t\t\t\tNome do fornecedor: ");
                    Fornec.Nome_Fornec = Console.ReadLine();
                    Console.Write("\t\t\t\tDigite o nome da empresa: ");
                    Fornec.Emp_Fornec = Console.ReadLine();
                    Console.Write("\t\t\t\tDigite endereço: ");
                    Fornec.End_Fornec = Console.ReadLine();
                    Console.Write("\t\t\t\tDigite o telefone para contato: ");
                    Fornec.Tel_Fornec = Console.ReadLine();
                    Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");

                    ag1.Write(Fornec.Cod_Fornec + ";");
                    ag1.Write(Fornec.Nome_Fornec + ";");
                    ag1.Write(Fornec.Emp_Fornec + ";");
                    ag1.Write(Fornec.End_Fornec + ";");
                    ag1.WriteLine(Fornec.Tel_Fornec + ";");
                }
                else
                {
                    ag1.Write(Fornec.Cod_Fornec + ";");
                    ag1.Write(Fornec.Nome_Fornec + ";");
                    ag1.Write(Fornec.Emp_Fornec + ";");
                    ag1.Write(Fornec.End_Fornec + ";");
                    ag1.WriteLine(Fornec.Tel_Fornec + ";");
                }
            }
            if (!exists)
            {
                Console.WriteLine("\t\t\t┌┬──────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼──────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││  Fornecedor Não Encontrado!  ││");
                Console.WriteLine("\t\t\t├┼──────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴──────────────────────────────┴┘");
            }
            ag.Close();
            ag1.Close();
            System.IO.File.Delete(Cmn_Fornec);
            System.IO.File.Move(alterarFornec, Cmn_Fornec);

            Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        // Deletar produtos
        //===========================================================================================================
        static void Deletar_produto(string Cmn_Prod)
        {
            Console.Clear();

            FileStream arqprod = new FileStream(Cmn_Prod, FileMode.Open, FileAccess.Read);
            BinaryReader ag = new BinaryReader(arqprod);

            string alterar = "Deletar.back";
            if (File.Exists(alterar))
            {
                System.IO.File.Delete("Deletar.back");

            }
            FileStream altprod = new FileStream(alterar, FileMode.CreateNew, FileAccess.Write);
            BinaryWriter alt = new BinaryWriter(altprod);

            Console.WriteLine("\t\t\t┌┬──────────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t├┼──────────────────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t││  Entre com o codigo do produto que queira deletar:   ││");
            Console.WriteLine("\t\t\t├┼──────────────────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t└┴──────────────────────────────────────────────────────┴┘");
            Console.SetCursorPosition(78, 2);
            int Alprod = int.Parse(Console.ReadLine());

            while (ag.PeekChar() != -1)
            {
                int codigo = ag.ReadInt32();
                string nomeprod = ag.ReadString();
                double preco = ag.ReadDouble();
                int quantidade = ag.ReadInt32();

                if (Alprod == codigo)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t\t┌┬─────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t\t├┼─────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t\t││  Produto Deletado!  ││");
                    Console.WriteLine("\t\t\t\t\t├┼─────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t\t└┴─────────────────────┴┘");
                }
                else
                {
                    alt.Write(codigo);
                    alt.Write(nomeprod);
                    alt.Write(preco);
                    alt.Write(quantidade);
                }
            }
            ag.Close();
            alt.Close();
            System.IO.File.Delete(Cmn_Prod);
            System.IO.File.Move(alterar, Cmn_Prod);

            Console.WriteLine("\n\n\t\t\t      ┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t      ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t      ││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t      ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t      └┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }

        //fim sub-rotinas do sub menu

        static bool Verificar(string Cmn_Fornec)
        {
            if (File.Exists(Cmn_Fornec))
            {
                return true;
            }
            else
            {

                FileStream arqfornec = new FileStream(Cmn_Fornec, FileMode.CreateNew);
                StreamReader ag = new StreamReader(arqfornec);

                arqfornec.Close();
                ag.Close();
                return false;
            }
        }
        static bool Verificar1(string Cmn_Prod)
        {
            if (File.Exists(Cmn_Prod))
            {
                return true;
            }
            else
            {
                FileStream arqprod = new FileStream(Cmn_Prod, FileMode.CreateNew);
                BinaryReader ag1 = new BinaryReader(arqprod);

                arqprod.Close();
                ag1.Close();
                return false;
            }
        }

        static bool Verificar3(string Cad)
        {
            if (File.Exists(Cad))
            {
                return true;
            }
            else
            {
                FileStream Cad_Cod = new FileStream(Cad, FileMode.CreateNew);
                BinaryReader br = new BinaryReader(Cad_Cod);

                br.Close();
                Cad_Cod.Close();
                return false;
            }
        }

        static bool Verificar2()
        {
            string Vend = "Vendas.dat";
            if (File.Exists(Vend))
            {
                return true;
            }
            else
            {
                FileStream Reg_Vend = new FileStream(Vend, FileMode.CreateNew);
                BinaryReader br = new BinaryReader(Reg_Vend);

                br.Close();
                Reg_Vend.Close();
                return false;
            }
        }
        //===========================================================================================================
        //Compras
        //===========================================================================================================
        static void Compras_Prod(string Cmn_Prod, Mercadoria Prod)
        {
            Console.Clear();

            string alterar = "Deletar.back";
            if (File.Exists(alterar))
            {
                System.IO.File.Delete("Deletar.back");
            }

            string Op_SN;

            Console.WriteLine("\t\t\t\t┌┬────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t├┼────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t││        Comprar Produtos        ││");
            Console.WriteLine("\t\t\t\t├┼────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t└┴────────────────────────────────┴┘");
            Console.WriteLine("\n\n");

            Console.WriteLine("\t\t\t┌┬──────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t├┼──────────────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t││  Digite o código do produto que deseja comprar:  ││");
            Console.WriteLine("\t\t\t├┼──────────────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t└┴──────────────────────────────────────────────────┴┘");
            Console.SetCursorPosition(74, 10);
            int Codigo = int.Parse(Console.ReadLine());

            FileStream Prod_arq = new FileStream(Cmn_Prod, FileMode.Open, FileAccess.Read);
            BinaryReader rd = new BinaryReader(Prod_arq);

            FileStream Prod_arq2 = new FileStream(alterar, FileMode.CreateNew, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(Prod_arq2);

            while (rd.PeekChar() != -1)
            {
                Prod.Cod_Prod = rd.ReadInt32();
                Prod.Nome_Prod = rd.ReadString();
                Prod.Preco_Prod = rd.ReadDouble();
                Prod.Quant_Prod = rd.ReadInt32();

                if (Codigo == Prod.Cod_Prod)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\t\t\tCodigo: {0}", Prod.Cod_Prod);
                    Console.WriteLine("\t\t\t\t\t\tProduto: {0}", Prod.Nome_Prod);
                    Console.WriteLine("\t\t\t\t\t\tPreco: {0:C}", Prod.Preco_Prod);
                    Console.WriteLine("\t\t\t\t\t\tQuantidade: {0}", Prod.Quant_Prod);
                    Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\t     Digite a quantidade que deseja comprar: ");
                    Console.SetCursorPosition(77, 13);
                    int Quantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("\t\t\t\t┌┬───────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t├┼───────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t││                                               ││");
                    Console.WriteLine("\t\t\t\t││      ──────────────────────────────────────   ││");
                    Console.WriteLine("\t\t\t\t││           Deseja comprar {0} {1}?           ||", Quantidade, Prod.Nome_Prod);
                    Console.WriteLine("\t\t\t\t││                (S ou N) [ ]                   ││");
                    Console.WriteLine("\t\t\t\t││      ─────────────────────────────────────    ││");
                    Console.WriteLine("\t\t\t\t││                                               ││");
                    Console.WriteLine("\t\t\t\t├┼───────────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t\t└┴───────────────────────────────────────────────┴┘");
                    Console.SetCursorPosition(60, 23);
                    Op_SN = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t┌┬───────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t││       Procedimento Realizada com Sucesso      ││");
                    Console.WriteLine("\t\t\t\t└┴───────────────────────────────────────────────┴┘");
                    while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t├┼─────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t││     Opcao Inválida! Deseja comprar {0} {1}    ||", Quantidade, Prod.Nome_Prod);
                        Console.WriteLine("\t\t\t││                    (S ou N) [ ]                 ││");
                        Console.WriteLine("\t\t\t├┼─────────────────────────────────────────────────┼┤");
                        Console.WriteLine("\t\t\t└┴─────────────────────────────────────────────────┴┘");
                        Console.SetCursorPosition(56, 3);
                        Op_SN = Console.ReadLine();
                    }

                    if (Op_SN == "S" || Op_SN == "s")
                    {
                        Prod.Quant_Prod = Prod.Quant_Prod + Quantidade;

                        bw.Write(Prod.Cod_Prod);
                        bw.Write(Prod.Nome_Prod);
                        bw.Write(Prod.Preco_Prod);
                        bw.Write(Prod.Quant_Prod);
                    }
                    else
                    {
                        bw.Write(Prod.Cod_Prod);
                        bw.Write(Prod.Nome_Prod);
                        bw.Write(Prod.Preco_Prod);
                        bw.Write(Prod.Quant_Prod);
                    }
                }
                else
                {
                    bw.Write(Prod.Cod_Prod);
                    bw.Write(Prod.Nome_Prod);
                    bw.Write(Prod.Preco_Prod);
                    bw.Write(Prod.Quant_Prod);
                }
            }

            bw.Close();
            Prod_arq2.Close();

            rd.Close();
            Prod_arq.Close();

            System.IO.File.Delete(Cmn_Prod);
            System.IO.File.Move(alterar, Cmn_Prod);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t   ┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t   ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t   ││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t\t   ├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t   └┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        //Menu do alterar
        //===========================================================================================================
        static void Alterar(Mercadoria Prod, Fornecedor Fornec, int op, int N, string Cmn_Fornec, string Cmn_Prod)//Menu de alterar
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t┌┬───────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││        ────────────────       ││");
                Console.WriteLine("\t\t\t\t││         Menu de Alterar       ││");
                Console.WriteLine("\t\t\t\t││         ───────────────       ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t││ 1- Alterar Produto            ││");
                Console.WriteLine("\t\t\t\t││ 2- Alterar Fornecedor         ││");
                Console.WriteLine("\t\t\t\t││ 3- Retornar ao Menu Principal ││");
                Console.WriteLine("\t\t\t\t││                               ││");
                Console.WriteLine("\t\t\t\t├┼───────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t└┴───────────────────────────────┴┘");
                Console.Write("\n");
                op = Opcao(op, N);

                switch (op)
                {
                    case 1:
                        {
                            Alt_Prod(Cmn_Prod);
                            break;
                        }
                    case 2:
                        {
                            Alt_Fornec(Cmn_Fornec, Fornec);
                            break;
                        }
                }
            } while (op != 3);
        }
        //===========================================================================================================
        //Menu de vendas do produtos!!!
        //===========================================================================================================
        static void Menu_Vendas(Mercadoria Prod, string Cmn_Prod, int op, int N)//Menu de Vendas
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t┌┬────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t├┼────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t││                                ││");
                Console.WriteLine("\t\t\t\t││     ───────────────────────    ││");
                Console.WriteLine("\t\t\t\t││     Menu de Vender Produtos    ││");
                Console.WriteLine("\t\t\t\t││     ───────────────────────    ││");
                Console.WriteLine("\t\t\t\t││                                ││");
                Console.WriteLine("\t\t\t\t││ 1- Efetuar Vendas              ││");
                Console.WriteLine("\t\t\t\t││ 2- Gerar Relatorio de Vendas   ││");
                Console.WriteLine("\t\t\t\t││ 3- Retornar ao Menu Principal  ││");
                Console.WriteLine("\t\t\t\t││                                ││");
                Console.WriteLine("\t\t\t\t├┼────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t└┴────────────────────────────────┴┘");
                Console.Write("\n");
                op = Opcao(op, N);

                switch (op)
                {
                    case 1:
                        {
                            Efetuar_Vendas(Prod, Cmn_Prod, op);
                            break;
                        }
                    case 2:
                        {
                            Gerar_Relat_Vend(Prod);
                            break;
                        }
                }
            } while (op != 3);
        }
        //===========================================================================================================
        //Efetuar vendas
        //===========================================================================================================
        static void Efetuar_Vendas(Mercadoria Prod, string Cmn_Prod, int op)//Vendas de Produtos
        {
            string Op_SN;
            Console.Clear();

            Console.WriteLine("\t\t\t\t   ┌┬────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t   ├┼────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t   ││          ──────────────        ││");
            Console.WriteLine("\t\t\t\t   ││          Efetuar Vendas        ││");
            Console.WriteLine("\t\t\t\t   ││          ──────────────        ││");
            Console.WriteLine("\t\t\t\t   ├┼────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t   └┴────────────────────────────────┴┘");

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────┴┘");
            Console.Write("\t\t\t\t   Deseja efetuar vendas de produtos?(S ou N) [ ]  ");
            Console.SetCursorPosition(79, 12);
            Op_SN = Console.ReadLine();
            Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────┴┘");

            while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
            {
                Console.Clear();
                Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼───────────────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││     Opcao Inválida! Deseja efetuar vendas de produtos     ||");
                Console.WriteLine("\t\t\t││                         (S ou N) [ ]                      ││");
                Console.WriteLine("\t\t\t├┼───────────────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴───────────────────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(61, 3);
                Op_SN = Console.ReadLine();
            }

            if (Op_SN == "S" || Op_SN == "s")
            {
                Vender(Prod, Cmn_Prod, op);
            }
        }
        //===========================================================================================================
        //Relatorio das vendas geradas!!
        //===========================================================================================================
        static void Gerar_Relat_Vend(Mercadoria Prod)
        {
            string Op_SN;
            string Vend = "Vendas.dat";
            Console.Clear();

            Verificar2();

            Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t\t├┼────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t\t││   ─────────────────────────    ││");
            Console.WriteLine("\t\t\t\t\t││   Gerar Relatorio de Vendas    ││");
            Console.WriteLine("\t\t\t\t\t││   ─────────────────────────    ││");
            Console.WriteLine("\t\t\t\t\t├┼────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────┴┘");

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────┴┘");
            Console.WriteLine("\t\t\t\t   Deseja gerar relatorio de vendas?(S ou N) [ ] ");
            Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────┴┘");

            Console.SetCursorPosition(78, 12);
            Op_SN = Console.ReadLine();

            while (Op_SN != "S" && Op_SN != "s" && Op_SN != "N" && Op_SN != "n")
            {
                Console.Clear();
                Console.WriteLine("\t\t\t┌┬───────────────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t├┼───────────────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t││     Opcao Inválida! Deseja efetuar relatório de vendas    ||");
                Console.WriteLine("\t\t\t││                         (S ou N) [ ]                      ││");
                Console.WriteLine("\t\t\t├┼───────────────────────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t└┴───────────────────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(61, 3);
                Op_SN = Console.ReadLine();
            }

            if (Op_SN == "S" || Op_SN == "s")
            {
                Console.Clear();
                FileStream Relat_Vend = new FileStream(Vend, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(Relat_Vend);

                while (br.PeekChar() != -1)
                {
                    Prod.Cod_Prod = br.ReadInt32();
                    Prod.Nome_Prod = br.ReadString();
                    Prod.Preco_Prod = br.ReadDouble();
                    Prod.Quant_Prod = br.ReadInt32();
                    // Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("\n\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.WriteLine("\n\t\t\t\t\t\tCodigo: {0}", Prod.Cod_Prod);
                    Console.WriteLine("\t\t\t\t\tProduto: {0}", Prod.Nome_Prod);
                    Console.WriteLine("\t\t\t\t\tPreco: {0:C}", Prod.Preco_Prod);
                    Console.WriteLine("\t\t\t\t\tQuantidade: {0}", Prod.Quant_Prod);
                }

                br.Close();
                Relat_Vend.Close();
                Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
            Console.WriteLine("\t\t\t\t├┼─────────────────────────────────────────┼┤");
            Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
            Console.ReadKey();
        }
        //===========================================================================================================
        //Vendas dos produtos
        //===========================================================================================================
        static void Vender(Mercadoria Prod, string Cmn_Prod, int op)
        {
            Console.Clear();
            int Codigo, Quantidade = 0;
            double Valor_Total = 0;
            double Valor_Final = 0;

            Console.Clear();
            Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────────────┴┘");
            Console.Write("\t\t\t\t   Digite o codigo do produto(0 para Finalizar Venda): ");
            Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────────────┬┐");
            Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────────────┴┘");

            while (Codigo != 0)
            {
                Lista_Prod(Prod, Cmn_Prod, Codigo, Quantidade, ref Valor_Total, ref Valor_Final);
                // Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────────┴┘");
                Console.WriteLine("\t\t\t\t  Digite o codigo do produto(0 para Finalizar Venda): ");
                Console.WriteLine("\t\t\t\t┌┬──────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t└┴──────────────────────────────────────────────────┴┘");
                Console.SetCursorPosition(85, 19);
                Codigo = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Pagamento(Valor_Final, op, Cmn_Prod);
        }
        //===========================================================================================================
        //Comprar quantidade desejada do produto
        //===========================================================================================================
        static void Lista_Prod(Mercadoria Prod, string Cmn_Prod, int Codigo, int Quantidade, ref double Valor_Total, ref double Valor_Final)
        {
            string Vend = "Vendas.dat";
            string alterar = "Deletar.back";
            if (File.Exists(alterar))
            {
                System.IO.File.Delete("Deletar.back");
            }
            string alterar2 = "Deletar2.back";
            if (File.Exists(alterar))
            {
                System.IO.File.Delete("Deletar2.back");
            }

            Verificar1(Cmn_Prod);

            FileStream Listar = new FileStream(Cmn_Prod, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(Listar);

            while (br.PeekChar() != -1)
            {
                Prod.Cod_Prod = br.ReadInt32();
                Prod.Nome_Prod = br.ReadString();
                Prod.Preco_Prod = br.ReadDouble();
                Prod.Quant_Prod = br.ReadInt32();

                if (Codigo == Prod.Cod_Prod)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\t\t\t     Digite a quantidade: ");
                    Console.SetCursorPosition(73, 5);
                    Quantidade = int.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                    // Console.Clear();
                    while (Quantidade > Prod.Quant_Prod)
                    {
                        Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                        Console.Write("\t\t\t\tQuantidade maior que existente! Digite novamente a quantidade: ");
                        Quantidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                        Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                    }

                    Prod.Quant_Prod = Prod.Quant_Prod - Quantidade;
                    Valor_Total = Quantidade * Prod.Preco_Prod;
                    Valor_Final = Valor_Final + Valor_Total;

                    FileStream Venda_arq = new FileStream(alterar2, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(Venda_arq);

                    bw.Write(Prod.Cod_Prod);
                    bw.Write(Prod.Nome_Prod);
                    bw.Write(Prod.Preco_Prod);
                    bw.Write(Quantidade);

                    bw.Close();
                    Venda_arq.Close();

                    FileStream Venda_arq2 = new FileStream(alterar, FileMode.CreateNew, FileAccess.Write);
                    BinaryWriter bw2 = new BinaryWriter(Venda_arq2);

                    bw2.Write(Prod.Cod_Prod);
                    bw2.Write(Prod.Nome_Prod);
                    bw2.Write(Prod.Preco_Prod);
                    bw2.Write(Prod.Quant_Prod);

                    bw2.Close();
                    Venda_arq2.Close();
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────────┴┘");
                    Console.WriteLine("\t\t\t\t                 Codigo: {0}      \t                           ", Prod.Cod_Prod);
                    Console.WriteLine("\t\t\t\t                 Produto: {0}     \t                   ", Prod.Nome_Prod);
                    Console.WriteLine("\t\t\t\t                 Preco: {0:C}     \t                           ", Prod.Preco_Prod);
                    Console.WriteLine("\t\t\t\t                 Quantidade: {0}  \t                           ", Quantidade);
                    Console.WriteLine("\t\t\t\t                 Valor: {0:C}     \t                           ", Valor_Total);
                    Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t\t││\tValor Total da Compra: {0:C}             ││", Valor_Final);
                    Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────────┴┘");
                    // Console.SetCursorPosition(61, 3);
                }
                else
                {
                    FileStream Venda_arq = new FileStream(Vend, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(Venda_arq);

                    bw.Write(Prod.Cod_Prod);
                    bw.Write(Prod.Nome_Prod);
                    bw.Write(Prod.Preco_Prod);
                    bw.Write(Prod.Quant_Prod);

                    bw.Close();
                    Venda_arq.Close();

                    FileStream Venda_arq2 = new FileStream(alterar, FileMode.CreateNew, FileAccess.Write);
                    BinaryWriter bw2 = new BinaryWriter(Venda_arq2);

                    bw2.Write(Prod.Cod_Prod);
                    bw2.Write(Prod.Nome_Prod);
                    bw2.Write(Prod.Preco_Prod);
                    bw2.Write(Prod.Quant_Prod);

                    bw2.Close();
                    Venda_arq2.Close();

                    Console.Clear();
                    Console.WriteLine("\t\t\t┌┬─────────────────────────────────────────┬┐");
                    Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t││         Produto nao encontrado!         ││");
                    Console.WriteLine("\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
                    Console.WriteLine("\t\t\t├┼─────────────────────────────────────────┼┤");
                    Console.WriteLine("\t\t\t└┴─────────────────────────────────────────┴┘");
                    Console.ReadKey();
                }
            }

            br.Close();
            Listar.Close();
        }
        //===========================================================================================================
        //Formas de pagamento!!
        //===========================================================================================================
        static void Pagamento(double Valor_Final, int op, string Cmn_Prod)
        {
            Console.Clear();
            int N = 4;
            int Fim_Compra = 0;
            while (op != 4 && Fim_Compra != 1)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t││\tValor Total da Compra: {0:C}             ││", Valor_Final);
                Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────────────┴┘");

                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                Console.WriteLine("\n\t\t\t\t\t     Metodos de pagamento:");
                Console.WriteLine("\n\n\t\t\t\t\t     1- Dinheiro");
                Console.WriteLine("\t\t\t\t\t     2- Debito");
                Console.WriteLine("\t\t\t\t\t     3- Credito");
                Console.WriteLine("\t\t\t\t\t     4- Cancelar Venda\n");
                Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");

                Console.WriteLine("\n\n\n\t\t\t\t     ┌┬────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t     ││   Digite a opção desejada:     ││");
                Console.WriteLine("\t\t\t\t     └┴────────────────────────────────┴┘");
                Console.SetCursorPosition(67, 22);
                op = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            Console.Write("\t\t\t\t\t    Digite o valor pago em dinheiro: ");
                            double Dinheiro = double.Parse(Console.ReadLine());
                            Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            while (Dinheiro < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────────────────────────────┬┐");
                                Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────────────────────────────┴┘");
                                Console.Write("\t\t\t\t\tValor invalido! Digite novamente o valor pago em dinheiro: ");
                                Dinheiro = double.Parse(Console.ReadLine());
                                Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────────────────────────────┬┐");
                                Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────────────────────────────┴┘");
                            }

                            while (Dinheiro < Valor_Final)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────────────────────────────┬┐");
                                Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────────────────────────────┴┘");
                                Console.Write("\t\t\t\t\tValor insuficiente! Digite novamente o valor pago em dinheiro: ");
                                Dinheiro = double.Parse(Console.ReadLine());
                                Console.WriteLine("\t\t\t\t\t┌┬────────────────────────────────────────────────────────┬┐");
                                Console.WriteLine("\t\t\t\t\t└┴────────────────────────────────────────────────────────┴┘");
                            }

                            double Troco = Dinheiro - Valor_Final;
                            Valor_Final = 0;

                            if (Valor_Final == 0)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("\t\t\t\t\t┌┬─────────────────────┬┐");
                                Console.WriteLine("\t\t\t\t\t└┴─────────────────────┴┘");
                                Console.WriteLine("\t\t\t\t\t   Troco de: {0:C}", Troco);
                                Console.WriteLine("\t\t\t\t\t┌┬─────────────────────┬┐");
                                Console.WriteLine("\t\t\t\t\t└┴─────────────────────┴┘");
                                Console.WriteLine("\n");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            Console.WriteLine("\t\t\t\t\t\t   Valor Total: {0:C}", Valor_Final);
                            Console.WriteLine("\n\t\t\t\t\t\t   Insira o cartao!");
                            Console.WriteLine("\t\t\t\t\t\t   Digite a senha: ");
                            Console.WriteLine("\t\t\t\t\t\t   Transacao Aprovada!");
                            Console.WriteLine("\t\t\t\t\t\t   Retire o cartao");
                            Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            Valor_Final = 0;
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            Console.WriteLine("\t\t\t\t\t\tOpcoes");
                            Console.WriteLine("\n1\t\t\t\t\t1- A vista");
                            Console.WriteLine("\t\t\t\t\t2- 2 vezes(Acrescimo de 5%)");
                            Console.WriteLine("\t\t\t\t\t3- 3 vezes(Acrescimo de 10%)");
                            Console.WriteLine("\n\t\t\t\t\tDigite a opcao desejada: ");
                            N = 3;
                            Console.WriteLine("\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            op = Opcao(op, N);
                            switch (op)
                            {
                                case 2:
                                    {
                                        Valor_Final = Valor_Final * 1.05;
                                        break;
                                    }
                                case 3:
                                    {
                                        Valor_Final = Valor_Final * 1.1;
                                        break;
                                    }
                            }
                            Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            Console.WriteLine("\t\t\t\t\t\t      Valor Total: {0:C}", Valor_Final);
                            Console.WriteLine("\n\t\t\t\t\t\t     Insira o cartao!");
                            Console.WriteLine("\t\t\t\t\t\t     Digite a senha: ");
                            Console.WriteLine("\t\t\t\t\t\t     Transacao Aprovada!");
                            Console.WriteLine("\t\t\t\t\t\t     Retire o cartao");
                            Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                            Valor_Final = 0;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\t\t\t\t\t┌┬────────────────────┬┐");
                            Console.WriteLine("\t\t\t\t\t├┼────────────────────┼┤");
                            Console.WriteLine("\t\t\t\t\t││  Venda Cancelada!  ││");
                            Console.WriteLine("\t\t\t\t\t├┼────────────────────┼┤");
                            Console.WriteLine("\t\t\t\t\t└┴────────────────────┴┘");
                            break;
                        }
                }
                Fim_Compra = 1;
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t\t├┼─────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t\t││  Aperte Qualquer Tecla Para Continuar!  ││");
                Console.WriteLine("\t\t\t\t\t├┼─────────────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────────────┴┘");
                Console.ReadKey();
            }
            Console.Clear();

            if (Valor_Final == 0)
            {
                string Vend = "Vendas.dat";
                string alterar = "Deletar.back";
                string alterar2 = "Deletar2.back";

                System.IO.File.Delete(Vend);
                System.IO.File.Move(alterar2, Vend);

                System.IO.File.Delete(Cmn_Prod);
                System.IO.File.Move(alterar, Cmn_Prod);

                Console.WriteLine("\t\t\t\t\t┌┬─────────────────────────────────┬┐");
                Console.WriteLine("\t\t\t\t\t├┼─────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t\t││  Compra Realizada com Sucesso!  ││");
                Console.WriteLine("\t\t\t\t\t├┼─────────────────────────────────┼┤");
                Console.WriteLine("\t\t\t\t\t└┴─────────────────────────────────┴┘");
            }
        }
    }
}

