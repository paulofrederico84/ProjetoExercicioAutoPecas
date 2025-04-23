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
            Clientes = 2,
            Veiculos = 3,            
            Sair = 4,
        }
        public void Main(string[] args)
        {
            bool executar = true;
            var primeiroMenu = PrimeiroMenu.NaoInformado;

            do
            {
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Menu de Peças");
                Console.WriteLine("2 - Menu de Clientes");
                Console.WriteLine("3 - Menu de Veiculos");
                Console.WriteLine("4 - SAIR");

                Console.WriteLine();
                primeiroMenu = (PrimeiroMenu)Convert.ToInt32(Console.ReadLine());

                switch (primeiroMenu) 
                {
                    case PrimeiroMenu.Pecas:
                        {
                            break;
                        }

                    case PrimeiroMenu.Clientes:
                        {
                            break;
                        }

                    case PrimeiroMenu.Veiculos:
                        {
                            break;
                        }

                    case PrimeiroMenu.Sair:
                        {
                            break;
                        }
                }


            }
            while (executar);
        }
    }
}
