using SocialProject.Persistence.App.Generics;
using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class Address : IEntity<int>
    {
        public Address()
        {
            Beneficiaries = new HashSet<Beneficiary>();
            OrganizationAddresses = new HashSet<OrganizationAddress>();
        }

        public int Id { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Cp4 { get; set; } = null!;
        public string Cp3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public int? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; }
        public virtual ICollection<OrganizationAddress> OrganizationAddresses { get; set; }
    }
}
