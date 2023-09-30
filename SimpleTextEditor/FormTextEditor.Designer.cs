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
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MFontSizePlus = new System.Windows.Forms.ToolStripMenuItem();
            this.MFontSizeMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.DOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.DSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.TextEditorWindow = new System.Windows.Forms.TextBox();
            this.ScrollEditor = new System.Windows.Forms.VScrollBar();
            this.InterfaceGroup = new System.Windows.Forms.GroupBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.StatusChar = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.StripStatus.Location = new System.Drawing.Point(0, 606);
            this.StripStatus.Name = "StripStatus";
            this.StripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StripStatus.Size = new System.Drawing.Size(1122, 22);
            this.StripStatus.TabIndex = 0;
            // 
            // StripMenu
            // 
            this.StripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuRefactor,
            this.MenuSearch,
            this.MenuView});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(1122, 28);
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
            this.MenuFile.Size = new System.Drawing.Size(59, 24);
            this.MenuFile.Text = "Файл";
            // 
            // MenuCreate
            // 
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.Size = new System.Drawing.Size(187, 26);
            this.MenuCreate.Text = "Створити";
            this.MenuCreate.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(187, 26);
            this.MenuOpen.Text = "Відкрити";
            this.MenuOpen.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Enabled = false;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(187, 26);
            this.MenuSave.Text = "Зберегти";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuSaveAS
            // 
            this.MenuSaveAS.Enabled = false;
            this.MenuSaveAS.Name = "MenuSaveAS";
            this.MenuSaveAS.Size = new System.Drawing.Size(187, 26);
            this.MenuSaveAS.Text = "Зберегти як ...";
            this.MenuSaveAS.Click += new System.EventHandler(this.MenuSaveAS_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.Enabled = false;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(187, 26);
            this.MenuClose.Text = "Закрити";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // MenuRefactor
            // 
            this.MenuRefactor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRenameMethod,
            this.MenuInlineMethod});
            this.MenuRefactor.Enabled = false;
            this.MenuRefactor.Name = "MenuRefactor";
            this.MenuRefactor.Size = new System.Drawing.Size(112, 24);
            this.MenuRefactor.Text = "Рефакторинг";
            this.MenuRefactor.Click += new System.EventHandler(this.MenuRefactor_Click);
            // 
            // MenuRenameMethod
            // 
            this.MenuRenameMethod.Enabled = false;
            this.MenuRenameMethod.Name = "MenuRenameMethod";
            this.MenuRenameMethod.Size = new System.Drawing.Size(267, 26);
            this.MenuRenameMethod.Text = "Перейменування методу";
            this.MenuRenameMethod.Click += new System.EventHandler(this.MenuRenameMethod_Click);
            // 
            // MenuInlineMethod
            // 
            this.MenuInlineMethod.Enabled = false;
            this.MenuInlineMethod.Name = "MenuInlineMethod";
            this.MenuInlineMethod.Size = new System.Drawing.Size(267, 26);
            this.MenuInlineMethod.Text = "Вбудова методу";
            this.MenuInlineMethod.Click += new System.EventHandler(this.MenuInlineMethod_Click);
            // 
            // MenuSearch
            // 
            this.MenuSearch.Enabled = false;
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(69, 24);
            this.MenuSearch.Text = "Пошук";
            this.MenuSearch.Click += new System.EventHandler(this.MenuSearch_Click);
            // 
            // MenuView
            // 
            this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFontSizePlus,
            this.MFontSizeMinus});
            this.MenuView.Enabled = false;
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(49, 24);
            this.MenuView.Text = "Вид";
            // 
            // MFontSizePlus
            // 
            this.MFontSizePlus.Name = "MFontSizePlus";
            this.MFontSizePlus.Size = new System.Drawing.Size(215, 26);
            this.MFontSizePlus.Text = "Збільшити шрифт";
            this.MFontSizePlus.Click += new System.EventHandler(this.MFontSizePlus_Click);
            // 
            // MFontSizeMinus
            // 
            this.MFontSizeMinus.Name = "MFontSizeMinus";
            this.MFontSizeMinus.Size = new System.Drawing.Size(215, 26);
            this.MFontSizeMinus.Text = "Зменшити шрифт";
            this.MFontSizeMinus.Click += new System.EventHandler(this.MFontSizeMinus_Click);
            // 
            // TextEditorWindow
            // 
            this.TextEditorWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextEditorWindow.Location = new System.Drawing.Point(8, 31);
            this.TextEditorWindow.Multiline = true;
            this.TextEditorWindow.Name = "TextEditorWindow";
            this.TextEditorWindow.Size = new System.Drawing.Size(1087, 572);
            this.TextEditorWindow.TabIndex = 2;
            this.TextEditorWindow.Visible = false;
            this.TextEditorWindow.Click += new System.EventHandler(this.TextEditorWindow_TextChanged);
            this.TextEditorWindow.TextChanged += new System.EventHandler(this.TextEditorWindow_TextChanged);
            // 
            // ScrollEditor
            // 
            this.ScrollEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollEditor.LargeChange = 3;
            this.ScrollEditor.Location = new System.Drawing.Point(1091, 35);
            this.ScrollEditor.Maximum = 10;
            this.ScrollEditor.Name = "ScrollEditor";
            this.ScrollEditor.Size = new System.Drawing.Size(23, 565);
            this.ScrollEditor.SmallChange = 3;
            this.ScrollEditor.TabIndex = 3;
            this.ScrollEditor.Visible = false;
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
            this.InterfaceGroup.Location = new System.Drawing.Point(8, 28);
            this.InterfaceGroup.Name = "InterfaceGroup";
            this.InterfaceGroup.Size = new System.Drawing.Size(1106, 575);
            this.InterfaceGroup.TabIndex = 4;
            this.InterfaceGroup.TabStop = false;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLabel.Location = new System.Drawing.Point(425, 222);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(236, 25);
            this.SecondLabel.TabIndex = 3;
            this.SecondLabel.Text = "Рефакторингу С++ коду";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(440, 122);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(216, 46);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Програма";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.Location = new System.Drawing.Point(264, 463);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(254, 51);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Відкрити файл";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileButton.Location = new System.Drawing.Point(587, 463);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(254, 51);
            this.CreateFileButton.TabIndex = 0;
            this.CreateFileButton.Text = "Створити файл";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // StatusChar
            // 
            this.StatusChar.Name = "StatusChar";
            this.StatusChar.Size = new System.Drawing.Size(86, 20);
            this.StatusChar.Text = "Символ: 00";
            this.StatusChar.Visible = false;
            // 
            // StatusRow
            // 
            this.StatusRow.Name = "StatusRow";
            this.StatusRow.Size = new System.Drawing.Size(72, 20);
            this.StatusRow.Text = "Рядок: 00";
            this.StatusRow.Visible = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // TextEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 628);
            this.Controls.Add(this.InterfaceGroup);
            this.Controls.Add(this.ScrollEditor);
            this.Controls.Add(this.TextEditorWindow);
            this.Controls.Add(this.StripStatus);
            this.Controls.Add(this.StripMenu);
            this.MainMenuStrip = this.StripMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1140, 675);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1140, 675);
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
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
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
        private System.Windows.Forms.TextBox TextEditorWindow;
        private System.Windows.Forms.VScrollBar ScrollEditor;
        private System.Windows.Forms.GroupBox InterfaceGroup;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.ToolStripStatusLabel StatusChar;
        private System.Windows.Forms.ToolStripStatusLabel StatusRow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

