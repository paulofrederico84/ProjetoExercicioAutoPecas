using ProjetoExercicioAutoPecas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Interfaces
{
    public interface IPecaService
    {
        string CadastrarPeca(Peca peca);
        Peca ConsultarPorCodigo(string codigo);
        Peca ConsultarPorDescricao(string descricao);
        Peca ConsultarPorFabricante(string fabricante);
        List<Peca> ListarTodas();
        List<Peca> ListarEmEstoque();
        void ExcluirPeca(string codigo);
    }
}
