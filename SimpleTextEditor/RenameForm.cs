using System;
using System.Windows.Forms;

namespace SimpleTextEditor {
    public partial class RenameForm : Form {
        public RenameForm() {InitializeComponent();}
        private void Cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel; Close();}
        private void Renew_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK; Close();}
    }
}
