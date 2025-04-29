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
    public class OccupationService : IOccupationService
    {
        IOccupationRepo _occupationRepo; 

        public OccupationService()
        {
            _occupationRepo = new OccupationRepo(); 
        }
        public bool Add(Occupation request)
        {
            return _occupationRepo.Add(request);
        }

        public bool Delete(Guid idOccupation)
        {
            return _occupationRepo.Delete(idOccupation);
        }

        public Occupation GetById(Guid idOccupation)
        {
            var obj = _occupationRepo.GetById(idOccupation);

            return obj;
        }

        public List<Occupation> GetList()
        {
            var listObj = _occupationRepo.GetList();

            return listObj;
        }

        public bool Update(Occupation request)
        {
            return _occupationRepo.Update(request);
        }
    }
}
