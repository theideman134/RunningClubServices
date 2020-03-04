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

        /*
         public MembersController(IMembersDao dao)
        {
            _memberDao = dao;
        }

    */
        [HttpGet]
        public List<MembersModel> Get()
        {
            List<MembersModel> memberList = new List<MembersModel>();

            _memberDao = new MembersMemoryDao();

            try
            {
                memberList = _memberDao.Get();
                if (memberList == null)
                    memberList = new List<MembersModel>();
            }
            catch (Exception ex)
            {

            }

            return memberList;
        }

        /*
        [HttpPost]
        public MembersModel Post(MembersModel membersModel)
        {

            _memberDao = new MembersMemoryDao();

            try
            {
                _memberDao.Save(membersModel);
            }
            catch (Exception ex)
            {

            }

            return membersModel;
        }
        */

        [HttpPost]
        public List<MembersModel> Post(List<MembersModel> membersModels)
        {

                _memberDao = new MembersMemoryDao();
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