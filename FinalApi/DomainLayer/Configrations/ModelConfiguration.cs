using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configrations
{
    public class ModelConfiguration: IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(200);
            builder.Property(m => m.Brand).IsRequired().HasMaxLength(200);
        }

       
    }
}
