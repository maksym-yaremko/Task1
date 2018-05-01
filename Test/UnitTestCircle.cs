using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;

namespace UnitTestInheritanceTask
{
    [TestClass]

    public class CircleTest
    {
        private TestContext _contextInstance;

        public TestContext TestContext
        {
            get => _contextInstance;
            set => _contextInstance = value;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Circle.csv", "Circle#csv", DataAccessMethod.Sequential),

         DeploymentItem("Circle.csv"), TestMethod]
        public void TestMethodCircleArea()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double radius = double.Parse(TestContext.DataRow["Radius"].ToString());
            double area = double.Parse(TestContext.DataRow["Area"].ToString());

            //Act
            Circle testedCircle = new Circle("Doesn't matter", "Doesn't matter", width, radius);

            //Assert
            Assert.AreEqual(testedCircle.Area(), area);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Circle.csv", "Circle#csv", DataAccessMethod.Sequential),

         DeploymentItem("Circle.csv"), TestMethod]
        public void TestMethodCirclePerimeter()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double radius = double.Parse(TestContext.DataRow["Radius"].ToString());
            double perimeter = double.Parse(TestContext.DataRow["Perimeter"].ToString());

            //Act
            Circle testedCircle = new Circle("Doesn't matter", "Doesn't matter", width, radius);

            //Assert
            Assert.AreEqual(testedCircle.Perimeter(), perimeter);
        }
    }
}
