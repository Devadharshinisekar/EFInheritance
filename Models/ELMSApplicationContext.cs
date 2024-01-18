using ELMSApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ELMSApplication
{
    public class ELMSApplicationContext : DbContext
    {
        public ELMSApplicationContext(DbContextOptions<ELMSApplicationContext>options):base(options){

        }
       
        public DbSet<Leave> Leave { get; set; }   

         public DbSet<Employee> Employee { get; set; }   
         protected override void OnModelCreating(ModelBuilder modelBuilder){
 
        base.OnModelCreating(modelBuilder);
           //primary key for the entities
            modelBuilder.Entity<Employee>()
            .HasKey(u => u.EmployeeId);
            modelBuilder.Entity<Leave>()
            .HasKey(u => u.EmployeeId);
    }

    }
}