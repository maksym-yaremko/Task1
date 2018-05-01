using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;

namespace UnitTestInheritanceTask
{
    [TestClass]

    public class ParallelepipedTest
    {
        private TestContext _contextInstance;

        public TestContext TestContext
        {
            get => _contextInstance;
            set => _contextInstance = value;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Parallelepiped.csv", "Parallelepiped#csv", DataAccessMethod.Sequential),

         DeploymentItem("Parallelepiped.csv"), TestMethod]
        public void TestMethodParallelepipedArea()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double sideA = double.Parse(TestContext.DataRow["SideA"].ToString());
            double sideB = double.Parse(TestContext.DataRow["SideB"].ToString());
            double height = double.Parse(TestContext.DataRow["Height"].ToString());
            double area = double.Parse(TestContext.DataRow["Area"].ToString());

            //Act
            Parallelepiped testedParallelepiped =
                new Parallelepiped("Doesn't matter", "Doesn't matter", width, sideA, sideB, height);

            //Assert
            Assert.AreEqual(testedParallelepiped.Area(), area);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Parallelepiped.csv", "Parallelepiped#csv", DataAccessMethod.Sequential),

         DeploymentItem("Parallelepiped.csv"), TestMethod]
        public void TestMethodParallelepipedVolume()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double sideA = double.Parse(TestContext.DataRow["SideA"].ToString());
            double sideB = double.Parse(TestContext.DataRow["SideB"].ToString());
            double height = double.Parse(TestContext.DataRow["Height"].ToString());
            double volume = double.Parse(TestContext.DataRow["Volume"].ToString());

            //Act
            Parallelepiped testedParallelepiped =
                new Parallelepiped("Doesn't matter", "Doesn't matter", width, sideA, sideB, height);

            //Assert
            Assert.AreEqual(testedParallelepiped.Area(), volume);
        }
    }
}
