namespace DeRange
{
    partial class DeRange
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
            this.showWindowsButton = new System.Windows.Forms.Button();
            this.showWindowPositionsButton = new System.Windows.Forms.Button();
            this.showWindowCollectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showWindowsButton
            // 
            this.showWindowsButton.Location = new System.Drawing.Point(12, 12);
            this.showWindowsButton.Name = "showWindowsButton";
            this.showWindowsButton.Size = new System.Drawing.Size(180, 23);
            this.showWindowsButton.TabIndex = 0;
            this.showWindowsButton.Text = "Show/Edit Windows";
            this.showWindowsButton.UseVisualStyleBackColor = true;
            this.showWindowsButton.Click += new System.EventHandler(this.showWindowsButton_Click);
            // 
            // showWindowPositionsButton
            // 
            this.showWindowPositionsButton.Location = new System.Drawing.Point(12, 41);
            this.showWindowPositionsButton.Name = "showWindowPositionsButton";
            this.showWindowPositionsButton.Size = new System.Drawing.Size(180, 23);
            this.showWindowPositionsButton.TabIndex = 1;
            this.showWindowPositionsButton.Text = "Show/Edit Window Positions";
            this.showWindowPositionsButton.UseVisualStyleBackColor = true;
            // 
            // showWindowCollectionButton
            // 
            this.showWindowCollectionButton.Location = new System.Drawing.Point(12, 70);
            this.showWindowCollectionButton.Name = "showWindowCollectionButton";
            this.showWindowCollectionButton.Size = new System.Drawing.Size(180, 23);
            this.showWindowCollectionButton.TabIndex = 2;
            this.showWindowCollectionButton.Text = "Show/Edit Window Collections";
            this.showWindowCollectionButton.UseVisualStyleBackColor = true;
            // 
            // DeRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 280);
            this.Controls.Add(this.showWindowCollectionButton);
            this.Controls.Add(this.showWindowPositionsButton);
            this.Controls.Add(this.showWindowsButton);
            this.Name = "DeRange";
            this.Text = "DeRange";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showWindowsButton;
        private System.Windows.Forms.Button showWindowPositionsButton;
        private System.Windows.Forms.Button showWindowCollectionButton;
    }
}

