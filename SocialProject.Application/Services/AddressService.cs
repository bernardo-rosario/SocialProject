using SocialProject.Domain;
using SocialProject.Domain.Contracts;
using SocialProject.Domain.Contracts.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressAdapter _addressAdapter;

        public AddressService(IAddressAdapter addressAdapter)
        {
            _addressAdapter = addressAdapter;
        }

        public IEnumerable<Address> GetAddresses()
        {
            return _addressAdapter.GetAddresses();
        }
    }
}
