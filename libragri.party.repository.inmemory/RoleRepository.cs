using libragri.core.repository;
using libragri.party.model;
using libragri.party.repository.interfaces;
using System;

namespace libragri.party.repository.inmemory
{
    public class RoleRepository : Repository<string, Role>, IRoleRepository
    {
        public RoleRepository(IStore<string> store) : base(store)
        {
        }
    }
}
