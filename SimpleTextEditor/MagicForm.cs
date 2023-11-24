using System;
using System.Windows.Forms;

namespace SimpleTextEditor {
    public partial class MagicForm : Form {
        public MagicForm() {InitializeComponent();}

        static bool IsValidCPlusPlusVariableName(string input) {
            if (string.IsNullOrWhiteSpace(input)) return false;

            if (!IsLetterOrUnderscore(input[0])) return false;

            for (int i = 1; i < input.Length; i++)
                if (!IsLetterOrDigitOrUnderscore(input[i])) return false;
            return true;
        }

        static bool IsLetterOrUnderscore(char c)
        { return char.IsLetter(c) || c == '_'; }

        static bool IsLetterOrDigitOrUnderscore(char c)
        { return char.IsLetterOrDigit(c) || c == '_'; }

        private void Cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel; Close(); }

        private void Renew_Click(object sender, EventArgs e) {
            if (ConstName.Text.Length == 0 ||
                !IsValidCPlusPlusVariableName(ConstName.Text)) {
                MessageBox.Show("Ім'я магічного числа не припустиме", "Помилка");
            } else { DialogResult = DialogResult.OK; Close(); }
        }
    }
}
