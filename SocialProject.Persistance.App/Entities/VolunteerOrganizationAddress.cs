using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class VolunteerOrganizationAddress
    {
        public int Id { get; set; }
        public int? VolunteerId { get; set; }
        public int? OrganizationAddressId { get; set; }

        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual Volunteer? Volunteer { get; set; }
    }
}
