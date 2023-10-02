using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor {
    public class Refactor {
        public string RenameMethod(string text, string old_name, string new_name, bool comment) {
            // Розділимо текст на рядки для обробки кожного рядка окремо
            string[] lines = text.Split('\n');
            List<string> modifiedLines = new List<string>();

            foreach (string line in lines)
            {
                // Перевіримо, чи містить рядок оголошення методу зі старою назвою
                if (line.Contains(old_name + "("))
                {
                    // Замінимо стару назву на нову в рядку
                    string modifiedLine = line.Replace(old_name + "(", new_name + "(");

                    // Якщо було вказано, що слід змінювати коментарі, замінимо їх також
                    if (comment)
                    {
                        modifiedLine = modifiedLine.Replace("// " + old_name, "// " + new_name);
                    }

                    modifiedLines.Add(modifiedLine);
                }
                else
                {
                    // Якщо рядок не містить оголошення методу зі старою назвою, залишимо його без змін
                    modifiedLines.Add(line);
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
