using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Dao
{
    interface IRaceResultsDao
    {
        public List<RaceResultsModel> Get();
        public RaceResultsModel Get(int i);
        public void Save(RaceResultsModel raceResultsModel);
        public void Delete(RaceResultsModel raceResultsModel);
        public void Update(RaceResultsModel raceResultsModel);
        public void Save(List<RaceResultsModel> raceResultsModels);
    }
}
