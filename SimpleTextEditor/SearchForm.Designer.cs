namespace SimpleTextEditor
{
    partial class SearchForm
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
            this.PrewWord = new System.Windows.Forms.Button();
            this.NextWord = new System.Windows.Forms.Button();
            this.Renew = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TextOld = new System.Windows.Forms.TextBox();
            this.LabelOld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrewWord
            // 
            this.PrewWord.Enabled = false;
            this.PrewWord.Location = new System.Drawing.Point(481, 15);
            this.PrewWord.Name = "PrewWord";
            this.PrewWord.Size = new System.Drawing.Size(64, 28);
            this.PrewWord.TabIndex = 17;
            this.PrewWord.Text = "Prew";
            this.PrewWord.UseVisualStyleBackColor = true;
            this.PrewWord.Click += new System.EventHandler(this.PrewWord_Click);
            // 
            // NextWord
            // 
            this.NextWord.Enabled = false;
            this.NextWord.Location = new System.Drawing.Point(411, 15);
            this.NextWord.Name = "NextWord";
            this.NextWord.Size = new System.Drawing.Size(64, 28);
            this.NextWord.TabIndex = 16;
            this.NextWord.Text = "Next";
            this.NextWord.UseVisualStyleBackColor = true;
            this.NextWord.Click += new System.EventHandler(this.NextWord_Click);
            // 
            // Renew
            // 
            this.Renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Renew.Location = new System.Drawing.Point(296, 63);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(249, 34);
            this.Renew.TabIndex = 15;
            this.Renew.Text = "Знайти";
            this.Renew.UseVisualStyleBackColor = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(16, 63);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(249, 34);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TextOld
            // 
            this.TextOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOld.Location = new System.Drawing.Point(164, 15);
            this.TextOld.Name = "TextOld";
            this.TextOld.Size = new System.Drawing.Size(241, 28);
            this.TextOld.TabIndex = 13;
            // 
            // LabelOld
            // 
            this.LabelOld.AutoSize = true;
            this.LabelOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOld.Location = new System.Drawing.Point(12, 18);
            this.LabelOld.Name = "LabelOld";
            this.LabelOld.Size = new System.Drawing.Size(133, 22);
            this.LabelOld.TabIndex = 12;
            this.LabelOld.Text = "Рядок пошуку:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 110);
            this.Controls.Add(this.PrewWord);
            this.Controls.Add(this.NextWord);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TextOld);
            this.Controls.Add(this.LabelOld);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 157);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(578, 157);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button PrewWord;
        public System.Windows.Forms.Button NextWord;
        public System.Windows.Forms.Button Renew;
        public System.Windows.Forms.TextBox TextOld;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Label LabelOld;
    }
}