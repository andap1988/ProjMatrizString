using System;

namespace MatrizString
{
    internal class Program
    {
        public static int Menu()
        {
            bool flag = true;
            string choice;
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n      ...:: Menu ::...\n");

                Console.WriteLine("\n 1 - Informar os nomes da Matriz");
                Console.WriteLine(" 2 - Imprimir todos os nomes da Matriz");
                Console.WriteLine(" 3 - Imprimir nomes de uma coluna qualquer");
                Console.WriteLine(" 4 - Imprimir nomes de uma linha qualquer");
                Console.WriteLine(" 5 - Procurar nomes");
                Console.WriteLine(" 6 - Ordenar Nomes da Linha");
                Console.WriteLine(" 7 - Sair\n");
                Console.Write(" Escolha: ");
                choice = Console.ReadLine();
                int.TryParse(choice, out op);

                if ((op < 1) || (op > 7))
                {
                    Console.WriteLine(" xxxx Opcao invalida");
                    Console.WriteLine(" xxxx Pressione ENTER para retornar ao menu...");
                    Console.ReadKey();
                }
                else
                {
                    flag = false;
                }

            } while (flag);

            return op;
        }

        public static void FindLine(string[,] names, int line)
        {
            string choice;
            int op = 0;
            bool flag = true;

            Console.Clear();
            Console.WriteLine("\n ...: Imprimir nomes de uma linha qualquer\n");

            do
            {
                Console.Clear();
                Console.WriteLine(" Temos {0} como primeira linha e {1} como ultima linha.\n", line - line, line - 1);
                Console.Write("\n Qual linha imprmir?  R: ");
                choice = Console.ReadLine();
                int.TryParse(choice, out op);

                if ((op < line - line) || (op > line - 1))
                {
                    Console.WriteLine(" xxxx Nao há essa linha na matriz.\n");
                    Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                    Console.ReadKey();
                }
                else
                {
                    for (int l = 0; l < names.GetLength(0); l++)
                    {
                        for (int c = 0; c < names.GetLength(1); c++)
                        {
                            if (l == op)

                                Console.Write("\n[{0}, {1}]: {2}\t", l, c, names[l, c]);
                        }
                        Console.WriteLine();
                    }
                    flag = false;
                }
            } while (flag);

            Console.WriteLine("\n oooo FIM DA IMPRESSAO \n");
            Console.WriteLine("\n oooo Pressione ENTER para retornar ao menu...");
            Console.ReadKey();
        }

        public static void FindColumn(string[,] names, int column)
        {
            string choice;
            int op = 0;
            bool flag = true;

            Console.Clear();
            Console.WriteLine("\n ...: Imprimir nomes de uma coluna qualquer\n");

            do
            {
                Console.Clear();
                Console.WriteLine(" Temos {0} como primeira coluna e {1} como ultima coluna.\n", column - column, column - 1);
                Console.Write("\n Qual coluna imprmir?  R: ");
                choice = Console.ReadLine();
                int.TryParse(choice, out op);

                if ((op < column - column) || (op > column - 1))
                {
                    Console.WriteLine(" xxxx Nao há essa coluna na matriz.\n");
                    Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                    Console.ReadKey();
                }
                else
                {
                    for (int l = 0; l < names.GetLength(0); l++)
                    {
                        for (int c = 0; c < names.GetLength(1); c++)
                        {
                            if (c == op)

                                Console.Write("\n[{0}, {1}]: {2}\t", l, c, names[l, c]);
                        }
                        Console.WriteLine();
                    }
                    flag = false;
                }
            } while (flag);

            Console.WriteLine("\n oooo FIM DA IMPRESSAO \n");
            Console.WriteLine("\n oooo Pressione ENTER para retornar ao menu...");
            Console.ReadKey();
        }

        public static void Print(string[,] names)
        {
            Console.Clear();
            Console.WriteLine(" \n...: Imprimir todos os nomes da Matriz\n");

            Console.WriteLine(" Os nomes são: \n");
            for (int l = 0; l < names.GetLength(0); l++)
            {
                for (int c = 0; c < names.GetLength(1); c++)
                {
                    Console.Write("\n[{0}, {1}]: {2}\t", l, c, names[l, c]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n oooo FIM DA IMPRESSAO \n");
            Console.WriteLine("\n oooo Pressione ENTER para retornar ao menu...");
            Console.ReadKey();
        }

        public static void Search(string[,] names)
        {
            bool flagName = false;
            string name;

            Console.Clear();
            Console.WriteLine("\n ...: Procurar nomes\n");

            Console.Write(" \nQual nome deseja procurar? R: ");
            name = Console.ReadLine();

            for (int l = 0; l < names.GetLength(0); l++)
            {
                for (int c = 0; c < names.GetLength(1); c++)
                {
                    if (string.Compare(names[l, c], name) == 0)
                    {
                        Console.Write("\n[{0}, {1}]: {2}\t", l, c, names[l, c]);
                        flagName = true;
                    }
                }
            }

            if (!flagName)
            {
                Console.WriteLine("\n xxxx Nome não encontrado.");
                Console.WriteLine("\n xxxx Pressione ENTER para retornar ao menu...\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n oooo FIM DA BUSCA \n");
                Console.WriteLine("\n oooo Pressione ENTER para retornar ao menu... \n");
                Console.ReadKey();
            }
        }

        public static void OrderOneLine(string[,] names, int line)
        {
            string choice;
            int op = 0;
            bool flag = true;

            Console.Clear();
            Console.WriteLine("\n ...: Ordenar Nomes da Linha\n");

            do
            {
                Console.Clear();
                Console.WriteLine(" Temos {0} como primeira linha e {1} como ultima linha.\n", line - line, line - 1);
                Console.Write(" \nQual linha deseja ordenar? R: ");
                choice = Console.ReadLine();
                int.TryParse(choice, out op);

                if ((op < line - line) || (op > line - 1))
                {
                    Console.WriteLine(" xxxx Nao há essa linha na matriz.\n");
                    Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                    Console.ReadKey();
                }
                else
                {
                    for (int l = 0; l < names.GetLength(0); l++)
                    {
                        for (int c = 0; c < names.GetLength(1); c++)
                        {
                            if (l == op)
                            {
                                for (int refer = 0; refer < names.GetLength(1) - 1; refer++)
                                {
                                    for (int comp = refer + 1; comp < names.GetLength(1); comp++)
                                    {
                                        if (string.Compare(names[l, refer], names[l, comp], StringComparison.Ordinal) >= 0)
                                        {
                                            string aux = names[l, refer];
                                            names[l, refer] = names[l, comp];
                                            names[l, comp] = aux;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    flag = false;
                }
            } while (flag);

            for (int l = 0; l < names.GetLength(0); l++)
            {
                for (int c = 0; c < names.GetLength(1); c++)
                {
                    if (l == op)
                        Console.Write("\n[{0}, {1}]: {2}\t", l, c, names[l, c]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n oooo FIM DA IMPRESSAO \n");
            Console.WriteLine("\n oooo Pressione ENTER para retornar ao menu...");
            Console.ReadKey();
        }

        public static string[,] Push(string[,] names)
        {
            Console.Clear();
            Console.WriteLine("\n ...: Informar os nomes da Matriz \n");

            for (int l = 0; l < names.GetLength(0); l++)
            {
                for (int c = 0; c < names.GetLength(1); c++)
                {
                    Console.Write("[{0}, {1}]: ", l, c);
                    names[l, c] = Console.ReadLine();
                }
            }

            Console.WriteLine("\n oooo INCLUSAO CONCLUIDA! \n");
            Console.WriteLine("\n oooo Pressione ENTER para retornar ao menu...");
            Console.ReadKey();

            return names;
        }

        public static bool VoidMatriz(string[,] names)
        {
            if (names[0, 0] == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool FullMatriz(string[,] names)
        {
            if (names[0, 0] != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string[,] PushNull(string[,] names)
        {
            for (int l = 0; l < names.GetLength(0); l++)
            {
                for (int c = 0; c < names.GetLength(1); c++)
                {
                    names[l, c] = "";
                }
            }

            return names;
        }

        static void Main(string[] args)
        {
            bool flag = true, flagMatriz = true;
            int op = 0, opLines = 0, opCol = 0;

            Console.Clear();
            Console.WriteLine("\n ........:::: Bem-vindo ao programa de Matriz ::::........\n");
            do
            {
                Console.Write("\n Quantas linhas deseja que a matriz contenha? R: ");
                string lines = Console.ReadLine();
                Console.Write("\n Quantas colunas deseja que a matriz contenha? R: ");
                string columns = Console.ReadLine();
                int.TryParse(lines, out opLines);
                int.TryParse(columns, out opCol);

                Console.WriteLine(opLines);
                Console.WriteLine(opCol);

                if ((opCol < 1) || (opLines < 1))
                {
                    Console.WriteLine(" xxxx Linha/Coluna tem que ser maior que 0.\n");
                    Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                    Console.ReadKey();
                }
                else
                {
                    flagMatriz = false;
                }
            } while (flagMatriz);

            string[,] names = new string[opLines, opCol];

            PushNull(names);

            op = Menu();

            do
            {
                switch (op)
                {
                    case 1:
                        if (FullMatriz(names))
                        {
                            Console.WriteLine("\n xxxx Matriz ja esta preenchida.\n");
                            Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            Push(names);
                        }
                        op = Menu();
                        break;
                    case 2:
                        if (VoidMatriz(names))
                        {
                            Console.WriteLine("\n xxxx Matriz vazia.\n");
                            Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            Print(names);
                        }
                        op = Menu();
                        break;
                    case 3:
                        if (VoidMatriz(names))
                        {
                            Console.WriteLine("\n xxxx Matriz vazia.\n");
                            Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            FindColumn(names, names.GetLength(1));
                        }
                        op = Menu();
                        break;
                    case 4:
                        if (VoidMatriz(names))
                        {
                            Console.WriteLine("\n xxxx Matriz vazia.\n");
                            Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            FindLine(names, names.GetLength(0));
                        }
                        op = Menu();
                        break;
                    case 5:
                        if (VoidMatriz(names))
                        {
                            Console.WriteLine("\n xxxx Matriz vazia.\n");
                            Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            Search(names);
                        }
                        op = Menu();
                        break;
                    case 6:
                        if (VoidMatriz(names))
                        {
                            Console.WriteLine("\n xxxx Matriz vazia.\n");
                            Console.WriteLine(" xxxx Pressione ENTER para retornar...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            OrderOneLine(names, names.GetLength(0));
                        }
                        op = Menu();
                        break;
                    case 7:
                        Console.Clear();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\n xxxx Opcao invalida\n");
                        Console.WriteLine("\n xxxx Pressione ENTER para retornar ao menu...");
                        Console.ReadKey();
                        break;

                }
            } while (flag);

            Console.WriteLine("\n\t xxxxxx Obrigado por usar nosso sistema xxxxxx \n\n");

        }
    }
}
