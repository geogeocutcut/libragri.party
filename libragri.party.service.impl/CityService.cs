using libragri.party.model;
using libragri.party.service.interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.impl
{
    public class CityService : ICityService
    {
        public Task<IList<City>> AddAsync(City party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<City>> DeleteAsync(City party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<City>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<City>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<City>> UpdateAsync(City party)
        {
            throw new NotImplementedException();
        }
    }
}
