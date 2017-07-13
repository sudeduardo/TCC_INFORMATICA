using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Aula
    {
        public int Id { get; set; }
        public virtual DateTime Data { get; set; }
        public string Resumo { get; set; }
        public virtual List<Dependente> Dependente { get; set; }
        public virtual List<Responsavel> Responsaveis { get; set; }
    }
}
