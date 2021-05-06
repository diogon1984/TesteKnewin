using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroCidade.Dominio.Entidades
{
    public class Cidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal QtdeHabitante { get; set; }

        public string FronteiraIds { get; set; }

        public List<int> ListFronteiraIds => FronteiraIds.Split(',').Select(Int32.Parse).ToList();
    }
}
