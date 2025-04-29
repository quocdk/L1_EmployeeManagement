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
    public class DiplomaService : IDiplomaService
    {
        IDiplomaRepo _diplomaRepo; 

        public DiplomaService()
        {
            _diplomaRepo = new DiplomaRepo(); 
        }
        public bool Add(Diploma request)
        {
            return _diplomaRepo.Add(request);
        }

        public bool Delete(Guid idDiploma)
        {
            return _diplomaRepo.Delete(idDiploma);
        }

        public Diploma GetById(Guid idDiploma)
        {
            var obj = _diplomaRepo.GetById(idDiploma);

            return obj;
        }

        public List<Diploma> GetList()
        {
            var listObj = _diplomaRepo.GetList();

            return listObj;
        }

        public bool Update(Diploma request)
        {
            return _diplomaRepo.Update(request);
        }
    }
}
