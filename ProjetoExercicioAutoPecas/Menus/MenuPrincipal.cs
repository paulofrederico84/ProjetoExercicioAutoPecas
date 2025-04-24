using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Menus
{
    public class MenuPrincipal
    {
        enum PrimeiroMenu
        {
            NaoInformado = 0,
            Pecas = 1,
            Pessoa = 2,
            Veiculos = 3,            
            Sair = 4,
        }
        public void Main()
        {
            bool executar = true;
            var primeiroMenu = PrimeiroMenu.NaoInformado;

            int opcao = 0;
            do
            {
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Menu de Peças");
                Console.WriteLine("2 - Menu de Clientes");
                Console.WriteLine("3 - Menu de Veiculos");
                Console.WriteLine("4 - SAIR");

                Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }

                primeiroMenu = (PrimeiroMenu)Convert.ToInt32(Console.ReadLine());

                switch (primeiroMenu) 
                {
                    case PrimeiroMenu.Pecas:
                        {
                            Console.WriteLine("Abrindo Menu de Peças...");
                            MenuPeca menuPeca = new MenuPeca();
                            menuPeca.Main();                            
                            break;
                        }

                    case PrimeiroMenu.Pessoa:
                        {
                            Console.WriteLine("Abrindo Menu de Clientes...");
                            MenuPessoa menuPessoa = new MenuPessoa();
                            menuPessoa.Main();
                            break;
                        }

                    case PrimeiroMenu.Veiculos:
                        {
                            Console.WriteLine("Abrindo Menu de Veiculos...");
                            MenuVeiculo menuVeiculo = new MenuVeiculo();
                            menuVeiculo.Main();
                            break;
                        }

                    case PrimeiroMenu.Sair:
                        {
                            executar = false;
                            break;
                        }
                }
            }
            while (executar);
        }
    }
}
