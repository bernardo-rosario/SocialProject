using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class Delivery
    {
        public Delivery()
        {
            ProductDeliveries = new HashSet<ProductDelivery>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? OrganizationAddressId { get; set; }
        public int? BeneficiaryId { get; set; }
        public int? OrganizationAddressDestinyId { get; set; }

        public virtual Beneficiary? Beneficiary { get; set; }
        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual OrganizationAddress? OrganizationAddressDestiny { get; set; }
        public virtual ICollection<ProductDelivery> ProductDeliveries { get; set; }
    }
}
