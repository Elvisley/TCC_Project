using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ConsoleApplication8.Domain;
using ConsoleApplication8.Mappings;

namespace ConsoleApplication8
{
    public class MyDataContext : DbContext
    {
        public MyDataContext()
            : base("name=DadosModel")
        {
            Database.SetInitializer<MyDataContext>(new MyDataContextInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        public DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

    }

    public class MyDataContextInitializer : DropCreateDatabaseIfModelChanges<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        { 
           
            base.Seed(context);
        }

    }
}
