using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Dao
{
    public class MembersEFDao : IMembersDao
    {
        private MembersEFContext _membersEFContext;

        public MembersEFDao(MembersEFContext membersEFContext)
        {
            _membersEFContext = membersEFContext;
        }

        public void Delete(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }

        public List<MembersModel> Load()
        {
            /*
             * public List<Company> GetCompanies()
{
    using (var context = new MyContext())
    {
        return context.Companies.ToList();
    }
}*/

           return  _membersEFContext.Members.ToList<MembersModel>();
//            var as = _membersEFContext.MembersSet;
        }

        public MembersModel Load(int id)
        {
            return _membersEFContext.Members.Where(c => c.Id == id).FirstOrDefault<MembersModel>();

    //        throw new NotImplementedException();
        }

        public void Save(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }

        public void Save(List<MembersModel> membersModels)
        {
            var memberContext = new MembersEFContext();
       //     memberContext.a
       //     memberContext.SaveChanges(membersModels);
        }

        public void Update(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }
    }
}
