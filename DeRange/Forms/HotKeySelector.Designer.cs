namespace DeRange.Forms
{
    partial class HotKeySelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyCombobox = new System.Windows.Forms.ComboBox();
            this.winCheckbox = new System.Windows.Forms.CheckBox();
            this.shiftCheckbox = new System.Windows.Forms.CheckBox();
            this.ctrlCheckbox = new System.Windows.Forms.CheckBox();
            this.altCheckbox = new System.Windows.Forms.CheckBox();
            this.keyboardShortCutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardShortCutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.keyCombobox);
            this.groupBox1.Controls.Add(this.winCheckbox);
            this.groupBox1.Controls.Add(this.shiftCheckbox);
            this.groupBox1.Controls.Add(this.ctrlCheckbox);
            this.groupBox1.Controls.Add(this.altCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyboard Shortcut";
            // 
            // keyCombobox
            // 
            this.keyCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.keyboardShortCutBindingSource, "Key", true));
            this.keyCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyCombobox.FormattingEnabled = true;
            this.keyCombobox.Location = new System.Drawing.Point(6, 42);
            this.keyCombobox.Name = "keyCombobox";
            this.keyCombobox.Size = new System.Drawing.Size(194, 21);
            this.keyCombobox.TabIndex = 9;
            // 
            // winCheckbox
            // 
            this.winCheckbox.AutoSize = true;
            this.winCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.keyboardShortCutBindingSource, "WinModifier", true));
            this.winCheckbox.Location = new System.Drawing.Point(155, 19);
            this.winCheckbox.Name = "winCheckbox";
            this.winCheckbox.Size = new System.Drawing.Size(45, 17);
            this.winCheckbox.TabIndex = 8;
            this.winCheckbox.Text = "Win";
            this.winCheckbox.UseVisualStyleBackColor = true;
            // 
            // shiftCheckbox
            // 
            this.shiftCheckbox.AutoSize = true;
            this.shiftCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.keyboardShortCutBindingSource, "ShiftModifier", true));
            this.shiftCheckbox.Location = new System.Drawing.Point(106, 19);
            this.shiftCheckbox.Name = "shiftCheckbox";
            this.shiftCheckbox.Size = new System.Drawing.Size(47, 17);
            this.shiftCheckbox.TabIndex = 7;
            this.shiftCheckbox.Text = "Shift";
            this.shiftCheckbox.UseVisualStyleBackColor = true;
            // 
            // ctrlCheckbox
            // 
            this.ctrlCheckbox.AutoSize = true;
            this.ctrlCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.keyboardShortCutBindingSource, "CtrlModifier", true));
            this.ctrlCheckbox.Location = new System.Drawing.Point(59, 19);
            this.ctrlCheckbox.Name = "ctrlCheckbox";
            this.ctrlCheckbox.Size = new System.Drawing.Size(41, 17);
            this.ctrlCheckbox.TabIndex = 6;
            this.ctrlCheckbox.Text = "Ctrl";
            this.ctrlCheckbox.UseVisualStyleBackColor = true;
            // 
            // altCheckbox
            // 
            this.altCheckbox.AutoSize = true;
            this.altCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.keyboardShortCutBindingSource, "AltModifier", true));
            this.altCheckbox.Location = new System.Drawing.Point(6, 19);
            this.altCheckbox.Name = "altCheckbox";
            this.altCheckbox.Size = new System.Drawing.Size(46, 17);
            this.altCheckbox.TabIndex = 5;
            this.altCheckbox.Text = "ALT";
            this.altCheckbox.UseVisualStyleBackColor = true;
            // 
            // HotKeySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "HotKeySelector";
            this.Size = new System.Drawing.Size(214, 79);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardShortCutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox keyCombobox;
        private System.Windows.Forms.CheckBox winCheckbox;
        private System.Windows.Forms.CheckBox shiftCheckbox;
        private System.Windows.Forms.CheckBox ctrlCheckbox;
        private System.Windows.Forms.CheckBox altCheckbox;
        private System.Windows.Forms.BindingSource keyboardShortCutBindingSource;
    }
}
