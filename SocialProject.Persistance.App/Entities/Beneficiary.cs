using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class Beneficiary
    {
        public Beneficiary()
        {
            Deliveries = new HashSet<Delivery>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? OrganizationAddressId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address? Address { get; set; }
        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
