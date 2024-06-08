using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace p2.Model8;

public partial class CUsersAhmadMurtazaDocumentsEaddMdfContext : DbContext
{
    public CUsersAhmadMurtazaDocumentsEaddMdfContext()
    {
    }

    public CUsersAhmadMurtazaDocumentsEaddMdfContext(DbContextOptions<CUsersAhmadMurtazaDocumentsEaddMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Ahmad Murtaza\\Documents\\EADD.mdf';Integrated Security=True;Connect Timeout=30;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83FB5FFCD97");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .HasColumnName("cnic");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .HasColumnName("phone");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .HasColumnName("role");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vid).HasName("PK__Vehicles__C5DF235BDF0C1B64");

            entity.Property(e => e.Vid).HasColumnName("VId");
            entity.Property(e => e.Vname)
                .HasMaxLength(50)
                .HasColumnName("VName");
            entity.Property(e => e.Vowner)
                .HasMaxLength(50)
                .HasColumnName("VOwner");
            entity.Property(e => e.Vplate)
                .HasMaxLength(15)
                .HasColumnName("VPlate");
            entity.Property(e => e.Vtype)
                .HasMaxLength(50)
                .HasColumnName("VType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
