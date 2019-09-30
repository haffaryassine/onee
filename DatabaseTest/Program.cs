using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using System.IO;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultContext");
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(connectionString);

            using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
            {
                var query = from droid in context.Droid
                            select droid;

                foreach(var item in query.ToList())
                {

                    Console.WriteLine(item.Matricule);
                }
                        }
            Console.WriteLine("Hello World!");

        }
    }
}
