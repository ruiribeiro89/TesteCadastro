using Cadastro.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.RepositorioEF
{
    public class Contexto:DbContext 
    {
        public Contexto():base("CadastroConfig")
        {

        }

        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Remove a função de criar tabelas com plurais
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.DataNascimento).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired().HasColumnType("varchar").HasMaxLength(30);
            modelBuilder.Entity<Usuario>().Property(x => x.Ativo).IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Usuario>().Property(x => x.Sexo).IsRequired().HasColumnType("int");
            //modelBuilder.Entity<Usuario>().HasRequired(r => r.se);



            modelBuilder.Entity<Sexo>().Property(x => x.SexoId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Sexo>().Property(x => x.Descricao).IsRequired().HasColumnType("varchar").HasMaxLength(15);


        }


    }
}
