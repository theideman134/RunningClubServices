using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Dao
{
    public interface IMembersDao
    {
        public List<MembersModel> Get();
        public MembersModel Get(int i);
        public void Save(MembersModel membersModel);
        public void Delete(MembersModel membersModel);
        public void Update(MembersModel membersModel);
        public void Save(List<MembersModel> membersModels);
        
    }
}
