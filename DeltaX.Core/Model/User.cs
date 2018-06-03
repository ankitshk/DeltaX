using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaX.Core.Model
{
    public class User : IdentityUser
    {
        public string Address { get; set; }
        public string Fullname { get; set; }
    }
}
