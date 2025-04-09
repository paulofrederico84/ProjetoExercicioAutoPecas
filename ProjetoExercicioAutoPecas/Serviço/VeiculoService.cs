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
    public class VeiculoService : IVeiculoService
    {
        private readonly VeiculoRepositorio _veiculoRepositorio;
        public VeiculoService(VeiculoRepositorio veiculoRepositorio)
        {
            _veiculoRepositorio = veiculoRepositorio;
        }
        public Guid CadastrarVeiculo(Veiculo veiculo)
        {
            return _veiculoRepositorio.RegistrarVeiculo(veiculo);
        }

        public List<Veiculo> BuscarTodos()
        {
            return _veiculoRepositorio.BuscarTodos();
        }

        public Veiculo BuscarVeiculoPorMarca(string marca)
        {
            return _veiculoRepositorio.BuscarVeiculoPorMarca(marca);
        }

        public Veiculo BuscarVeiculoPorModelo(string modelo)
        {
            return _veiculoRepositorio.BuscarVeiculoPorModelo(modelo);
        }

        public List<Veiculo> BuscarVeiculosAtivos()
        {
            return _veiculoRepositorio.BuscarVeiculosAtivos();
        }
        public Veiculo BuscarVeiculoPeloId(Guid id)
        {
            return _veiculoRepositorio.BuscarVeiculoPeloId(id);
        }
        public void ExcluirVeiculo(Guid id)
        {
            Veiculo veiculo = _veiculoRepositorio.BuscarVeiculoPeloId(id);
            if (veiculo != null)
            {
                veiculo.Ativo = false;
            }
        }
    }
}
