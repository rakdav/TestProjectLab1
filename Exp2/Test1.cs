namespace Exp2
{
    [TestClass]
    public sealed class Test1
    {
        static int Fact(int n)
        {
            if(n <0) return 0;
            int f = 1;
            for (int i = 2; i <= n; i++) f *= i;
            return f;
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(720, Fact(6));
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Fact(1));
        }
        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(1, Fact(0));
        }
        [TestMethod]
        public void TestNegative()
        {
            Assert.AreEqual(0, Fact(-5));
        }
    }
}
