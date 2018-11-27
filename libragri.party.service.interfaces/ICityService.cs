using libragri.party.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.interfaces
{
    public interface ICityService
    {
        Task<IList<City>> GetAllAsync();
        Task<IList<City>> GetByIdAsync(string id);

        Task<IList<City>> AddAsync(City party);
        Task<IList<City>> UpdateAsync(City party);
        Task<IList<City>> DeleteAsync(City party);

    }
}
