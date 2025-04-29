using BUS.Services.Interfaces;
using DAL.Models;
using DAL.Repositories.Implements;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Implements
{
    public class DistrictService : IDistrictService
    {
        IDistrictRepo _districtRepo; 

        public DistrictService()
        {
            _districtRepo = new DistrictRepo(); 
        }
        public bool Add(District request)
        {
            return _districtRepo.Add(request);
        }

        public bool Delete(Guid idDistrict)
        {
            return _districtRepo.Delete(idDistrict);
        }

        public District GetById(Guid idDistrict)
        {
            var obj = _districtRepo.GetById(idDistrict);

            return obj;
        }

        public List<District> GetList()
        {
            var listObj = _districtRepo.GetList();

            return listObj;
        }

        public bool Update(District request)
        {
            return _districtRepo.Update(request);
        }
    }
}
