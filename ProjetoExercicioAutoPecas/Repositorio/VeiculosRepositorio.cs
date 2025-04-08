using ProjetoExercicioAutoPecas.Entidades;
using ProjetoExercicioAutoPecas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Repositorio
{
    public class VeiculosRepositorio : IVeiculoService
    {
        private List<Veiculo> _veiculos = [];
        public Guid RegistrarVeiculo(Veiculo veiculo)
        {
            veiculo.Id = Guid.NewGuid();

            _veiculos.Add(veiculo);
            return veiculo.Id;
        }

        public Veiculo BuscarVeiculoPorMarca(string marca)
        {
            Veiculo veiculo = _veiculos.Find(veiculo => veiculo.Marca == marca);
            return veiculo;
        }

        public Veiculo BuscarVeiculoPorModelo(string modelo)
        {
            Veiculo veiculo = _veiculos.Find(veiculo => veiculo.Modelo == modelo);
            return veiculo;
        }

        public Veiculo BuscarVeiculoPeloId(Guid id)
        {
            Veiculo veiculo = _veiculos.Find(veiculo => veiculo.Id == id);
            return veiculo;
        }

        public List<Veiculo> BuscarTodos()
        {
            return _veiculos;
        }

        public List<Veiculo> BuscarVeiculosAtivos()
        {
            List<Veiculo> veiculosAtivos = [];

            foreach (Veiculo veiculo in _veiculos)
            {
                if (veiculo.Ativo)
                    veiculosAtivos.Add(veiculo);
            }

            return veiculosAtivos;
        }        
    }
}

