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
                memberList = _memberDao.Load();
                if (memberList == null)
                    memberList = new List<MembersModel>();
            }
            catch (Exception ex)
            {

            }

            return memberList;
        }

        [HttpGet("{id}")]
        public MembersModel Get(int id)
        {
            MembersModel model = null;

            try
            {
                model = _memberDao.Load(id);
                if (model == null)
                    model = new MembersModel();
            }
            catch (Exception ex)
            {

            }

            return model;
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