using DAL.Configurations;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LAOT6MD\\SQLEXPRESS;Database=Oceantech_L1_EmployeeManagement;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new CityConfigs());
            modelBuilder.ApplyConfiguration(new CommuneConfigs());
            modelBuilder.ApplyConfiguration(new DiplomaConfigs());
            modelBuilder.ApplyConfiguration(new DistrictConfigs());
            modelBuilder.ApplyConfiguration(new EmployeeConfigs());
            modelBuilder.ApplyConfiguration(new EthnicConfigs());
            modelBuilder.ApplyConfiguration(new OccupationConfigs());
            

            SeedingData(modelBuilder);
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Commune> Communes { get; set; }
        public virtual DbSet<Diploma> Diplomas { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Ethnic> Ethnics { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }

        void SeedingData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                    Name = "Hà Nội"
                },
                new City()
                {
                    Id = Guid.Parse("d9ccef94-ba5e-4746-9150-c7ffa4492d6d"),
                    Name = "Thái Bình"
                }
                );

            modelBuilder.Entity<District>().HasData(
                new District()
                {
                    Id = Guid.Parse("8df1f290-ed39-43d9-9f86-76eb7570bbe6"),
                    Name = "Đan Phượng",
                    CityId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                },
                new District()
                {
                    Id = Guid.Parse("48868dd6-6ef9-4d85-ab33-3e68369f3542"),
                    Name = "Hoài Đức",
                    CityId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                }
                );

            modelBuilder.Entity<Commune>().HasData(
                new Commune()
                {
                    Id = Guid.Parse("c7b4e2be-4902-498f-954b-e35ebb7be2aa"),
                    Name = "Tân Lập",
                    DistrictId = Guid.Parse("8df1f290-ed39-43d9-9f86-76eb7570bbe6"),
                },
                new Commune()
                {
                    Id = Guid.Parse("0d118c45-451d-4be9-aea5-21e727a4e68c"),
                    Name = "Tân Hội",
                    DistrictId = Guid.Parse("8df1f290-ed39-43d9-9f86-76eb7570bbe6"),
                }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = Guid.Parse("db3fc518-b1f8-4694-ab71-b5657c6a663a"),
                    FullName = "Đinh Kiến Quốc 1",
                    DateOfBirth = DateTime.Parse("11/11/2003"),
                    Age = 22,
                    EthnicId = Guid.Parse("41b20ba1-2ce1-405f-b828-30e2a975db67"),
                    OccupationId = Guid.Parse("9c6764d2-508c-4ea8-a916-bd8c39900a6c"),
                    CitizenIdentityCard = "012345678911",
                    PhoneNumber = "0123456781",
                    CityId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                    DistrictId = Guid.Parse("8df1f290-ed39-43d9-9f86-76eb7570bbe6"),
                    CommuneId = Guid.Parse("c7b4e2be-4902-498f-954b-e35ebb7be2aa"),
                    SpecificAddress = "Cụm 1",
                    DiplomaNumber = 1,
                },
                new Employee()
                {
                    Id = Guid.Parse("1e35b504-4a19-429a-9fe9-a14151e6ebd5"),
                    FullName = "Đinh Kiến Quốc 2",
                    DateOfBirth = DateTime.Parse("11/11/2003"),
                    Age = 22,
                    EthnicId = Guid.Parse("192f5268-6de2-4093-a720-4f4409dbc707"),
                    OccupationId = Guid.Parse("4f8d1e94-7904-4598-8343-f2984ee1af87"),
                    CitizenIdentityCard = "012345678912",
                    PhoneNumber = "0123456782",
                    CityId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                    DistrictId = Guid.Parse("8df1f290-ed39-43d9-9f86-76eb7570bbe6"),
                    CommuneId = Guid.Parse("0d118c45-451d-4be9-aea5-21e727a4e68c"),
                    SpecificAddress = "cụm 2",
                    DiplomaNumber = 1,
                }
                );

            modelBuilder.Entity<Occupation>().HasData(
                new Occupation()
                {
                    Id = Guid.Parse("9c6764d2-508c-4ea8-a916-bd8c39900a6c"),
                    Name = "Lập trình viên",
                },
                new Occupation()
                {
                    Id = Guid.Parse("4f8d1e94-7904-4598-8343-f2984ee1af87"),
                    Name = "Nhân viên bán hàng",
                }
                );
            modelBuilder.Entity<Ethnic>().HasData(
                new Ethnic()
                {
                    Id = Guid.Parse("41b20ba1-2ce1-405f-b828-30e2a975db67"),
                    Name = "Kinh",
                },
                new Ethnic()
                {
                    Id = Guid.Parse("192f5268-6de2-4093-a720-4f4409dbc707"),
                    Name = "Mường",
                }
                );
            modelBuilder.Entity<Diploma>().HasData(
                new Diploma()
                {
                    Id = Guid.Parse("60c03512-f941-4bd0-ae94-62f2315b05b9"),
                    Name = "Văn bằng 1",
                    IssueDate = DateTime.Parse("11/11/2021"),
                    ExpiryDate = DateTime.Parse("11/11/2022"),
                    CityId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                    EmployeeId = Guid.Parse("db3fc518-b1f8-4694-ab71-b5657c6a663a"),
                },
                new Diploma()
                {
                    Id = Guid.Parse("84caaff9-1259-42fd-9e48-4507dc9b5cb4"),
                    Name = "Văn bằng 2",
                    IssueDate = DateTime.Parse("11/11/2023"),
                    ExpiryDate = DateTime.Parse("11/11/2024"),
                    CityId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                    EmployeeId = Guid.Parse("1e35b504-4a19-429a-9fe9-a14151e6ebd5"),
                }
                );
        }
    }
}
