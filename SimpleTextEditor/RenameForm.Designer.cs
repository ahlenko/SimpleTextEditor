namespace SimpleTextEditor
{
    partial class RenameForm
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
            this.Renew = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TextNew = new System.Windows.Forms.TextBox();
            this.TextOld = new System.Windows.Forms.TextBox();
            this.LabelNew = new System.Windows.Forms.Label();
            this.LabelOld = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.AddOptionActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Renew
            // 
            this.Renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Renew.Location = new System.Drawing.Point(304, 176);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(249, 34);
            this.Renew.TabIndex = 11;
            this.Renew.Text = "Замінити";
            this.Renew.UseVisualStyleBackColor = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(12, 176);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(249, 34);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TextNew
            // 
            this.TextNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextNew.Location = new System.Drawing.Point(172, 103);
            this.TextNew.Name = "TextNew";
            this.TextNew.Size = new System.Drawing.Size(381, 28);
            this.TextNew.TabIndex = 9;
            // 
            // TextOld
            // 
            this.TextOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOld.Location = new System.Drawing.Point(172, 59);
            this.TextOld.Name = "TextOld";
            this.TextOld.Size = new System.Drawing.Size(381, 28);
            this.TextOld.TabIndex = 8;
            // 
            // LabelNew
            // 
            this.LabelNew.AutoSize = true;
            this.LabelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNew.Location = new System.Drawing.Point(12, 106);
            this.LabelNew.Name = "LabelNew";
            this.LabelNew.Size = new System.Drawing.Size(123, 22);
            this.LabelNew.TabIndex = 7;
            this.LabelNew.Text = "Новий рядок:";
            // 
            // LabelOld
            // 
            this.LabelOld.AutoSize = true;
            this.LabelOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOld.Location = new System.Drawing.Point(12, 62);
            this.LabelOld.Name = "LabelOld";
            this.LabelOld.Size = new System.Drawing.Size(131, 22);
            this.LabelOld.TabIndex = 6;
            this.LabelOld.Text = "Старий рядок:";
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.Location = new System.Drawing.Point(110, 17);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(354, 25);
            this.FormLabel.TabIndex = 12;
            this.FormLabel.Text = "Виконання перейменування методу:";
            // 
            // AddOptionActive
            // 
            this.AddOptionActive.AutoSize = true;
            this.AddOptionActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOptionActive.Location = new System.Drawing.Point(128, 143);
            this.AddOptionActive.Name = "AddOptionActive";
            this.AddOptionActive.Size = new System.Drawing.Size(327, 22);
            this.AddOptionActive.TabIndex = 13;
            this.AddOptionActive.Text = "перейменування закоментованих викликів";
            this.AddOptionActive.UseVisualStyleBackColor = true;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 222);
            this.Controls.Add(this.AddOptionActive);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TextNew);
            this.Controls.Add(this.TextOld);
            this.Controls.Add(this.LabelNew);
            this.Controls.Add(this.LabelOld);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(585, 269);
            this.Name = "RenameForm";
            this.Text = "RenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Renew;
        public System.Windows.Forms.TextBox TextNew;
        public System.Windows.Forms.TextBox TextOld;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Label LabelNew;
        public System.Windows.Forms.Label LabelOld;
        public System.Windows.Forms.Label FormLabel;
        public System.Windows.Forms.CheckBox AddOptionActive;
    }
}