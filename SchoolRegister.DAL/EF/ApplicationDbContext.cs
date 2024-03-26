using System.Data.SqlTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.Model.DataModels;
namespace SchoolRegister.DAL.EF;

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

/// SubjectGroup
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
///

///Grades
modelBuilder.Entity<Grade>()
.HasKey(g => new {g.DateOfIssue, g.SubjectId, g.StudentId});

modelBuilder.Entity<Grade>()
.HasOne(s => s.Student)
.WithMany(g => g.Grades)
.HasForeignKey(s => s.StudentId);

modelBuilder.Entity<Grade>()
.HasOne(s => s.Subject)
.WithMany(g => g.Grades)
.HasForeignKey(s => s.SubjectId);
///

///Subject
modelBuilder.Entity<Subject>()
.HasKey(i => new {i.Id});

modelBuilder.Entity<Subject>()
.HasOne(t=> t.Teacher)
.WithMany(s => s.Subjects)
.HasForeignKey(t => t.TeacherId);
///

///Group
modelBuilder.Entity<Group>()
.HasKey(id => new {id.Id});

modelBuilder.Entity<Group>()
.Property(n => n.Name)
.IsRequired();
///

///SubjectGroup
modelBuilder.Entity<SubjectGroup>()
.HasOne(g => g.Group)
.WithMany(sg => sg.SubjectGroups)
.HasForeignKey(g => g.GroupId);

modelBuilder.Entity<SubjectGroup>()
.HasOne(g => g.Group)
.WithMany(sg => sg.SubjectGroups)
.HasForeignKey(g => g.GroupId);
///

}
}