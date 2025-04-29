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
    public class EthnicService : IEthnicService
    {
        IEthnicRepo _ethnicRepo; 

        public EthnicService()
        {
            _ethnicRepo = new EthnicRepo(); 
        }
        public bool Add(Ethnic request)
        {
            return _ethnicRepo.Add(request);
        }

        public bool Delete(Guid idEthnic)
        {
            return _ethnicRepo.Delete(idEthnic);
        }

        public Ethnic GetById(Guid idEthnic)
        {
            var obj = _ethnicRepo.GetById(idEthnic);

            return obj;
        }

        public List<Ethnic> GetList()
        {
            var listObj = _ethnicRepo.GetList();

            return listObj;
        }

        public bool Update(Ethnic request)
        {
            return _ethnicRepo.Update(request);
        }
    }
}
