using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class Organization
    {
        public Organization()
        {
            OrganizationAddresses = new HashSet<OrganizationAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<OrganizationAddress> OrganizationAddresses { get; set; }
    }
}
