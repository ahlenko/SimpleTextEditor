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

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod2()
        {
            Refactor refactor = new Refactor();

            string old_name = "int";
            string new_name = "void";

            string text =
                "#include <iostream>\r\n" +
                "int main() {\r\n" +
                "    int arr[] = {64, 34, 25, 12, 22, 11, 90};\r\n" +
                "    int n = sizeof(arr) / sizeof(arr[0]);\r\n" +
                "    for (int i = 0; i < n; i++) {\r\n" +
                "        std::cout << arr[i] << \" \";\r\n" +
                "    }\r\n" +
                "    std::cout << std::endl;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "void main() {\r\n" +
                "    void arr[] = {64, 34, 25, 12, 22, 11, 90};\r\n" +
                "    void n = sizeof(arr) / sizeof(arr[0]);\r\n" +
                "    for (void i = 0; i < n; i++) {\r\n" +
                "        std::cout << arr[i] << \" \";\r\n" +
                "    }\r\n" +
                "    std::cout << std::endl;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod3()
        {
            Refactor refactor = new Refactor();

            string old_name = "bubbleSort(arr, n)";
            string new_name = "bubbleSort(mass, 100)";

            string text =
                "#include <iostream>\r\n" +
                "    bubbleSort(arr, n);\r\n" +
                "    for (int i = 0; i < n; i++) {\r\n" +
                "        std::cout << arr[i] << \" \";\r\n" +
                "    }\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "    bubbleSort(mass, 100);\r\n" +
                "    for (int i = 0; i < n; i++) {\r\n" +
                "        std::cout << arr[i] << \" \";\r\n" +
                "    }\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod4()
        {
            Refactor refactor = new Refactor();

            string old_name = "main()";
            string new_name = "main(int argc, char* argv[])";

            string text =
                "#include <iostream>\r\n" +
                "#include <fstream>\r\n" +
                "int main() {\r\n" +
                "    std::ofstream outputFile(\"example.txt\");\r\n" +
                "    if (!outputFile) {\r\n" +
                "        std::cerr << \"Could not open the file for writing\" << std::endl;\r\n" +
                "        return 1;\r\n" +
                "    }\r\n" +
                "    outputFile << \"This is an example of working with files in C++\" << std::endl;\r\n" +
                "    outputFile.close();\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "#include <fstream>\r\n" +
                "int main(int argc, char* argv[]) {\r\n" +
                "    std::ofstream outputFile(\"example.txt\");\r\n" +
                "    if (!outputFile) {\r\n" +
                "        std::cerr << \"Could not open the file for writing\" << std::endl;\r\n" +
                "        return 1;\r\n" +
                "    }\r\n" +
                "    outputFile << \"This is an example of working with files in C++\" << std::endl;\r\n" +
                "    outputFile.close();\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod5()
        {
            Refactor refactor = new Refactor();

            string old_name = "close()";
            string new_name = "is_open()";

            string text =
                "#include <iostream>\r\n" +
                "#include <fstream>\r\n" +
                "int main() {\r\n" +
                "    std::ifstream inputFile(\"example.txt\");\r\n" +
                "    if (!inputFile) {\r\n" +
                "        std::cerr << \"Could not open file for reading.\" << std::endl;\r\n" +
                "        return 1;\r\n" +
                "    }\r\n" +
                "    std::string line;\r\n" +
                "    while (std::getline(inputFile, line)) {\r\n" +
                "        std::cout << line << std::endl;\r\n" +
                "    }\r\n" +
                "    inputFile.close();\r\n" +
                "    return 0;\r\n" +
                "}";

            string res =
                "#include <iostream>\r\n" +
                "#include <fstream>\r\n" +
                "int main() {\r\n" +
                "    std::ifstream inputFile(\"example.txt\");\r\n" +
                "    if (!inputFile) {\r\n" +
                "        std::cerr << \"Could not open file for reading.\" << std::endl;\r\n" +
                "        return 1;\r\n" +
                "    }\r\n" +
                "    std::string line;\r\n" +
                "    while (std::getline(inputFile, line)) {\r\n" +
                "        std::cout << line << std::endl;\r\n" +
                "    }\r\n" +
                "    inputFile.is_open();\r\n" +
                "    return 0;\r\n" +
                "}";

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod6()
        {
            Refactor refactor = new Refactor();

            string old_name = "void insertionSort";
            string new_name = "int injectionSort";

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
                "int injectionSort(int arr[], int n) {\r\n" +
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

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod7()
        {
            Refactor refactor = new Refactor();

            string old_name = "displayInfo()";
            string new_name = "showInfo()";

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

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
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

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
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

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }

        [TestMethod] //--------------------------------------------------------------------
        public void TestMethod10()
        {
            Refactor refactor = new Refactor();

            string old_name = "calculateFactorial(int n)";
            string new_name = "computeFactorial(int n)";

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

            Assert.AreEqual(res, refactor.RenameMethod(text, old_name, new_name));
        }
    }
}
