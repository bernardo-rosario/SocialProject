using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class Role
    {
        public Role()
        {
            UserRoleOrganizationAddresses = new HashSet<UserRoleOrganizationAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<UserRoleOrganizationAddress> UserRoleOrganizationAddresses { get; set; }
    }
}
