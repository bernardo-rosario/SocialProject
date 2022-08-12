using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class OrganizationAddress
    {
        public OrganizationAddress()
        {
            Beneficiaries = new HashSet<Beneficiary>();
            DeliveryOrganizationAddressDestinies = new HashSet<Delivery>();
            DeliveryOrganizationAddresses = new HashSet<Delivery>();
            Donations = new HashSet<Donation>();
            Requests = new HashSet<Request>();
            Schedules = new HashSet<Schedule>();
            UserRoleOrganizationAddresses = new HashSet<UserRoleOrganizationAddress>();
            VolunteerOrganizationAddresses = new HashSet<VolunteerOrganizationAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? AddressId { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber1 { get; set; } = null!;
        public string? PhoneNumber2 { get; set; }
        public bool IsMainOffice { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Address? Address { get; set; }
        public virtual Organization? Organization { get; set; }
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; }
        public virtual ICollection<Delivery> DeliveryOrganizationAddressDestinies { get; set; }
        public virtual ICollection<Delivery> DeliveryOrganizationAddresses { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<UserRoleOrganizationAddress> UserRoleOrganizationAddresses { get; set; }
        public virtual ICollection<VolunteerOrganizationAddress> VolunteerOrganizationAddresses { get; set; }
    }
}
