using System;
using SchoolRegister.Model.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SchoolRegister.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        // table properties
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectGroup> SubjectGroups { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //configuration commands
            optionsBuilder.UseLazyLoadingProxies(); //enable lazy loading proxies
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API commands
            modelBuilder.Entity<User>()
            .ToTable("AspNetUsers")
            .HasDiscriminator<int>("UserType")
            .HasValue<User>((int)RoleValue.User)
            .HasValue<Student>((int)RoleValue.Student)
            .HasValue<Parent>((int)RoleValue.Parent)
            .HasValue<Teacher>((int)RoleValue.Teacher);


            modelBuilder.Entity<SubjectGroup>()
            .HasKey(sg => new { sg.GroupId, sg.SubjectId });

            modelBuilder.Entity<SubjectGroup>()
            .HasOne(g => g.Group)
            .WithMany(sg => sg.SubjectGroups)
            .HasForeignKey(g => g.GroupId);

            modelBuilder.Entity<SubjectGroup>()
            .HasOne(s => s.Subject)
            .WithMany(sg => sg.SubjectGroups)
            .HasForeignKey(s => s.SubjectId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grade>()
            .HasKey(sg => new { sg.StudentId, sg.SubjectId, sg.DateOfIssue });

            modelBuilder.Entity<Grade>()
            .HasOne(g => g.Student)
            .WithMany(sg => sg.Grades)
            .HasForeignKey(g => g.StudentId);

            modelBuilder.Entity<Grade>()
            .HasOne(g => g.Subject)
            .WithMany(sg => sg.Grades)
            .HasForeignKey(g => g.SubjectId);

            modelBuilder.Entity<Subject>()
            .HasKey(sg => new { sg.Id});

            modelBuilder.Entity<Subject>()
            .HasOne(g => g.Teacher)
            .WithMany(sg => sg.Subjects)
            .HasForeignKey(g => g.TeacherId);

            modelBuilder.Entity<Group>()
            .HasKey(sg => new { sg.Id });
        }
    }
}