using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;

namespace EditorTesting {
    [TestClass] //|-----------------------------------------------------------------------|
    public class InlineMethodTest {
        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod1() {
            Refactor refactor = new Refactor();

            string method_call = "math.plus(6, 4)";

            string text = "#include <iostream>\r\n" +
                "class MathOperation { \r\n" +
                "public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "using namespace std;\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.plus(6, 4);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "t";

            int id = 213;

            string res = "#include <iostream>\r\n" +
                "class MathOperation { \r\n" +
                "public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "using namespace std;\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    //MInline: math.plus(6, 4)\r\n" +
                "    int t; {\r\n" +
                "        t = 6 + 4;\r\n" +
                "    }\r\n" +
                "    int n = t;\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod2() {
            Refactor refactor = new Refactor();

            string method_call = "math.mult(8, 2)";

            string text = 
                "#include <iostream>\r\n" +
                "class MathOperation { \r\n" +
                "public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;\r\n" +
                "    }\r\n" +
                "    int minus(int first, int second) {\r\n" +
                "        return first - second;\r\n" +
                "    }\r\n" +
                "    int mult(int first, int second) {\r\n" +
                "        return first * second;\r\n" +
                "    }\r\n" +
                "    int div(int first, int second) {\r\n" +
                "        return first / second;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "using namespace std;\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.mult(8, 2);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "mult_res";

            int id = 447;

            string res = 
                "#include <iostream>\r\n" +
                "class MathOperation { \r\n" +
                "public:\r\n    int plus(int first, int second) {\r\n" +
                "        return first + second;\r\n" +
                "    }\r\n" +
                "    int minus(int first, int second) {\r\n" +
                "        return first - second;\r\n" +
                "    }\r\n" +
                "    int mult(int first, int second) {\r\n" +
                "        return first * second;\r\n" +
                "    }\r\n" +
                "    int div(int first, int second) {\r\n" +
                "        return first / second;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "using namespace std;\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    //MInline: math.mult(8, 2)\r\n" +
                "    int mult_res; {\r\n" +
                "        mult_res = 8 * 2;\r\n" +
                "    }\r\n" +
                "    int n = mult_res;\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod3() {
            Refactor refactor = new Refactor();

            string method_call = "math.div(3, 1)";

            string text =
                "#include <iostream>\r\n" +
                "class MathOperation { public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;\r\n" +
                "    }\r\n" +
                "    int minus(int first, int second) {\r\n" +
                "        return first - second;\r\n" +
                "    }\r\n" +
                "    int mult(int first, int second) {\r\n" +
                "        return first * second;\r\n" +
                "    }\r\n" +
                "    int div(int first, int second) {\r\n" +
                "        return first / second;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "using namespace std;\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    int n = math.mult(8, 2) + math.div(3, 1);\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "res_div";

            int id = 463;

            string res =
                "#include <iostream>\r\n" +
                "class MathOperation { public:\r\n" +
                "    int plus(int first, int second) {\r\n" +
                "        return first + second;\r\n" +
                "    }\r\n" +
                "    int minus(int first, int second) {\r\n" +
                "        return first - second;\r\n" +
                "    }\r\n" +
                "    int mult(int first, int second) {\r\n" +
                "        return first * second;\r\n" +
                "    }\r\n" +
                "    int div(int first, int second) {\r\n" +
                "        return first / second;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "using namespace std;\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    MathOperation math;\r\n" +
                "    //MInline: math.div(3, 1)\r\n" +
                "    int res_div; {\r\n" +
                "        res_div = 3 / 1;\r\n" +
                "    }\r\n" +
                "    int n = math.mult(8, 2) + res_div;\r\n" +
                "    cout << n;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod4() {
            Refactor refactor = new Refactor();

            string method_call = "user.displayInfo()";

            string text =
                "#include <iostream>\r\n" +
                "class Username { \r\n" +
                "public:\r\n" +
                "    Username(std::string name, int age) : name(name), age(age) {}\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Ім'я: \" << name << std::endl;\r\n" +
                "        std::cout << \"Вік: \" << age << \" років\" << std::endl;\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::string name;\r\n" +
                "    int age;\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    User user(\"Іван\", 30);\r\n" +
                "    std::cout << \"Інформація про користувача:\" << std::endl;\r\n" +
                "    user.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "_";

            int id = 426;

            string res =
                "Worning! Not allowed to inline method.\n Methot description not found";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod5() {
            Refactor refactor = new Refactor();

            string method_call = "user.displayInfo()";

            string text =
                "int main() {\r\n" +
                "    User user(\"Іван\", 30);\r\n" +
                "    std::cout << \"Інформація про користувача:\" << std::endl;\r\n" +
                "    user.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "_";

            int id = 108;

            string res =
                "Worning! Not allowed to inline method.\n Methot description not found";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod6() {
            Refactor refactor = new Refactor();

            string method_call = "car.displayInfo()";

            string text =
                "#include <iostream>\r\n" +
                "class Car { \r\n" +
                "public:\r\n" +
                "    Car(std::string make, std::string model) : make(make), model(model) {}\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Марка: \" << make << std::endl;\r\n" +
                "        std::cout << \"Модель: \" << model << std::endl;}\r\n" +
                "    std::string make;\r\n" +
                "    std::string model;\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    Car car(\"Toyota\", \"Camry\");\r\n" +
                "    std::cout << \"\\nІнформація про автомобіль:\" << std::endl;\r\n" +
                "    car.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "_";

            int id = 424;

            string res =
                "#include <iostream>\r\n" +
                "class Car { \r\n" +
                "public:\r\n" +
                "    Car(std::string make, std::string model) : make(make), model(model) {}\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Марка: \" << make << std::endl;\r\n" +
                "        std::cout << \"Модель: \" << model << std::endl;}\r\n" +
                "    std::string make;\r\n" +
                "    std::string model;\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    Car car(\"Toyota\", \"Camry\");\r\n" +
                "    std::cout << \"\\nІнформація про автомобіль:\" << std::endl;\r\n" +
                "    //MInline: car.displayInfo(){\r\n" +
                "        std::cout << \"Марка: \" << make << std::endl;\r\n" +
                "        std::cout << \"Модель: \" << model << std::endl;\r\n" +
                "    }\r\n" +
                "    car.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod7() {
            Refactor refactor = new Refactor();

            string method_call = "c1.Subtract(p, q)";

            string text =
                "class Class1 {\r\n" +
                "public:\r\n" +
                "    int Add(int a, int b) {\r\n" +
                "        return a + b;\r\n" +
                "    }\r\n" +
                "    int Subtract(int a, int b) {\r\n" +
                "        return a - b;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "class Class2 { \r\n" +
                "public:\r\n" +
                "    Class1 c1;\r\n" +
                "    int Calculate(int x, int y) {\r\n" +
                "        return x + c1.Add(x, y);\r\n" +
                "    }\r\n" +
                "    int Compute(int p, int q) {\r\n" +
                "        return p - c1.Subtract(p, q);\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    Class2 c2;\r\n" +
                "    int result1 = c2.Calculate(10, 5);\r\n" +
                "    int result2 = c2.Compute(20, 8);\r\n" +
                "    std::cout << \"Result 1: \" << result1 << std::endl;\r\n" +
                "    std::cout << \"Result 2: \" << result2 << std::endl;\r\n" +
                "    return 0;\r\n" +
                "};";

            string returned_var = "res";

            int id = 324;

            string res =
                "class Class1 {\r\n" +
                "public:\r\n" +
                "    int Add(int a, int b) {\r\n" +
                "        return a + b;\r\n" +
                "    }\r\n" +
                "    int Subtract(int a, int b) {\r\n" +
                "        return a - b;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "class Class2 { \r\n" +
                "public:\r\n" +
                "    Class1 c1;\r\n" +
                "    int Calculate(int x, int y) {\r\n" +
                "        return x + c1.Add(x, y);\r\n" +
                "    }\r\n" +
                "    int Compute(int p, int q) {\r\n" +
                "        //MInline: c1.Subtract(p, q)\r\n" +
                "        int res; {\r\n" +
                "            res = p - q;\r\n" +
                "        }\r\n" +
                "        return p - res;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    Class2 c2;\r\n" +
                "    int result1 = c2.Calculate(10, 5);\r\n" +
                "    int result2 = c2.Compute(20, 8);\r\n" +
                "    std::cout << \"Result 1: \" << result1 << std::endl;\r\n" +
                "    std::cout << \"Result 2: \" << result2 << std::endl;\r\n" +
                "    return 0;\r\n" +
                "};";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod8() {
            Refactor refactor = new Refactor();

            string method_call = "c2.Calculate(10, 5)";

            string text =
                "class Class1 {\r\n" +
                "public:\r\n" +
                "    int Add(int a, int b) {\r\n" +
                "        return a + b;\r\n" +
                "    }\r\n" +
                "    int Subtract(int a, int b) {\r\n" +
                "        return a - b;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "class Class2 { \r\n" +
                "public:\r\n" +
                "    Class1 c1;\r\n" +
                "    int Calculate(int x, int y) {\r\n" +
                "        return x + c1.Add(x, y);\r\n" +
                "    }\r\n" +
                "    int Compute(int p, int q) {\r\n" +
                "        return p - c1.Subtract(p, q);\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    Class2 c2;\r\n" +
                "    int result1 = c2.Calculate(10, 5);\r\n" +
                "    int result2 = c2.Compute(20, 8);\r\n" +
                "    std::cout << \"Result 1: \" << result1 << std::endl;\r\n" +
                "    std::cout << \"Result 2: \" << result2 << std::endl;\r\n" +
                "    return 0;\r\n" +
                "};";

            string returned_var = "res";

            int id = 405;

            string res =
                "class Class1 {\r\n" +
                "public:\r\n" +
                "    int Add(int a, int b) {\r\n" +
                "        return a + b;\r\n" +
                "    }\r\n" +
                "    int Subtract(int a, int b) {\r\n" +
                "        return a - b;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "class Class2 { \r\n" +
                "public:\r\n" +
                "    Class1 c1;\r\n" +
                "    int Calculate(int x, int y) {\r\n" +
                "        return x + c1.Add(x, y);\r\n" +
                "    }\r\n" +
                "    int Compute(int p, int q) {\r\n" +
                "        return p - c1.Subtract(p, q);\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    Class2 c2;\r\n" +
                "    //MInline: c2.Calculate(10, 5)\r\n" +
                "    int res; {\r\n" +
                "        res = 10 + c1.Add(10, 5);\r\n" +
                "    }\r\n" +
                "    int result1 = res;\r\n" +
                "    int result2 = c2.Compute(20, 8);\r\n" +
                "    std::cout << \"Result 1: \" << result1 << std::endl;\r\n" +
                "    std::cout << \"Result 2: \" << result2 << std::endl;\r\n" +
                "    return 0;\r\n" +
                "};";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod9() {
            Refactor refactor = new Refactor();

            string method_call = "IsPrime(i)";

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

            string returned_var = "boolRes";

            int id = 161;

            string res =
                "class DataProcessor { public:\r\n" +
                "    int ProcessData(int data) {\r\n" +
                "        int result = 0;\r\n" +
                "        if (data > 0) for (int i = 1; i <= data; ++i) {\r\n" +
                "            //MInline: IsPrime(i);\r\n" +
                "            bool boolRes; {\r\n" +
                "                if (i <= 1) boolRes = false;\r\n" +
                "                for (int i_ = 2; i * i_ <= i; ++i_)\r\n" +
                "                    if (i % i_ == 0) boolRes = false;\r\n" +
                "                boolRes = true;}\r\n" +
                "            if (boolRes) result += i;}\r\n" +
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

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod10() {
            Refactor refactor = new Refactor();

            string method_call = "processor.ProcessData(inputData)";

            string text =
                "class DataProcessor { \r\n" +
                "public:\r\n" +
                "    int ProcessData(int data) {\r\n" +
                "        int result = 0;\r\n" +
                "        if (data > 0) for (int i = 1; i <= data; ++i) {\r\n" +
                "            if (IsPrime(i)) \r\n" +
                "                result += i;\r\n" +
                "        }\r\n" +
                "        else std::cerr << \"Error: Invalid input data.\" << std::endl;\r\n" +
                "        return result;\r\n" +
                "    }\r\n" +
                "\r\n" +
                "    bool IsPrime(int number) {\r\n" +
                "        if (number <= 1) return false; \r\n" +
                "        for (int i = 2; i * i <= number; ++i) \r\n" +
                "            if (number % i == 0) \r\n" +
                "                return false;\r\n" +
                "            return true;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    DataProcessor processor;\r\n" +
                "    int inputData = 10;\r\n" +
                "    int result = processor.ProcessData(inputData);\r\n" +
                "    std::cout << \"Result: \" << result << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string returned_var = "res";

            int id = 634;

            string res =
                "class DataProcessor { \r\n" +
                "public:\r\n" +
                "    int ProcessData(int data) {\r\n" +
                "        int result = 0;\r\n" +
                "        if (data > 0) for (int i = 1; i <= data; ++i) {\r\n" +
                "            if (IsPrime(i)) \r\n" +
                "                result += i;\r\n" +
                "        }\r\n" +
                "        else std::cerr << \"Error: Invalid input data.\" << std::endl;\r\n" +
                "        return result;\r\n" +
                "    }\r\n" +
                "\r\n" +
                "    bool IsPrime(int number) {\r\n" +
                "        if (number <= 1) return false; \r\n" +
                "        for (int i = 2; i * i <= number; ++i) \r\n" +
                "            if (number % i == 0) \r\n" +
                "                return false;\r\n" +
                "            return true;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "\r\n" +
                "int main() {\r\n" +
                "    DataProcessor processor;\r\n" +
                "    int inputData = 10;\r\n" +
                "    //MInline: processor.ProcessData(inputData)\r\n" +
                "    int res; {\r\n" +
                "        int result = 0;\r\n" +
                "        if (inputData > 0) for (int i = 1; i <= inputData; ++i) {\r\n" +
                "        if (IsPrime(i))\r\n" +
                "        result += i;\r\n" +
                "        }\r\n" +
                "        else std::cerr << \"Error: Invalid input inputData.\" << std::endl;\r\n" +
                "        res = result;\r\n" +
                "    }\r\n" +
                "    int result = res;\r\n" +
                "    std::cout << \"Result: \" << result << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.InlineMethod(text, id, method_call, returned_var));
        }
    }
}


