using ConsoleApp1;

namespace exp5
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> input=new List<string>()
            {"word","world","and","library","hello"};
            List<string> output = new List<string>()
            {"word","and","hello"};
            WorldList words=new WorldList(input);
            int count = words.DeleteWords(4);
            CollectionAssert.AreEqual(output,words.worldList);
            Assert.AreEqual(2,count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<string> input = new List<string>()
            {"word","world","and","library","hello"};
            List<string> output = new List<string>()
            {"word","world","and","library","hello"};
            WorldList words = new WorldList(input);
            int count = words.DeleteWords(7);
            CollectionAssert.AreEqual(output, words.worldList);
            Assert.AreEqual(0,count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<string> input = new List<string>()
            {"world","mouse","library","hello"};
            List<string> output = new List<string>() { };
            WorldList words = new WorldList(input);
            int count = words.DeleteWords(4);
            CollectionAssert.AreEqual(output, words.worldList);
            Assert.AreEqual(4, count);
        }
    }
}
