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
}
}
}
