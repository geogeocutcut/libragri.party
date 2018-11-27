using libragri.party.model;
using libragri.party.service.interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.impl
{
    public class CountryService : ICountryService
    {
        public Task<IList<Country>> AddAsync(Country party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Country>> DeleteAsync(Country party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Country>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Country>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Country>> UpdateAsync(Country party)
        {
            throw new NotImplementedException();
        }
    }
}
