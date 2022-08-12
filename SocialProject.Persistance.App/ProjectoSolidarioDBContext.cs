using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SocialProject.Persistence.App.Entities;

namespace SocialProject.Persistence.App
{
    public partial class ProjectoSolidarioDBContext : DbContext
    {
        public ProjectoSolidarioDBContext()
        {
        }

        public ProjectoSolidarioDBContext(DbContextOptions<ProjectoSolidarioDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Beneficiary> Beneficiaries { get; set; } = null!;
        public virtual DbSet<Delivery> Deliveries { get; set; } = null!;
        public virtual DbSet<Donation> Donations { get; set; } = null!;
        public virtual DbSet<Organization> Organizations { get; set; } = null!;
        public virtual DbSet<OrganizationAddress> OrganizationAddresses { get; set; } = null!;
        public virtual DbSet<ProductDelivery> ProductDeliveries { get; set; } = null!;
        public virtual DbSet<ProductDonation> ProductDonations { get; set; } = null!;
        public virtual DbSet<ProductSubType> ProductSubTypes { get; set; } = null!;
        public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<RegionVolunteer> RegionVolunteers { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestType> RequestTypes { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<StateType> StateTypes { get; set; } = null!;
        public virtual DbSet<UnitType> UnitTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRoleOrganizationAddress> UserRoleOrganizationAddresses { get; set; } = null!;
        public virtual DbSet<Volunteer> Volunteers { get; set; } = null!;
        public virtual DbSet<VolunteerOrganizationAddress> VolunteerOrganizationAddresses { get; set; } = null!;
        public virtual DbSet<Weekday> Weekdays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ProjectoSolidarioDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cp3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cp4)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__Address__RegionI__4E88ABD4");
            });

            modelBuilder.Entity<Beneficiary>(entity =>
            {
                entity.ToTable("Beneficiary");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK__Beneficia__Addre__4F7CD00D");

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__Beneficia__Organ__5070F446");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Beneficiary)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => d.BeneficiaryId)
                    .HasConstraintName("FK__Delivery__Benefi__5165187F");

                entity.HasOne(d => d.OrganizationAddressDestiny)
                    .WithMany(p => p.DeliveryOrganizationAddressDestinies)
                    .HasForeignKey(d => d.OrganizationAddressDestinyId)
                    .HasConstraintName("FK__Delivery__Organi__534D60F1");

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.DeliveryOrganizationAddresses)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__Delivery__Organi__52593CB8");
            });

            modelBuilder.Entity<Donation>(entity =>
            {
                entity.ToTable("Donation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__Donation__Organi__5441852A");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organization");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrganizationAddress>(entity =>
            {
                entity.ToTable("OrganizationAddress");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.OrganizationAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK__Organizat__Addre__5535A963");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationAddresses)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK__Organizat__Organ__5629CD9C");
            });

            modelBuilder.Entity<ProductDelivery>(entity =>
            {
                entity.ToTable("ProductDelivery");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.ProductDeliveries)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK__ProductDe__Deliv__571DF1D5");

                entity.HasOne(d => d.ProductSubType)
                    .WithMany(p => p.ProductDeliveries)
                    .HasForeignKey(d => d.ProductSubTypeId)
                    .HasConstraintName("FK__ProductDe__Produ__59063A47");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.ProductDeliveries)
                    .HasForeignKey(d => d.ProductTypeId)
                    .HasConstraintName("FK__ProductDe__Produ__5812160E");

                entity.HasOne(d => d.StateType)
                    .WithMany(p => p.ProductDeliveries)
                    .HasForeignKey(d => d.StateTypeId)
                    .HasConstraintName("FK__ProductDe__State__59FA5E80");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.ProductDeliveries)
                    .HasForeignKey(d => d.UnitTypeId)
                    .HasConstraintName("FK__ProductDe__UnitT__5AEE82B9");
            });

            modelBuilder.Entity<ProductDonation>(entity =>
            {
                entity.ToTable("ProductDonation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Donation)
                    .WithMany(p => p.ProductDonations)
                    .HasForeignKey(d => d.DonationId)
                    .HasConstraintName("FK__ProductDo__Donat__5BE2A6F2");

                entity.HasOne(d => d.ProductSubType)
                    .WithMany(p => p.ProductDonations)
                    .HasForeignKey(d => d.ProductSubTypeId)
                    .HasConstraintName("FK__ProductDo__Produ__5DCAEF64");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.ProductDonations)
                    .HasForeignKey(d => d.ProductTypeId)
                    .HasConstraintName("FK__ProductDo__Produ__5CD6CB2B");

                entity.HasOne(d => d.StateType)
                    .WithMany(p => p.ProductDonations)
                    .HasForeignKey(d => d.StateTypeId)
                    .HasConstraintName("FK__ProductDo__State__5EBF139D");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.ProductDonations)
                    .HasForeignKey(d => d.UnitTypeId)
                    .HasConstraintName("FK__ProductDo__UnitT__5FB337D6");
            });

            modelBuilder.Entity<ProductSubType>(entity =>
            {
                entity.ToTable("ProductSubType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.ProductSubTypes)
                    .HasForeignKey(d => d.ProductTypeId)
                    .HasConstraintName("FK__ProductSu__Produ__60A75C0F");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("ProductType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegionVolunteer>(entity =>
            {
                entity.ToTable("RegionVolunteer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionVolunteers)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__RegionVol__Regio__619B8048");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.RegionVolunteers)
                    .HasForeignKey(d => d.VolunteerId)
                    .HasConstraintName("FK__RegionVol__Volun__628FA481");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("Request");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__Request__Organiz__6383C8BA");

                entity.HasOne(d => d.ProductSubType)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ProductSubTypeId)
                    .HasConstraintName("FK__Request__Product__6477ECF3");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ProductTypeId)
                    .HasConstraintName("FK__Request__Product__656C112C");

                entity.HasOne(d => d.RequestType)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestTypeId)
                    .HasConstraintName("FK__Request__Request__66603565");
            });

            modelBuilder.Entity<RequestType>(entity =>
            {
                entity.ToTable("RequestType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__Schedule__Organi__6754599E");

                entity.HasOne(d => d.WeekDay)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.WeekDayId)
                    .HasConstraintName("FK__Schedule__WeekDa__68487DD7");
            });

            modelBuilder.Entity<StateType>(entity =>
            {
                entity.ToTable("StateType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.ToTable("UnitType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoleOrganizationAddress>(entity =>
            {
                entity.ToTable("UserRoleOrganizationAddress");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.UserRoleOrganizationAddresses)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__UserRoleO__Organ__693CA210");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoleOrganizationAddresses)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__UserRoleO__RoleI__6A30C649");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleOrganizationAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserRoleO__UserI__6B24EA82");
            });

            modelBuilder.Entity<Volunteer>(entity =>
            {
                entity.ToTable("Volunteer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VolunteerOrganizationAddress>(entity =>
            {
                entity.ToTable("VolunteerOrganizationAddress");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.OrganizationAddress)
                    .WithMany(p => p.VolunteerOrganizationAddresses)
                    .HasForeignKey(d => d.OrganizationAddressId)
                    .HasConstraintName("FK__Volunteer__Organ__6C190EBB");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.VolunteerOrganizationAddresses)
                    .HasForeignKey(d => d.VolunteerId)
                    .HasConstraintName("FK__Volunteer__Volun__6D0D32F4");
            });

            modelBuilder.Entity<Weekday>(entity =>
            {
                entity.ToTable("Weekday");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
