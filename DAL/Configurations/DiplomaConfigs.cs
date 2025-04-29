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
    public class DiplomaConfigs : IEntityTypeConfiguration<Diploma>
    {
        public void Configure(EntityTypeBuilder<Diploma> builder)
        {
            builder.ToTable("Diploma");
            builder.HasKey(e => e.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(Constant.NameMaxLength);
            builder.Property(c => c.IssueDate).IsRequired();
            builder.Property(c => c.ExpiryDate).IsRequired();

            builder.HasOne<Employee>(p => p.Employee).WithMany(c => c.Diplomas).HasForeignKey(c => c.EmployeeId);
            builder.HasOne<City>(p => p.City).WithMany(c => c.Diplomas).HasForeignKey(c => c.CityId);
        }
    }
}
