using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class ProductDonation
    {
        public int Id { get; set; }
        public int? StateTypeId { get; set; }
        public int? UnitTypeId { get; set; }
        public int? DonationId { get; set; }
        public int? Quantity { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ProductSubTypeId { get; set; }

        public virtual Donation? Donation { get; set; }
        public virtual ProductSubType? ProductSubType { get; set; }
        public virtual ProductType? ProductType { get; set; }
        public virtual StateType? StateType { get; set; }
        public virtual UnitType? UnitType { get; set; }
    }
}
