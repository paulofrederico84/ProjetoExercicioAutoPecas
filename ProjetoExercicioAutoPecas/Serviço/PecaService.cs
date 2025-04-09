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
        private readonly PecaRepositorio _pecaRepositorio;
        public PecaService(PecaRepositorio pecaRepositorio)
        {
            _pecaRepositorio = pecaRepositorio;
        }
        public string CadastrarPeca(Peca peca)
        {
            return _pecaRepositorio.RegistrarPeca(peca);
        }
        public Peca ConsultarPorCodigo(string codigo)
        {
            return _pecaRepositorio.BuscarPecaPeloCodigo(codigo);
        }
        public Peca ConsultarPorDescricao(string descricao)
        {
            return _pecaRepositorio.BuscarPecaPelaDescricao(descricao);
        }
        public Peca ConsultarPorFabricante(string fabricante)
        {
            return _pecaRepositorio.BuscarPecaPeloFabricante(fabricante);
        }
        public List<Peca> ListarTodas()
        {
            return _pecaRepositorio.BuscarTodas();
        }
        public List<Peca> ListarEmEstoque()
        {
            return _pecaRepositorio.BuscarPecasEmEstoque();
        }
        public void ExcluirPeca(string codigo)
        {
            _pecaRepositorio.RemoverPeca(codigo);
        }
    }
}
