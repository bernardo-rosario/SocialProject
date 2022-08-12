using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class RegionVolunteer
    {
        public int Id { get; set; }
        public int? VolunteerId { get; set; }
        public int? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual Volunteer? Volunteer { get; set; }
    }
}
