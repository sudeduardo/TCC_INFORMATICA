using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Dependente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public virtual DateTime Data_Nascimento { get; set; }
        public string Telefone { get; set; }
        public virtual List<Curso> Cursos { get; set; }
        public virtual List<Aula> Aulas { get; set; }
    }
}
