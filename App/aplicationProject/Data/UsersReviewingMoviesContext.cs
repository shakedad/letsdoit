using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aplicationProject.Models
{
    public class UsersReviewingMoviesContext : DbContext
    {
        public UsersReviewingMoviesContext(DbContextOptions<UsersReviewingMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<aplicationProject.Models.Movie> Movie { get; set; }
        public DbSet<aplicationProject.Models.Review> Reviews { get; set; }
        public DbSet<aplicationProject.Models.User> Users { get; set; }
        public DbSet<aplicationProject.Models.Reviewing> Reviewings { get; set; }
    }
}
