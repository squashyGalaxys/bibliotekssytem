using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace bibliotekssytemLinnea_Schilstrom
{
/* basen för att arbeta med User-entiteter i databas via Entity Framework
   Till för att bland annat anropa basklassen BdContext och för att skapa en databasuppsättning {get;set} av typen user
*/
    
        public class UserContext : DbContext
        {
            public DbSet<User> Users { get; set; }

            public UserContext() : base("name=UserDatabaseConnectionString")
            {

            }
        }
}
