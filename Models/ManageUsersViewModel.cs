using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreBank.Models
{
    public class ManageUsersViewModel{
        public IdentityUser[] Administrators { get; set; }
        public IdentityUser[] Everyone { get; set;}
    }
}