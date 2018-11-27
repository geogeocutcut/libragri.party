using libragri.core.repository;
using libragri.party.model;
using libragri.party.repository.interfaces;
using System;

namespace libragri.party.repository.inmemory
{
    public class PartyRepository : Repository<string, Party>, IPartyRepository
    {
        public PartyRepository(IStore<string> store) : base(store)
        {
        }
    }
}
