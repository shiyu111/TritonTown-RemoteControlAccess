using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace triton.Models
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }

    public class UserRegistration
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        /*
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string University { get; set; }

        public string Group { get; set; }

        public string Preffered_Language { get; set; }

        public string Experience { get; set; }

        public string Focus { get; set; }

        public string Goals { get; set; }
        */
    }

    public class User
    {
        public string Id { get; set; }
        
        public bool Active { get; set; } = true;

        public bool Is_Admin { get; set; } = false; 

        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        internal string Hash { get; set; }
        internal ClaimsPrincipal _principal { get; private set; }


        internal void SetClaims()
        {
            var claims = new List<Claim>{
                new Claim(ClaimTypes.Email, Email),
                new Claim(ClaimTypes.Name, Id) //req.session.uid = id
            };
            var userIdentity = new ClaimsIdentity(claims, "login");
            _principal = new ClaimsPrincipal(userIdentity);
        }
    }
}