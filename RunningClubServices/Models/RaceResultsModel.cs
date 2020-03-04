using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Models
{
    public class RaceResultsModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameLastName { get; set; }
        public string LastNameFirstName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Division { get; set; }
        public int DivisionPlace { get; set; }
        public int GenderPlace { get; set; }
        public int OverallPlace { get; set; }
        public int DivisionTotal { get; set; }
        public int GenderTotal { get; set; }
        public int OverallTotal { get; set; }
        public string FinishTime { get; set; }
        public decimal FinishTimeSeconds { get; set; }
   
    }
}
