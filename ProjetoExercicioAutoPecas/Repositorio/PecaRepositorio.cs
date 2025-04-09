using ProjetoExercicioAutoPecas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Repositorio
{
    public class PecaRepositorio
    {
        private List<Peca> _peca = new List<Peca>();
        public string RegistrarPeca(Peca peca)
        {
            _peca.Add(peca);
            return peca.Codigo;
        }
        public Peca BuscarPecaPeloCodigo(string codigo)
        {
            Peca peca = _peca.Find(peca => peca.Codigo == codigo);
            return peca;
        }
        public Peca BuscarPecaPelaDescricao(string descricao)
        {
            Peca peca = _peca.Find(peca => peca.Descricao == descricao);
            return peca;
        }
        public Peca BuscarPecaPeloFabricante(string fabricante)
        {
            Peca peca = _peca.Find(peca => peca.Fabricante == fabricante);
            return peca;
        }
        public List<Peca> BuscarTodas()
        {
            return _peca;
        }
        public List<Peca> BuscarPecasEmEstoque()
        {
            List<Peca> pecasEmEstoque = new List<Peca>();
            foreach (Peca peca in _peca)
            {
                if (peca.Estoque)
                    pecasEmEstoque.Add(peca);
            }
            return pecasEmEstoque;
        }
        public void RemoverPeca(string codigo)
        {
            Peca peca = _peca.Find(p => p.Codigo == codigo);
            if (peca != null)
            {
                _peca.Remove(peca);
                Console.WriteLine("Peça removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Peça com este código não foi encontrada.");
            }
        }
    }
}
