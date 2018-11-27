using libragri.core.repository;
using libragri.party.model;
using libragri.party.repository.interfaces;
using System;

namespace libragri.party.repository.inmemory
{
    public class CountryRepository : Repository<string, Country>, ICountryRepository
    {
        public CountryRepository(IStore<string> store) : base(store)
        {
        }
    }
}
