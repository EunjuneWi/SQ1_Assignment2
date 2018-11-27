/*
* FILE			: TriangleUnitTest.cs
* PROJECT		: INFO2180 - Assignment #2
* PROGRAMMER	: Eunjune Wi
* FIRST VERSION : 2018-11-26
* DESCRIPTION	:
*   This file contains 6 data-driven unit tests for Triangle class.
*   All the inputs for test was generated with Excel file and
*   saved as comma separated .csv file.
*   In order to build data-driven unit test, the link below was used.
*   https://msdev.pro/2016/02/07/how-to-set-up-a-parameterized-unit-test/
*/



// *--------------*
// |  References  |
// *--------------*
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Assignment2
{
    /*
    *   Name    :   TriangleUnitTest
    *   Purpose :   This class has unit test methods for Triangle classes.
    */
    [TestClass]
    public class TriangleUnitTest
    {
        // *----------------*
        // |  Data Members  |
        // *----------------*
        // This helps in loading csv file for each test method
        private TestContext testContextInstance;



        // *-----------*
        // |  Methods  |
        // *-----------*
        /*
        *   METHOD      :   TestContext
        *   DESCRIPTION :   This method is a getter and setter of member 'testContextInstance'.
        *   PARAMETERS  :   If it is used as setter, new input for unit test is passed. 
        *   RETURNS     :   If it is getter, inputs for unit test is returned.
        */
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }



        /*
        *   METHOD      :   NormalTestForRemainingSide
        *   DESCRIPTION :   This is a normal unit test for 'GetRemainingSide' of Triangle class.
        *                   It reads inputs from csv file and compares result.
        *                   Due to double precision, the result should be compared with rounded number.
        *                   In order to check test result without reading long numbers,
        *                   all the result is rounded to have four digits right of the decimal point.
        *   PARAMETERS  :   N/A
        *   RETURNS     :   N/A
        */
        [TestMethod()]
        [DataSource(    "Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @"..\..\TestInput\NorTestForRemSide.csv",
                        "NorTestForRemSide#csv", DataAccessMethod.Sequential)]
        public void NormalTestForRemainingSide()
        {
            // Arrange
            string firstSide = TestContext.DataRow["FirstSide"].ToString();
            string secondSide = TestContext.DataRow["SecondSide"].ToString();
            double expected = Convert.ToDouble(TestContext.DataRow["Expected"]);

            // Act
            double actual = Triangle.GetRemainingSide(firstSide, secondSide);

            // Assert
            Assert.AreEqual(expected, actual,
                            "firstSide:<{0}> secondSide:<{1}>", 
                            new object[] { firstSide, secondSide });
        }



        /*
        *   METHOD      :   ExceptionTestForRemainingSide
        *   DESCRIPTION :   This is a exception unit test for 'GetRemainingSide' of Triangle class.
        *                   It reads inputs from csv file 'ExTestForRemSide.csv'.
        *                   Since all the result should raise exception,
        *                   There is no code for assert.
        *   PARAMETERS  :   N/A
        *   RETURNS     :   N/A
        */
        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @"..\..\TestInput\ExTestForRemSide.csv",
                        "ExTestForRemSide#csv", DataAccessMethod.Sequential)]
        [ExpectedException(typeof(Exception))]
        public void ExceptionTestForRemainingSide()
        {
            // Arrange
            string firstSide = TestContext.DataRow["FirstSide"].ToString();
            string secondSide = TestContext.DataRow["SecondSide"].ToString();

            // Act
            double actual = Triangle.GetRemainingSide(firstSide, secondSide);

            // Assert
        }



        /*
        *   METHOD      :   NormalTestForGetArea
        *   DESCRIPTION :   This is a normal unit test for 'GetArea' of Triangle class.
        *                   It reads inputs from csv file and compares result.
        *                   Due to double precision, the result should be compared with rounded number.
        *                   In order to check test result without reading long numbers,
        *                   all the result is rounded to have four digits right of the decimal point.
        *   PARAMETERS  :   N/A
        *   RETURNS     :   N/A
        */
        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @"..\..\TestInput\NorTestForGetArea.csv",
                        "NorTestForGetArea#csv", DataAccessMethod.Sequential)]
        public void NormalTestForGetArea()
        {
            // Arrange
            string firstSide = TestContext.DataRow["FirstSide"].ToString();
            string secondSide = TestContext.DataRow["SecondSide"].ToString();
            double expected = Convert.ToDouble(TestContext.DataRow["Expected"]);

            // Act
            double actual = Triangle.GetArea(firstSide, secondSide);

            // Assert
            Assert.AreEqual(expected, actual,
                            "firstSide:<{0}> secondSide:<{1}>",
                            new object[] { firstSide, secondSide });
        }



        /*
        *   METHOD      :   ExceptionTestForGetArea
        *   DESCRIPTION :   This is a exception unit test for 'GetArea' of Triangle class.
        *                   It reads inputs from csv file 'ExTestForRemSide.csv'.
        *                   Since all the result should raise exception,
        *                   There is no code for assert.
        *   PARAMETERS  :   N/A
        *   RETURNS     :   N/A
        */
        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @"..\..\TestInput\ExTestForRemSide.csv",
                        "ExTestForRemSide#csv", DataAccessMethod.Sequential)]
        [ExpectedException(typeof(Exception))]
        public void ExceptionTestForGetArea()
        {
            // Arrange
            string firstSide = TestContext.DataRow["FirstSide"].ToString();
            string secondSide = TestContext.DataRow["SecondSide"].ToString();

            // Act
            double actual = Triangle.GetArea(firstSide, secondSide);

            // Assert
        }



        /*
        *   METHOD      :   NormalTestForGetAngle
        *   DESCRIPTION :   This is a normal unit test for 'GetAngle' of Triangle class.
        *                   It reads inputs from csv file and compares result.
        *                   Due to double precision, the result should be compared with rounded number.
        *                   In order to check test result without reading long numbers,
        *                   all the result is rounded to have four digits right of the decimal point.
        *   PARAMETERS  :   N/A
        *   RETURNS     :   N/A
        */
        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @"..\..\TestInput\NorTestForGetAngle.csv",
                        "NorTestForGetAngle#csv", DataAccessMethod.Sequential)]
        public void NormalTestForGetAngle()
        {
            // Arrange
            string firstAngle = TestContext.DataRow["FirstAngle"].ToString();
            string secondAngle = TestContext.DataRow["SecondAngle"].ToString();
            double expected = Convert.ToDouble(TestContext.DataRow["Expected"]);

            // Act
            double actual = Triangle.GetAngle(firstAngle, secondAngle);

            // Assert
            Assert.AreEqual(expected, actual,
                            "firstAngle:<{0}> secondAngle:<{1}>",
                            new object[] { firstAngle, secondAngle });
        }
    }
}