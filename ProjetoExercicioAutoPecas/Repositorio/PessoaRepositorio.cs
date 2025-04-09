using ProjetoExercicioAutoPecas.Entidades;

namespace ProjetoExercicioAutoPecas.Repositorio
{
    public class PessoaRepositorio
    {
        private List<Pessoa> _pessoa = [];
        public string RegistrarPessoa(Pessoa pessoa)
        {
            _pessoa.Add(pessoa);
            return pessoa.CPF;
        }
        public Pessoa BuscarPessoaPeloCPF(string CPF)
        {
            Pessoa pessoa = _pessoa.Find(pessoa => pessoa.CPF == CPF);
            return pessoa;
        }
        public Pessoa BuscarPessoaPeloNome(string nome)
        {
            Pessoa pessoa = _pessoa.Find(pessoa => pessoa.Nome == nome);
            return pessoa;
        }
        public Pessoa BuscarPessoaPeloTelefone(string telefone)
        {
            Pessoa pessoa = _pessoa.Find(pessoa => pessoa.Telefone == telefone);
            return pessoa;
        }
        public Pessoa BuscarPessoaPorCidade(string cidade)
        {
            Pessoa pessoa = _pessoa.Find(pessoa => pessoa.Cidade == cidade);
            return pessoa;
        }
        public List<Pessoa> BuscarTodas()
        { 
            return _pessoa;
        }
        public void RemoverPessoa(string CPF)
        {
            Pessoa pessoa = _pessoa.Find(p => p.CPF == CPF);
            if (pessoa != null)
            {
                _pessoa.Remove(pessoa);
                Console.WriteLine("Pessoa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Pessoa com este CPF não foi encontrada.");
            }
        }
        
    }
}

