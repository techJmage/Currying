using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Currying.Tests
{
    [TestClass()]
    public class ExtensionsTests
    {
        [TestMethod()]
        public void PipeTest()
        {
            int i = 0;
            var add = (int i, int j) => i + j;
            var addBy10 = (int i) => add(i, 10);
            var square = (int i) => i * i;

            var res = i.Pipe(addBy10, square);
            Assert.IsTrue(res == (i + 10) * 10);
        }
        [TestMethod()]
        public void PipeTest2()
        {
            int i = 0;
            var add = (int i, int j) => i + j;
            var addBy10 = i.Pipe(add, 10);
            var square = (int i) => i * i;
            var res = addBy10.Pipe(square);
            Assert.IsTrue(res == (i + 10) * 10);
        }
        [TestMethod()]
        public void PipeTest3()
        {
            int i = 0;
            var add = (int j) =>
            {
                i += j;
            };
            var square = (int j) =>
            {
                i = j * j;
            };
            10.Pipe(add, square);
            Assert.AreEqual(i, 100);
        }
        [TestMethod()]
        public void PipeTest4()
        {
            var getList = () => new int[] { 1, 2, 3, 4 };
            var res = getList().Sum().Pipe(p => p * 10, p => p / 100);
            Assert.AreEqual(res, 1);
        }
    }
}