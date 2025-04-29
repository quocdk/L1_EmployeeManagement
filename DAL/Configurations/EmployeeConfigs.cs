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
    internal class EmployeeConfigs : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.FullName).IsRequired().HasMaxLength(Constant.NameMaxLength);
            builder.Property(c => c.DateOfBirth).IsRequired();
            builder.Property(c => c.Age).IsRequired().HasMaxLength(Constant.AgeMaxLength);
            builder.Property(c => c.CitizenIdentityCard).IsRequired().HasMaxLength(Constant.CitizenIdentityCardLength);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(Constant.PhoneNumberLength);
            builder.Property(c => c.SpecificAddress).HasMaxLength(Constant.SpecificAddressMaxLength);

            builder.HasOne<Ethnic>(p => p.Ethnic).WithMany(c => c.Employees).HasForeignKey(c => c.EthnicId);
            builder.HasOne<Occupation>(p => p.Occupation).WithMany(c => c.Employees).HasForeignKey(c => c.OccupationId);
            //builder.HasOne<City>(p => p.City).WithMany(c => c.Employees).HasForeignKey(c => c.CityId);
            //builder.HasOne<District>(p => p.District).WithMany(c => c.Employees).HasForeignKey(c => c.DistrictId);
            builder.HasOne<Commune>(p => p.Commune).WithMany(c => c.Employees).HasForeignKey(c => c.CommuneId);
        }
    }
}
