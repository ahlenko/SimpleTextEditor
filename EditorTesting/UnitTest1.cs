using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;
using System;

namespace EditorTesting {
    [TestClass]
    public class RenameMethodTest {
        [TestMethod]
        public void TestMethod1()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }
    }

    [TestClass]
    public class InlineMethodTest {
        [TestMethod]
        public void TestMethod1() {
            Refactor refactor = new Refactor();

            string method_call = "math.plus(6, 4)";

            string text =
                "#include <iostream>\r\n" +
                "class MathOperation { public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;}\r\n" +
                "    int minus(int first, int second) {\r\n" +
                "        return first - second;}\r\n" +
                "    int mult(int first, int second) {\r\n" +
                "        return first * second;}\r\n" +
                "    int div(int first, int second) {\r\n" +
                "        return first / second;}\r\n" +
                "}; using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.plus(6, 4);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res = 
                "#include <iostream>\r\n" +
                "class MathOperation { public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;}\r\n" +
                "    int minus(int first, int second) {\r\n" +
                "        return first - second;}\r\n" +
                "    int mult(int first, int second) {\r\n" +
                "        return first * second;}\r\n" +
                "    int div(int first, int second) {\r\n" +
                "        return first / second;}\r\n" +
                "}; using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n; { // MInline: plus\r\n" +
                "        n = 6 + 4;\r\n" +
                "    }\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = "";

            string res = "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text));
        }
    }
}
