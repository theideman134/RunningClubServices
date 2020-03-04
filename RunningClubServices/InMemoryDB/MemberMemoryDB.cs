using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.MemoryDB
{
    public static class MemberMemoryDB
    {
        private static List<MembersModel> _memberList;
        private static int _id;

        public static int NextId()
        {
            return _id++;
        }

        public static List<MembersModel> Get()
        {
            return _memberList;
        }

        public static MembersModel Get(int id)
        {
            return _memberList.Where(c => c.Id == id).FirstOrDefault();
        }

        public static List<MembersModel> Get(string firstName, string lastName)
        {
            return _memberList.Where(c => c.FirstName == firstName && c.LastName == lastName).ToList();
        }


        public static void Add(List<MembersModel> membersModels)
        {
            foreach(var memberModel in membersModels)
            {
                Add(memberModel);
            }
        }

        public static void Add(MembersModel membersModel)
        {
            if(_memberList == null)
                _memberList = new List<MembersModel>();

            if (membersModel == null)
                return;

            if(_memberList == null)
            {
                _memberList.Add(membersModel);
                return;
            }

            if (_memberList.Count == 0)
            {
                _id++;
                membersModel.Id = _id;
                _memberList.Add(membersModel);
                return;
            }

            
            if(membersModel.Id != 0 && _memberList.Where(c => c.Id == membersModel.Id).Any())
            {
                return;
            }

            if(_memberList.Where(c => c.FirstName == membersModel.FirstName && c.LastName == membersModel.LastName).Any())
            {
                return; 
            }

            _memberList.Add(membersModel);


        }

        public static void Clear()
        {
            _memberList = null;
        }

    }
}
