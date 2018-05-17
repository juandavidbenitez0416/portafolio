namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextPortafolio : DbContext
    {
        public ContextPortafolio()
            : base("name=ContextPortafolio")
        {
        }

        public virtual DbSet<Experiencia> Experiencias { get; set; }
        public virtual DbSet<Habilidad> Habilidads { get; set; }
        public virtual DbSet<TablaDato> TablaDatoes { get; set; }
        public virtual DbSet<Testimonio> Testimonios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
