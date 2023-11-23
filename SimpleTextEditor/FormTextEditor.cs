using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleTextEditor {
    public partial class TextEditorView : Form {
        public TextEditorView() { InitializeComponent(); }

        Refactor refactor = new Refactor();

        // Шлях до оброблюваного файлу
        string filePath = "";

        // Розширення файлів
        string filter =
            "Текстові файли (*.txt)|*.txt|" +
            "Файли на мові С++ (*.cpp)|*.cpp";

        private int oldSearchPosition = 0;

        private int startSelected = 0;
        private int lenghtSelected = 0;
        private string origSelectedText = "";

        // Інтерфейс: файл відкрито
        void SetOpen() {
            InterfaceGroup.Visible = false;
            TextEditorWindow.Visible = true;
            ScrollEditor.Visible = true;

            MenuSave.Enabled = true;
            MenuSaveAS.Enabled = true;
            MenuClose.Enabled = true;
            MenuRefactor.Enabled = true;
            MenuView.Enabled = true;
            StatusRow.Visible = true;
            StatusChar.Visible = true;
        }

        // Інтерфейс: файл закрито
        void SetClose() {
            InterfaceGroup.Visible = true;
            TextEditorWindow.Visible = false;
            ScrollEditor.Visible = false;

            MenuSave.Enabled = false;
            MenuSaveAS.Enabled = false;
            MenuClose.Enabled = false;
            MenuRefactor.Enabled = false;
            MenuView.Enabled = false;
            StatusRow.Visible = false;
            StatusChar.Visible = false;
        }

        // Збереження файлу ...
        private void SaveMethod() {
            try { using (StreamWriter writer = new StreamWriter(filePath, false))
                    writer.Write(TextEditorWindow.Text);
                Console.WriteLine($"Текст було успішно записано в файл {filePath}.");
            } catch (Exception ex) {
                MessageBox.Show("Помилка запису файлу", "Помилка");
            }
        }

        // Збереження файлу в ...
        private void SaveAsMethod() {
            DSaveFile.Filter = filter;
            if (DSaveFile.ShowDialog(this) == DialogResult.OK)
                filePath = DSaveFile.FileName; SaveMethod();
        }

        // Тип відкриття файлу: створення/відкриття
        private void OpenMethod(bool itsSave) {
            DSaveFile.Filter = filter;
            if (itsSave) {
                if (DSaveFile.ShowDialog(this) == DialogResult.OK) { SetClose();
                    filePath = DSaveFile.FileName;
                    if (SelectOpenMethod() == 0) {
                        SetOpenAfterCreate();
                        SetOpen();
                    } else MessageBox.Show("Формат файлу не підтримується", "Помилка");
                }
            } else {
                if (DOpenFile.ShowDialog(this) == DialogResult.OK) {
                    SetClose();
                    filePath = DOpenFile.FileName;
                    if (SelectOpenMethod() == 0) {
                        SetOpenAfterOpen();
                        SetOpen();
                    } else MessageBox.Show("Формат файлу не підтримується", "Помилка");
                }
            }
        }

        // Визначення типу файлу
        private int SelectOpenMethod() {
            string fileExtension = Path.GetExtension(filePath).ToLower();
            switch (fileExtension) {
                case ".txt":
                case ".cpp":
                    return 0;
                default: return -1;
            }
        }

        // Відкриття файлу після створення
        private bool SetOpenAfterCreate() {
            try {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
                { fs.SetLength(0); return true; }
            } catch (Exception ex) {
                MessageBox.Show("Помилка створення файлу", "Помилка");
                return false;
            }
        }

        // Відкриття файлу після відкриття
        private bool SetOpenAfterOpen() {
            try {
                if (File.Exists(filePath))
                    using (StreamReader reader = new StreamReader(filePath)) {
                        TextEditorWindow.Text = reader.ReadToEnd();
                        UpdateVScrollBarMaximum(); return true; }
                else { MessageBox.Show("Файлу не існує", "Помилка"); return false; }
            } catch (Exception ex) {
                MessageBox.Show("Файлу не вдалося відкрити", "Помилка");
                return false;
            }
        }

        // Закриття файлу: зберегти зміни?
        void SetCloseMethod() {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете закрити файл без збереження змін?",
                "Запит", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                SaveMethod(); SetClose(); MessageBox.Show("Зміни збережено", "Повідомлення"); }
            else SetClose();
        }

        // Оновіть максимальне значення VScrollBar відповідно до кількості рядків у TextBox
        private void UpdateVScrollBarMaximum() =>
            ScrollEditor.Maximum = TextEditorWindow.GetLineFromCharIndex(TextEditorWindow.TextLength) + 1;

        private void UpdateRVScrollBarMaximum() =>
            RightScrollEditor.Maximum = RightTextBox.GetLineFromCharIndex(RightTextBox.TextLength) + 1;


        // Призначення деяких обробників інтерфейсу користувача
        private void OpenFileButton_Click(object sender, EventArgs e) => OpenMethod(false);
        private void CreateFileButton_Click(object sender, EventArgs e) => OpenMethod(true);
        private void MenuSave_Click(object sender, EventArgs e) => SaveMethod();
        private void MenuSaveAS_Click(object sender, EventArgs e) => SaveAsMethod();
        private void MenuClose_Click(object sender, EventArgs e) => SetCloseMethod();

        //Призначення обробників що відповідають за рефакторинг
        private void MenuRefactor_Click(object sender, EventArgs e) {
            string selectedText = TextEditorWindow.SelectedText;

            origSelectedText = selectedText; // Старий виділений текст (ім'я методу)
            startSelected = TextEditorWindow.SelectionStart; // Початок імені методу
            lenghtSelected = TextEditorWindow.SelectionLength; // Довжина імені методу

            // Далі те саме але для повного коду виклику методу

            MenuInlineMethod.Enabled = false;
            MenuRenameMethod.Enabled = false;

            int selectionEnd = TextEditorWindow.SelectionStart + TextEditorWindow.SelectionLength;

            if (!string.IsNullOrWhiteSpace(selectedText)) {
                if (isOnlyName(selectedText)) {
                    if (isMethodCall(selectedText)) {
                        MenuInlineMethod.Enabled = true;
                        MenuRenameMethod.Enabled = true;
                    } else if (isMethodDeclaration(selectedText)) {
                        MenuRenameMethod.Enabled = true;
                    }
                }              
            } 
        }

        // Це оголошення методу ?
        private bool isMethodDeclaration(string selectedText) {
            int nestingLevel = 1; int iteration = 0;
            while (nestingLevel > 0 || iteration > 1500) {
                TextEditorWindow.SelectionLength += 1;
                selectedText = TextEditorWindow.SelectedText;
                if (selectedText[selectedText.Length - 1] == '(') {
                    nestingLevel++; }
                else if (selectedText[selectedText.Length - 1] == ')') {
                    nestingLevel--; }
                iteration++; 
            } if (nestingLevel == 0) return true;
            else return false;
        }

        // Це виклик методу ?
        private bool isMethodCall(string selectedText) {
            TextEditorWindow.SelectionStart -= 1;
            selectedText = TextEditorWindow.SelectedText;
            if (selectedText[0] != '.') {TextEditorWindow.SelectionStart += 1; return false;}
            TextEditorWindow.SelectionStart += 1;
            selectedText = TextEditorWindow.SelectedText;
            int nestingLevel = 1; int iteration = 0;
            while (nestingLevel > 0 || iteration > 1500) {
                TextEditorWindow.SelectionLength += 1;
                selectedText = TextEditorWindow.SelectedText;
                if (selectedText[selectedText.Length - 1] == '(') {
                    nestingLevel++; }
                else if (selectedText[selectedText.Length - 1] == ')') {
                    nestingLevel--; }
                iteration++;
            } if (nestingLevel == 0) return true;
            else return false;
        }

        // Це ім'я методу ?
        private bool isOnlyName(string selectedText) {
            TextEditorWindow.SelectionLength += 1;
            selectedText = TextEditorWindow.SelectedText;
            string pattern = @"^[a-zA-Z_][a-zA-Z0-9_]*\($";
            return Regex.IsMatch(selectedText, pattern);
        }

        // Виклик функції перейменування методу
        private void MenuRenameMethod_Click(object sender, EventArgs e) {
            using (var customDialog = new RenameForm()) {
                customDialog.TextOld.Text = origSelectedText;
                if (customDialog.ShowDialog() == DialogResult.OK) {
                    string oldText = customDialog.TextOld.Text;
                    string newText = customDialog.TextNew.Text;
                    bool comments = customDialog.AddOptionActive.Checked;
                    RightTextBox.Text = refactor.RenameMethod(
                        TextEditorWindow.Text,
                        oldText, newText, comments);
                    UpdateRVScrollBarMaximum(); button1.Enabled = true;
                    MessageBox.Show("Метод " + oldText + " перейменовано на - " + newText, "Повідомлення");
                }
            }
        }

        // Виклик функції вбудови методу
        private void MenuInlineMethod_Click(object sender, EventArgs e) {
            string selectedText = TextEditorWindow.SelectedText;

            while (selectedText[0] != ' ') {
                TextEditorWindow.SelectionStart -= 1;
                TextEditorWindow.SelectionLength += 1;
                selectedText = TextEditorWindow.SelectedText;
            }

            TextEditorWindow.SelectionStart += 1;
            TextEditorWindow.SelectionLength -= 1;

            using (var customDialog = new InlineForm()) {
                customDialog.TextOld.Text = origSelectedText;
                string text = TextEditorWindow.Text;
                if (text.Contains("void " + origSelectedText) ||
                    text.Contains("void\t" + origSelectedText)){
                    customDialog.TextNew.Enabled = false;
                    customDialog.TextNew.Text = "_";         
                } if (customDialog.ShowDialog() == DialogResult.OK) {
                    string oldText = customDialog.TextOld.Text;
                    string newText = customDialog.TextNew.Text;
                    RightTextBox.Text = refactor.InlineMethod(
                        TextEditorWindow.Text, TextEditorWindow.SelectionStart,
                        TextEditorWindow.SelectedText, newText);
                    UpdateRVScrollBarMaximum(); button1.Enabled = true; 
                    MessageBox.Show("Метод " + oldText + " вбудовано до коду у місці виклику");
                }
            }
        }

        // Обробники масштабування
        private void MFontSizePlus_Click(object sender, EventArgs e) {
            if (TextEditorWindow.Font.Size < 20) { MFontSizeMinus.Enabled = true;
                TextEditorWindow.Font = new Font(
                    TextEditorWindow.Font.FontFamily,
                    TextEditorWindow.Font.Size + 1,
                    TextEditorWindow.Font.Style);
                UpdateVScrollBarMaximum(); }
            else MFontSizePlus.Enabled = false;
        }

        private void MFontSizeMinus_Click(object sender, EventArgs e) {
            if (TextEditorWindow.Font.Size > 5) { MFontSizePlus.Enabled = true;
                TextEditorWindow.Font = new Font(
                    TextEditorWindow.Font.FontFamily,
                    TextEditorWindow.Font.Size - 1,
                    TextEditorWindow.Font.Style);
                UpdateVScrollBarMaximum(); }
            else MFontSizeMinus.Enabled = false;
        }

        // Зміна позиції у TextBox за рахунок VSScrollBar
        private void ScrollEditor_Scroll(object sender, ScrollEventArgs e) {
            int scrollValue = ScrollEditor.Value;
            int textPosition = TextEditorWindow.GetFirstCharIndexFromLine(scrollValue);
            TextEditorWindow.SelectionStart = textPosition;
            TextEditorWindow.ScrollToCaret();
        }

        // Зміна позиції у TextBox за рахунок VSScrollBar
        private void ScrollEditorRight_Scroll(object sender, ScrollEventArgs e) {
            int scrollValue = ScrollEditor.Value;
            int textPosition = RightTextBox.GetFirstCharIndexFromLine(scrollValue);
            RightTextBox.SelectionStart = textPosition;
            RightTextBox.ScrollToCaret();
        }

        // Перерахунок кількості рядків VSScrollBar при зміні тексту TextBox
        private void TextEditorWindow_TextChanged(object sender, EventArgs e) {
            UpdateVScrollBarMaximum();
            int currentLineNumber = TextEditorWindow.GetLineFromCharIndex(TextEditorWindow.SelectionStart);
            int currentLinePosition = TextEditorWindow.SelectionStart - TextEditorWindow.GetFirstCharIndexFromLine(currentLineNumber);
            StatusRow.Text = "Рядок: " + currentLineNumber + 1;
            StatusChar.Text = "Символ: " + currentLinePosition + 1;
        }

        // Кнопка підтвердження рефакторингу (перенесення змін до головного вікна)
        private void button1_Click(object sender, EventArgs e) {
            TextEditorWindow.Text = RightTextBox.Text;
            RightTextBox.Text = "";
            button1.Enabled = false;
            SaveMethod();
        }
    }
}
