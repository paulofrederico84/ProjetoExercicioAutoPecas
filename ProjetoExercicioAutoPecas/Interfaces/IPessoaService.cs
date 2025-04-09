using ProjetoExercicioAutoPecas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Interfaces
{
    public interface IPessoaService
    {
        string CadastrarPessoa(Pessoa pessoa);
        Pessoa ConsultarPorCpf(string cpf);
        Pessoa ConsultarPorNome(string nome);
        Pessoa ConsultarPorTelefone(string telefone);
        Pessoa ConsultarPorCidade(string cidade);
        List<Pessoa> ListarTodas();
        void ExcluirPessoa(string cpf);
    }
}
