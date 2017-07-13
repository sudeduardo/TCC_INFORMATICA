using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class ChamadaDependente
    {
        public ChamadaDependente(int id_aula)
        {
            Id_Aula = id_aula;
        }
        public int Id_Aluno { get; set; }

        public int Id_Aula { get; set; }

        public string Alunos { get; set; }

        public bool Presenca { get; set; }
       
        public List<ChamadaDependente> Chamada()
        {
            List<ChamadaDependente> chamada = new List<ChamadaDependente>();
            using(Conexao c = new Conexao())
            {
               List<Dependente> list_presenca= c.Aulas.Find(Id_Aula).Dependente;
               List<Dependente> lisa_matricula = c.Cursos.Where(p => p.Aulas.Where(j => j.Id == Id_Aula).Count() == 1).First().Depentes;

                foreach(Dependente dep in lisa_matricula)
                {
                    if (list_presenca.Contains(dep))
                    {
                        chamada.Add(new ChamadaDependente(Id_Aula){ Alunos = dep.Nome, Id_Aluno = dep.Id,Presenca = true});
                    }
                    else
                    {
                        chamada.Add(new ChamadaDependente(Id_Aula) { Alunos = dep.Nome, Id_Aluno = dep.Id, Presenca = false });
                    }
                }
            }
            return chamada;
        }
        public void SaveChamada(List<ChamadaDependente> chm, string txt)
        {
            using (Conexao c = new Conexao())
            {
                Aula aula = c.Aulas.Find(chm[0].Id_Aula);
                aula.Resumo = txt;
                foreach (ChamadaDependente Chamada in chm)
            {
                    if (Chamada.Presenca) {
                        aula.Dependente.Add(c.Dependentes.Find(Chamada.Id_Aluno));
                    }
                    else
                    {
                        aula.Dependente.Remove(c.Dependentes.Find(Chamada.Id_Aluno));
                    }
                }
                c.SaveChanges();
            }
        }
    }
}
