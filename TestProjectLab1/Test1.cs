namespace TestProjectLab1
{
    [TestClass]
    public class Test1
    {
        static bool IsSimple(int x)
        {
            bool simple=x>1;
            for (int i = 2;i<x;i++)
                if (x % i == 0)
                {
                    simple=false;
                    break;
                }
            return simple;
        }
        [TestMethod]
        public void TestMethod17()
        {
            Assert.IsTrue(IsSimple(17));
        }
        [TestMethod]
        public void TestMethod72()
        {
            Assert.IsFalse(IsSimple(72));
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(IsSimple(1));
        }
        [TestMethod]
        public void TestMethod0()
        {
            Assert.IsFalse(IsSimple(0));
        }
        [TestMethod]
        public void TestMethod_5()
        {
            Assert.IsFalse(IsSimple(-5));
        }
    }
}
