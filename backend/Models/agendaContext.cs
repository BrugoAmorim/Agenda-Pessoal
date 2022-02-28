﻿using System;
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

        public virtual DbSet<TbContato> TbContatos { get; set; }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}