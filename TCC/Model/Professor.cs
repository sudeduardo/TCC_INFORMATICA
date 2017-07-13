using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Professor
    {       public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public string CPF { get; set; }
            public string Celular { get; set; }
            public string Endereco { get; set; }
            public virtual DateTime Data_Nascimento { get; set; }
            public virtual DateTime Data_Cadastro { get; set; }
            public virtual List<Curso> Cursos { get; set; }
    }
}
