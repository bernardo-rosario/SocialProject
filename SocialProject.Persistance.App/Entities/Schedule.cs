using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public TimeSpan Open { get; set; }
        public TimeSpan Close { get; set; }
        public int? WeekDayId { get; set; }
        public int? OrganizationAddressId { get; set; }

        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual Weekday? WeekDay { get; set; }
    }
}
