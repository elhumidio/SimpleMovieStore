using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientWebMovieStore;
using ClientWebMovieStore.Controllers;

namespace ClientWebMovieStore.Tests.Controllers
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
            JsonResult result = controller.Index() as JsonResult;

            // Assert
            Assert.IsNotNull(result.Data);
        }


    }
}
