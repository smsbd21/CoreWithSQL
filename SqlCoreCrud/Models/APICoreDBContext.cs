﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SqlCoreCrud.Models
{
    public partial class APICoreDBContext : DbContext
    {
        public APICoreDBContext()
        {
        }

        public APICoreDBContext(DbContextOptions<APICoreDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //# warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseSqlServer("Server=HASH;Database=APICoreDB;user id=sa;password=sqldb123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(18,0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
