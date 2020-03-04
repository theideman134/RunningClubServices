using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Models
{
    public class RaceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Year { get; set; }
        public List<RaceResultsModel> RaceResults { get; set; }
    }
}
