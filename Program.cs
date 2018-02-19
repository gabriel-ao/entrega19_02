using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaEntrega19_02
{
    class Program
    {
        public static int tamVetor = 3;
        public static string[] nomes = new string[tamVetor];


        static void Main(string[] args)
        {
            Console.Clear();
           menu();
        }

        private static void menu()
        {
            int opcao;

            Console.Clear();
            Console.WriteLine("[ 1 ] Matricular Aluno");
            Console.WriteLine("[ 2 ] Cancelar matricula de um aluno");
            Console.WriteLine("[ 3 ] verificar lista");
            Console.WriteLine("[ 4 ] Sair do Programa");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Digite uma opção:");

            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    matricularAluno();
                    break;
                case 2:
                    cancelarMatricula();
                    break;
                case 3:
                    verificarLista();
                    break;
                case 4:
                    sairPrograma();
                    break;
                default:
                    aviso();
                    break;
            }
            Console.ReadKey();
        }

        private static void verificarLista()
        {
            
            
        }
        private static void sairPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("O programa será atualizado! " +
            "Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Environment.Exit(0);

        }

        private static void cancelarMatricula()
        {
            Console.WriteLine();
            Console.WriteLine("CANCELAR MATRICULA \n");
            Console.WriteLine("digite o nome do aluno a ser cancelado");
            string cancelarAluno = Console.ReadLine();
            for (int j = 0; j < tamVetor; j++)
            {
                if(nomes[j] == cancelarAluno)
                {
                    nomes[j] = null;
                }
                else{
                    Console.WriteLine("aluno não consta em lista");
                    Console.WriteLine(nomes[j]);
                }
                
            }


            menu();
        }


        private static void matricularAluno()
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Clear();
                Console.WriteLine("MATRICULA \n");
                Console.WriteLine("digite o nome do aluno");
                string nome = Console.ReadLine();

               
                if (nomes[i] == null)
                {
                    nomes[i] = nome;
                } else
                {
                    nomes[i + 1] = nome;
                }
                // test dos cadastros
                for (int g = 0; g < tamVetor; g++)
                {
                    if (nomes[g] != null)
                    {
                        Console.WriteLine("o" + (g+1) + "nome é " + nomes[g]);
                    }
                }

                Console.WriteLine("\n\nDeseja cadastrar novamente (1-SIM / 2-NÃO)");
                int opcao = Int32.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    continue;
                }
                else if (opcao == 2)
                {
                    menu();
                }
            }
        }

        private static void aviso()
        {
            Console.WriteLine();
            Console.WriteLine("Você deve digitar algum valor " +
            "referente as funções do menu");
            Console.ReadKey();
            Console.Clear();
            menu();
        }
    }
}
