using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Model.Entities
{
    public class Agent: IEntityBase
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
        public int CompanyId { get; set; }
    }
}
