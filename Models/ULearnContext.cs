using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ULearn.Models
{
    public partial class ULearnContext : DbContext
    {
        public ULearnContext()
        {
        }

        public ULearnContext(DbContextOptions<ULearnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CartVM> Carts { get; set; }
        public virtual DbSet<CategoryVM> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CrsCart> CrsCarts { get; set; }
        public virtual DbSet<CrsWhish> CrsWhishes { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<LearnCr> LearnCrs { get; set; }
        public virtual DbSet<LearningList> LearningLists { get; set; }
        public virtual DbSet<LevelThree> LevelThrees { get; set; }
        public virtual DbSet<LevelTwo> LevelTwos { get; set; }
        public virtual DbSet<Levelone> Levelones { get; set; }
        public virtual DbSet<StdCr> StdCrs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<WhishList> WhishLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{

            //    optionsBuilder.UseSqlServer("Data Source=mra\\sqlexpress;Initial Catalog=ULearn;Persist Security Info=True;User ID=sa;Password=123");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<CartVM>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StdId).HasColumnName("Std_Id");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("Total_Price");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.StdId)
                    .HasConstraintName("FK_Carts_Student");
            });

            modelBuilder.Entity<CategoryVM>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.LoneId).HasColumnName("lone_id");

                entity.Property(e => e.LthreeId).HasColumnName("lthree_id");

                entity.Property(e => e.LtwoId).HasColumnName("ltwo_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Lone)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.LoneId)
                    .HasConstraintName("FK_Category_Levelone");

                entity.HasOne(d => d.Lthree)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.LthreeId)
                    .HasConstraintName("FK_Category_LevelThree");

                entity.HasOne(d => d.Ltwo)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.LtwoId)
                    .HasConstraintName("FK_Category_LevelTwo");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripton)
                    .HasMaxLength(100)
                    .HasColumnName("descripton")
                    .IsFixedLength(true);

                entity.Property(e => e.Duration)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("duration");

                entity.Property(e => e.InsId).HasColumnName("ins_Id");

                entity.Property(e => e.LoneId).HasColumnName("lone_id");

                entity.Property(e => e.LthreeId).HasColumnName("lthree_id");

                entity.Property(e => e.LtwoId).HasColumnName("ltwo_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.HasOne(d => d.Ins)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InsId)
                    .HasConstraintName("FK_Course_Instructor");

                entity.HasOne(d => d.Lone)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LoneId)
                    .HasConstraintName("FK_Course_Levelone");

                entity.HasOne(d => d.Lthree)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LthreeId)
                    .HasConstraintName("FK_Course_LevelThree");

                entity.HasOne(d => d.Ltwo)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LtwoId)
                    .HasConstraintName("FK_Course_LevelTwo");
            });

            modelBuilder.Entity<CrsCart>(entity =>
            {
                entity.HasKey(e => new { e.CrsId, e.CartId });

                entity.ToTable("Crs_Cart");

                entity.Property(e => e.CrsId).HasColumnName("Crs_Id");

                entity.Property(e => e.CartId).HasColumnName("Cart_Id");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CrsCarts)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Crs_Cart_Carts");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.CrsCarts)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Crs_Cart_Course");
            });

            modelBuilder.Entity<CrsWhish>(entity =>
            {
                entity.HasKey(e => new { e.CrsId, e.WhishId });

                entity.ToTable("Crs_Whish");

                entity.Property(e => e.CrsId).HasColumnName("Crs_Id");

                entity.Property(e => e.WhishId).HasColumnName("Whish_Id");

                entity.HasOne(d => d.Whish)
                    .WithMany(p => p.CrsWhishes)
                    .HasForeignKey(d => d.WhishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Crs_Whish_WhishList");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.ToTable("Instructor");

                entity.Property(e => e.InsId)
                    .ValueGeneratedNever()
                    .HasColumnName("Ins_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LearnCr>(entity =>
            {
                entity.HasKey(e => new { e.CrsId, e.LearnId });

                entity.ToTable("Learn_Crs");

                entity.Property(e => e.CrsId).HasColumnName("Crs_Id");

                entity.Property(e => e.LearnId).HasColumnName("Learn_Id");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.LearnCrs)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Learn_Crs_Course");

                entity.HasOne(d => d.Learn)
                    .WithMany(p => p.LearnCrs)
                    .HasForeignKey(d => d.LearnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Learn_Crs_LearningList");
            });

            modelBuilder.Entity<LearningList>(entity =>
            {
                entity.ToTable("LearningList");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StdId).HasColumnName("Std_Id");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.LearningLists)
                    .HasForeignKey(d => d.StdId)
                    .HasConstraintName("FK_LearningList_Student");
            });

            modelBuilder.Entity<LevelThree>(entity =>
            {
                entity.ToTable("LevelThree");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LevelTwo>(entity =>
            {
                entity.ToTable("LevelTwo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Levelone>(entity =>
            {
                entity.ToTable("Levelone");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StdCr>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.CrsId });

                entity.ToTable("Std_Crs");

                entity.Property(e => e.StdId).HasColumnName("Std_Id");

                entity.Property(e => e.CrsId).HasColumnName("Crs_Id");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.StdCrs)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Std_Crs_Course");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.StdCrs)
                    .HasForeignKey(d => d.StdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Std_Crs_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("city")
                    .IsFixedLength(true);

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Pass)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<WhishList>(entity =>
            {
                entity.ToTable("WhishList");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StdId).HasColumnName("Std_Id");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.WhishLists)
                    .HasForeignKey(d => d.StdId)
                    .HasConstraintName("FK_WhishList_Student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
