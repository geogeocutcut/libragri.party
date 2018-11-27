using libragri.party.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.interfaces
{
    public interface IRoleService
    {
        Task<IList<Role>> GetAllAsync();
        Task<IList<Role>> GetByIdAsync(string id);

        Task<IList<Role>> AddAsync(Role party);
        Task<IList<Role>> UpdateAsync(Role party);
        Task<IList<Role>> DeleteAsync(Role party);

    }
}
