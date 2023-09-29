using System;
using System.Windows.Forms;

namespace SimpleTextEditor {
    public partial class SearchForm : Form {
        FormTextEditor mainForm = Application.OpenForms["TextEditorView"] as FormTextEditor;
        public SearchForm() { InitializeComponent(); }
        private void Cancel_Click(object sender, EventArgs e) { Close(); }
        private void Renew_Click(object sender, EventArgs e) { mainForm.ClickSearch(); }
        private void PrewWord_Click(object sender, EventArgs e) { mainForm.ClickPrevious(); }
        private void NextWord_Click(object sender, EventArgs e) { mainForm.ClickNext(); }
    }
}
