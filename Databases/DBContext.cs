using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Databases
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("myConnectionString")
            {
                
            }

        public DbSet<User> users { get; set; }
        public DbSet<User_sJob> jobs { get; set; }
    }

}
