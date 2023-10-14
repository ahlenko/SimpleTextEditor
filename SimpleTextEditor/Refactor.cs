using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
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
                } if (searchIndex == 0) return "Problem";
                else { foreach (string lines in classNames) {
                        if (text.Contains(lines + " " + OriginalClassName)) { 
                            OriginalClassName = lines; break; }
                    } if (OriginalClassName == name.Substring(0, name.IndexOf('.')))
                        return "Problem"; 
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
                segVar[id] = segVar[id].Trim();
                string st = s.Trim();
                string[] temp = st.Split(' '); segMetVar[id] = temp[temp.Length - 1]; id++;}

            id = 0; foreach(string s in segMetVar) {
                InsertedMethodText = InsertedMethodText.Replace(s, segVar[id]); id++; }

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
            foreach (string s in Inserted) 
                if (s.Length != 0) ReturnedCode += "    " + s + "\r\n";
            ReturnedCode += "}\r\n";
            ReturnedCode = "Test";

            return "";
        }
    }
}
