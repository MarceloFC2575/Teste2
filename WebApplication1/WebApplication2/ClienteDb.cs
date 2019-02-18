using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2
{
    public class ClienteDb : DbContext
    {
        public ClienteDb(DbContextOptions<ClienteDb> options)
            : base(options) { }
        public ClienteDb() { }
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server = sql10.freemysqlhosting.net; DataBase = sql10185723; Uid = sql10185723; Pwd = maVj1MHQaz;");

    }
}
