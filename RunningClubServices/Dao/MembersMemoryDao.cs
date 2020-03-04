using RunningClubServices.MemoryDB;
using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Dao
{
    public class MembersMemoryDao : IMembersDao
    {
        public void Delete(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }

        public List<MembersModel> Get()
        {
            return MemberMemoryDB.Get();
        }

        public MembersModel Get(int id)
        {
            return MemberMemoryDB.Get(id);
        }

        public void Save(MembersModel membersModel)
        {
            MemberMemoryDB.Add(membersModel);
        }

        public void Save(List<MembersModel> membersModels)
        {
            MemberMemoryDB.Add(membersModels);
        }

        public void Update(MembersModel membersModel)
        {
            MemberMemoryDB.Add(membersModel);
        }
    

    
    
    }
}
