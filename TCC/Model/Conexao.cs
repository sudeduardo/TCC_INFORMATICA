namespace TCC.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Conexao : DbContext
    {
        public Conexao()
            : base("name=Conexao")
        {
        }

        public virtual DbSet<Responsavel> Responsaveis { get; set; }
        public virtual DbSet<Contas> Contas { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Dependente> Dependentes { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Aula> Aulas { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
