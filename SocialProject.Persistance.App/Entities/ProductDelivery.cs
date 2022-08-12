using System;
using System.Collections.Generic;

namespace SocialProject.Persistence.App.Entities
{
    public partial class ProductDelivery
    {
        public int Id { get; set; }
        public int? UnitTypeId { get; set; }
        public int? DeliveryId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? StateTypeId { get; set; }
        public int? ProductSubTypeId { get; set; }
        public int Quantity { get; set; }

        public virtual Delivery? Delivery { get; set; }
        public virtual ProductSubType? ProductSubType { get; set; }
        public virtual ProductType? ProductType { get; set; }
        public virtual StateType? StateType { get; set; }
        public virtual UnitType? UnitType { get; set; }
    }
}
