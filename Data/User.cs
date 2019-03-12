using System;
using Microsoft.AspNetCore.Identity;

namespace danielmoorhouse.Data
{
    public class User : IdentityUser
    {
        public DateTime MemberSince { get; set; }
    }
}