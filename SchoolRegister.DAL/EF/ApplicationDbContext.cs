using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.Model.DataModels;
namespace SchoolRegister.DAL.EF;

public class ApplicationDbContext : IdentityDbContext<User, Role, int> 
{ 
    // table properties 
    public required virtual DbSet<Grade> Grades { get; set; } 
    public required virtual DbSet<Group> Groups { get; set; } 
    public required virtual DbSet<Subject> Subjects { get; set; } 
    public required virtual DbSet<SubjectGroup> SubjectGroups { get; set; } 
 
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
        
        modelBuilder.Entity<Grade>()
            .HasKey(sg => new { sg.StudentId, sg.SubjectId, sg.DateOfissue });
        
        modelBuilder.Entity<SubjectGroup>()
            .HasOne(g => g.Group)
            .WithMany(sg => sg.SubjectGroups)
            .HasForeignKey(g => g.GroupId);
        
        modelBuilder.Entity<SubjectGroup>()
            .HasOne(s => s.Subject)
            .WithMany(sg => sg.SubjectGroups)
            .HasForeignKey(s => s.SubjectId)
            .OnDelete(DeleteBehavior.Restrict);
    } 
} 