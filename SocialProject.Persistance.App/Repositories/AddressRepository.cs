using SocialProject.Persistence.App.Entities;
using SocialProject.Persistence.App.Generics;
using SocialProject.Persistence.App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Persistence.App.Repositories;

public class AddressRepository : RepositoryBase<Address, int>, IAddressRepository
{
    public AddressRepository(ProjectoSolidarioDBContext dBContext) : base(dBContext)
    {

    }
}
