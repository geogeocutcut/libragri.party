using libragri.core.common;
using libragri.core.repository;
using libragri.party.model;
using libragri.party.repository.interfaces;
using libragri.party.service.interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace libragri.party.service.impl
{
    public class AddressTypeService : IAddressTypeService
    {
        IFactory factory;

        public AddressTypeService(IFactory factory)
        {
            this.factory = factory;
        }

        public async Task<AddressType> AddAsync(AddressType addressType)
        {
            var uow = factory.Resolve<IUnitOfWork<string>>();
            using (var transaction = await uow.BeginAsync())
            {
                var repository = factory.Resolve<IAddressTypeRepository>(uow);

                var addressTypeTmp = await repository.UpsertAsync(addressType);
                await uow.CommitAsync();

                return addressTypeTmp;
            }
                
        }

        public async Task DeleteAsync(AddressType addressType)
        {
            var uow = factory.Resolve<IUnitOfWork<string>>();
            using (var transaction = await uow.BeginAsync())
            {
                var repository = factory.Resolve<IAddressTypeRepository>(uow);

                await repository.DeleteAsync(addressType);
                await uow.CommitAsync();
            }
        }

        public async Task<IList<AddressType>> GetAllAsync()
        {
            var uow = factory.Resolve<IUnitOfWork<string>>();
            var repository = factory.Resolve<IAddressTypeRepository>(uow);

            return await repository.GetAllAsync();
        }

        public async Task<AddressType> GetByIdAsync(string id)
        {
            var uow = factory.Resolve<IUnitOfWork<string>>();
            var repository = factory.Resolve<IAddressTypeRepository>(uow);

            return await repository.GetByIdAsync(id);
        }

        public async Task<AddressType> UpdateAsync(AddressType addressType)
        {
            var uow = factory.Resolve<IUnitOfWork<string>>();
            using (var transaction = await uow.BeginAsync())
            {
                var repository = factory.Resolve<IAddressTypeRepository>(uow);

                var addressTypeTmp = await repository.UpsertAsync(addressType);
                await uow.CommitAsync();

                return addressTypeTmp;
            }
        }
    }
}
