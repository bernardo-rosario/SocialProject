using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class Donation
    {
        public Donation()
        {
            ProductDonations = new HashSet<ProductDonation>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? OrganizationAddressId { get; set; }

        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual ICollection<ProductDonation> ProductDonations { get; set; }
    }
}
