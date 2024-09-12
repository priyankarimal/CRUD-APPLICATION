using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CodeFirstApproach.Models
{
    public class StudentDBContext : DbContext // it is used for the interaction with the database(to save or to retrieve the data form the database). 
    {
        public StudentDBContext(DbContextOptions options /*this stores the information about connection string,Database provider*/ ) :base(options)  
        {
            
        }

        public DbSet<Student> Students { get; set; }//Dbset represents the table in the database
    }
}
