namespace SimpleTextEditor
{
    partial class TextEditorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StripStatus = new System.Windows.Forms.StatusStrip();
            this.StatusChar = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAS = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRefactor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRenameMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInlineMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExtractMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMagicNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MFontSizePlus = new System.Windows.Forms.ToolStripMenuItem();
            this.MFontSizeMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.DOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.DSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ScrollEditor = new System.Windows.Forms.VScrollBar();
            this.InterfaceGroup = new System.Windows.Forms.GroupBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.RightScrollEditor = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RightTextBox = new System.Windows.Forms.RichTextBox();
            this.TextEditorWindow = new System.Windows.Forms.TextBox();
            this.StripStatus.SuspendLayout();
            this.StripMenu.SuspendLayout();
            this.InterfaceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripStatus
            // 
            this.StripStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusChar,
            this.StatusRow,
            this.toolStripStatusLabel3});
            this.StripStatus.Location = new System.Drawing.Point(0, 493);
            this.StripStatus.Name = "StripStatus";
            this.StripStatus.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.StripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StripStatus.Size = new System.Drawing.Size(842, 22);
            this.StripStatus.TabIndex = 0;
            // 
            // StatusChar
            // 
            this.StatusChar.Name = "StatusChar";
            this.StatusChar.Size = new System.Drawing.Size(69, 17);
            this.StatusChar.Text = "Символ: 00";
            this.StatusChar.Visible = false;
            // 
            // StatusRow
            // 
            this.StatusRow.Name = "StatusRow";
            this.StatusRow.Size = new System.Drawing.Size(57, 17);
            this.StatusRow.Text = "Рядок: 00";
            this.StatusRow.Visible = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // StripMenu
            // 
            this.StripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuRefactor,
            this.MenuView});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.StripMenu.Size = new System.Drawing.Size(842, 24);
            this.StripMenu.TabIndex = 1;
            this.StripMenu.Text = "StripMenu";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreate,
            this.MenuOpen,
            this.MenuSave,
            this.MenuSaveAS,
            this.MenuClose});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(48, 20);
            this.MenuFile.Text = "Файл";
            // 
            // MenuCreate
            // 
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.Size = new System.Drawing.Size(151, 22);
            this.MenuCreate.Text = "Створити";
            this.MenuCreate.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(151, 22);
            this.MenuOpen.Text = "Відкрити";
            this.MenuOpen.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Enabled = false;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(151, 22);
            this.MenuSave.Text = "Зберегти";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuSaveAS
            // 
            this.MenuSaveAS.Enabled = false;
            this.MenuSaveAS.Name = "MenuSaveAS";
            this.MenuSaveAS.Size = new System.Drawing.Size(151, 22);
            this.MenuSaveAS.Text = "Зберегти як ...";
            this.MenuSaveAS.Click += new System.EventHandler(this.MenuSaveAS_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.Enabled = false;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(151, 22);
            this.MenuClose.Text = "Закрити";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // MenuRefactor
            // 
            this.MenuRefactor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRenameMethod,
            this.MenuInlineMethod,
            this.MenuExtractMethod,
            this.MenuMagicNumber});
            this.MenuRefactor.Enabled = false;
            this.MenuRefactor.Name = "MenuRefactor";
            this.MenuRefactor.Size = new System.Drawing.Size(91, 20);
            this.MenuRefactor.Text = "Рефакторинг";
            this.MenuRefactor.Click += new System.EventHandler(this.MenuRefactor_Click);
            // 
            // MenuRenameMethod
            // 
            this.MenuRenameMethod.Enabled = false;
            this.MenuRenameMethod.Name = "MenuRenameMethod";
            this.MenuRenameMethod.Size = new System.Drawing.Size(211, 22);
            this.MenuRenameMethod.Text = "Перейменування методу";
            this.MenuRenameMethod.Click += new System.EventHandler(this.MenuRenameMethod_Click);
            // 
            // MenuInlineMethod
            // 
            this.MenuInlineMethod.Enabled = false;
            this.MenuInlineMethod.Name = "MenuInlineMethod";
            this.MenuInlineMethod.Size = new System.Drawing.Size(211, 22);
            this.MenuInlineMethod.Text = "Вбудова методу";
            this.MenuInlineMethod.Click += new System.EventHandler(this.MenuInlineMethod_Click);
            // 
            // MenuExtractMethod
            // 
            this.MenuExtractMethod.Enabled = false;
            this.MenuExtractMethod.Name = "MenuExtractMethod";
            this.MenuExtractMethod.Size = new System.Drawing.Size(211, 22);
            this.MenuExtractMethod.Text = "Виділення методу";
            this.MenuExtractMethod.Click += new System.EventHandler(this.MenuExtractMethod_Click);
            // 
            // MenuMagicNumber
            // 
            this.MenuMagicNumber.Enabled = false;
            this.MenuMagicNumber.Name = "MenuMagicNumber";
            this.MenuMagicNumber.Size = new System.Drawing.Size(211, 22);
            this.MenuMagicNumber.Text = "Заміна магічного числа";
            this.MenuMagicNumber.Click += new System.EventHandler(this.MenuMagicNumber_Click);
            // 
            // MenuView
            // 
            this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFontSizePlus,
            this.MFontSizeMinus});
            this.MenuView.Enabled = false;
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(39, 20);
            this.MenuView.Text = "Вид";
            // 
            // MFontSizePlus
            // 
            this.MFontSizePlus.Name = "MFontSizePlus";
            this.MFontSizePlus.Size = new System.Drawing.Size(176, 22);
            this.MFontSizePlus.Text = "Збільшити шрифт";
            this.MFontSizePlus.Click += new System.EventHandler(this.MFontSizePlus_Click);
            // 
            // MFontSizeMinus
            // 
            this.MFontSizeMinus.Name = "MFontSizeMinus";
            this.MFontSizeMinus.Size = new System.Drawing.Size(176, 22);
            this.MFontSizeMinus.Text = "Зменшити шрифт";
            this.MFontSizeMinus.Click += new System.EventHandler(this.MFontSizeMinus_Click);
            // 
            // ScrollEditor
            // 
            this.ScrollEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollEditor.LargeChange = 3;
            this.ScrollEditor.Location = new System.Drawing.Point(398, 49);
            this.ScrollEditor.Maximum = 10;
            this.ScrollEditor.Name = "ScrollEditor";
            this.ScrollEditor.Size = new System.Drawing.Size(23, 436);
            this.ScrollEditor.SmallChange = 3;
            this.ScrollEditor.TabIndex = 3;
            this.ScrollEditor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollEditor_Scroll);
            // 
            // InterfaceGroup
            // 
            this.InterfaceGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InterfaceGroup.Controls.Add(this.SecondLabel);
            this.InterfaceGroup.Controls.Add(this.MainLabel);
            this.InterfaceGroup.Controls.Add(this.OpenFileButton);
            this.InterfaceGroup.Controls.Add(this.CreateFileButton);
            this.InterfaceGroup.Location = new System.Drawing.Point(8, 24);
            this.InterfaceGroup.Margin = new System.Windows.Forms.Padding(2);
            this.InterfaceGroup.Name = "InterfaceGroup";
            this.InterfaceGroup.Padding = new System.Windows.Forms.Padding(2);
            this.InterfaceGroup.Size = new System.Drawing.Size(828, 462);
            this.InterfaceGroup.TabIndex = 4;
            this.InterfaceGroup.TabStop = false;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLabel.Location = new System.Drawing.Point(319, 180);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(191, 20);
            this.SecondLabel.TabIndex = 3;
            this.SecondLabel.Text = "Рефакторингу С++ коду";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(330, 99);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(169, 37);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Програма";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.Location = new System.Drawing.Point(198, 376);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(190, 41);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Відкрити файл";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileButton.Location = new System.Drawing.Point(440, 376);
            this.CreateFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(190, 41);
            this.CreateFileButton.TabIndex = 0;
            this.CreateFileButton.Text = "Створити файл";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // RightScrollEditor
            // 
            this.RightScrollEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightScrollEditor.LargeChange = 3;
            this.RightScrollEditor.Location = new System.Drawing.Point(818, 49);
            this.RightScrollEditor.Maximum = 10;
            this.RightScrollEditor.Name = "RightScrollEditor";
            this.RightScrollEditor.Size = new System.Drawing.Size(23, 436);
            this.RightScrollEditor.SmallChange = 3;
            this.RightScrollEditor.TabIndex = 6;
            this.RightScrollEditor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollEditorRight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вміст документу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Підтвердження змін:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(720, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Підтвердити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RightTextBox
            // 
            this.RightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightTextBox.Location = new System.Drawing.Point(419, 49);
            this.RightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(397, 436);
            this.RightTextBox.TabIndex = 5;
            this.RightTextBox.Text = "";
            // 
            // TextEditorWindow
            // 
            this.TextEditorWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextEditorWindow.Location = new System.Drawing.Point(11, 49);
            this.TextEditorWindow.Margin = new System.Windows.Forms.Padding(2);
            this.TextEditorWindow.Multiline = true;
            this.TextEditorWindow.Name = "TextEditorWindow";
            this.TextEditorWindow.Size = new System.Drawing.Size(386, 436);
            this.TextEditorWindow.TabIndex = 9;
            this.TextEditorWindow.TextChanged += new System.EventHandler(this.TextEditorWindow_TextChanged);
            // 
            // TextEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InterfaceGroup);
            this.Controls.Add(this.RightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RightScrollEditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScrollEditor);
            this.Controls.Add(this.StripStatus);
            this.Controls.Add(this.StripMenu);
            this.Controls.Add(this.TextEditorWindow);
            this.MainMenuStrip = this.StripMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(858, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(858, 554);
            this.Name = "TextEditorView";
            this.Text = "TextEditorView";
            this.StripStatus.ResumeLayout(false);
            this.StripStatus.PerformLayout();
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.InterfaceGroup.ResumeLayout(false);
            this.InterfaceGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StripStatus;
        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuRefactor;
        private System.Windows.Forms.ToolStripMenuItem MenuView;
        private System.Windows.Forms.OpenFileDialog DOpenFile;
        private System.Windows.Forms.SaveFileDialog DSaveFile;
        private System.Windows.Forms.ToolStripMenuItem MenuCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAS;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ToolStripMenuItem MenuRenameMethod;
        private System.Windows.Forms.ToolStripMenuItem MFontSizePlus;
        private System.Windows.Forms.ToolStripMenuItem MFontSizeMinus;
        private System.Windows.Forms.ToolStripMenuItem MenuInlineMethod;
        private System.Windows.Forms.VScrollBar ScrollEditor;
        private System.Windows.Forms.GroupBox InterfaceGroup;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.ToolStripStatusLabel StatusChar;
        private System.Windows.Forms.ToolStripStatusLabel StatusRow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.VScrollBar RightScrollEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RightTextBox;
        private System.Windows.Forms.TextBox TextEditorWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuExtractMethod;
        private System.Windows.Forms.ToolStripMenuItem MenuMagicNumber;
    }
}

