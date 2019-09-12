using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVezyTest.tests.CollectionService
{
    [TestClass]
    public class CsvService
    {

        public CsvService service;

        [TestInitialize]
        public void Setup()
        {
            service = new CsvService();
        }


        [TestMethod]
        public void GetValues_ReturnsValues()
        {
            // Arrange
           
            // Act
            var result = service.GetValues();


            // Assert
            Assert.IsNotNull(result);
        }
    }
}
