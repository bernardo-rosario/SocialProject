using System;
using System.Collections.Generic;

namespace SocialProject.Persistance.App.Entities
{
    public partial class Request
    {
        public int Id { get; set; }
        public int? OrganizationAddressId { get; set; }
        public int? RequestTypeId { get; set; }
        public int? ProductSubTypeId { get; set; }
        public int? ProductTypeId { get; set; }

        public virtual OrganizationAddress? OrganizationAddress { get; set; }
        public virtual ProductSubType? ProductSubType { get; set; }
        public virtual ProductType? ProductType { get; set; }
        public virtual RequestType? RequestType { get; set; }
    }
}
