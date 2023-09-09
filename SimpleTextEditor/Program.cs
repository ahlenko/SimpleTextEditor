using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Refactor {

        public string RenameMethod(string text, string old_name, string new_name) {
            return "";
        }

        public string InsertMethod(string text, string name) {
            return "";
        }
    }
}
