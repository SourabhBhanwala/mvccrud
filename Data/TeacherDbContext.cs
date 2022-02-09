using Crud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Data
{
    public class TeacherDbContext:DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options)
        { }

        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Students> Student { get; set; }




    }
}
