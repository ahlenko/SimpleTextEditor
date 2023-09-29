using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SimpleTextEditor {
    public partial class FormTextEditor : Form {
        public FormTextEditor() {InitializeComponent();}

        // Шлях до оброблюваного файлу
        string filePath = "";

        // Розширення файлів
        string filter = 
            "Текстові файли (*.txt)|*.txt|" +
            "Файли на мові С++ (*.cpp)|*.cpp";

        private SearchForm searchForm;
        private int oldSearchPosition = 0;

        // Інтерфейс: файл відкрито
        void SetOpen() {
            InterfaceGroup.Visible = false;
            TextEditorWindow.Visible = true;
            ScrollEditor.Visible = true;

            MenuSave.Enabled = true;
            MenuSaveAS.Enabled = true;
            MenuClose.Enabled = true;
            MenuRefactor.Enabled = true;
            MenuSearch.Enabled = true;
            MenuView.Enabled = true;
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
            MenuSearch.Enabled = false;
            MenuView.Enabled = false;
        }

        // Збереження файлу ...
        private void SaveMethod() {
            try {using (StreamWriter writer = new StreamWriter(filePath, false))
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
                    using (StreamReader reader = new StreamReader(filePath))
                    { TextEditorWindow.Text = reader.ReadToEnd(); return true; }
                else { MessageBox.Show("Файлу не існує", "Помилка"); return false; }
            } catch (Exception ex) {
                MessageBox.Show("Файлу не вдалося відкрити", "Помилка");
                return false;
            }
        }

        void SetCloseMethod() {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете закрити файл без збереження змін?",
                "Запит", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                SaveMethod(); SetClose(); MessageBox.Show("Зміни збережено", "Повідомлення");  }
            else SetClose();
        }

        // Призначення деяких обробників інтерфейсу користувача
        private void OpenFileButton_Click(object sender, EventArgs e) { OpenMethod(false);}
        private void CreateFileButton_Click(object sender, EventArgs e) { OpenMethod(true);}
        private void MenuSave_Click(object sender, EventArgs e) { SaveMethod();}
        private void MenuSaveAS_Click(object sender, EventArgs e) {SaveAsMethod();}
        private void MenuClose_Click(object sender, EventArgs e) {SetCloseMethod();}

        //Призначення обробників що відповідають за рефакторинг
        private void MenuRenameMethod_Click(object sender, EventArgs e) {}
        private void MenuInlineMethod_Click(object sender, EventArgs e) {}

        // Виклик дочірнього вікна пошуку
        private void MenuSearch_Click(object sender, EventArgs e) {
            searchForm = new SearchForm();
            searchForm.NextWord.Enabled = false;
            searchForm.PrewWord.Enabled = false;
            searchForm.Show();
        }

        // Обробники дочірнього вікна
        public void ClickSearch() {
            string searchText = searchForm.TextOld.Text;
            string textBoxText = TextEditorWindow.Text;

            int startIndex = textBoxText.IndexOf(searchText, oldSearchPosition, StringComparison.OrdinalIgnoreCase);

            if (startIndex != -1) { Activate();
                TextEditorWindow.Select(startIndex, searchText.Length);
                oldSearchPosition = startIndex + 1;
                searchForm.NextWord.Enabled = true;
                searchForm.PrewWord.Enabled = true;
            } else {
                MessageBox.Show("Збігів не виявлено", "Повідомлення");
                TextEditorWindow.SelectionStart = 0;
                TextEditorWindow.SelectionLength = 0;
                searchForm.NextWord.Enabled = false;
                searchForm.PrewWord.Enabled = false;
            }
        }

        public void ClickPrevious() {
            string searchText = searchForm.TextOld.Text;
            string textBoxText = TextEditorWindow.Text;

            int lastIndex = textBoxText.LastIndexOf(searchText, oldSearchPosition - 1, StringComparison.OrdinalIgnoreCase);

            if (lastIndex != -1) {
                Activate();
                TextEditorWindow.Select(lastIndex, searchText.Length);
                oldSearchPosition = lastIndex;
            } else {
                MessageBox.Show("Попереднє входження відсутнє", "Повідомлення");
                TextEditorWindow.SelectionStart = 0;
                TextEditorWindow.SelectionLength = 0;
            }
        }

        public void ClickNext() {
            string searchText = searchForm.TextOld.Text;
            string textBoxText = TextEditorWindow.Text;

            int startIndex = textBoxText.IndexOf(searchText, oldSearchPosition, StringComparison.OrdinalIgnoreCase);

            if (startIndex != -1) { Activate();
                TextEditorWindow.Select(startIndex, searchText.Length);
                oldSearchPosition = startIndex + 1;
            } else {
                MessageBox.Show("Наступне входження відсутнє", "Повідомлення");
                TextEditorWindow.SelectionStart = 0;
                TextEditorWindow.SelectionLength = 0;
            }
        }

        // Обробники масштабування
        private void MFontSizePlus_Click(object sender, EventArgs e) {
            if (TextEditorWindow.Font.Size < 20) { MFontSizeMinus.Enabled = true;
                TextEditorWindow.Font = new Font(
                    TextEditorWindow.Font.FontFamily,
                    TextEditorWindow.Font.Size + 1,
                    TextEditorWindow.Font.Style);}    
            else MFontSizePlus.Enabled = false;
        }

        private void MFontSizeMinus_Click(object sender, EventArgs e) {
            if (TextEditorWindow.Font.Size > 5) { MFontSizePlus.Enabled = true;
                TextEditorWindow.Font = new Font(
                    TextEditorWindow.Font.FontFamily,
                    TextEditorWindow.Font.Size - 1,
                    TextEditorWindow.Font.Style);}
            else MFontSizeMinus.Enabled = false;
        }
    }
}
