using DAL.Constants;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class EthnicConfigs : IEntityTypeConfiguration<Ethnic>
    {
        public void Configure(EntityTypeBuilder<Ethnic> builder)
        {
            builder.ToTable("Ethnic");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(Constant.NameMaxLength);
        }
    }
}
