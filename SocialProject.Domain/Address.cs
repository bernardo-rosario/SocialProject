using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Cp4 { get; set; } = null!;
        public string Cp3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public int? RegionId { get; set; }
    }
}
