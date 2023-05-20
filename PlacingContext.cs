using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CombinatorialProblem;

public partial class PlacingContext : DbContext
{
    public PlacingContext()
    {
    }

    public PlacingContext(DbContextOptions<PlacingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<UserException> UserExceptions { get; set; }

    public Form1 Form1
    {
        get => default;
        set
        {
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Placing;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Result_pkey");

            entity.ToTable("Result");

            entity.Property(e => e.DateTime).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Result1).HasColumnName("Result");
        });

        modelBuilder.Entity<UserException>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserException_pkey");

            entity.ToTable("UserException");

            entity.Property(e => e.DateTimeExc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dateTimeExc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
