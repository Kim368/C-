namespace FormatDrives
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrivesBox = new System.Windows.Forms.ComboBox();
            this.DriveSizeBox = new System.Windows.Forms.TextBox();
            this.DriveSizeLabel = new System.Windows.Forms.Label();
            this.DriveFormatLabel = new System.Windows.Forms.Label();
            this.DriveFormatBox = new System.Windows.Forms.TextBox();
            this.FormatDriveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrivesBox
            // 
            this.DrivesBox.FormattingEnabled = true;
            this.DrivesBox.Location = new System.Drawing.Point(21, 42);
            this.DrivesBox.Name = "DrivesBox";
            this.DrivesBox.Size = new System.Drawing.Size(255, 21);
            this.DrivesBox.TabIndex = 0;
            this.DrivesBox.Text = "Choose the drive";
            this.DrivesBox.SelectedIndexChanged += new System.EventHandler(this.DrivesBox_SelectedIndexChanged);
            // 
            // DriveSizeBox
            // 
            this.DriveSizeBox.Location = new System.Drawing.Point(66, 120);
            this.DriveSizeBox.Name = "DriveSizeBox";
            this.DriveSizeBox.Size = new System.Drawing.Size(164, 20);
            this.DriveSizeBox.TabIndex = 1;
            // 
            // DriveSizeLabel
            // 
            this.DriveSizeLabel.AutoSize = true;
            this.DriveSizeLabel.Location = new System.Drawing.Point(103, 104);
            this.DriveSizeLabel.Name = "DriveSizeLabel";
            this.DriveSizeLabel.Size = new System.Drawing.Size(94, 13);
            this.DriveSizeLabel.TabIndex = 2;
            this.DriveSizeLabel.Text = "Total Size of Drive";
            // 
            // DriveFormatLabel
            // 
            this.DriveFormatLabel.AutoSize = true;
            this.DriveFormatLabel.Location = new System.Drawing.Point(120, 166);
            this.DriveFormatLabel.Name = "DriveFormatLabel";
            this.DriveFormatLabel.Size = new System.Drawing.Size(67, 13);
            this.DriveFormatLabel.TabIndex = 4;
            this.DriveFormatLabel.Text = "Drive Format";
            // 
            // DriveFormatBox
            // 
            this.DriveFormatBox.Location = new System.Drawing.Point(66, 182);
            this.DriveFormatBox.Name = "DriveFormatBox";
            this.DriveFormatBox.Size = new System.Drawing.Size(164, 20);
            this.DriveFormatBox.TabIndex = 3;
            // 
            // FormatDriveButton
            // 
            this.FormatDriveButton.Location = new System.Drawing.Point(106, 251);
            this.FormatDriveButton.Name = "FormatDriveButton";
            this.FormatDriveButton.Size = new System.Drawing.Size(75, 23);
            this.FormatDriveButton.TabIndex = 5;
            this.FormatDriveButton.Text = "Format";
            this.FormatDriveButton.UseVisualStyleBackColor = true;
            this.FormatDriveButton.Click += new System.EventHandler(this.FormatDriveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 328);
            this.Controls.Add(this.FormatDriveButton);
            this.Controls.Add(this.DriveFormatLabel);
            this.Controls.Add(this.DriveFormatBox);
            this.Controls.Add(this.DriveSizeLabel);
            this.Controls.Add(this.DriveSizeBox);
            this.Controls.Add(this.DrivesBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DrivesBox;
        private System.Windows.Forms.TextBox DriveSizeBox;
        private System.Windows.Forms.Label DriveSizeLabel;
        private System.Windows.Forms.Label DriveFormatLabel;
        private System.Windows.Forms.TextBox DriveFormatBox;
        private System.Windows.Forms.Button FormatDriveButton;
    }
}

