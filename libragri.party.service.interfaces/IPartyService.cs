using libragri.party.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.interfaces
{
    public interface IPartyService
    {
        Task<IList<Party>> GetAllAsync();
        Task<IList<Party>> GetByIdAsync(string id);

        Task<IList<Party>> AddAsync(Party party);
        Task<IList<Party>> UpdateAsync(Party party);
        Task<IList<Party>> DeleteAsync(Party party);


        Task<Party> AddAddressAsync(string partyId,Address address);
        Task<Party> UpdateAddressAsync(string addressId);
        Task<Party> DeleteAddressAsync(Address address);
    }
}
