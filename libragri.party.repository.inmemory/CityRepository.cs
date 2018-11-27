using libragri.core.repository;
using libragri.party.model;
using libragri.party.repository.interfaces;
using System;

namespace libragri.party.repository.inmemory
{
    public class CityRepository : Repository<string, City>, ICityRepository
    {
        public CityRepository(IStore<string> store) : base(store)
        {
        }
    }
}
