namespace SimpleTextEditor
{
    partial class MagicForm
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
            this.ConstName = new System.Windows.Forms.TextBox();
            this.NumValue = new System.Windows.Forms.TextBox();
            this.LabelConstName = new System.Windows.Forms.Label();
            this.LabelNumValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.Location = new System.Drawing.Point(84, 9);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(280, 20);
            this.FormLabel.TabIndex = 19;
            this.FormLabel.Text = "Виконання заміни магічним числом:";
            // 
            // Renew
            // 
            this.Renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Renew.Location = new System.Drawing.Point(231, 116);
            this.Renew.Margin = new System.Windows.Forms.Padding(2);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(187, 28);
            this.Renew.TabIndex = 18;
            this.Renew.Text = "Замінити";
            this.Renew.UseVisualStyleBackColor = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(12, 116);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(187, 28);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ConstName
            // 
            this.ConstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConstName.Location = new System.Drawing.Point(155, 79);
            this.ConstName.Margin = new System.Windows.Forms.Padding(2);
            this.ConstName.Name = "ConstName";
            this.ConstName.Size = new System.Drawing.Size(263, 24);
            this.ConstName.TabIndex = 16;
            // 
            // NumValue
            // 
            this.NumValue.Enabled = false;
            this.NumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumValue.Location = new System.Drawing.Point(155, 43);
            this.NumValue.Margin = new System.Windows.Forms.Padding(2);
            this.NumValue.Name = "NumValue";
            this.NumValue.Size = new System.Drawing.Size(263, 24);
            this.NumValue.TabIndex = 15;
            // 
            // LabelConstName
            // 
            this.LabelConstName.AutoSize = true;
            this.LabelConstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelConstName.Location = new System.Drawing.Point(11, 81);
            this.LabelConstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelConstName.Name = "LabelConstName";
            this.LabelConstName.Size = new System.Drawing.Size(112, 18);
            this.LabelConstName.TabIndex = 14;
            this.LabelConstName.Text = "Ім\'я константи:";
            // 
            // LabelNumValue
            // 
            this.LabelNumValue.AutoSize = true;
            this.LabelNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumValue.Location = new System.Drawing.Point(11, 45);
            this.LabelNumValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNumValue.Name = "LabelNumValue";
            this.LabelNumValue.Size = new System.Drawing.Size(140, 18);
            this.LabelNumValue.TabIndex = 13;
            this.LabelNumValue.Text = "Числове значення:";
            // 
            // MagicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 152);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ConstName);
            this.Controls.Add(this.NumValue);
            this.Controls.Add(this.LabelConstName);
            this.Controls.Add(this.LabelNumValue);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 191);
            this.Name = "MagicForm";
            this.Text = "MagicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label FormLabel;
        public System.Windows.Forms.Button Renew;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox ConstName;
        public System.Windows.Forms.TextBox NumValue;
        public System.Windows.Forms.Label LabelConstName;
        public System.Windows.Forms.Label LabelNumValue;
    }
}