using ConsoleApplication8.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("tab_product");

            HasKey(x => x.Id); 

            Property(x => x.Title)
                  .HasMaxLength(60)
                  .IsRequired();

            Property(x => x.Price).IsRequired();
        }
    }
}
