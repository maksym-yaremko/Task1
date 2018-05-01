using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;

namespace UnitTestInheritanceTask
{
    [TestClass]

    public class RectangleTest
    {
        private TestContext _contextInstance;

        public TestContext TestContext
        {
            get => _contextInstance;
            set => _contextInstance = value;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Rectangle.csv", "Rectangle#csv", DataAccessMethod.Sequential),

         DeploymentItem("Rectangle.csv"), TestMethod]
        public void TestMethodRectangleArea()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double sideA = double.Parse(TestContext.DataRow["SideA"].ToString());
            double sideB = double.Parse(TestContext.DataRow["SideB"].ToString());
            double area = double.Parse(TestContext.DataRow["Area"].ToString());

            //Act
            Rectangle testedRectangle =
                new Rectangle("Doesn't matter", "Doesn't matter", width, sideA, sideB);

            //Assert
            Assert.AreEqual(testedRectangle.Area(), area);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Rectangle.csv", "Rectangle#csv", DataAccessMethod.Sequential),

         DeploymentItem("Rectangle.csv"), TestMethod]
        public void TestMethodRectangleVolume()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double sideA = double.Parse(TestContext.DataRow["SideA"].ToString());
            double sideB = double.Parse(TestContext.DataRow["SideB"].ToString());
            double volume = double.Parse(TestContext.DataRow["Volume"].ToString());

            //Act
            Rectangle testedRectangle =
                new Rectangle("Doesn't matter", "Doesn't matter", width, sideA, sideB);

            //Assert
            Assert.AreEqual(testedRectangle.Area(), volume);
        }
    }
}

