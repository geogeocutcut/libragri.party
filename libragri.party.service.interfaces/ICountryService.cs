using libragri.party.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.interfaces
{
    public interface ICountryService
    {
        Task<IList<Country>> GetAllAsync();
        Task<IList<Country>> GetByIdAsync(string id);

        Task<IList<Country>> AddAsync(Country party);
        Task<IList<Country>> UpdateAsync(Country party);
        Task<IList<Country>> DeleteAsync(Country party);

    }
}
