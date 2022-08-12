using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class StateType
    {
        public StateType()
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
