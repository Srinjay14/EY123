using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mile3;

public partial class Mileston3task2Context : DbContext
{
    public Mileston3task2Context()
    {
    }

    public Mileston3task2Context(DbContextOptions<Mileston3task2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User1> User1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=1EB507C8177550A;database=mileston3task2;integrated security = true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Ticket__712CC60773A52AC5");

            entity.ToTable("Ticket");

            entity.Property(e => e.TicketId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.User).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ticket__UserId__3B75D760");
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User1__1788CC4CCE34440E");

            entity.ToTable("User1");

            entity.HasIndex(e => e.Email, "UQ__User1__A9D10534BD40FB66").IsUnique();

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
