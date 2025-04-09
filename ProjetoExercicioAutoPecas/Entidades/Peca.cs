using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioAutoPecas.Entidades
{
    public class Peca
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public bool Estoque { get; set; }
    }
}
