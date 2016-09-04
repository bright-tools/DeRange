namespace DeRange
{
    partial class DeRangeWindowList
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
            this.components = new System.ComponentModel.Container();
            this.activeWindowsListBox = new System.Windows.Forms.ListBox();
            this.updateActiveWindowsList = new System.Windows.Forms.Button();
            this.windowConfigListBox = new System.Windows.Forms.ListBox();
            this.windowConfigurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.captureButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowConfigurationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeWindowsListBox
            // 
            this.activeWindowsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeWindowsListBox.FormattingEnabled = true;
            this.activeWindowsListBox.Location = new System.Drawing.Point(3, 3);
            this.activeWindowsListBox.Name = "activeWindowsListBox";
            this.activeWindowsListBox.Size = new System.Drawing.Size(348, 342);
            this.activeWindowsListBox.TabIndex = 0;
            this.activeWindowsListBox.SelectedIndexChanged += new System.EventHandler(this.activeWindowsListBox_SelectedIndexChanged);
            // 
            // updateActiveWindowsList
            // 
            this.updateActiveWindowsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateActiveWindowsList.Location = new System.Drawing.Point(5, 349);
            this.updateActiveWindowsList.Name = "updateActiveWindowsList";
            this.updateActiveWindowsList.Size = new System.Drawing.Size(75, 23);
            this.updateActiveWindowsList.TabIndex = 1;
            this.updateActiveWindowsList.Text = "Update";
            this.updateActiveWindowsList.UseVisualStyleBackColor = true;
            this.updateActiveWindowsList.Click += new System.EventHandler(this.updateActiveWindowsList_Click);
            // 
            // windowConfigListBox
            // 
            this.windowConfigListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowConfigListBox.DataSource = this.windowConfigurationsBindingSource;
            this.windowConfigListBox.DisplayMember = "m_windowTitle";
            this.windowConfigListBox.FormattingEnabled = true;
            this.windowConfigListBox.Location = new System.Drawing.Point(3, 3);
            this.windowConfigListBox.Name = "windowConfigListBox";
            this.windowConfigListBox.Size = new System.Drawing.Size(338, 342);
            this.windowConfigListBox.TabIndex = 2;
            // 
            // windowConfigurationsBindingSource
            // 
            this.windowConfigurationsBindingSource.DataMember = "windowConfigurations";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.removeButton);
            this.splitContainer1.Panel1.Controls.Add(this.windowConfigListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.captureButton);
            this.splitContainer1.Panel2.Controls.Add(this.activeWindowsListBox);
            this.splitContainer1.Panel2.Controls.Add(this.updateActiveWindowsList);
            this.splitContainer1.Size = new System.Drawing.Size(704, 375);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 3;
            // 
            // captureButton
            // 
            this.captureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(97, 349);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 2;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(3, 349);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // DeRangeWindowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 392);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DeRangeWindowList";
            this.Text = "DeRangeWindow";
            ((System.ComponentModel.ISupportInitialize)(this.windowConfigurationsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox activeWindowsListBox;
        private System.Windows.Forms.Button updateActiveWindowsList;
        private System.Windows.Forms.ListBox windowConfigListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.BindingSource windowConfigurationsBindingSource;
        private System.Windows.Forms.Button removeButton;
    }
}