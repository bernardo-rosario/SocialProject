using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class UnitType
    {
        public UnitType()
        {
            ProductDeliveries = new HashSet<ProductDelivery>();
            ProductDonations = new HashSet<ProductDonation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductDelivery> ProductDeliveries { get; set; }
        public virtual ICollection<ProductDonation> ProductDonations { get; set; }
    }
}
