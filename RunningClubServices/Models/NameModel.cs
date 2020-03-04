using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Models
{
    public class NameModel
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string FirstNameLastName { get; }
      public string LastNameFirstName { get;  }
    }
}
