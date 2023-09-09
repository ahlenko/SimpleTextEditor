using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;

namespace EditorTesting {

    [TestClass] //|-----------------------------------------------------------------------|
    public class RenameMethodTest {

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod1() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

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

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod2() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

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

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod3() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

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

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod4() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

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

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod5() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

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

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod6() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text =
                "#include <iostream>\r\n" +
                "class Car { // Клас Автомобіль\r\n" +
                "public:\r\n" +
                "    Car(std::string make, std::string model) : make(make), model(model) {}\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Марка: \" << make << std::endl;\r\n" +
                "        std::cout << \"Модель: \" << model << std::endl;}\r\n" +
                "    std::string make;\r\n" +
                "    std::string model;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    Car car(\"Toyota\", \"Camry\");\r\n" +
                "    std::cout << \"\\nІнформація про автомобіль:\" << std::endl;\r\n" +
                "    car.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod7() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text =
                "class Class1 { public:\r\n" +
                "    int Add(int a, int b) {\r\n" +
                "        return a + b;}\r\n" +
                "    int Subtract(int a, int b) {\r\n" +
                "        return a - b;}\r\n" +
                "};\r\n" +
                "class Class2 { public:\r\n" +
                "    Class1 c1;\r\n" +
                "    int Calculate(int x, int y) {\r\n" +
                "        return x + c1.Add(x, y);}\r\n" +
                "    int Compute(int p, int q) {\r\n" +
                "        return p - c1.Subtract(p, q);}\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    Class2 c2;\r\n" +
                "    int result1 = c2.Calculate(10, 5);\r\n" +
                "    int result2 = c2.Compute(20, 8);\r\n" +
                "    std::cout << \"Result 1: \" << result1 << std::endl;\r\n" +
                "    std::cout << \"Result 2: \" << result2 << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod8() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text =
                "class Class1 { public:\r\n" +
                "    int Add(int a, int b) {\r\n" +
                "        return a + b;}\r\n" +
                "    int Subtract(int a, int b) {\r\n" +
                "        return a - b;}\r\n" +
                "};\r\n" +
                "class Class2 { public:\r\n" +
                "    Class1 c1;\r\n" +
                "    int Calculate(int x, int y) {\r\n" +
                "        return x + c1.Add(x, y);}\r\n" +
                "    int Compute(int p, int q) {\r\n" +
                "        return p - c1.Subtract(p, q);}\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    Class2 c2;\r\n" +
                "    int result1 = c2.Calculate(10, 5);\r\n" +
                "    int result2 = c2.Compute(20, 8);\r\n" +
                "    std::cout << \"Result 1: \" << result1 << std::endl;\r\n" +
                "    std::cout << \"Result 2: \" << result2 << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod9() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text =
                "class DataProcessor { public:\r\n" +
                "    int ProcessData(int data) {\r\n" +
                "        int result = 0;\r\n" +
                "        if (data > 0) for (int i = 1; i <= data; ++i) {\r\n" +
                "            if (IsPrime(i)) result += i;}\r\n" +
                "        else std::cerr << \"Error: Invalid input data.\" << std::endl;\r\n" +
                "        return result;}\r\n" +
                "    bool IsPrime(int number) {\r\n" +
                "        if (number <= 1) return false; \r\n" +
                "        for (int i = 2; i * i <= number; ++i) \r\n" +
                "            if (number % i == 0) return false;\r\n" +
                "                return true;}\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    DataProcessor processor;\r\n" +
                "    int inputData = 10;\r\n" +
                "    int result = processor.ProcessData(inputData);\r\n" +
                "    std::cout << \"Result: \" << result << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod10() {
            Refactor refactor = new Refactor();

            string old_name = "";
            string new_name = "";

            string text =
                "class DataProcessor { public:\r\n" +
                "    int ProcessData(int data) {\r\n" +
                "        int result = 0;\r\n" +
                "        if (data > 0) for (int i = 1; i <= data; ++i) {\r\n" +
                "            if (IsPrime(i)) result += i;}\r\n" +
                "        else std::cerr << \"Error: Invalid input data.\" << std::endl;\r\n" +
                "        return result;}\r\n" +
                "    bool IsPrime(int number) {\r\n" +
                "        if (number <= 1) return false; \r\n" +
                "        for (int i = 2; i * i <= number; ++i) \r\n" +
                "            if (number % i == 0) return false;\r\n" +
                "                return true;}\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    DataProcessor processor;\r\n" +
                "    int inputData = 10;\r\n" +
                "    int result = processor.ProcessData(inputData);\r\n" +
                "    std::cout << \"Result: \" << result << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res = 
                "";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }
    }
}
