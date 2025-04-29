using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Interfaces
{
    public interface IDistrictService
    {
        District GetById(Guid idDistrict);
        List<District> GetList();
        bool Add(District request);
        bool Update(District request);
        bool Delete(Guid idDistrict);
    }
}
