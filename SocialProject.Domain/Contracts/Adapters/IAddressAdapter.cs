using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Domain.Contracts.Adapters
{
    public interface IAddressAdapter
    {
        IEnumerable<Address> GetAddresses();
    }
}
