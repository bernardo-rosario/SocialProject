using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class ProductSubType
    {
        public ProductSubType()
        {
            ProductDeliveries = new HashSet<ProductDelivery>();
            ProductDonations = new HashSet<ProductDonation>();
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public int? ProductTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ProductType? ProductType { get; set; }
        public virtual ICollection<ProductDelivery> ProductDeliveries { get; set; }
        public virtual ICollection<ProductDonation> ProductDonations { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
