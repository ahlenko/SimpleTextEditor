using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTextEditor;
using System;

namespace EditorTesting
{
    [TestClass]
    public class ExtractMethodTests
    {
        [TestMethod]
        public void SimpleExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int x = 23;\r\n" +
                "return x;\r\n" +
                "}";

            expectedResult = $"int {methodName}() {{\r\n" +
                "return 23;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                $"int x = {methodName}();\r\n" +
                "return x;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 14, 25);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RangeStartNotValid()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int x = 99;\r\n" +
                "return x;\r\n" +
                "}";

            expectedResult = "int main() {\r\n" +
                "int x = 99;\r\n" +
                "return x;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 19, 24);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RangeEndNotValid()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int x = 99;\r\n" +
                "return x;\r\n" +
                "}";

            expectedResult = "int main() {\r\n" +
                "int x = 99;\r\n" +
                "return x;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 13, 21);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FarTypeDefinitionExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int a;\r\n" +
                "int x = 3;\r\n" +
                "a = 5;\r\n" +
                "return a;\r\n" +
                "}";

            expectedResult = $"int {methodName}() {{\r\n" +
                "return 5;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                "int a;\r\n" +
                "int x = 3;\r\n" +
                $"a = {methodName}();\r\n" +
                "return a;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 34, 40);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TypeBehindVariablesExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int a, b, c, d;\r\n" +
                "a = 1;\r\n" +
                "b = 2;\r\n" +
                "c = 3;\r\n" +
                "d = 4;\r\n" +
                "return c;\r\n" +
                "}";

            expectedResult = $"int {methodName}() {{\r\n" +
                "return 3;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                "int a, b, c, d;\r\n" +
                "a = 1;\r\n" +
                "b = 2;\r\n" +
                $"c = {methodName}();\r\n" +
                "d = 4;\r\n" +
                "return c;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 47, 53);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ComplexReturnTypeExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "std::string y = \"some string\";\r\n" +
                "return y;\r\n" +
                "}";

            expectedResult = $"std::string {methodName}() {{\r\n" +
                "return \"some string\";\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                $"std::string y = {methodName}();\r\n" +
                "return y;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 14, 44);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SimpleArgumentsExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int x = 12;\r\n" +
                "int y = 32 + x;\r\n" +
                "return y;\r\n" +
                "}";

            expectedResult = $"int {methodName}(int x) {{\r\n" +
                "return 32 + x;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                "int x = 12;\r\n" +
                $"int y = {methodName}(x);\r\n" +
                "return y;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 27, 42);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MultipleArgumentsExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int a = 12;\r\n" +
                "float b = 43.3;\r\n" +
                "int c = 57;\r\n" +
                "float d = a * b - c;\r\n" +
                "return d;\r\n" +
                "}";

            expectedResult = $"float {methodName}(int a, float b, int c) {{\r\n" +
                "return a * b - c;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                "int a = 12;\r\n" +
                "float b = 43.3;\r\n" +
                "int c = 57;\r\n" +
                $"float d = {methodName}(a, b, c);\r\n" +
                "return d;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 57, 77);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MultilineExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "int a = 12;\r\n" +
                "int b = 43;\r\n" +
                "int c = 57;\r\n" +
                "int d = a * b - c;\r\n" +
                "return d;\r\n" +
                "}";

            expectedResult = $"int {methodName}(int a) {{\r\n" +
                "int b = 43;\r\n" +
                "int c = 57;\r\n" +
                "return a * b - c;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                "int a = 12;\r\n" +
                $"int d = {methodName}(a);\r\n" +
                "return d;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 27, 71);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ComplexMultilineExtraction()
        {
            string src, methodName, result, expectedResult;
            Refactor r = new Refactor();
            methodName = "ExtractedMethod";
            src = "int main() {\r\n" +
                "  int a, b, c;\r\n" +
                "  a = 12;\r\n" +
                "  b = a + 43;\r\n" +
                "  c = b + 57;\r\n" +
                "  a = c + b;\r\n" +
                "  int d = c * c;\r\n" +
                "  return d;\r\n" +
                "}";

            expectedResult = $"int {methodName}(int b, int &c, int &a) {{\r\n" +
                "  c = b + 57;\r\n" +
                "  a = c + b;\r\n" +
                "return c * c;\r\n" +
                "}\r\n\r\n" +
                "int main() {\r\n" +
                "  int a, b, c;\r\n" +
                "  a = 12;\r\n" +
                "  b = a + 43;\r\n" +
                $"int d = {methodName}(b, c, a);\r\n" +
                "  return d;\r\n" +
                "}";

            result = r.ExtractMethod(src, methodName, 56, 101);
            Assert.AreEqual(expectedResult, result);
        }
    }
}

