using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoExercicioAutoPecas.Entidades;
using ProjetoExercicioAutoPecas.Interfaces;
using ProjetoExercicioAutoPecas.Repositorio;
using ProjetoExercicioAutoPecas.Serviço;

namespace ProjetoExercicioAutoPecas.Menus
{
    public class MenuVeiculo
    {
        static VeiculoRepositorio veiculoRepositorio = new();
        static VeiculoService veiculoService = new(veiculoRepositorio);
        enum Menu
        {
            NaoInformado = 0,
            CadastrarVeiculo = 1,           
            ConsultarMarca = 2,
            ConsultarModelo = 3,            
            ExcluirVeiculo = 4,
            VoltarMenuPrincipal = 5,
            Sair = 6,
        }
        public void Main()
        {
            bool executar = true;
            var menu = Menu.NaoInformado;

            int opcao = 0;
            do
            {
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Cadastrar Veículo");                
                Console.WriteLine("4 - Consultar Veículo por Marca");                
                Console.WriteLine("3 - Consultar Veículo por Modelo");
                Console.WriteLine("6 - Excluir Veículo");
                Console.WriteLine("7 - Voltar Menu Principal");
                Console.WriteLine("8 - SAIR");
                Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }

                menu = (Menu)Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case Menu.CadastrarVeiculo:
                        {
                            Veiculo veiculo = new Veiculo();
                                                       
                            Console.WriteLine("Digite a Marca para Cadastro");
                            veiculo.Marca = Console.ReadLine();
                            veiculoService.CadastrarVeiculo(veiculo);
                            Console.WriteLine("Digite o Modelo para Cadastro");
                            veiculo.Modelo = Console.ReadLine();
                            veiculoService.CadastrarVeiculo(veiculo);
                            Console.WriteLine("Digite o Ano para Cadastro");
                            veiculo.AnoFabricacao = (Console.ReadLine());
                            veiculoService.CadastrarVeiculo(veiculo);
                            Console.WriteLine("Digite o Motor para Cadastro");
                            veiculo.Motor = Console.ReadLine();
                            veiculoService.CadastrarVeiculo(veiculo);
                        }
                        break;

                    case Menu.ConsultarMarca:
                        {
                            Console.WriteLine("Digite o Modelo do Veiculo para Consulta");
                            var modelo = Console.ReadLine();
                            var consultaModelo = veiculoService.BuscarVeiculoPorModelo(modelo);
                            Console.WriteLine(modelo);
                        }
                        break;

                    case Menu.ConsultarModelo:
                        {
                            Console.WriteLine("Digite o Modelo do Veiculo para Consulta");
                            var modelo = Console.ReadLine();
                            var consultaModelo = veiculoService.BuscarVeiculoPorModelo(modelo);
                            Console.WriteLine(modelo);                           
                        }
                        break;

                    case Menu.ExcluirVeiculo:
                        {
                            Console.WriteLine("Digite ID para Exclusão");
                            var ID = Console.ReadLine();
                            veiculoService.ExcluirVeiculo(Guid.Parse(ID));
                            break;
                        }

                    case Menu.VoltarMenuPrincipal:
                        {
                            Console.WriteLine("Voltando ao Menu Principal...");
                            MenuPrincipal menuPrincipal = new MenuPrincipal();
                            menuPrincipal.Main();
                            break;
                        }

                    case Menu.Sair:
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
