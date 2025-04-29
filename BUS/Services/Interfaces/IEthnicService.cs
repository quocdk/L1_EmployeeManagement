using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Interfaces
{
    public interface IEthnicService
    {
        Ethnic GetById(Guid idEthnic);
        List<Ethnic> GetList();
        bool Add(Ethnic request);
        bool Update(Ethnic request);
        bool Delete(Guid idEthnic);
    }
}
