using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Entidades
{
    public class Veiculos
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Motor { get; set; }
        public string AnoFabricacao { get; set; }
        public bool Ativo { get; set; }
       
    }
}
