using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TableModels;

namespace Project4_Fall23
{
    /// <summary>
    /// A class to manage and handle the connection to the database
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //create the tables using the data models we made in the 2nd project    
        public virtual DbSet<PointOfContact> PointOfContact { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Market> Market { get; set; }


    }
}
