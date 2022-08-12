using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class Volunteer
    {
        public Volunteer()
        {
            RegionVolunteers = new HashSet<RegionVolunteer>();
            VolunteerOrganizationAddresses = new HashSet<VolunteerOrganizationAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<RegionVolunteer> RegionVolunteers { get; set; }
        public virtual ICollection<VolunteerOrganizationAddress> VolunteerOrganizationAddresses { get; set; }
    }
}
