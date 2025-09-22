using ConsoleApp1;

namespace Exp4
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodOk6()
        {
            Password password=new Password();
            password.UserPassword = "d2f9st";
            Assert.IsTrue(password.CheckPassword());
        }
        [TestMethod]
        public void TestMethodOk10()
        {
            Password password = new Password();
            password.UserPassword = "d21fstz!";
            Assert.IsTrue(password.CheckPassword());
        }
        [TestMethod]
        public void TestMethodNotOkNoNumbers()
        {
            Password password = new Password();
            password.UserPassword = "dzyo!_x";
            Assert.IsFalse(password.CheckPassword());
        }
        [TestMethod]
        public void TestMethodNotOkLengthLessThen6()
        {
            Password password = new Password();
            password.UserPassword = "d23j";
            Assert.IsFalse(password.CheckPassword());
        }
    }
}
