using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Servico
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<CentralAlarme> CentralAlarme { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.idCentral)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.jalogado)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.alterou)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.diasParaUso)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.bloqueioUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.bateria)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona1)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona2)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona3)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona4)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona5)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona6)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona7)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.zona8)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona1)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona2)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona3)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona4)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona5)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona6)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona7)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.statZona8)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona1)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona2)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona3)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona4)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona5)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona6)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona7)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.despZona8)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra1)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra2)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra3)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra4)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra5)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra6)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra7)
                .IsUnicode(false);

            modelBuilder.Entity<CentralAlarme>()
                .Property(e => e.pinExtra8)
                .IsUnicode(false);
        }
    }
}
