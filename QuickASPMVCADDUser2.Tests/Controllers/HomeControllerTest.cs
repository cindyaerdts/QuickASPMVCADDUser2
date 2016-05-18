using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickASPMVCADDUser2;
using QuickASPMVCADDUser2.Controllers;

namespace QuickASPMVCADDUser2.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddUser()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.AddUser() as ViewResult;

            // Assert
            Assert.AreEqual("Find and add users", result.ViewBag.Message);
        }

        [Ignore]
        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            //ViewResult result = controller.Contact() as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
        }
    }
}
