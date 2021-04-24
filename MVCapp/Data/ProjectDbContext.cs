using Microsoft.EntityFrameworkCore;
using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCapp.Data
{
    public class ProjectDbContext :DbContext 
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
