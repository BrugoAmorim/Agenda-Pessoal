using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace backend.Models
{
    public partial class agendaContext : DbContext
    {
        public agendaContext()
        {
        }

        public agendaContext(DbContextOptions<agendaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBlocoNotas> TbBlocoNota { get; set; }
        public virtual DbSet<TbCategoria> TbCategoria { get; set; }
        public virtual DbSet<TbContato> TbContatos { get; set; }
        public virtual DbSet<TbTarefa> TbTarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("host=localhost;user=root;password=12345;database=agenda", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4");

            modelBuilder.Entity<TbBlocoNotas>(entity =>
            {
                entity.HasKey(e => e.IdBlocoNota)
                    .HasName("PRIMARY");

                entity.ToTable("tb_bloco_nota");

                entity.Property(e => e.IdBlocoNota).HasColumnName("id_bloco_nota");

                entity.Property(e => e.DsConteudo)
                    .HasMaxLength(500)
                    .HasColumnName("ds_conteudo");

                entity.Property(e => e.DtAtualizado)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_atualizado");

                entity.Property(e => e.DtCriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_criacao");

                entity.Property(e => e.NmBloco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nm_bloco");
            });

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PRIMARY");

                entity.ToTable("tb_categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.DsCategoria)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("ds_categoria");

                entity.Property(e => e.NmCategoria)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm_categoria");
            });

            modelBuilder.Entity<TbContato>(entity =>
            {
                entity.HasKey(e => e.IdContato)
                    .HasName("PRIMARY");

                entity.ToTable("tb_contato");

                entity.Property(e => e.IdContato).HasColumnName("id_contato");

                entity.Property(e => e.DsCelular)
                    .HasMaxLength(14)
                    .HasColumnName("ds_celular");

                entity.Property(e => e.DsCidade)
                    .HasMaxLength(50)
                    .HasColumnName("ds_cidade");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(80)
                    .HasColumnName("ds_email");

                entity.Property(e => e.DsEstado)
                    .HasMaxLength(50)
                    .HasColumnName("ds_estado");

                entity.Property(e => e.DsNotas)
                    .HasMaxLength(80)
                    .HasColumnName("ds_notas");

                entity.Property(e => e.DsTelefone)
                    .HasMaxLength(9)
                    .HasColumnName("ds_telefone");

                entity.Property(e => e.NmContato)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("nm_contato");
            });

            modelBuilder.Entity<TbTarefa>(entity =>
            {
                entity.HasKey(e => e.IdTarefa)
                    .HasName("PRIMARY");

                entity.ToTable("tb_tarefa");

                entity.HasIndex(e => e.IdCategoria, "id_categoria");

                entity.Property(e => e.IdTarefa).HasColumnName("id_tarefa");

                entity.Property(e => e.BlConcluida).HasColumnName("bl_concluida");

                entity.Property(e => e.DsTarefa)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ds_tarefa");

                entity.Property(e => e.DtAdicionado)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_adicionado");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.VlPrioridade).HasColumnName("vl_prioridade");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbTarefas)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_tarefa_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
