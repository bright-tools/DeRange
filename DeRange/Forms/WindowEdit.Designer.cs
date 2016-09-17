namespace DeRange.Forms
{
    partial class WindowEdit
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
            this.windowConfigListBox = new System.Windows.Forms.ListBox();
            this.windowConfigurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.windowNameTextbox = new System.Windows.Forms.TextBox();
            this.processFileAsRegexCheckbox = new System.Windows.Forms.CheckBox();
            this.windowTitleIsRegexCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.processFileMatchEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.windowClassMatchEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.windowNameMatchEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processFileTextbox = new System.Windows.Forms.TextBox();
            this.windowClassTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.windowTitleTextbox = new System.Windows.Forms.TextBox();
            this.captureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowConfigurationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowConfigListBox
            // 
            this.windowConfigListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowConfigListBox.DataSource = this.windowConfigurationsBindingSource;
            this.windowConfigListBox.FormattingEnabled = true;
            this.windowConfigListBox.Location = new System.Drawing.Point(3, 3);
            this.windowConfigListBox.Name = "windowConfigListBox";
            this.windowConfigListBox.Size = new System.Drawing.Size(249, 342);
            this.windowConfigListBox.TabIndex = 2;
            this.windowConfigListBox.SelectedValueChanged += new System.EventHandler(this.activeWindowsListBox_SelectedValueChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.addButton);
            this.splitContainer1.Panel1.Controls.Add(this.removeButton);
            this.splitContainer1.Panel1.Controls.Add(this.windowConfigListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.windowNameTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.processFileAsRegexCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.windowTitleIsRegexCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.processFileMatchEnabledCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.windowClassMatchEnabledCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.windowNameMatchEnabledCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.processFileTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.windowClassTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.windowTitleTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.captureButton);
            this.splitContainer1.Size = new System.Drawing.Size(743, 375);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(51, 349);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(132, 349);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name";
            // 
            // windowNameTextbox
            // 
            this.windowNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowConfigurationsBindingSource, "WindowName", true));
            this.windowNameTextbox.Enabled = false;
            this.windowNameTextbox.Location = new System.Drawing.Point(95, 3);
            this.windowNameTextbox.Name = "windowNameTextbox";
            this.windowNameTextbox.Size = new System.Drawing.Size(262, 20);
            this.windowNameTextbox.TabIndex = 23;
            // 
            // processFileAsRegexCheckbox
            // 
            this.processFileAsRegexCheckbox.AutoSize = true;
            this.processFileAsRegexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowConfigurationsBindingSource, "ProcessFileIsRegex", true));
            this.processFileAsRegexCheckbox.Enabled = false;
            this.processFileAsRegexCheckbox.Location = new System.Drawing.Point(451, 114);
            this.processFileAsRegexCheckbox.Name = "processFileAsRegexCheckbox";
            this.processFileAsRegexCheckbox.Size = new System.Drawing.Size(15, 14);
            this.processFileAsRegexCheckbox.TabIndex = 22;
            this.processFileAsRegexCheckbox.UseVisualStyleBackColor = true;
            // 
            // windowTitleIsRegexCheckbox
            // 
            this.windowTitleIsRegexCheckbox.AutoSize = true;
            this.windowTitleIsRegexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowConfigurationsBindingSource, "WindowTitleIsRegex", true));
            this.windowTitleIsRegexCheckbox.Enabled = false;
            this.windowTitleIsRegexCheckbox.Location = new System.Drawing.Point(451, 63);
            this.windowTitleIsRegexCheckbox.Name = "windowTitleIsRegexCheckbox";
            this.windowTitleIsRegexCheckbox.Size = new System.Drawing.Size(15, 14);
            this.windowTitleIsRegexCheckbox.TabIndex = 21;
            this.windowTitleIsRegexCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Regex";
            // 
            // processFileMatchEnabledCheckbox
            // 
            this.processFileMatchEnabledCheckbox.AutoSize = true;
            this.processFileMatchEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowConfigurationsBindingSource, "m_matchProcessFile", true));
            this.processFileMatchEnabledCheckbox.Enabled = false;
            this.processFileMatchEnabledCheckbox.Location = new System.Drawing.Point(390, 114);
            this.processFileMatchEnabledCheckbox.Name = "processFileMatchEnabledCheckbox";
            this.processFileMatchEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.processFileMatchEnabledCheckbox.TabIndex = 19;
            this.processFileMatchEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // windowClassMatchEnabledCheckbox
            // 
            this.windowClassMatchEnabledCheckbox.AutoSize = true;
            this.windowClassMatchEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowConfigurationsBindingSource, "m_matchWindowClass", true));
            this.windowClassMatchEnabledCheckbox.Enabled = false;
            this.windowClassMatchEnabledCheckbox.Location = new System.Drawing.Point(390, 88);
            this.windowClassMatchEnabledCheckbox.Name = "windowClassMatchEnabledCheckbox";
            this.windowClassMatchEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.windowClassMatchEnabledCheckbox.TabIndex = 18;
            this.windowClassMatchEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // windowNameMatchEnabledCheckbox
            // 
            this.windowNameMatchEnabledCheckbox.AutoSize = true;
            this.windowNameMatchEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.windowConfigurationsBindingSource, "m_matchWindowTitle", true));
            this.windowNameMatchEnabledCheckbox.Enabled = false;
            this.windowNameMatchEnabledCheckbox.Location = new System.Drawing.Point(390, 63);
            this.windowNameMatchEnabledCheckbox.Name = "windowNameMatchEnabledCheckbox";
            this.windowNameMatchEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.windowNameMatchEnabledCheckbox.TabIndex = 17;
            this.windowNameMatchEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Match Enabled";
            // 
            // processFileTextbox
            // 
            this.processFileTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowConfigurationsBindingSource, "m_processFile", true));
            this.processFileTextbox.Enabled = false;
            this.processFileTextbox.Location = new System.Drawing.Point(95, 110);
            this.processFileTextbox.Name = "processFileTextbox";
            this.processFileTextbox.Size = new System.Drawing.Size(262, 20);
            this.processFileTextbox.TabIndex = 15;
            // 
            // windowClassTextbox
            // 
            this.windowClassTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowConfigurationsBindingSource, "m_windowClass", true));
            this.windowClassTextbox.Enabled = false;
            this.windowClassTextbox.Location = new System.Drawing.Point(95, 84);
            this.windowClassTextbox.Name = "windowClassTextbox";
            this.windowClassTextbox.Size = new System.Drawing.Size(262, 20);
            this.windowClassTextbox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Window Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Window Title";
            // 
            // windowTitleTextbox
            // 
            this.windowTitleTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.windowConfigurationsBindingSource, "m_windowTitle", true));
            this.windowTitleTextbox.Enabled = false;
            this.windowTitleTextbox.Location = new System.Drawing.Point(95, 60);
            this.windowTitleTextbox.Name = "windowTitleTextbox";
            this.windowTitleTextbox.Size = new System.Drawing.Size(262, 20);
            this.windowTitleTextbox.TabIndex = 11;
            // 
            // captureButton
            // 
            this.captureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(3, 349);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(136, 23);
            this.captureButton.TabIndex = 2;
            this.captureButton.Text = "Capture from Window";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // WindowEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 392);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WindowEdit";
            this.Text = "Edit Window Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.windowConfigurationsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox windowConfigListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.BindingSource windowConfigurationsBindingSource;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox processFileMatchEnabledCheckbox;
        private System.Windows.Forms.CheckBox windowClassMatchEnabledCheckbox;
        private System.Windows.Forms.CheckBox windowNameMatchEnabledCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox processFileTextbox;
        private System.Windows.Forms.TextBox windowClassTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox windowTitleTextbox;
        private System.Windows.Forms.CheckBox processFileAsRegexCheckbox;
        private System.Windows.Forms.CheckBox windowTitleIsRegexCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox windowNameTextbox;
    }
}