using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RVezyTest.Controllers;
using RVezyTest.Interfaces;
using RVezyTest.Models;
using System.Collections.Generic;

namespace RVezyTest.tests.Controllers
{
    [TestClass]
    public class Class1
    {
        ValuesController controller;
        Mock<ICsvService> csvServiceMock;

        [TestInitialize]
        public void Setup()
        {
            csvServiceMock = new Mock<ICsvService>();
        }

        [TestMethod]
        public void Get_ReturnsOkResponse()
        {
            // Arrange
            List<Listing> list = new List<Listing>();
            csvServiceMock.Setup(x => x.GetValues()).Returns(list);

            controller = new ValuesController(csvServiceMock.Object);

            // Act
            var result = controller.Get();


            // Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult<IEnumerable<Listing>>));
        }

        [TestMethod]
        public void GetByPropertyType_ReturnsOkResponse()
        {
            // Arrange
            List<Listing> list = new List<Listing>();
            csvServiceMock.Setup(x => x.GetValuesByPropertyType(It.IsAny<string>())).Returns(list);

            controller = new ValuesController(csvServiceMock.Object);

            // Act
            var result = controller.GetByPropertyType("test");


            // Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult<string>));
        }

    }
}
