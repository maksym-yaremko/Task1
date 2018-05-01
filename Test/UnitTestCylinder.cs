using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;

namespace UnitTestInheritanceTask
{
    [TestClass]

    public class CylinderTest
    {
        private TestContext _contextInstance;

        public TestContext TestContext
        {
            get => _contextInstance;
            set => _contextInstance = value;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Cylinder.csv", "Cylinder#csv", DataAccessMethod.Sequential),

         DeploymentItem("Cylinder.csv"), TestMethod]
        public void TestMethodCylinderArea()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double radius = double.Parse(TestContext.DataRow["Radius"].ToString());
            double height = double.Parse(TestContext.DataRow["Height"].ToString());
            double area = double.Parse(TestContext.DataRow["Area"].ToString());

            //Act
            Cylinder testedCylinder = new Cylinder("Doesn't matter", "Doesn't matter", width, radius, height);

            //Assert
            Assert.AreEqual(testedCylinder.Area(), area);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",

             "|DataDirectory|\\test\\Cylinder.csv", "Cylinder#csv", DataAccessMethod.Sequential),

         DeploymentItem("Cylinder.csv"), TestMethod]
        public void TestMethodCylinderVolume()
        {
            //Arrange
            double width = double.Parse(TestContext.DataRow["Width"].ToString());
            double radius = double.Parse(TestContext.DataRow["Radius"].ToString());
            double height = double.Parse(TestContext.DataRow["Height"].ToString());
            double volume = double.Parse(TestContext.DataRow["Volume"].ToString());

            //Act
            Cylinder testedCylinder = new Cylinder("Doesn't matter", "Doesn't matter", width, radius, height);

            //Assert
            Assert.AreEqual(testedCylinder.Volume(), volume);
        }
    }
}
