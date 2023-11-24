namespace SimpleTextEditor
{
    partial class ExtractingForm
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
            this.MethodName = new System.Windows.Forms.TextBox();
            this.LabelMethodName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.Location = new System.Drawing.Point(102, 9);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(233, 20);
            this.FormLabel.TabIndex = 24;
            this.FormLabel.Text = "Виконання виділення методу";
            // 
            // Renew
            // 
            this.Renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Renew.Location = new System.Drawing.Point(232, 79);
            this.Renew.Margin = new System.Windows.Forms.Padding(2);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(187, 28);
            this.Renew.TabIndex = 23;
            this.Renew.Text = "Виділити";
            this.Renew.UseVisualStyleBackColor = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(13, 79);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(187, 28);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Скасувати";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MethodName
            // 
            this.MethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodName.Location = new System.Drawing.Point(156, 42);
            this.MethodName.Margin = new System.Windows.Forms.Padding(2);
            this.MethodName.Name = "MethodName";
            this.MethodName.Size = new System.Drawing.Size(263, 24);
            this.MethodName.TabIndex = 21;
            // 
            // LabelMethodName
            // 
            this.LabelMethodName.AutoSize = true;
            this.LabelMethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMethodName.Location = new System.Drawing.Point(12, 44);
            this.LabelMethodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMethodName.Name = "LabelMethodName";
            this.LabelMethodName.Size = new System.Drawing.Size(112, 18);
            this.LabelMethodName.TabIndex = 20;
            this.LabelMethodName.Text = "Ім\'я константи:";
            // 
            // ExtractingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 119);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.MethodName);
            this.Controls.Add(this.LabelMethodName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 158);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(447, 158);
            this.Name = "ExtractingForm";
            this.Text = "ExtractingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label FormLabel;
        public System.Windows.Forms.Button Renew;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox MethodName;
        public System.Windows.Forms.Label LabelMethodName;
    }
}