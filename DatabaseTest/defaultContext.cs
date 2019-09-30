
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseTest
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
           
        }

        protected DefaultContext()
        {
        }


        public DbSet<Droid> Droid { get; set; }
    }
}
