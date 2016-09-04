namespace DeRange
{
    partial class DeRangeWindowEdit
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
            this.windowNameTextbox = new System.Windows.Forms.TextBox();
            this.deRangeWindowConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.windowClassTextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.windowNameMatchEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.windowClassMatchEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.processFileMatchEnabledCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowConfigurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // windowNameTextbox
            // 
            this.windowNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowConfigurationBindingSource, "m_windowTitle", true));
            this.windowNameTextbox.Location = new System.Drawing.Point(98, 35);
            this.windowNameTextbox.Name = "windowNameTextbox";
            this.windowNameTextbox.Size = new System.Drawing.Size(555, 20);
            this.windowNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Window Name";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(617, 247);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(698, 247);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Window Class";
            // 
            // windowClassTextbox
            // 
            this.windowClassTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowConfigurationBindingSource, "m_windowClass", true));
            this.windowClassTextbox.Location = new System.Drawing.Point(98, 59);
            this.windowClassTextbox.Name = "windowClassTextbox";
            this.windowClassTextbox.Size = new System.Drawing.Size(555, 20);
            this.windowClassTextbox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowConfigurationBindingSource, "m_processFile", true));
            this.textBox1.Location = new System.Drawing.Point(98, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match Enabled";
            // 
            // windowNameMatchEnabledCheckbox
            // 
            this.windowNameMatchEnabledCheckbox.AutoSize = true;
            this.windowNameMatchEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deRangeWindowConfigurationBindingSource, "m_matchWindowTitle", true));
            this.windowNameMatchEnabledCheckbox.Location = new System.Drawing.Point(690, 37);
            this.windowNameMatchEnabledCheckbox.Name = "windowNameMatchEnabledCheckbox";
            this.windowNameMatchEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.windowNameMatchEnabledCheckbox.TabIndex = 8;
            this.windowNameMatchEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // windowClassMatchEnabledCheckbox
            // 
            this.windowClassMatchEnabledCheckbox.AutoSize = true;
            this.windowClassMatchEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deRangeWindowConfigurationBindingSource, "m_matchWindowClass", true));
            this.windowClassMatchEnabledCheckbox.Location = new System.Drawing.Point(690, 62);
            this.windowClassMatchEnabledCheckbox.Name = "windowClassMatchEnabledCheckbox";
            this.windowClassMatchEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.windowClassMatchEnabledCheckbox.TabIndex = 9;
            this.windowClassMatchEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // processFileMatchEnabledCheckbox
            // 
            this.processFileMatchEnabledCheckbox.AutoSize = true;
            this.processFileMatchEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.deRangeWindowConfigurationBindingSource, "m_matchProcessFile", true));
            this.processFileMatchEnabledCheckbox.Location = new System.Drawing.Point(690, 88);
            this.processFileMatchEnabledCheckbox.Name = "processFileMatchEnabledCheckbox";
            this.processFileMatchEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.processFileMatchEnabledCheckbox.TabIndex = 10;
            this.processFileMatchEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeRangeWindowEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 282);
            this.Controls.Add(this.processFileMatchEnabledCheckbox);
            this.Controls.Add(this.windowClassMatchEnabledCheckbox);
            this.Controls.Add(this.windowNameMatchEnabledCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.windowClassTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowNameTextbox);
            this.Name = "DeRangeWindowEdit";
            this.Text = "DeRangeWindowEdit";
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowConfigurationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox windowNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource deRangeWindowConfigurationBindingSource;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox windowClassTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox windowNameMatchEnabledCheckbox;
        private System.Windows.Forms.CheckBox windowClassMatchEnabledCheckbox;
        private System.Windows.Forms.CheckBox processFileMatchEnabledCheckbox;
    }
}