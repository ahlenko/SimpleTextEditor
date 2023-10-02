using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;

namespace EditorTesting
{

    [TestClass] //|-----------------------------------------------------------------------|
    public class RenameMethodTest
    {

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod1()
        {
            Refactor refactor = new Refactor();

            string old_name = "bubbleSort";
            string new_name = "ballSort";

            string text =
                "#include <iostream>\r\n" +
                "void bubbleSort(int arr[], int n) {\r\n" +
                "    for (int i = 0; i < n - 1; i++) {\r\n" +
                "        for (int j = 0; j < n - i - 1; j++) {\r\n" +
                "            if (arr[j] > arr[j + 1]) {\r\n" +
                "                int temp = arr[j];\r\n" +
                "                arr[j] = arr[j + 1];\r\n" +
                "                arr[j + 1] = temp;\r\n" +
                "            }\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "void ballSort(int arr[], int n) {\r\n" +
                "    for (int i = 0; i < n - 1; i++) {\r\n" +
                "        for (int j = 0; j < n - i - 1; j++) {\r\n" +
                "            if (arr[j] > arr[j + 1]) {\r\n" +
                "                int temp = arr[j];\r\n" +
                "                arr[j] = arr[j + 1];\r\n" +
                "                arr[j + 1] = temp;\r\n" +
                "            }\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod2()
        {
            Refactor refactor = new Refactor();

            string old_name = "Add";
            string new_name = "Plus";

            string text =
                "#include <iostream>\r\n" +
                "class MathUtils {\r\n" +
                "public:\r\n" +
                "    static int Add(int a, int b) {\r\n" +
                "        return a + b;\r\n" +
                "    }\r\n" +
                "int main() {\r\n" +
                "    int sum = MathUtils::Add(5, 3);\r\n" +
                "    std::cout << \"5 + 3 = \" << sum << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "class MathUtils {\r\n" +
                "public:\r\n" +
                "    static int Plus(int a, int b) {\r\n" +
                "        return a + b;\r\n" +
                "    }\r\n" +
                "int main() {\r\n" +
                "    int sum = MathUtils::Plus(5, 3);\r\n" +
                "    std::cout << \"5 + 3 = \" << sum << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod3()
        {
            Refactor refactor = new Refactor();

            string old_name = "popUpSort";
            string new_name = "bubbleSort";

            string text =
                "#include <iostream>\r\n" +
                "    popUpSort(arr, n);\r\n" +
                "    for (int i = 0; i < n; i++) {\r\n" +
                "        std::cout << arr[i] << \" \";\r\n" +
                "    }\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "    bubbleSort(arr, n);\r\n" +
                "    for (int i = 0; i < n; i++) {\r\n" +
                "        std::cout << arr[i] << \" \";\r\n" +
                "    }\r\n" +
                "    return 0;\r\n" +
                "}";


            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod4()
        {
            Refactor refactor = new Refactor();

            string old_name = "Square";
            string new_name = "Rectangle";

            string text =
                "#include <iostream>\r\n" +
                "class MathUtils {\r\n" +
                "public:\r\n" +
                "    static double Square(double x) {\r\n" +
                "        return x * x;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    double square = MathUtils::Square(4.0);\r\n" +
                "    std::cout << \"Square() of 4.0 is \" << square << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "class MathUtils {\r\n" +
                "public:\r\n" +
                "    static double Rectangle(double x) {\r\n" +
                "        return x * x;\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    double square = MathUtils::Rectangle(4.0);\r\n" +
                "    std::cout << \"Rectangle() of 4.0 is \" << square << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod5()
        {
            Refactor refactor = new Refactor();

            string old_name = "RemoveItem";
            string new_name = "DeleteItem";

            string text =
                "#include <iostream>\r\n" +
                "#include <vector>\r\n" +
                "class ShoppingCart {\r\n" +
                "public:\r\n" +
                "    void AddItem(const std::string& item) {\r\n" +
                "        items_.push_back(item);\r\n" +
                "    }\r\n" +
                "    void RemoveItem(const std::string& item) {\r\n" +
                "        for (auto it = items_.begin(); it != items_.end(); ++it) {\r\n" +
                "            if (*it == item) {\r\n" +
                "                items_.erase(it);\r\n" +
                "                break;\r\n" +
                "            }\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "    void DisplayCart() {\r\n" +
                "        std::cout << \"Shopping Cart Contents:\" << std::endl;\r\n" +
                "        for (const std::string& item : items_) {\r\n" +
                "            std::cout << \"- \" << item << std::endl;\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::vector<std::string> items_;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    ShoppingCart myCart;\r\n" +
                "    myCart.AddItem(\"Item 1\");\r\n" +
                "    myCart.AddItem(\"Item 2\");\r\n" +
                "    myCart.AddItem(\"Item 3\");\r\n" +
                "    myCart.DisplayCart();\r\n" +
                "    myCart.RemoveItem(\"Item 2\");\r\n" +
                "    std::cout << \"After removing Item 2:\" << std::endl;\r\n" +
                "    myCart.DisplayCart();\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "#include <vector>\r\n" +
                "class ShoppingCart {\r\n" +
                "public:\r\n" +
                "    void AddItem(const std::string& item) {\r\n" +
                "        items_.push_back(item);\r\n" +
                "    }\r\n" +
                "    void DeleteItem(const std::string& item) {\r\n" +
                "        for (auto it = items_.begin(); it != items_.end(); ++it) {\r\n" +
                "            if (*it == item) {\r\n" +
                "                items_.erase(it);\r\n" +
                "                break;\r\n" +
                "            }\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "    void DisplayCart() {\r\n" +
                "        std::cout << \"Shopping Cart Contents:\" << std::endl;\r\n" +
                "        for (const std::string& item : items_) {\r\n" +
                "            std::cout << \"- \" << item << std::endl;\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::vector<std::string> items_;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    ShoppingCart myCart;\r\n" +
                "    myCart.AddItem(\"Item 1\");\r\n" +
                "    myCart.AddItem(\"Item 2\");\r\n" +
                "    myCart.AddItem(\"Item 3\");\r\n" +
                "    myCart.DisplayCart();\r\n" +
                "    myCart.DeleteItem(\"Item 2\");\r\n" +
                "    std::cout << \"After removing Item 2:\" << std::endl;\r\n" +
                "    myCart.DisplayCart();\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod6()
        {
            Refactor refactor = new Refactor();

            string old_name = "insertionSort";
            string new_name = "injectionSort";

            string text =
                "#include <iostream>\r\n" +
                "void insertionSort(int arr[], int n) {\r\n" +
                "    for (int i = 1; i < n; i++) {\r\n" +
                "        int key = arr[i];\r\n" +
                "        int j = i - 1;\r\n" +
                "        while (j >= 0 && arr[j] > key) {\r\n" +
                "            arr[j + 1] = arr[j];\r\n" +
                "            j--;\r\n" +
                "        }\r\n" +
                "        arr[j + 1] = key;\r\n" +
                "    }\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "void injectionSort(int arr[], int n) {\r\n" +
                "    for (int i = 1; i < n; i++) {\r\n" +
                "        int key = arr[i];\r\n" +
                "        int j = i - 1;\r\n" +
                "        while (j >= 0 && arr[j] > key) {\r\n" +
                "            arr[j + 1] = arr[j];\r\n" +
                "            j--;\r\n" +
                "        }\r\n" +
                "        arr[j + 1] = key;\r\n" +
                "    }\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod7()
        {
            Refactor refactor = new Refactor();

            string old_name = "displayInfo";
            string new_name = "showInfo";

            string text =
                "#include <iostream>\r\n" +
                "#include <string>\r\n" +
                "class Student {\r\n" +
                "public:\r\n" +
                "    Student(std::string firstName, std::string lastName, int age, double gpa)\r\n" +
                "        : firstName_(firstName), lastName_(lastName), age_(age), gpa_(gpa) {\r\n" +
                "    }\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Ім'я: \" << firstName_ << \" \" << lastName_ << std::endl;\r\n" +
                "        std::cout << \"Вік: \" << age_ << \" років\" << std::endl;\r\n" +
                "        std::cout << \"Середній бал: \" << gpa_ << std::endl;\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::string firstName_;\r\n" +
                "    std::string lastName_;\r\n" +
                "    int age_;\r\n" +
                "    double gpa_;\r\n" +
                "};";

            string res =
                "#include <iostream>\r\n" +
                "#include <string>\r\n" +
                "class Student {\r\n" +
                "public:\r\n" +
                "    Student(std::string firstName, std::string lastName, int age, double gpa)\r\n" +
                "        : firstName_(firstName), lastName_(lastName), age_(age), gpa_(gpa) {\r\n" +
                "    }\r\n" +
                "    void showInfo() {\r\n" +
                "        std::cout << \"Ім'я: \" << firstName_ << \" \" << lastName_ << std::endl;\r\n" +
                "        std::cout << \"Вік: \" << age_ << \" років\" << std::endl;\r\n" +
                "        std::cout << \"Середній бал: \" << gpa_ << std::endl;\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::string firstName_;\r\n" +
                "    std::string lastName_;\r\n" +
                "    int age_;\r\n" +
                "    double gpa_;\r\n" +
                "};";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod8()
        {
            Refactor refactor = new Refactor();

            string old_name = "add";
            string new_name = "append";

            string text =
                "#include <iostream>\r\n" +
                "double add(double a, double b) {\r\n" +
                "    return a + b;\r\n" +
                "}\r\n" +
                "int main() {\r\n" +
                "    double num1, num2;\r\n" +
                "    std::cout << \"Введіть перше число: \";\r\n" +
                "    std::cin >> num1;\r\n" +
                "    std::cout << \"Введіть друге число: \";\r\n" +
                "    std::cin >> num2;\r\n" +
                "    double sum = add(num1, num2);\r\n" +
                "    std::cout << \"Сума чисел \" << num1 << \" і \" << num2 << \" дорівнює \" << sum << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "double append(double a, double b) {\r\n" +
                "    return a + b;\r\n" +
                "}\r\n" +
                "int main() {\r\n" +
                "    double num1, num2;\r\n" +
                "    std::cout << \"Введіть перше число: \";\r\n" +
                "    std::cin >> num1;\r\n" +
                "    std::cout << \"Введіть друге число: \";\r\n" +
                "    std::cin >> num2;\r\n" +
                "    double sum = append(num1, num2);\r\n" +
                "    std::cout << \"Сума чисел \" << num1 << \" і \" << num2 << \" дорівнює \" << sum << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod9()
        {
            Refactor refactor = new Refactor();

            string old_name = "raiseSalary";
            string new_name = "increaseSalary";

            string text =
                "#include <iostream>\r\n" +
                "#include <string>\r\n" +
                "class Employee {\r\n" +
                "public:\r\n" +
                "    Employee(std::string name, int id, double salary)\r\n" +
                "        : name_(name), id_(id), salary_(salary) {\r\n" +
                "    }\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Працівник: \" << name_ << std::endl;\r\n" +
                "        std::cout << \"ID: \" << id_ << std::endl;\r\n" +
                "        std::cout << \"Зарплата: \" << salary_ << \" грн\" << std::endl;\r\n" +
                "    }\r\n" +
                "    void raiseSalary(double percent) {\r\n" +
                "        salary_ *= (1 + percent / 100);\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::string name_;\r\n" +
                "    int id_;\r\n" +
                "    double salary_;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    Employee employee(\"Іван Петров\", 101, 5000.0);\r\n" +
                "    std::cout << \"Інформація про працівника:\" << std::endl;\r\n" +
                "    employee.displayInfo();\r\n" +
                "    employee.raiseSalary(10);\r\n" +
                "    std::cout << \"\\nОновлена інформація про працівника:\" << std::endl;\r\n" +
                "    employee.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "#include <string>\r\n" +
                "class Employee {\r\n" +
                "public:\r\n" +
                "    Employee(std::string name, int id, double salary)\r\n" +
                "        : name_(name), id_(id), salary_(salary) {\r\n" +
                "    }\r\n" +
                "    void displayInfo() {\r\n" +
                "        std::cout << \"Працівник: \" << name_ << std::endl;\r\n" +
                "        std::cout << \"ID: \" << id_ << std::endl;\r\n" +
                "        std::cout << \"Зарплата: \" << salary_ << \" грн\" << std::endl;\r\n" +
                "    }\r\n" +
                "    void increaseSalary(double percent) {\r\n" +
                "        salary_ *= (1 + percent / 100);\r\n" +
                "    }\r\n" +
                "private:\r\n" +
                "    std::string name_;\r\n" +
                "    int id_;\r\n" +
                "    double salary_;\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    Employee employee(\"Іван Петров\", 101, 5000.0);\r\n" +
                "    std::cout << \"Інформація про працівника:\" << std::endl;\r\n" +
                "    employee.displayInfo();\r\n" +
                "    employee.increaseSalary(10);\r\n" +
                "    std::cout << \"\\nОновлена інформація про працівника:\" << std::endl;\r\n" +
                "    employee.displayInfo();\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod10()
        {
            Refactor refactor = new Refactor();

            string old_name = "calculateFactorial";
            string new_name = "computeFactorial";

            string text =
                "#include <iostream>\r\n" +
                "class FactorialCalculator {\r\n" +
                "public:\r\n" +
                "    int calculateFactorial(int n) {\r\n" +
                "        if (n <= 0) {\r\n" +
                "            return 1;\r\n" +
                "        } else {\r\n" +
                "            int result = 1;\r\n" +
                "            for (int i = 1; i <= n; ++i) {\r\n" +
                "                result *= i;\r\n" +
                "            }\r\n" +
                "            return result;\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    FactorialCalculator calculator;\r\n" +
                "    int num;\r\n" +
                "    std::cout << \"Введіть число: \";\r\n" +
                "    std::cin >> num;\r\n" +
                "    int factorial = calculator.calculateFactorial(num);\r\n" +
                "    std::cout << \"Факторіал числа \" << num << \" дорівнює \" << factorial << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "class FactorialCalculator {\r\n" +
                "public:\r\n" +
                "    int computeFactorial(int n) {\r\n" +
                "        if (n <= 0) {\r\n" +
                "            return 1;\r\n" +
                "        } else {\r\n" +
                "            int result = 1;\r\n" +
                "            for (int i = 1; i <= n; ++i) {\r\n" +
                "                result *= i;\r\n" +
                "            }\r\n" +
                "            return result;\r\n" +
                "        }\r\n" +
                "    }\r\n" +
                "};\r\n" +
                "int main() {\r\n" +
                "    FactorialCalculator calculator;\r\n" +
                "    int num;\r\n" +
                "    std::cout << \"Введіть число: \";\r\n" +
                "    std::cin >> num;\r\n" +
                "    int factorial = calculator.computeFactorial(num);\r\n" +
                "    std::cout << \"Факторіал числа \" << num << \" дорівнює \" << factorial << std::endl;\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name, false));
        }
    }
}