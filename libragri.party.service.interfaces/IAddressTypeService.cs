using libragri.party.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.interfaces
{
    public interface IAddressTypeService
    {
        Task<IList<AddressType>> GetAllAsync();
        Task<IList<AddressType>> GetByIdAsync(string id);

        Task<IList<AddressType>> AddAsync(AddressType party);
        Task<IList<AddressType>> UpdateAsync(AddressType party);
        Task<IList<AddressType>> DeleteAsync(AddressType party);

    }
}
