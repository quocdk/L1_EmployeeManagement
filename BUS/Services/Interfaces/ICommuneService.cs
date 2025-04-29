using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Interfaces
{
    public interface ICommuneService
    {
        Commune GetById(Guid idCommune);
        List<Commune> GetList();
        bool Add(Commune request);
        bool Update(Commune request);
        bool Delete(Guid idCommune);
    }
}
