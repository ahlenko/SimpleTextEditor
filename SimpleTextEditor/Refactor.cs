using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleTextEditor {
    public class Refactor {
        public string RenameMethod(string text, string old_name, string new_name, bool comment) {
            // Розділимо текст на рядки для обробки кожного рядка окремо
            string[] lines = text.Split('\n');
            List<string> modifiedLines = new List<string>();

            bool isMultiLineComment = false; // Прапор, що вказує на багаторядковий коментар

            foreach (string line in lines) {
                // Перевіримо, чи рядок починається з багаторядкового коментаря "/*"
                if (line.Trim().StartsWith("/*")) isMultiLineComment = true;
                
                // Перевіримо, чи рядок закінчується багаторядковим коментарем "*/"
                if (line.Trim().EndsWith("*/")) isMultiLineComment = false;
                
                // Якщо рядок не є багаторядковим коментарем, то ми можемо перевірити, чи містить він оголошення методу
                if (!isMultiLineComment) {
                    // Перевіримо, чи містить рядок оголошення методу зі старою назвою
                    if (line.Contains(old_name + "(")) {
                        if (line.Trim().StartsWith("//")) {//Перевіримо, чи є рядок однорядковим коментарем
                            if (comment) {//Якщо чекбокс відмічений
                                // Замінимо стару назву на нову в рядку
                                string modifiedLine = line.Replace(old_name, new_name);
                                modifiedLines.Add(modifiedLine);
                            } else { // Якщо чекбокс не відімчений - залишаємо однорядковий коментар без змін
                                modifiedLines.Add(line);
                            }
                        } else {
                            // Замінимо стару назву на нову в рядку
                            string modifiedLine = line.Replace(old_name, new_name);
                            modifiedLines.Add(modifiedLine);
                        }
                    } else {
                        // Якщо рядок не містить оголошення методу зі старою назвою, залишимо його без змін
                        modifiedLines.Add(line);
                    }
                } else { // Якщо рядок є багаторядковим коментарем
                    if (comment) { //відмічений чекбокс-замінюємо стару назву
                        if (line.Contains(old_name + "(")) {
                            // Замінимо стару назву на нову в рядку
                            string modifiedLine = line.Replace(old_name, new_name);
                            modifiedLines.Add(modifiedLine);
                        } else {
                            // Якщо рядок не містить оголошення методу зі старою назвою, залишимо його без змін
                            modifiedLines.Add(line);
                        }
                    } else { //то додаємо його без змін
                        modifiedLines.Add(line);
                    }
                }
            } // Об'єднаємо модифіковані рядки назад у текст коду
            string modifiedText = string.Join("\n", modifiedLines);
            return modifiedText;
        }

        public string InlineMethod(string text, int selectionStart, string name, string returned_var) {
            string pattern = @"\(([^)]*)\)"; string Variables = "";
            MatchCollection matches = Regex.Matches(name, pattern);
            if (matches.Count > 0) Variables = matches[0].Groups[1].Value;

            string OriginalClassName = name.Substring(0, name.IndexOf('.'));
            if (!text.Contains("class " + OriginalClassName)) {
                LinkedList<string> classNames = new LinkedList<string>();
                int searchIndex = 0; string subStr = text;
                bool terminate = false; while (!terminate) {
                    int index = subStr.IndexOf("class");
                    if (index != -1) { string nameCl = ""; int i = 0;
                        subStr = subStr.Substring(index + "class ".Length);
                        while (subStr[i] != ' ' && subStr[i] != '{') { nameCl += subStr[i]; i++; }
                        classNames.AddLast(nameCl); searchIndex += 1;
                    } else terminate = true;
                } if (searchIndex == 0) return "Worning! Not allowed to inline method." +
                        "\n Methot description not found";
                else { foreach (string lines in classNames) {
                        if (text.Contains(lines + " " + OriginalClassName)) {
                            OriginalClassName = lines; break; }
                    } if (OriginalClassName == name.Substring(0, name.IndexOf('.')))
                        return "Worning! Not allowed to inline method." +
                            "\n Methot description not found"; 
                }
            }

            int id; string ClassDeclaratoin = "class " + OriginalClassName;
            int index2 = text.IndexOf(ClassDeclaratoin); 
            id = index2 += ClassDeclaratoin.Length;
            
            do { ClassDeclaratoin += text[id]; id++; } 
            while (text[id] != '{'); ClassDeclaratoin += '{';
            int cordsLevel = 1; while (cordsLevel != 0) {
                id++; if (text[id] == '{') cordsLevel++;
                if (text[id] == '}') cordsLevel--;
                ClassDeclaratoin += text[id];}
            
            string MethodName = ""; index2 = name.IndexOf('.') + 1;
            while (name[index2] != '(') { MethodName += name[index2]; index2++;}

            string InsertedMethodText = "";
            id = ClassDeclaratoin.IndexOf(MethodName);
            do { id++; } while (ClassDeclaratoin[id] != '{');
            cordsLevel = 1; while (cordsLevel != 0){
                id++; if (ClassDeclaratoin[id] == '{') cordsLevel++;
                if (ClassDeclaratoin[id] == '}') cordsLevel--;
                InsertedMethodText += ClassDeclaratoin[id];
            } InsertedMethodText = InsertedMethodText.Remove(
                InsertedMethodText.Length - 1);

            string MethodVariables = "";
            id = ClassDeclaratoin.IndexOf(MethodName);
            do { id++; } while (ClassDeclaratoin[id] != '(');
            cordsLevel = 1; while (cordsLevel != 0) {
                id++; if (ClassDeclaratoin[id] == '(') cordsLevel++;
                if (ClassDeclaratoin[id] == ')') cordsLevel--;
                MethodVariables += ClassDeclaratoin[id];
            } MethodVariables = MethodVariables.Remove(
                MethodVariables.Length - 1);

            string ReturnMethodType = "";
            id = ClassDeclaratoin.IndexOf(MethodName);
            do { id--; } while (ClassDeclaratoin[id] != ' '); id--;
            while (ClassDeclaratoin[id] != ' ') { id--;} id++;
            while (ClassDeclaratoin[id] != ' ') { 
                ReturnMethodType += ClassDeclaratoin[id]; id++;}

            string[] segMetVar = MethodVariables.Split(',');
            string[] segVar = Variables.Split(',');

            
            id = 0; foreach (string s in segMetVar) {
                if (s.Length > 0) { 
                    segVar[id] = segVar[id].Trim(); string st = s.Trim();
                    string[] temp = st.Split(' '); segMetVar[id] = temp[temp.Length - 1]; id++;
                }
            } id = 0; foreach (string s in segMetVar) {
                if (s.Length > 0)
                InsertedMethodText = InsertedMethodText.Replace(s, segVar[id]); id++;
            }
            
            
            if (returned_var != "_") 
                InsertedMethodText = InsertedMethodText.Replace("return ", returned_var + " = ");
            else 
                InsertedMethodText = InsertedMethodText.Replace("return", "");

            string[] Inserted = InsertedMethodText.Split('\r');
            foreach (string s in Inserted) {
                id = Array.IndexOf(Inserted, s); 
                if (s.Contains("\n")) Inserted[id] = s.Replace("\n", ""); 
                Inserted[id] = Inserted[id].Trim();}
            
            string ReturnedCode = "//MInline: " + name;
            if (returned_var != "_")
                ReturnedCode += "\r\n" + ReturnMethodType + " " + returned_var + "; {\r\n";
            else ReturnedCode += "{\r\n";
            foreach (string s in Inserted) 
                if (s.Length != 0) ReturnedCode += "    " + s + "\r\n";
            ReturnedCode += "}\r\n";

            string LineWithMethodColl = ""; 
            int spaces = 0; id = selectionStart;  
            while (text[id] != '\n') { id--; } id++; 
            while (text[id] == ' ') { id++; spaces++; }
            while (text[id] != '\r') { LineWithMethodColl += text[id]; id++; }

            string line = LineWithMethodColl;
            if (returned_var != "_")
                LineWithMethodColl = LineWithMethodColl.Replace(name, returned_var);
            else LineWithMethodColl = LineWithMethodColl.Replace(name + ";\r\n", "");

            string sp = ""; while (spaces != 0) { sp += " "; spaces--; };
            ReturnedCode = ReturnedCode.Replace("\n", "\n" + sp);
            ReturnedCode += LineWithMethodColl;

            ReturnedCode = text.Replace(line, ReturnedCode);
            return ReturnedCode;
        }

        public String ExtractMethod(String src, String methodName, int regionStart, int regionEnd)
        {
            // Check for valid input
            if (string.IsNullOrEmpty(src) || string.IsNullOrEmpty(methodName)
                || regionStart >= src.Length || regionEnd < regionStart)

            {
                return src;
            }

            string extractedCode = src.Substring(regionStart, regionEnd - regionStart);

            if (extractedCode.Last().CompareTo(';') != 0)
            {
                return src;
            }

            List<Tuple<string, string, string, int>> variables =
                FindVariables(src, regionStart, regionEnd);
            if (variables.Count == 0)
            {
                return src;
            }


            string[] extractedLines = extractedCode.Split('\n');
            string lastLine = extractedLines[extractedLines.Length - 1];
            Array.Resize(ref extractedLines, extractedLines.Length - 1);
            string modifiedExtracted = string.Join("\n", extractedLines);
            if (modifiedExtracted.Length > 0)
            {
                modifiedExtracted += "\n";
            }

            Tuple<string, string, string, int> returnVariable = Tuple.Create("", "", "", 0);

            // TODO: check if this variable really need to be returned
            if (variables.Any())
            {
                returnVariable = variables.Last();
                variables.RemoveAt(variables.Count - 1);
            }

            string methodBody = $"{modifiedExtracted}" +
                $"return {returnVariable.Item3};";

            string leftPart = src.Substring(0, regionStart);
            string rightPart = src.Substring(regionEnd);

            string methodArguments = "";
            string methodArgumentsDef = "";
            foreach (Tuple<string, string, string, int> var in variables)
            {
                if (var.Item4 < regionStart)
                {
                    methodArguments += methodArguments.Length == 0 ? $"{var.Item1}" : $", {var.Item1}";

                    Match match = Regex.Match(extractedCode, $"{var.Item1}\\s*=");
                    if (match.Success)
                    {
                        methodArgumentsDef +=
                            methodArgumentsDef.Length == 0 ? $"{var.Item2} &{var.Item1}" : $", {var.Item2} &{var.Item1}";
                    }
                    else
                    {
                        methodArgumentsDef +=
                            methodArgumentsDef.Length == 0 ? $"{var.Item2} {var.Item1}" : $", {var.Item2} {var.Item1}";
                    }
                }
            }
            string variableTypeInCall =
                returnVariable.Item2 != "" && lastLine.Contains(returnVariable.Item2) ? returnVariable.Item2 + " " : "";
            string methodCall =
                $"{variableTypeInCall}{returnVariable.Item1} = {methodName}({methodArguments});";

            string modifiedSrc = leftPart + methodCall + rightPart;

            string returnType = returnVariable.Item2;

            string result = $"{returnType} {methodName}({methodArgumentsDef}) {{\r\n" +
                $"{methodBody}\r\n" +
                $"}}\r\n\r\n" +
                $"{modifiedSrc}";
            return result;
        }

        private List<Tuple<string, string, string, int>>
            FindVariables(string src, int regionStart, int regionEnd)
        {
            List<Tuple<string, string, string, int>> variables =
                new List<Tuple<string, string, string, int>>();

            string region = src.Substring(regionStart, regionEnd - regionStart);

            string patternForAllDeclarations = @"\b(?:(?<type>(?!return)[\w:<>]+)\s+(?<variables>\w+(?:\s*,\s*\w+)*))(\s*;)?";
            MatchCollection matchesVariables = Regex.Matches(src, patternForAllDeclarations);

            string patternNamesInRegion = @"(?<name>[_a-zA-Z][_a-zA-Z0-9]*)";
            MatchCollection matchNamesInRegion = Regex.Matches(region, patternNamesInRegion);

            foreach (Match nameInRegion in matchNamesInRegion)
            {
                foreach (Match var in matchesVariables)
                {
                    string names = var.Groups["variables"].Value;
                    string type = var.Groups["type"].Value;
                    string[] namesSplit = names.Split(',').Select(p => p.Trim()).ToArray();
                    foreach (string name in namesSplit)
                    {
                        if (name != nameInRegion.Groups["name"].Value) continue;

                        var result = variables.FirstOrDefault(t => t.Item1 == name);
                        if (result == null)
                        {
                            variables.Add(Tuple.Create(name, type, "", var.Index));
                        }
                    }
                }
            }

            string pattern = @"\b(?<name>\w+)\s*=\s*(?<value>.+?);";
            MatchCollection matchesValues = Regex.Matches(region, pattern);
            foreach (Match match in matchesValues)
            {
                string name = match.Groups["name"].Value;
                string value = match.Groups["value"].Value;
                var result = variables.FirstOrDefault(t => t.Item1 == name);
                if (result != null)
                {
                    variables.Remove(result);
                    variables.Add(Tuple.Create(result.Item1, result.Item2, value, result.Item4));
                }
            }


            return variables;
        }


        public string ChangeNum(string origin, string constName, int magicNum)
        {
            string pattern = @"(?<![0-9'])\b" + magicNum + @"\b(?!')"; // Паттерн для пошуку магічних чисел
            Regex regex = new Regex(pattern);
            // Перевірка, чи константа constName коректна
            if (!IsValidConstantName(constName))
            {
                return origin;
            }
            // Перевірка, чи константа constName не міститься в рядках як змінна
            string[] lines = origin.Split('\n');


            foreach (string line in lines)
            {
                if (line.Contains(constName + " "))
                {
                    return origin; // Повертаємо вихідний рядок, оскільки constName вже використовується як змінна
                }
            }

            string[] parts = origin.Split('\n');

            bool constAdded = false; // Флаг, який вказує, чи об'явлення константи вже було додано
            for (int i = 0; i < parts.Length; i++)
            {
                MatchCollection matches = regex.Matches(parts[i]);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        if (!IsPartOfVariable(parts[i], match.Index) &&
                            !IsPartOfOtherNumber(parts[i], match.Index, match.Length) &&
                            !IsInsideComments(parts[i], magicNum) &&
                            !IsInsideQuotes(parts[i], magicNum))
                        {
                            // Замінюємо магічне число на constName
                            parts[i] = regex.Replace(parts[i], constName);
                            // Додаємо об'явлення константи як перший елемент масиву parts
                            if (!constAdded)
                            {
                                Array.Resize(ref parts, parts.Length + 1);
                                Array.Copy(parts, 0, parts, 1, parts.Length - 1);
                                parts[0] = $"const int {constName} = {magicNum}";
                                constAdded = true;
                            }
                        }
                    }
                }
            }
            return string.Join("\n", parts);
        }

        private bool IsPartOfVariable(string line, int index)
        {
            // Перевіряє, чи число є частиною змінної
            // Тут ви можете визначити власні правила для того, що вважати змінною
            // Наприклад, якщо ви знаєте, що змінні завжди починаються з літери, то ви можете використовувати регулярний вираз для перевірки
            // У цьому прикладі просто перевіряємо, чи перед числом є пробіл або початок рядка
            if (index > 0 && !char.IsWhiteSpace(line[index - 1]))
            {
                return true;
            }
            return false;
        }

        private bool IsPartOfOtherNumber(string line, int index, int length)
        {
            // Перевіряє, чи число є частиною іншого числа
            // В даному випадку, ми шукаємо будь-які цифри перед і після збігу
            string numberPattern = @"\d+";
            string lineSubstring = line.Substring(index, length);

            // Знаходимо числа перед і після збігу
            MatchCollection matches = Regex.Matches(lineSubstring, numberPattern);

            foreach (Match match in matches)
            {
                if (match.Index != 0 && match.Index + match.Length != lineSubstring.Length)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInsideQuotes(string line, int magicNum)
        {
            // Перевіряє, чи число знаходиться між лапками в строці
            string pattern = @"([""'])(?:(?=(\\?))\2.)*?\1";
            MatchCollection matches = Regex.Matches(line, pattern);

            foreach (Match match in matches)
            {
                if (match.Index < line.IndexOf(magicNum.ToString()) && line.IndexOf(magicNum.ToString()) < match.Index + match.Length)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInsideComments(string line, int magicNum)
        {
            // Перевіряє, чи число знаходиться після початку коментаря в строці
            int commentStartIndex = line.IndexOf("//");
            int commentStartIndex2 = line.IndexOf("/*");

            if ((commentStartIndex >= 0 && line.IndexOf(magicNum.ToString()) > commentStartIndex) ||
                (commentStartIndex2 >= 0 && line.IndexOf(magicNum.ToString()) > commentStartIndex2))
            {
                return true;
            }

            return false;
        }

        public bool IsValidConstantName(string name)
        {
            if (!char.IsLetter(name[0])) return false;

            foreach (var ch in name)
            {
                if (!char.IsLetterOrDigit(ch) && ch != '_') return false;
            }

            return true;
        }
    }
}
