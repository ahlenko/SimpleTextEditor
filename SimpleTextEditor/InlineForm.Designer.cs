namespace SimpleTextEditor
{
    partial class InlineForm
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
            this.FormLabel = new System.Windows.Forms.Label();
            this.Renew = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TextNew = new System.Windows.Forms.TextBox();
            this.TextOld = new System.Windows.Forms.TextBox();
            this.LabelNew = new System.Windows.Forms.Label();
            this.LabelOld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.Location = new System.Drawing.Point(150, 15);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(272, 25);
            this.FormLabel.TabIndex = 19;
            this.FormLabel.Text = "Виконання вбудови методу:";
            // 
            // Renew
            // 
            this.Renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Renew.Location = new System.Drawing.Point(305, 145);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(249, 34);
            this.Renew.TabIndex = 18;
            this.Renew.Text = "Вбудувати";
            this.Renew.UseVisualStyleBackColor = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(13, 145);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(249, 34);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TextNew
            // 
            this.TextNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextNew.Location = new System.Drawing.Point(305, 101);
            this.TextNew.Name = "TextNew";
            this.TextNew.Size = new System.Drawing.Size(249, 28);
            this.TextNew.TabIndex = 16;
            // 
            // TextOld
            // 
            this.TextOld.Enabled = false;
            this.TextOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOld.Location = new System.Drawing.Point(305, 57);
            this.TextOld.Name = "TextOld";
            this.TextOld.Size = new System.Drawing.Size(249, 28);
            this.TextOld.TabIndex = 15;
            // 
            // LabelNew
            // 
            this.LabelNew.AutoSize = true;
            this.LabelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNew.Location = new System.Drawing.Point(13, 104);
            this.LabelNew.Name = "LabelNew";
            this.LabelNew.Size = new System.Drawing.Size(324, 28);
            this.LabelNew.TabIndex = 14;
            this.LabelNew.Text = "Ім\'я змінної що повертається:";
            // 
            // LabelOld
            // 
            this.LabelOld.AutoSize = true;
            this.LabelOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOld.Location = new System.Drawing.Point(13, 60);
            this.LabelOld.Name = "LabelOld";
            this.LabelOld.Size = new System.Drawing.Size(140, 28);
            this.LabelOld.TabIndex = 13;
            this.LabelOld.Text = "Ім\'я методу:";
            // 
            // InlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 190);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TextNew);
            this.Controls.Add(this.TextOld);
            this.Controls.Add(this.LabelNew);
            this.Controls.Add(this.LabelOld);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 237);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(585, 237);
            this.Name = "InlineForm";
            this.Text = "InlineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label FormLabel;
        public System.Windows.Forms.Button Renew;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox TextNew;
        public System.Windows.Forms.TextBox TextOld;
        public System.Windows.Forms.Label LabelNew;
        public System.Windows.Forms.Label LabelOld;
    }
}