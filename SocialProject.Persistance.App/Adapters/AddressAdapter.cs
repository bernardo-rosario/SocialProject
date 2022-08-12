using SocialProject.Domain;
using SocialProject.Domain.Contracts.Adapters;
using SocialProject.Persistence.App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Persistence.App.Adapters
{
    public class AddressAdapter : IAddressAdapter
    {
        private readonly IAddressRepository _addressRepository;

        public AddressAdapter(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public IEnumerable<Address> GetAddresses()
        {
            var list = new List<Address>();
            foreach (var address in _addressRepository.GetAll())
            {
                list.Add(MapEntitiesToDomain(address));
            }
            return list;
        }

        private static Address MapEntitiesToDomain(Entities.Address address)
        {
            return new Address
            {
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                City = address.City,
                Cp3 = address.Cp3,
                Cp4 = address.Cp4,
                Id = address.Id,
                RegionId = address.RegionId,
            };
        }
    }
}
