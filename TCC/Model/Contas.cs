using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Contas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public virtual DateTime Data_Lancamento { get; set; }
        public virtual DateTime Data_Contribuicao { get; set; }
    }
}
