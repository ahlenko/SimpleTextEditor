using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor {
    public class Refactor {

        public string RenameMethod(string text, string old_name, string new_name, bool comment)
        {
            // Розділимо текст на рядки для обробки кожного рядка окремо
            string[] lines = text.Split('\n');
            List<string> modifiedLines = new List<string>();

            bool isMultiLineComment = false; // Прапор, що вказує на багаторядковий коментар

            foreach (string line in lines)
            {
                // Перевіримо, чи рядок починається з багаторядкового коментаря "/*"
                if (line.Trim().StartsWith("/*"))
                {
                    isMultiLineComment = true;
                }

                // Перевіримо, чи рядок закінчується багаторядковим коментарем "*/"
                if (line.Trim().EndsWith("*/"))
                {
                    isMultiLineComment = false;
                }

                // Якщо рядок не є багаторядковим коментарем, то ми можемо перевірити, чи містить він оголошення методу
                if (!isMultiLineComment)
                {
                    // Перевіримо, чи містить рядок оголошення методу зі старою назвою
                    if (line.Contains(old_name + "("))
                    {
                        if (line.Trim().StartsWith("//")) //Перевіримо, чи є рядок однорядковим коментарем
                        {
                            if (comment) //Якщо чекбокс відмічений
                            {
                                // Замінимо стару назву на нову в рядку
                                string modifiedLine = line.Replace(old_name, new_name);
                                modifiedLines.Add(modifiedLine);
                            }
                            else
                            {
                                // Якщо чекбокс не відімчений - залишаємо однорядковий коментар без змін
                                modifiedLines.Add(line);
                            }
                        }
                        else
                        {
                            // Замінимо стару назву на нову в рядку
                            string modifiedLine = line.Replace(old_name, new_name);
                            modifiedLines.Add(modifiedLine);
                        }
                    }
                    else
                    {
                        // Якщо рядок не містить оголошення методу зі старою назвою, залишимо його без змін
                        modifiedLines.Add(line);
                    }
                }


                else
                { // Якщо рядок є багаторядковим коментарем
                    if (comment)
                    { //відмічений чекбокс-замінюємо стару назву
                        if (line.Contains(old_name + "("))
                        {
                            // Замінимо стару назву на нову в рядку
                            string modifiedLine = line.Replace(old_name, new_name);
                            modifiedLines.Add(modifiedLine);
                        }
                        else
                        {
                            // Якщо рядок не містить оголошення методу зі старою назвою, залишимо його без змін
                            modifiedLines.Add(line);
                        }
                    }
                    else
                    { //то додаємо його без змін
                        modifiedLines.Add(line);
                    }
                }
            }
            // Об'єднаємо модифіковані рядки назад у текст коду
            string modifiedText = string.Join("\n", modifiedLines);
            return modifiedText;
        }

        public string InlineMethod(string text, string name, string returned_var)
        {
            return "";
        }
    }
}
