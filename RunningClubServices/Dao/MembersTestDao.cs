using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Dao
{
    public class MembersTestDao : IMembersDao
    {
        public void Delete(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }

        public List<MembersModel> Load()
        {
            var memberList = new List<MembersModel>();
            var memberModel1 = new MembersModel() { FirstName = "Bob", LastName = "Jensen" };
            var memberModel2 = new MembersModel() { FirstName = "Susie", LastName = "Smith" };

            memberList.Add(memberModel1);
            memberList.Add(memberModel2);
            
            return memberList;
        }

        public MembersModel Load(int i)
        {
            throw new NotImplementedException();
        }

        public void Save(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }

        public void Save(List<MembersModel> membersModels)
        {
            throw new NotImplementedException();
        }

        public void Update(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }
    }
}
