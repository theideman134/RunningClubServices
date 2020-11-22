using Microsoft.EntityFrameworkCore;
using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningClubServices.Dao
{
    public class MembersEFContext : DbContext
    {

        public MembersEFContext()
        {

        }


        public MembersEFContext(DbContextOptions<MembersEFContext> options) : base(options)
        {

        }

        public virtual DbSet<MembersModel> Members { get; set; }
    //   public DbSet<Tag> Tags { get; set; }
    }
}
