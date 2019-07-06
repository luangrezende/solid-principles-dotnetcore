using System.Collections.Generic;

namespace SOLID.Models.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual List<Account> Accounts { get; set; }
    }
}
