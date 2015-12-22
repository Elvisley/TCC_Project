using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ConsoleApplication8.Domain;


namespace ConsoleApplication8
{
    public class MyDataContext : DbContext
    {
        public MyDataContext()
            : base("name=DadosModel")
        {
            Database.SetInitializer<MyDataContext>(new MyDataContextInitializer());
        }
        
        public DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

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
