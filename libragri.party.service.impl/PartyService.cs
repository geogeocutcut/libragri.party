using libragri.party.model;
using libragri.party.service.interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.impl
{
    public class PartyService : IPartyService
    {
        public Task<Party> AddAddressAsync(string partyId, Address address)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Party>> AddAsync(Party party)
        {
            throw new NotImplementedException();
        }

        public Task<Party> DeleteAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Party>> DeleteAsync(Party party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Party>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Party>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Party> UpdateAddressAsync(string addressId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Party>> UpdateAsync(Party party)
        {
            throw new NotImplementedException();
        }
    }
}
