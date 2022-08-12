using SocialProject.Persistance.App.Entities;
using SocialProject.Persistance.App.Generics;
using SocialProject.Persistance.App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Persistance.App.Repositories;

public class AddressRepository : RepositoryBase<Address,int>, IAddressRepository
{
    public AddressRepository(ProjectoSolidarioDBContext dBContext): base(dBContext)
    {

    }
}
