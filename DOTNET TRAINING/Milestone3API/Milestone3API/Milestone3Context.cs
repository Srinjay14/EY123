using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Milestone3API;

public partial class Milestone3Context : DbContext
{
    public Milestone3Context()
    {
    }

    public Milestone3Context(DbContextOptions<Milestone3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Task3> Task3s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=1EB507C8177550A;database=Milestone_3;integrated security = true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task3>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__task3__3213E83F2B1A8621");

            entity.ToTable("task3");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duedate)
                .HasColumnType("datetime")
                .HasColumnName("duedate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
