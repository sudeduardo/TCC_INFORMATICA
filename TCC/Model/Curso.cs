using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual DateTime Data_Inicio { get; set; }
        public virtual DateTime Data_Final { get; set; }
        public string Descricao { get; set; }

        public virtual List<Aula> Aulas { get; set; }
        public virtual List<Dependente> Depentes { get; set; }
        public virtual List<Responsavel> Responsavel { get; set; }

    }
}
