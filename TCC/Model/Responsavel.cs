using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Responsavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email{ get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public virtual DateTime Data_Nascimento { get; set; }
        public virtual DateTime Data_Associacao { get; set; }
        public virtual List<Dependente> Dependentes { get; set; }
        public virtual List<Curso> Cursos { get; set; }
        public virtual List<Aula> Aulas { get; set; }
    }
}
