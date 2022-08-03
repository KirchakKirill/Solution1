using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCodeBLog.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCodeBLog.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void UserControllerTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void SaveTest()
        {
            var username = Guid.NewGuid().ToString();
            var cntr = new UserController(username);
            Assert.AreEqual(username,cntr.CurrentUser.Name);
           // Assert.Fail();
        }

        [TestMethod()]
        public void SetNewUserDataTest()
        {
           // Assert.Fail();
        }
    }
}