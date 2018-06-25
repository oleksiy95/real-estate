using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Model.Entities
{
    public class Seller : IEntityBase
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
        public string Description { get; set; }
    }
}
