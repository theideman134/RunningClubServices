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
    public class MembersController : ControllerBase
    {
        private IMembersDao _memberDao;

         public MembersController(IMembersDao dao)
        {
            _memberDao = dao;
        }


        [HttpGet]
        public List<MembersModel> Get()
        {
            List<MembersModel> memberList = new List<MembersModel>();

            try
            {
                memberList = _memberDao.Get();
            }
            catch (Exception ex)
            {

            }

            return memberList;
        }


        [HttpPost]
        public List<MembersModel> Post(List<MembersModel> membersModels)
        {
            try
            {
                _memberDao.Save(membersModels);
            }
            catch (Exception ex)
            {

            }

            return membersModels;
        }
    }
}