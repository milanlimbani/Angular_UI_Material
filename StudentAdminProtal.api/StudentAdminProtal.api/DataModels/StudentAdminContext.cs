using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminProtal.api.DataModels
{
    public class StudentAdminContext:DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options):base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
