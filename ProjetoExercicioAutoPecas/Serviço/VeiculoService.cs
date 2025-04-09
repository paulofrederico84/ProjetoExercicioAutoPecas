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
        public Guid RegistrarVeiculo(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }
        public Veiculo BuscarVeiculoPorMarca(string marca)
        {
            throw new NotImplementedException();
        }
        public Veiculo BuscarVeiculoPorModelo(string modelo)
        {
            throw new NotImplementedException();
        }
        public List<Veiculo> BuscarTodos()
        {
            throw new NotImplementedException();
        }
        public List<Veiculo> BuscarVeiculosAtivos()
        {
            throw new NotImplementedException();
        }    
    }
}
