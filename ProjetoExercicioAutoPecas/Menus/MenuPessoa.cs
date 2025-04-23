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
    public class MenuPessoa
    {
        static PessoaRepositorio pessoaRepositorio = new();
        static PessoaService pessoaService = new(pessoaRepositorio);
        
    
        enum Menu
        {
            NaoInformado = 0,
            CadastrarPessoa = 1,
            ConsultarNome = 3,
            ConsultarSobrenome = 2,
            ConsultarCpf = 4,
            ConsultarTelefone = 5,
            ConsultarEndereco = 6,
            ConsultarCidade = 7,
            Excluir = 8,
            VoltarMenuPrincipal = 9,
            Sair = 10,
        }

        public void Main(string[] args)
         
        {
            bool executar = true;
            var menu = Menu.NaoInformado;

            do
            {
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Consultar Pessoa por Nome");                
                Console.WriteLine("3 - Consultar Pessoa por CPF");
                Console.WriteLine("4 - Consultar Pessoa por Telefone");
                Console.WriteLine("5 - Consultar Pessoa por Endereço");
                Console.WriteLine("6 - Consultar Pessoa por Cidade");
                Console.WriteLine("7 - Excluir Pessoa");
                Console.WriteLine("8 - Voltar Menu Principal");
                Console.WriteLine("9 - SAIR");
                Console.WriteLine();

                menu = (Menu)Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case Menu.CadastrarPessoa:
                        {
                            Pessoa pessoa = new Pessoa();

                            Console.WriteLine("Digite o CPF para Cadastro");
                            pessoa.CPF = Console.ReadLine();
                            pessoaService.CadastrarPessoa(pessoa);

                            Console.WriteLine("Digite o Nome para Cadastro");
                            pessoa.Nome = Console.ReadLine();
                            pessoaService.CadastrarPessoa(pessoa);

                            Console.WriteLine("Digite o Sobrenome para Cadastro");
                            pessoa.Sobrenome = Console.ReadLine();
                            pessoaService.CadastrarPessoa(pessoa);

                            Console.WriteLine("Digite o Telefone para Cadastro");
                            pessoa.Telefone = Console.ReadLine();
                            pessoaService.CadastrarPessoa(pessoa);

                            Console.WriteLine("Digite o Endereço para Cadastro");
                            pessoa.Endereco = Console.ReadLine();
                            pessoaService.CadastrarPessoa(pessoa);

                            Console.WriteLine("Digite a Cidade para Cadastro");
                            pessoa.Cidade = Console.ReadLine();
                            pessoaService.CadastrarPessoa(pessoa);

                            break;
                        }
                    case Menu.ConsultarNome:
                        {
                            Console.WriteLine("Digite o Nome para Consulta");
                            var nome = Console.ReadLine();
                            var consultaNome = pessoaService.ConsultarPorNome(nome);
                            Console.WriteLine(nome);

                            break;
                        }
                    
                    case Menu.ConsultarCpf:
                        {

                            break;
                        }
                    case Menu.ConsultarTelefone:
                        {
                            Console.WriteLine("Digite o Telefone para Consulta");
                            var telefone = Console.ReadLine();
                            var consultaTelefone = pessoaService.ConsultarPorTelefone(telefone);
                            Console.WriteLine(telefone);

                            break;
                        }
                    
                    case Menu.ConsultarCidade:
                        {
                            Console.WriteLine("Digite a Cidade para Consulta");
                            var cidade = Console.ReadLine();
                            var consultaCidade = pessoaService.ConsultarPorCidade(cidade);
                            Console.WriteLine(cidade);

                            break;
                        }
                    case Menu.Excluir:
                        {
                            Console.WriteLine("Digite CPF para Exclusão");
                            var CPF = Console.ReadLine();
                            pessoaService.ExcluirPessoa(CPF);

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
                            executar = false;
                            break;
                        }
                }
            } while (executar);
        }
    }
}
