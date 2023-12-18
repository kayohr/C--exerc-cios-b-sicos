using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ExemploProjeto.Models
{
    public class MenuInterativo
    {
        public void ExecutarMenu()
    {
        string opcao;

        while (true)
        {
            // Console.Clear(); Para limpar o console, não aparecer o menu toda vez que clica.
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastrar Cliente");
                    break;

                case "2":
                    Console.WriteLine("Buscar Cliente");
                    break;

                case "3":
                    Console.WriteLine("Apagar Cliente");
                    break;

                case "4":
                    Console.WriteLine("Encerrar");
                     ; //Para encerrar o programa
                     break;
                    //  return; //Em vez dos dois de cima, funciona também.

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
            }
                    Console.WriteLine("O programa se encerrou"); //AQui não mostra...Pois
                    //Environment.Exit(0) sai e não executa mais nada depois.

        }
        
    }

          public void ExecutarMenuRefatorado()
    {
        string opcao;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastrar Cliente");
                    break;

                case "2":
                    Console.WriteLine("Buscar Cliente");
                    break;

                case "3":
                    Console.WriteLine("Apagar Cliente");
                    break;

                case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;
                    break;

                    default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        Console.WriteLine("O programa se encerrou");
    }

    }
    
    }