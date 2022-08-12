using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class User
    {
        public User()
        {
            UserRoleOrganizationAddresses = new HashSet<UserRoleOrganizationAddress>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<UserRoleOrganizationAddress> UserRoleOrganizationAddresses { get; set; }
    }
}
