using libragri.core.common;
using libragri.core.repository;
using libragri.core.repository.inmemorydb;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace libragri.party.repository.inmemory
{
    public class UnitOfWorkInMemory : AbstractUnitOfWorkInMemory<string>
    {
        public UnitOfWorkInMemory(IFactory factory) : base(factory)
        {
        }

        public async override Task<TRepository> GetRepository<TRepository>()
        {
            return _factory.Resolve<TRepository>(_store);
        }
    }
}
