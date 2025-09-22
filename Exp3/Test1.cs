namespace Exp3
{
    [TestClass]
    public sealed class Test1
    {
        static double Square(double a,double b)
        {
            if(a > 0&&b>0) return a*b;
            return 0;
        }
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(27, Square(6, 4.5));
        }
        [TestMethod]
        public void TestMethod2()
        {
       
            Assert.AreEqual(6.82, Square(3.1, 2.2),0.01);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Square(5, -3));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, Square(-5, -3));
        }
    }
}
