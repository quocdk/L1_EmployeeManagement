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
    internal class DistrictConfigs : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("District");
            builder.HasKey(e => e.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(Constant.NameMaxLength);
            
            builder.HasOne<City>(p => p.City).WithMany(c => c.Districts).HasForeignKey(c => c.CityId);
            
        }
    }
}
