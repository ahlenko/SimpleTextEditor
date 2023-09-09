using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;
using System;

namespace EditorTesting {

    [TestClass] //|-----------------------------------------------------------------------|
    public class RenameMethodTest {

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod1()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod2()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod3()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod4()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod5()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod6()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod7()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod8()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod9()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod10()
        {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text = 
                "";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }
    }

    [TestClass] //|-----------------------------------------------------------------------|
    public class InlineMethodTest {

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod1() {
            Refactor refactor = new Refactor();

            string method_call = "math.plus(6, 4)";

            string text =
                "#include <iostream>\r\n" +
                "class MathOperation { public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;}\r\n" +
                "};using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.plus(6, 4);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "t";

            string res =
                "#include <iostream>\r\n" +
                "class MathOperation { public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;}\r\n" +
                "};using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    //MInline: math.plus(6, 4)\r\n" +
                "    int t = 6 + 4;\r\n" +
                "    int n = t;\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod2()
        {
            Refactor refactor = new Refactor();

            string method_call = "math.mult(8, 2)";

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
                "};using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.mult(8, 2);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";
            
            string returned_var = "mult_res";

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
                "};using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    //MInline: math.mult(8, 2)\r\n" +
                "    int mult_res = 8 * 2;\r\n" +
                "    int n = mult_res;\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod3()
        {
            Refactor refactor = new Refactor();

            string method_call = "math.div(3, 1)";

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
                "};using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.mult(8, 2) + math.div(3, 1);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "res_div";

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
                "};using namespace std;\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    //MInline: math.div(3, 1)\r\n" +
                "    int res_div = 3 / 1;\r\n" +
                "    int n = math.mult(8, 2) + res_div;\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod4()
        {
            Refactor refactor = new Refactor();

            string method_call = "user.displayInfo()";

            string text =
                "#include <iostream>\r\n" +
                "class User { // Клас \"Користувач\"\r\n" +
                "public:\r\n" +
                "    User(std::string name, int age) : name(name), age(age) {}\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Ім'я: \" << name << std::endl;\r\n" +
                "        std::cout << \"Вік: \" << age << \" років\" << std::endl;}\r\n" +
                "private:\r\n" +
                "    std::string name;\r\n" +
                "    int age;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    User user(\"Іван\", 30);\r\n" +
                "    std::cout << \"Інформація про користувача:\" << std::endl;\r\n" +
                "    user.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "_";

            string res =
                "Worning! Not allowed to inline method.\n Thet methot use private class variable";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod5()
        {
            Refactor refactor = new Refactor();

            string method_call = "user(\"Іван\", 30)";

            string text =
                "#include <iostream>\r\n" +
                "class User { // Клас \"Користувач\"\r\n" +
                "public:\r\n" +
                "    User(std::string name, int age) : name(name), age(age) {}\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Ім'я: \" << name << std::endl;\r\n" +
                "        std::cout << \"Вік: \" << age << \" років\" << std::endl;}\r\n" +
                "private:\r\n" +
                "    std::string name;\r\n" +
                "    int age;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    User user(\"Іван\", 30);\r\n" +
                "    std::cout << \"Інформація про користувача:\" << std::endl;\r\n" +
                "    user.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "_";

            string res =
                "Worning! Not allowed to inline method.\n Thet methot is class constructor";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod6()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = 
                "";

            string returned_var = "";

            string res =
                "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod7()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = 
                "";

            string returned_var = "";

            string res =
                "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod8()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = 
                "";

            string returned_var = "";

            string res =
                "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod9()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = 
                "";

            string returned_var = "";

            string res =
                "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod10()
        {
            Refactor refactor = new Refactor();

            string method_call = "";

            string text = 
                "";

            string returned_var = "";

            string res =
                "";

            Assert.AreEqual(res, refactor.InlineMethod(method_call, text, returned_var));
        }
    }
}
