using System;

namespace Exercício_produtos
{
    class Program
    {
        static string[] produto = new string[10];
        static float[] preco = new float[10];
        static bool[] desconto = new bool[10];
        static int i = 0;
        static int resp = 0;
        static int opcao = 0;
        static void Main(string[] args)
        {
            do
            {
                
            Console.WriteLine("Bem vindo! Selecione uma opção:");
            Console.WriteLine($@"
1 - Cadastrar Produto
2 - Listar Produtos
0 - Sair
"
            );
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("\nQual produto deseja cadastrar?");
                        produto[i] = Console.ReadLine();
                        Console.WriteLine("\nQual o valor do produto?");
                        preco[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nO produto tem desconto? sim/não");
                        string RespDesconto = Console.ReadLine().ToLower();

                        if (RespDesconto == "sim")
                        {
                            desconto[i] = true;
                        }
                        else if(RespDesconto != "sim")
                        {
                            desconto[i] = false;
                        }

                        Console.WriteLine("\nDeseja cadastrar outro produto? 1 - sim/0 - não");
                        resp = int.Parse(Console.ReadLine());

                        i++;
                    } while (resp == 1);
                    break;
                case 2:
                for (var c = 0; c < i; c++)
                {
                    Console.WriteLine("\nProduto: " + produto[c]);
                    Console.WriteLine("Preço: " + preco[c]);
                    if (desconto[i] == true)
                    {
                    Console.WriteLine("Tem desconto");
                        
                    }else if (desconto[i] == false)
                    {
                    Console.WriteLine("Não tem desconto");
                        
                    }
                }
                    break;
                default:
                    break;

            }

            } while (opcao != 0);
        }
    }
}
