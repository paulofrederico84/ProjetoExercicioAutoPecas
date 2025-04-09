using ProjetoExercicioAutoPecas.Interfaces;
using ProjetoExercicioAutoPecas.Entidades;
using ProjetoExercicioAutoPecas.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Serviço
{
    public class PessoaService : IPessoaService
    {
        private readonly PessoaRepositorio _pessoaRepositorio;
        public PessoaService(PessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        public string CadastrarPessoa(Pessoa pessoa)
        {
            return _pessoaRepositorio.RegistrarPessoa(pessoa);
        }
        public Pessoa ConsultarPorCpf(string cpf)
        {
            return _pessoaRepositorio.BuscarPessoaPeloCPF(cpf);
        }
        public Pessoa ConsultarPorNome(string nome)
        {
            return _pessoaRepositorio.BuscarPessoaPeloNome(nome);
        }
        public Pessoa ConsultarPorTelefone(string telefone)
        {
            return _pessoaRepositorio.BuscarPessoaPeloTelefone(telefone);
        }
        public Pessoa ConsultarPorCidade(string cidade)
        {
            return _pessoaRepositorio.BuscarPessoaPorCidade(cidade);
        }
        public List<Pessoa> ListarTodas()
        {
            return _pessoaRepositorio.BuscarTodas();
        }
        public void ExcluirPessoa(string cpf)
        {
            _pessoaRepositorio.RemoverPessoa(cpf);
        }
    }
}
