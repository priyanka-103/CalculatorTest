using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using AwesomeCalculator;

namespace CalculatorTest {
        [TestFixture]
        public class CalculatorTest
        {

        //Adition
            [Test]
            public void GetAddition_Input25and4_Returns29()
            {

                //Arrange
                double number1 = 25;
                double number2 = 4;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetAddition();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        [Test]
        public void GetAddition_Input3point2and5point0_Returns8point2()
            {

                //Arrange
                double number1 = 3.2;
                double number2 = 5.0 ;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetAddition();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        [Test]
        public void GetAddition_Input350point0and20point0_Returns370point0()
            {

                //Arrange
                double number1 = 350.0;
                    double number2 = 20.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetAddition();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }



        //subtraction
        [Test]
        public void GetSubtraction_Input25and4_Returns21()
            {

                //Arrange
                double number1 = 25;
                double number2 = 4;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetSubtraction();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        [Test]
        public void GetSubtraction_Input5point0and3point2_Returns1point8()
            {

                //Arrange
                double number1 = 5.0;
                double number2 = 3.5;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetSubtraction();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        [Test]
        public void GetSubtraction_Input50point5and20point5_Returns30point0()
            {

                //Arrange
                double number1 = 50.5;
                double number2 = 20.5;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetSubtraction();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }


        //multiplication
        [Test]
        public void GetMultiplication_Input25and4_Returns100point0()
            {

                //Arrange
                double number1 = 25;
                double number2 = 4;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetMultiplication();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        [Test]
        public void GetMultiiplication_Input5point0and3point2_Returns16point0()
            {

                //Arrange
                double number1 = 5.0;
                double number2 = 3.2;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetMultiplication();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        [Test]
        public void GetMultiiplication_Input50point5and2point0_Returns101point0()
            {

                //Arrange
                double number1 = 50.5;
                double number2 = 2.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);

                //Act
                double actualResult = testCalc.GetMultiplication();

                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }


        //division

        [Test]
        public void Getdivision_Input25and5_Returns5point0()
        {

            //Arrange
            double number1 = 25;
            double number2 = 5;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input6point0and3point0_Returns2point0()
        {

            //Arrange
            double number1 = 6.0;
            double number2 = 3.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input7point0and3point5_Returns2point0()
        {

            //Arrange
            double number1 = 7.0;
            double number2 = 3.5;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }




    }


}