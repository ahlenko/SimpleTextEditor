using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;
using System;

namespace EditorTesting
{
    [TestClass]
    public class MagicNumberTests
    {
        //1
        [TestMethod]
        public void NumberChange()
        {
            Refactor r = new Refactor();
            string origin = "int a = 10 + 4";
            int magicNum = 4;
            string constName = "b";
            string result = r.ChangeNum(origin, constName, magicNum);
            string expectedResult = "const int b = 4\n" +
                "int a = 10 + b";
            Assert.AreEqual(expectedResult, result);
        }
        //2
        [TestMethod]
        public void NumberNotChange()
        {
            Refactor r = new Refactor();
            string origin = "int a = 10 + 4";
            int magicNum = 5;
            string constName = "b";
            string result = r.ChangeNum(origin, constName, magicNum);
            string expectedResult = "int a = 10 + 4";
            Assert.AreEqual(expectedResult, result);
        }
        //3
        [TestMethod]
        public void MultiNumberChange()
        {
            Refactor r = new Refactor();
            string origin = "int a = 10 + 4\n" +
                "int c = 10 - 4";
            int magicNum = 4;
            string constName = "b";
            string result = r.ChangeNum(origin, constName, magicNum);
            string expectedResult = "const int b = 4\n" +
                "int a = 10 + b\n" +
                "int c = 10 - b";
            Assert.AreEqual(expectedResult, result);
        }
        //4
        [TestMethod]
        public void NumberIsNotVariable()
        {
            Refactor r = new Refactor();

            string origin = "int a1 = 10 + 2\n" +
                "int a2 = 2 + 3";
            int magicNum = 2;
            string constName = "b";
            string result = r.ChangeNum(origin, constName, magicNum);
            string expectedResult = "const int b = 2\n" +
                "int a1 = 10 + b\n" +
                "int a2 = b + 3";
            Assert.AreEqual(expectedResult, result);
        }
        //5
        [TestMethod]
        public void ConstantAlreadyExists()
        {
            Refactor r = new Refactor();

            string origin = "const int b = 5\n" +
                "int a = b + 4";
            int magicNum = 4;
            string constName = "b";

            string result = r.ChangeNum(origin, constName, magicNum);

            string expectedResult = "const int b = 5\n" +
                "int a = b + 4";

            Assert.AreEqual(expectedResult, result);
        }
        //6
        [TestMethod]
        public void InvalidConstantName()
        {
            Refactor r = new Refactor();

            string origin = "int a = 5";
            int magicNum = 5;
            string constName = "1b";

            string result = r.ChangeNum(origin, constName, magicNum);

            string expectedResult = "int a = 5";

            Assert.AreEqual(expectedResult, result);
        }
        //7
        [TestMethod]

        public void ConstantNameInOtherNumber()
        {
            Refactor r = new Refactor();

            string origin = "float a = 1.534";
            int magicNum = 4;
            string constName = "b";

            string result = r.ChangeNum(origin, constName, magicNum);

            string expectedResult = "float a = 1.534";

            Assert.AreEqual(expectedResult, result);
        }
        //8
        [TestMethod]
        public void MagicNumberInComments()
        {
            Refactor r = new Refactor();

            string origin = "// int a = 10 + 4\n" +
                "int b = 5";
            int magicNum = 4;
            string constName = "c";

            string result = r.ChangeNum(origin, constName, magicNum);

            string expectedResult = "// int a = 10 + 4\n" +
                "int b = 5";

            Assert.AreEqual(expectedResult, result);
        }
        //9
        [TestMethod]
        public void MagicNumberInstrings()
        {
            Refactor r = new Refactor();

            string origin = "string s = \"Value is 4\"";
            int magicNum = 4;
            string constName = "a";

            string result = r.ChangeNum(origin, constName, magicNum);

            string expectedResult = "string s = \"Value is 4\"";

            Assert.AreEqual(expectedResult, result);

        }
        //10
        [TestMethod]
        public void ReplaceInNestedExpressions()
        {
            Refactor r = new Refactor();

            string origin = "int a = (2 + 4) * 5";
            int magicNum = 4;
            string constName = "x";

            string result = r.ChangeNum(origin, constName, magicNum);

            string expectedResult = "const int x = 4\n" +
                "int a = (2 + x) * 5";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
