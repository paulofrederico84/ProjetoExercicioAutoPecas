using ProjetoExercicioAutoPecas.Entidades;
using ProjetoExercicioAutoPecas.Repositorio;
using ProjetoExercicioAutoPecas.Serviço;

namespace ProjetoExercicioAutoPecas.Menus
{
    public class MenuPeca
    {
        static PecaRepositorio pecaRepositorio = new();
        static PecaService pecaService = new(pecaRepositorio);

        enum Menu
        {
            NaoInformado = 0,
            Cadastrar = 1,
            ConsultarCodigo = 2,
            ConsultarDescricao = 3,
            ConsultarFabricante = 4,
            ConsultarEstoque = 5,
            Excluir = 6,
            VoltarMenuPrincipal = 7,
            Sair = 8,

        }
        static void Main(string[] args)
        {
            bool executar = true;
            var menu = Menu.NaoInformado;

            do
            {
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Cadastrar Peças");
                Console.WriteLine("2 - Consultar Peças por Código");
                Console.WriteLine("3 - Consultar Peças por Descrição");
                Console.WriteLine("4 - Consultar Peças por Fabricante");
                Console.WriteLine("5 - Consultar Estoque de Peças");
                Console.WriteLine("6 - Excluir Peça");
                Console.WriteLine("7 - Voltar Menu Principal");
                Console.WriteLine("8 - SAIR");

                Console.WriteLine();
                menu = (Menu)Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case Menu.Cadastrar:
                        {
                            Peca peca = new Peca();

                            Console.WriteLine("Digite o Código para Cadastro");
                            peca.Codigo = Console.ReadLine();
                            pecaService.CadastrarPeca(peca);

                            Console.WriteLine("Digite a Descrição para Cadastro");
                            peca.Descricao = Console.ReadLine();
                            pecaService.CadastrarPeca(peca);

                            Console.WriteLine("Digite o Fabricante para Cadastro");
                            peca.Fabricante = Console.ReadLine();
                            pecaService.CadastrarPeca(peca);

                            Console.WriteLine("Digite a quantidade de Estoque para Cadastro");
                            peca.Estoque = Console.ReadLine();
                            pecaService.CadastrarPeca(peca);

                            break;
                        }


                    case Menu.ConsultarCodigo:
                        {
                            Console.WriteLine("Digite Código para Consulta");                           
                            var codigo = Console.ReadLine();
                            var consultaCodigo = pecaService.ConsultarPorCodigo(codigo);
                            Console.WriteLine(codigo);
                            
                            break;
                        }

                    case Menu.ConsultarDescricao:
                        {
                            Console.WriteLine("Digite Descrição para Consulta");
                            var descricao = Console.ReadLine();
                            var consultaDescricao = pecaService.ConsultarPorDescricao(descricao);
                            Console.WriteLine(descricao);

                            break;
                        }

                    case Menu.ConsultarFabricante:
                        {
                            Console.WriteLine("Digite Fabricante para Consulta");
                            var fabricante = Console.ReadLine();
                            var consultaFabricante = pecaService.ConsultarPorFabricante(fabricante);
                            Console.WriteLine(fabricante);

                            break;
                        }

                    case Menu.ConsultarEstoque:
                        {
                            Console.WriteLine("Digite Estoque para Consulta");
                            List<Peca> listaEstoque = pecaService.ListarEmEstoque();
                            foreach (var peca in listaEstoque)
                            {
                                Console.WriteLine($"Código: {peca.Codigo}, Descrição: {peca.Descricao}, Fabricante: {peca.Fabricante}, Estoque: {peca.Estoque}");
                            }

                            break;
                        }
                  case Menu.Excluir:
                        {
                            Console.WriteLine("Digite Código para Exclusão");
                            var codigo = Console.ReadLine();
                            pecaService.ExcluirPeca(codigo);
                            break;
                        }

                    case Menu.VoltarMenuPrincipal:
                        {
                            Console.WriteLine("Voltando ao Menu Principal...");
                            MenuPrincipal menuPrincipal = new MenuPrincipal();
                            menuPrincipal.Main(args);
                            break;
                        }


                    case Menu.Sair:
                        {
                            break;
                        }

                }


            }
            while (executar);
        }
    }
}



