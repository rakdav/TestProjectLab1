namespace TDDProject
{
    [TestClass]
    public class TestTriangle
    {
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///</summary>
        [TestMethod]
        public void isRightTest()
        {
            RightTriangle t=new RightTriangle();
            t.A = 3;
            t.B = 4;
            t.C = 5;
            Assert.IsTrue(t.IsRight());
        }
        ///<summary>
        ///Негативный тест
        ///Треугольник непрямоугольный
        ///</summary>
        [TestMethod]
        public void isNotRightTest()
        {
            RightTriangle t = new RightTriangle();
            t.A = 3;
            t.B = 4;
            t.C = 4;
            Assert.IsFalse(t.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///Гипотенуза - А
        ///</summary>
        [TestMethod]
        public void isRightTestA()
        {
            RightTriangle t = new RightTriangle();
            t.A = 10;
            t.B = 6;
            t.C = 8;
            Assert.IsTrue(t.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///Гипотенуза - B
        ///</summary>
        [TestMethod]
        public void isRightTestB()
        {
            RightTriangle t = new RightTriangle();
            t.A = 3;
            t.B = 5;
            t.C = 4;
            Assert.IsTrue(t.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///Гипотенуза - C
        ///</summary>
        [TestMethod]
        public void isRightTestC()
        {
            RightTriangle t = new RightTriangle();
            t.A = 3;
            t.B = 4;
            t.C = 5;
            Assert.IsTrue(t.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление периметра
        ///</summary>
        [TestMethod]
        public void PerimetrTest()
        {
            RightTriangle t = new RightTriangle();
            t.A = 3;
            t.B = 4;
            t.C = 5;
            Assert.AreEqual(12,t.Perimetr());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление площади
        ///</summary>
        [TestMethod]
        public void AreaTest()
        {
            RightTriangle t = new RightTriangle();
            t.A = 3;
            t.B = 4;
            t.C = 5;
            Assert.AreEqual(6, t.Area());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление площади
        ///Гипотенуза a
        ///</summary>
        [TestMethod]
        public void AreaTestA()
        {
            RightTriangle t = new RightTriangle();
            t.A = 5;
            t.B = 4;
            t.C = 3;
            Assert.AreEqual(6, t.Area());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление площади
        ///Гипотенуза b
        ///</summary>
        [TestMethod]
        public void AreaTestB()
        {
            RightTriangle t = new RightTriangle();
            t.A = 3;
            t.B = 5;
            t.C = 4;
            Assert.AreEqual(6, t.Area());
        }
    }
}
