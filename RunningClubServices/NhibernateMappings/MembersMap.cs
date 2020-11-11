using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.NhibernateMappings
{
    public class MembersMap : ClassMapping<MembersModel>
    {
        public MembersMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Guid);
                x.Type(NHibernateUtil.Guid);
                x.Column("Id");
                x.UnsavedValue(Guid.Empty);
            });

            Property(b => b.FirstName, x =>
            {
                x.Column("first_name");
                x.Length(100);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Property(b => b.LastName, x =>
            {
                x.Column("last_name");
                x.Length(200);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Table("Members");
        }
    }
}
