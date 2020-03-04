using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.InMemoryDB
{
    public static class RaceResultsMemoryDB
    {
        private static List<RaceResultsModel> _raceResultsList;
        private static int _id;

        public static int NextId()
        {
            return _id++;
        }

        public static List<RaceResultsModel> Get()
        {
            return _raceResultsList; 
        }

        public static RaceResultsModel Get(int id)
        {
            return _raceResultsList.Where(c => c.Id == id).FirstOrDefault();
        }

        public static List<RaceResultsModel> Get(string firstName, string lastName)
        {
            return _raceResultsList.Where(c => c.FirstName == firstName && c.LastName == lastName).ToList();
        }


        public static void Save(List<RaceResultsModel> resultsModels)
        {
            if (resultsModels != null)
            {
                foreach (var raceResults in resultsModels)
                {
                    Save(resultsModels);
                }
            }
        }

        public static void Save(RaceResultsModel raceResultModel)
        {
            if (_raceResultsList == null)
            {
                _raceResultsList = new List<RaceResultsModel>();
            }

            if (raceResultModel == null)
                return;

            if (_raceResultsList == null)
            {
                _raceResultsList.Add(raceResultModel);
                return;
            }

            if (_raceResultsList.Count == 0)
            {
                _id++;
                raceResultModel.Id = _id;
                _raceResultsList.Add(raceResultModel);
                return;
            }


            if (raceResultModel.Id != 0 && _raceResultsList.Where(c => c.Id == raceResultModel.Id).Any())
            {
                return;
            }

            if (_raceResultsList.Where(c => c.FirstName == raceResultModel.FirstName && c.LastName == raceResultModel.LastName).Any())
            {
                return;
            }

            _raceResultsList.Add(raceResultModel);


        }

        public static void Delete()
        {
            _raceResultsList = null;
        }

    }
}
