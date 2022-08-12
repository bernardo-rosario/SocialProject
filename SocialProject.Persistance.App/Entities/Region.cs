using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class Region
    {
        public Region()
        {
            Addresses = new HashSet<Address>();
            RegionVolunteers = new HashSet<RegionVolunteer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<RegionVolunteer> RegionVolunteers { get; set; }
    }
}
