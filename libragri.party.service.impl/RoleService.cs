using libragri.party.model;
using libragri.party.service.interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.impl
{
    public class RoleService : IRoleService
    {
        public Task<IList<Role>> AddAsync(Role party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Role>> DeleteAsync(Role party)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Role>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Role>> UpdateAsync(Role party)
        {
            throw new NotImplementedException();
        }
    }
}
