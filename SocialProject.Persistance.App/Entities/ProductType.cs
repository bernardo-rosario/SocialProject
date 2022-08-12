using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class ProductType
    {
        public ProductType()
        {
            ProductDeliveries = new HashSet<ProductDelivery>();
            ProductDonations = new HashSet<ProductDonation>();
            ProductSubTypes = new HashSet<ProductSubType>();
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductDelivery> ProductDeliveries { get; set; }
        public virtual ICollection<ProductDonation> ProductDonations { get; set; }
        public virtual ICollection<ProductSubType> ProductSubTypes { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
