using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleTextEditor {
    public partial class InlineForm : Form {
        public InlineForm() {InitializeComponent();}
        private void Cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel; Close();}
        private void Renew_Click(object sender, EventArgs e) {
            string pattern = @"^[a-zA-Z_][a-zA-Z0-9_]*$";
            if (TextNew.Text == "_" && TextNew.Enabled == false) {
                DialogResult = DialogResult.OK; Close();
            } else if (
                Regex.IsMatch(TextNew.Text, pattern) || 
                TextNew.Text.Length == 0) {
                MessageBox.Show("Ім'я змінної не припустиме", "Помилка");   
            } else { DialogResult = DialogResult.OK; Close(); }
        } 
    }
}
