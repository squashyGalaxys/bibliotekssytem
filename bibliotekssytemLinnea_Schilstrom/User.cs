using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace bibliotekssytemLinnea_Schilstrom
{

        //User class i namespace InloggSystem
        // Public class User kan nås från andra delar av programmet och innehåller egenskaperna för Username och password. 
        // get;set innebär att user object både går att läsa och skrivas till. 
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public bool IsAdmin { get; set; }

        }
}

