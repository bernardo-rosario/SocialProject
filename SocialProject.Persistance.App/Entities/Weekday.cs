using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class Weekday
    {
        public Weekday()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
