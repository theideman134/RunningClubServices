using NUnit.Framework;
using RunningClubServices.Dao;
using RunningClubServices.Models;
using System.Collections.Generic;

namespace RunningClubServicesTest
{
    public class MembersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MemberPostMemoryNullTest()
        {
            var memberDao = new MembersMemoryDao();
            MembersModel memberModel = null;
            memberDao.Save(memberModel);

            var membersGetList = memberDao.Get();

            Assert.AreEqual(0, membersGetList.Count);

        }


        [Test]
        public void MemberPostMemoryTest()
        {
           var member1 = new MembersModel() { FirstName = "Bob", LastName = "Jones" };
           var member2 = new MembersModel() { FirstName = "Sue", LastName = "Johnson"};
           var member3 = new MembersModel() { FirstName = "Bob", LastName = "Jones" };
           var members = new List<MembersModel>() { member1, member2,member3 };

           var memberDao = new MembersMemoryDao();
            memberDao.Save(members);

            var membersGetList = memberDao.Get();

            Assert.AreEqual(2, membersGetList.Count);
            Assert.AreEqual(1, membersGetList[0].Id);
            Assert.AreEqual("Bob", membersGetList[0].FirstName);
            Assert.AreEqual("Jones", membersGetList[0].LastName);
            Assert.AreEqual(2, membersGetList[1].Id);
            Assert.AreEqual("Sue", membersGetList[1].FirstName);
            Assert.AreEqual("Johnson", membersGetList[1].LastName);
        }

        [Test]
        public void MemberPostMemoryDeleteTest()
        {
            var member1 = new MembersModel() { FirstName = "Bob", LastName = "Jones" };
            var member2 = new MembersModel() { FirstName = "Sue", LastName = "Johnson" };
            var member3 = new MembersModel() { FirstName = "Bob", LastName = "Jones" };
            var members = new List<MembersModel>() { member1, member2, member3 };

            var memberDao = new MembersMemoryDao();
            memberDao.Save(members);

            memberDao.Delete(member1);

            var membersGetList = memberDao.Get();

            Assert.AreEqual(1, membersGetList.Count);
            Assert.AreEqual(2, membersGetList[0].Id);
            Assert.AreEqual("Sue", membersGetList[0].FirstName);
            Assert.AreEqual("Johnson", membersGetList[0].LastName);
        }

        [Test]
        public void MemberPostMemoryDelete2Test()
        {
            var member1 = new MembersModel() { FirstName = "Bob", LastName = "Jones" };
            var member2 = new MembersModel() { FirstName = "Sue", LastName = "Johnson" };
            var member3 = new MembersModel() { FirstName = "Bob", LastName = "Jones" };
            var members = new List<MembersModel>() { member1, member2, member3 };

            var memberDao = new MembersMemoryDao();
            memberDao.Save(members);

            memberDao.Delete(member1);

            var membersGetList = memberDao.Get();

            Assert.AreEqual(1, membersGetList.Count);
            Assert.AreEqual(2, membersGetList[0].Id);
            Assert.AreEqual("Sue", membersGetList[0].FirstName);
            Assert.AreEqual("Johnson", membersGetList[0].LastName);

            memberDao.Save(member3);


            Assert.AreEqual(2, membersGetList.Count);
            Assert.AreEqual(2, membersGetList[0].Id);
            Assert.AreEqual("Sue", membersGetList[0].FirstName);
            Assert.AreEqual("Johnson", membersGetList[0].LastName);
            Assert.AreEqual(3, membersGetList[1].Id);
            Assert.AreEqual("Bob", membersGetList[1].FirstName);
            Assert.AreEqual("Jones", membersGetList[1].LastName);
        }
    }
}
