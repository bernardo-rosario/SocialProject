using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class UserRoleOrganizationAddress
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int? OrganizationAddressId { get; set; }
        public bool IsMainContact { get; set; }

        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual Role? Role { get; set; }
        public virtual User? User { get; set; }
    }
}
