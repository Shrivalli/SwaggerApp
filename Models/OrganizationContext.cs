using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SwaggerEg.Models
{
    public partial class OrganizationContext : DbContext
    {
        public OrganizationContext()
        {
        }

        public OrganizationContext(DbContextOptions<OrganizationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetSqlCacheTablesForChangeNotification> AspNetSqlCacheTablesForChangeNotification { get; set; }
        public virtual DbSet<Cust> Cust { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<EmpApi> EmpApi { get; set; }
        public virtual DbSet<Empgrid> Empgrid { get; set; }
        public virtual DbSet<Empl> Empl { get; set; }
        public virtual DbSet<Employeenew> Employeenew { get; set; }
        public virtual DbSet<Empvalid> Empvalid { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductNiit> ProductNiit { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RankDemo> RankDemo { get; set; }
        public virtual DbSet<Sample> Sample { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentAddress> StudentAddress { get; set; }
        public virtual DbSet<TblDepartment1> TblDepartment1 { get; set; }
        public virtual DbSet<TblDept> TblDept { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
        public virtual DbSet<TblEmployee1> TblEmployee1 { get; set; }
        public virtual DbSet<TblRecord> TblRecord { get; set; }
        public virtual DbSet<Tbldepartment> Tbldepartment { get; set; }
        public virtual DbSet<Tblemp> Tblemp { get; set; }
        public virtual DbSet<Tblempl> Tblempl { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Organization;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetSqlCacheTablesForChangeNotification>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK__AspNet_S__93F7AC6927057C20");

                entity.ToTable("AspNet_SqlCacheTablesForChangeNotification");

                entity.Property(e => e.TableName).HasColumnName("tableName");

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.NotificationCreated)
                    .HasColumnName("notificationCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cust>(entity =>
            {
                entity.Property(e => e.CustId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsMember)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasMaxLength(30);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_dbo.Customers");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Msg).HasColumnName("msg");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("PK_dbo.Departments");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Deptname).HasColumnName("deptname");
            });

            modelBuilder.Entity<EmpApi>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK_dbo.EmpAPI");

                entity.ToTable("EmpAPI");

                entity.Property(e => e.Eid).HasColumnName("eid");
            });

            modelBuilder.Entity<Empgrid>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("empgrid");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(50);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Empl>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__empl__AF4CE865C4931D2C");

                entity.ToTable("empl");

                entity.Property(e => e.Empid)
                    .HasColumnName("empid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Newcity)
                    .HasColumnName("newcity")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employeenew>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasMaxLength(30);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Doj)
                    .HasColumnName("doj")
                    .HasColumnType("date");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Empvalid>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empvalid__D9509F6DF5B3E511");

                entity.ToTable("empvalid");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Doj)
                    .HasColumnName("doj")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(20);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(10);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Friends>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK__friends__D9908D64492F619C");

                entity.ToTable("friends");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.HasKey(e => e.RollNo)
                    .HasName("PK__Images__28B564052974BF64");

                entity.Property(e => e.RollNo)
                    .HasColumnName("Roll_no")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.ImgDate)
                    .HasColumnName("img_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<ProductNiit>(entity =>
            {
                entity.HasKey(e => e.Prid);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.Dop)
                    .HasColumnName("dop")
                    .HasColumnType("date");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Prname).HasMaxLength(25);

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("products");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<RankDemo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rank_demo");

                entity.Property(e => e.V)
                    .HasColumnName("v")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sample");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sid).HasColumnName("SID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).ValueGeneratedNever();

                entity.Property(e => e.StudentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StudentAddress)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.StudentAddressId)
                    .HasConstraintName("FK__Student__Student__5441852A");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Student__Teacher__534D60F1");
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.Property(e => e.StudentAddressId).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepartment1>(entity =>
            {
                entity.HasKey(e => e.Deptid);

                entity.ToTable("tblDepartment1");

                entity.Property(e => e.Deptid).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDept>(entity =>
            {
                entity.HasKey(e => e.Did);

                entity.ToTable("tblDept");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__tblEmplo__D9509F6D438B9770");

                entity.ToTable("tblEmployee");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Doj)
                    .HasColumnName("doj")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sal).HasColumnName("sal");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.TblEmployee)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK__tblEmploy__depti__173876EA");
            });

            modelBuilder.Entity<TblEmployee1>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("tblEmployee1");

                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.JoiningDate)
                    .HasColumnName("Joining_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRecord>(entity =>
            {
                entity.ToTable("tbl_Record");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldepartment>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("PK__tbldepar__BE2C1AEE38622143");

                entity.ToTable("tbldepartment");

                entity.Property(e => e.Deptid)
                    .HasColumnName("deptid")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblemp");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Doj)
                    .HasColumnName("doj")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Tblempl>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("tblempl");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Doj)
                    .HasColumnName("doj")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
