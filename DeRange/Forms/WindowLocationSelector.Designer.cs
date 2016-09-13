namespace DeRange.Forms
{
    partial class WindowLocationSelector
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
            this.locationListbox = new System.Windows.Forms.ListBox();
            this.locationListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windowListbox = new System.Windows.Forms.ListBox();
            this.windowListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.locationListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // locationListbox
            // 
            this.locationListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationListbox.DataSource = this.locationListBindingSource;
            this.locationListbox.DisplayMember = "StringOf";
            this.locationListbox.FormattingEnabled = true;
            this.locationListbox.Location = new System.Drawing.Point(0, 0);
            this.locationListbox.Name = "locationListbox";
            this.locationListbox.Size = new System.Drawing.Size(458, 108);
            this.locationListbox.TabIndex = 10;
            this.locationListbox.SelectedValueChanged += new System.EventHandler(this.locationListbox_SelectedValueChanged);
            // 
            // windowListbox
            // 
            this.windowListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowListbox.DataSource = this.windowListBindingSource;
            this.windowListbox.DisplayMember = "m_windowTitle";
            this.windowListbox.FormattingEnabled = true;
            this.windowListbox.Location = new System.Drawing.Point(0, 0);
            this.windowListbox.Name = "windowListbox";
            this.windowListbox.Size = new System.Drawing.Size(458, 108);
            this.windowListbox.TabIndex = 9;
            this.windowListbox.SelectedValueChanged += new System.EventHandler(this.windowListbox_SelectedValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(366, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(287, 114);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(5, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.windowListbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.locationListbox);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.okButton);
            this.splitContainer1.Size = new System.Drawing.Size(458, 255);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 13;
            // 
            // WindowLocationSelector
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WindowLocationSelector";
            this.Text = "Choose Window & Location Combination";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowListBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox locationListbox;
        private System.Windows.Forms.ListBox windowListbox;
        private System.Windows.Forms.BindingSource locationListBindingSource;
        private System.Windows.Forms.BindingSource windowListBindingSource;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}