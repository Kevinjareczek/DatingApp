using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } //Name by convention for EF
        public string UserName { get; set; } //Name by convention for EF

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}