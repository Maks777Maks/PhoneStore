namespace DAL
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {      
        public Context()
            : base("name=Context")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }

    
}