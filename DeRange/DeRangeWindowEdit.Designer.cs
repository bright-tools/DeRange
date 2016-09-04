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
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowConfigurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // windowNameTextbox
            // 
            this.windowNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowConfigurationBindingSource, "m_windowTitle", true));
            this.windowNameTextbox.Location = new System.Drawing.Point(96, 9);
            this.windowNameTextbox.Name = "windowNameTextbox";
            this.windowNameTextbox.Size = new System.Drawing.Size(555, 20);
            this.windowNameTextbox.TabIndex = 0;
            // 
            // deRangeWindowConfigurationBindingSource
            // 
            this.deRangeWindowConfigurationBindingSource.DataSource = typeof(DeRangeWindowConfiguration);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Window Name";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(497, 247);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(578, 247);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DeRangeWindowEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 282);
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
    }
}