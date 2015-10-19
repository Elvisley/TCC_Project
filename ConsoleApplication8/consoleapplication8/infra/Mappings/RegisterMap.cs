using ConsoleApplication8.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.infra.Mappings
{
    class RegisterMap : EntityTypeConfiguration<Register>
    {

        public RegisterMap()
        {
            ToTable("tab_register");

            HasKey(x => x.id);

            Property(x => x.ccontrato)
               .IsRequired();

            Property(x => x.valoratual)
               .HasPrecision(20,2)
               .IsRequired();

            Property(x => x.valortitulo)
               .HasPrecision(20, 2)
               .IsRequired();

            Property(x => x.contrato)
               .IsRequired();

            Property(x => x.nossonumero)
              .IsRequired();

            Property(x => x.numdocumento)
             .IsRequired();

            Property(x => x.endereco)
               .IsRequired();

            Property(x => x.cedente)
               .IsRequired();

            Property(x => x.cendereco)
               .IsRequired();

            Property(x => x.codigobarras)
               .IsRequired();

            Property(x => x.linhadigitavel)
               .IsRequired();

            Property(x => x.nomecedente)
              .HasMaxLength(256)
              .IsRequired();

            Property(x => x.nomecredor)
              .HasMaxLength(256)
              .IsRequired();

            Property(x => x.nomesacado)
               .HasMaxLength(256)
               .IsRequired();

            Property(x => x.mensagem1)
               .HasColumnType("TEXT");

            Property(x => x.mensagem2)
                .HasColumnType("TEXT");

            Property(x => x.mensagem3)
                .HasColumnType("TEXT");

            Property(x => x.mensagem4)
                .HasColumnType("TEXT");

            Property(x => x.mensagem5)
                .HasColumnType("TEXT");

            Property(x => x.mensagem6)
                .HasColumnType("TEXT");
        }
    }
}
