using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Model.Entities
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PictureUrl { get; set; }
    }
}
