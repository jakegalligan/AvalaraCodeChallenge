using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using AvalaraCodeChallenge.Pages;


namespace avalaracodechallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProvidingList_ReturnsAverage_OfAllNumbers ()
        {
            //Arrange
            List<double> listOfNumbers = new List<double>();
            numbers.Add(3.2);
            numbers.Add(5.3);
            numbers.Add(.4);
            double expectedMean = 8.9/3;

            //Act
            var actualMean = IndexModel.getAverage(listOfNumbers);

            //Assert
            Assert.AreEqual(expectedMean, actualMean, .001);

        }
        public void EnteringNoDate_ReturnsCurrentDate () {
            //Arrange
            var noDate = null;
            var expectedDateReturned = DateTime.Today.ToString('d');

            //Act
            var acutalDateReturned = IndexModel.getDate(noDate);

            //Assert
            AssemblyLoadEventArgs.AreEqual(expectedDateReturned,acutalDateReturned);
        } 
    }
}
