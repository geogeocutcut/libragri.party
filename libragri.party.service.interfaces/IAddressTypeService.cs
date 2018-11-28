using libragri.party.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.interfaces
{
    public interface IAddressTypeService
    {
        Task<IList<AddressType>> GetAllAsync();
        Task<AddressType> GetByIdAsync(string id);

        Task<AddressType> AddAsync(AddressType party);
        Task<AddressType> UpdateAsync(AddressType party);
        Task DeleteAsync(AddressType party);

    }
}
