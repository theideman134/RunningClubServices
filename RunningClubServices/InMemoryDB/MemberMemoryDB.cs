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


        public static void Save(List<MembersModel> membersModels)
        {
            if (membersModels != null)
            {
                foreach (var memberModel in membersModels)
                {
                    Save(memberModel);
                }
            }
        }

        public static void Save(MembersModel membersModel)
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

            _id++;
            membersModel.Id = _id;
            _memberList.Add(membersModel);


        }

        public static void Delete()
        {
            _memberList = null;
        }

        public static void Delete(int id)
        {
          var memberList =  _memberList.Where(c => c.Id == id).FirstOrDefault();
           _memberList.Remove(memberList);
        }
    }
}
