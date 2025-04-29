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
    public class CommuneService : ICommuneService
    {
        ICommuneRepo _communeRepo; 

        public CommuneService()
        {
            _communeRepo = new CommuneRepo(); 
        }
        public bool Add(Commune request)
        {
            return _communeRepo.Add(request);
        }

        public bool Delete(Guid idCommune)
        {
            return _communeRepo.Delete(idCommune);
        }

        public Commune GetById(Guid idCommune)
        {
            var obj = _communeRepo.GetById(idCommune);

            return obj;
        }

        public List<Commune> GetList()
        {
            var listObj = _communeRepo.GetList();

            return listObj;
        }

        public bool Update(Commune request)
        {
            return _communeRepo.Update(request);
        }
    }
}
