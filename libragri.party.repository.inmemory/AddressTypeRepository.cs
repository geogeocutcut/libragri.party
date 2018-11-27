using libragri.core.repository;
using libragri.party.model;
using libragri.party.repository.interfaces;
using System;

namespace libragri.party.repository.inmemory
{
    public class AddressTypeRepository : Repository<string, AddressType>, IAddressTypeRepository
    {
        public AddressTypeRepository(IStore<string> store) : base(store)
        {
        }
    }
}
