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
            if (membersModel != null)
            {
                MemberMemoryDB.Delete(membersModel.Id);
            }
        }

        public List<MembersModel> Load()
        {
            return MemberMemoryDB.Get();
        }

        public MembersModel Load(int id)
        {
            return MemberMemoryDB.Get(id);
        }

        public void Save(MembersModel membersModel)
        {
            MemberMemoryDB.Save(membersModel);
        }

        public void Save(List<MembersModel> membersModels)
        {
            MemberMemoryDB.Save(membersModels);
        }

        public void Update(MembersModel membersModel)
        {
            MemberMemoryDB.Save(membersModel);
        }
    

    
    
    }
}
