using ProjetoExercicioAutoPecas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Interfaces
{
    internal class IVeiculoService
    {
        Guid RegistrarVeiculo(Veiculo veiculo);
        Veiculo BuscarVeiculoPorMarca(string marca);
        Veiculo BuscarVeiculoPorModelo(string modelo);
        List<Veiculo> BuscarTodos();
        List<Veiculo> BuscarVeiculosAtivos();        

    }
}
