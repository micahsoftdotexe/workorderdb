using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class WorkOrderContext : DbContext
    {
        public WorkOrderContext()
        {
        }

        public WorkOrderContext(DbContextOptions<WorkOrderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Automobile> Automobiles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Labor> Labors { get; set; }
        public virtual DbSet<Own> Owns { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=localhost;database=WorkOrders;user id=SA; Password=DBProjectPass!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressType })
                    .HasName("Address_pk");

                entity.ToTable("Address");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressTypeNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Address_AddressType");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Address_Customer");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasKey(e => e.AddressType1)
                    .HasName("AddressType_pk");

                entity.ToTable("AddressType");

                entity.Property(e => e.AddressType1)
                    .ValueGeneratedNever()
                    .HasColumnName("AddressType");

                entity.Property(e => e.AddressDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Automobile>(entity =>
            {
                entity.ToTable("Automobile");

                entity.Property(e => e.AutomobileId).HasColumnName("AutomobileID");

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Labor>(entity =>
            {
                entity.ToTable("Labor");

                entity.Property(e => e.LaborId).HasColumnName("LaborID");

                entity.Property(e => e.LaborDesc)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LaborNotes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LaborPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.Labors)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Labor_WorkOrder");
            });

            modelBuilder.Entity<Own>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AutomobileId })
                    .HasName("Owns_pk");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AutomobileId).HasColumnName("AutomobileID");

                entity.HasOne(d => d.Automobile)
                    .WithMany(p => p.Owns)
                    .HasForeignKey(d => d.AutomobileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Owns_Automobile");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Owns)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Owns_Customer");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("Part");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.PartDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartMargin).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Parts_WorkOrder");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.PhoneType })
                    .HasName("PhoneNumber_pk");

                entity.ToTable("PhoneNumber");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.PhoneNumber1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PhoneNumber");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PhoneNumber_Customer");

                entity.HasOne(d => d.PhoneTypeNavigation)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.PhoneType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PhoneNumber_PhoneType");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneType1)
                    .HasName("PhoneType_pk");

                entity.ToTable("PhoneType");

                entity.Property(e => e.PhoneType1)
                    .ValueGeneratedNever()
                    .HasColumnName("PhoneType");

                entity.Property(e => e.PhoneDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.ToTable("WorkOrder");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AutomobileId).HasColumnName("AutomobileID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Tax).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkOrderNotes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.Automobile)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.AutomobileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WorkOrder_Automobile");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WorkOrder_Customer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
