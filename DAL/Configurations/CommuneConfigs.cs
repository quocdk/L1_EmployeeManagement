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
    internal class CommuneConfigs : IEntityTypeConfiguration<Commune>
    {
        public void Configure(EntityTypeBuilder<Commune> builder)
        {
            builder.ToTable("Commune");
            builder.HasKey(e => e.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(Constant.NameMaxLength);

            builder.HasOne<District>(p => p.District).WithMany(c => c.Communes).HasForeignKey(c => c.DistrictId);
        }
    }
}
