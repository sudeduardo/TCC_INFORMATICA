using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class ChamadaResponsavel
    {
        public ChamadaResponsavel(int id_aula)
        {
            Id_Aula = id_aula;
        }
        public int Id_Aluno { get; set; }

        public int Id_Aula { get; set; }

        public string Alunos { get; set; }

        public bool Presenca { get; set; }
       
        public List<ChamadaResponsavel> Chamada()
        {
            List<ChamadaResponsavel> chamada = new List<ChamadaResponsavel>();
            using(Conexao c = new Conexao())
            {
               List<Responsavel> list_presenca= c.Aulas.Find(Id_Aula).Responsaveis;
               List<Responsavel> lisa_matricula = c.Cursos.Where(p => p.Aulas.Where(j => j.Id == Id_Aula).Count() == 1).First().Responsavel;

                foreach(Responsavel resp in lisa_matricula)
                {
                    if (list_presenca.Contains(resp))
                    {
                        chamada.Add(new ChamadaResponsavel(Id_Aula){ Alunos = resp.Nome, Id_Aluno = resp.Id,Presenca = true});
                    }
                    else
                    {
                        chamada.Add(new ChamadaResponsavel(Id_Aula) { Alunos = resp.Nome, Id_Aluno = resp.Id, Presenca = false });
                    }
                }
            }
            return chamada;
        }
        public void SaveChamada(List<ChamadaResponsavel> chm, string txt)
        {
            using (Conexao c = new Conexao())
            {
                Aula aula = c.Aulas.Find(chm[0].Id_Aula);
                aula.Resumo = txt;
                foreach (ChamadaResponsavel Chamada in chm){
                    if (Chamada.Presenca) {
                        aula.Responsaveis.Add(c.Responsaveis.Find(Chamada.Id_Aluno));
                    }
                    else
                    {
                        aula.Responsaveis.Remove(c.Responsaveis.Find(Chamada.Id_Aluno));
                    }
                }
                c.SaveChanges();
            }
        }
    }
}
