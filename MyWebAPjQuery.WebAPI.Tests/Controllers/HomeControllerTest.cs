using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebAPjQuery.WebAPI;
using MyWebAPjQuery.WebAPI.Controllers;
using System.Web.Mvc;

namespace MyWebAPjQuery.WebAPI.Tests.Controllers
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
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
