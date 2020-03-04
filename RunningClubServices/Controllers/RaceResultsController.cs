using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunningClubServices.Dao;
using RunningClubServices.Models;

namespace RunningClubServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceResultsController : ControllerBase
    {
        private IRaceResultsDao _RaceResultsDao;

        [HttpGet]
        public List<RaceResultsModel> Get()
        {
            List<RaceResultsModel> raceResultsList = new List<RaceResultsModel>();

            _RaceResultsDao = new RaceResultsMemoryDao();

            try
            {
                raceResultsList = _RaceResultsDao.Get();
                
            }
            catch (Exception ex)
            {

            }

            return raceResultsList;
        }


        [HttpPost]
        public List<RaceResultsModel> Post(List<RaceResultsModel> membersModels)
        {
            try
            {
                _RaceResultsDao.Save(membersModels);
            }
            catch (Exception ex)
            {

            }

            return membersModels;
        }

    }
}