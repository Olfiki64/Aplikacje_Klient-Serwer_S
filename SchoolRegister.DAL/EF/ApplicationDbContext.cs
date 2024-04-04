using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.Model.DataModels;

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
.HasKey(g=>new{g.DateOfIssue,g.SubjectId,g.StudentId});

modelBuilder.Entity<Grade>()
.HasOne(s=>s.Student)
.WithMany(g=>g.Grades)
.HasForeignKey(s=> s.StudentId);

modelBuilder.Entity<Grade>()
.HasOne(s=>s.Subject)
.WithMany(g=>g.Grades)
.HasForeignKey(s=> s.SubjectId);

modelBuilder.Entity<Subject>()
.HasKey(s=>new{s.Id});
modelBuilder.Entity<Subject>()
.HasOne(s=>s.Teacher)
.WithMany(s=>s.Subjects)
.HasForeignKey(s=>s.TeacherId);
modelBuilder.Entity<Group>()
.HasKey(g=>new{g.Id});
modelBuilder.Entity<Group>()
.HasMany(g=>g.Students)
.WithOne(g=>g.Group)
.HasForeignKey(g=>g.GroupId)
.IsRequired();
}
}
}