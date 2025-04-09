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
    public class PecaService : IPecaService
    {
        public string CadastrarPeca(Peca peca)
        {
            throw new NotImplementedException();
        }
        public Peca ConsultarPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }
        public Peca ConsultarPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }
        public Peca ConsultarPorFabricante(string fabricante)
        {
            throw new NotImplementedException();
        }
        public List<Peca> ListarTodas()
        {
            throw new NotImplementedException();
        }
        public List<Peca> ListarEmEstoque()
        {
            throw new NotImplementedException();
        }
        public void ExcluirPeca(string codigo)
        {
            throw new NotImplementedException();
        }   
    }
}
