using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ProjektASP.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public IList<Rating> Ratings { get; set; }
    }
}
