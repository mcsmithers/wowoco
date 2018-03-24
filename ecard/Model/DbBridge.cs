using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecard.Model
{
    public class DbBridge : DbContext
    {
        // WOWOCO: DEFAULT CONSTRUCTOR (JUST DO THIS!)
        public DbBridge() { }

        // WOWOCO: CONSTRUCTOR (JUST DO THIS!)
        public DbBridge(DbContextOptions<DbBridge> options) : base(options) { }

        // WOWOCO: TABLE IN THE DATABASE; EACH TABLE GETS ITS OWN LINE.
        // public DbSet<ENTER-TABLENAME-HERE> ENTER-TABLENAME-HERE { get; set; }
        public DbSet<Greetings> Greetings { get; set; }
        public DbSet<Questions> Questions { get; set; }
        //Every time you create a new table, you have to go under dbbridge and add to this here

    }
}