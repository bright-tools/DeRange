namespace DeRange
{
    partial class ArrangementEdit
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.removeArrangementButton = new System.Windows.Forms.Button();
            this.addArrangementButton = new System.Windows.Forms.Button();
            this.arrangementListBox = new System.Windows.Forms.ListBox();
            this.deRangeArrangementListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.locatedWindowListbox = new System.Windows.Forms.ListBox();
            this.locatedWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyCombobox = new System.Windows.Forms.ComboBox();
            this.keyboardShortCutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ctrlCheckbox = new System.Windows.Forms.CheckBox();
            this.altCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeArrangementListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatedWindowBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardShortCutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.removeArrangementButton);
            this.splitContainer1.Panel1.Controls.Add(this.addArrangementButton);
            this.splitContainer1.Panel1.Controls.Add(this.arrangementListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.testButton);
            this.splitContainer1.Panel2.Controls.Add(this.removeButton);
            this.splitContainer1.Panel2.Controls.Add(this.updateButton);
            this.splitContainer1.Panel2.Controls.Add(this.addButton);
            this.splitContainer1.Panel2.Controls.Add(this.locatedWindowListbox);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(681, 312);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 0;
            // 
            // removeArrangementButton
            // 
            this.removeArrangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeArrangementButton.Location = new System.Drawing.Point(85, 286);
            this.removeArrangementButton.Name = "removeArrangementButton";
            this.removeArrangementButton.Size = new System.Drawing.Size(75, 23);
            this.removeArrangementButton.TabIndex = 2;
            this.removeArrangementButton.Text = "Remove";
            this.removeArrangementButton.UseVisualStyleBackColor = true;
            this.removeArrangementButton.Click += new System.EventHandler(this.removeArrangementButton_Click);
            // 
            // addArrangementButton
            // 
            this.addArrangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addArrangementButton.Location = new System.Drawing.Point(3, 286);
            this.addArrangementButton.Name = "addArrangementButton";
            this.addArrangementButton.Size = new System.Drawing.Size(75, 23);
            this.addArrangementButton.TabIndex = 1;
            this.addArrangementButton.Text = "Add";
            this.addArrangementButton.UseVisualStyleBackColor = true;
            this.addArrangementButton.Click += new System.EventHandler(this.addArrangementButton_Click);
            // 
            // arrangementListBox
            // 
            this.arrangementListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrangementListBox.DataSource = this.deRangeArrangementListBindingSource;
            this.arrangementListBox.DisplayMember = "StringOf";
            this.arrangementListBox.FormattingEnabled = true;
            this.arrangementListBox.Location = new System.Drawing.Point(3, 13);
            this.arrangementListBox.Name = "arrangementListBox";
            this.arrangementListBox.Size = new System.Drawing.Size(170, 264);
            this.arrangementListBox.TabIndex = 0;
            this.arrangementListBox.SelectedIndexChanged += new System.EventHandler(this.arrangementListBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(242, 221);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(38, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(242, 192);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(38, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 163);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // locatedWindowListbox
            // 
            this.locatedWindowListbox.DataSource = this.locatedWindowBindingSource;
            this.locatedWindowListbox.FormattingEnabled = true;
            this.locatedWindowListbox.Location = new System.Drawing.Point(3, 163);
            this.locatedWindowListbox.Name = "locatedWindowListbox";
            this.locatedWindowListbox.Size = new System.Drawing.Size(233, 147);
            this.locatedWindowListbox.TabIndex = 6;
            this.locatedWindowListbox.SelectedIndexChanged += new System.EventHandler(this.locatedWindowListbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyCombobox);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.ctrlCheckbox);
            this.groupBox1.Controls.Add(this.altCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(11, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 72);
            this.groupBox1.TabIndex = 5;
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.keyboardShortCutBindingSource, "WinModifier", true));
            this.checkBox2.Location = new System.Drawing.Point(155, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Win";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.keyboardShortCutBindingSource, "ShiftModifier", true));
            this.checkBox1.Location = new System.Drawing.Point(106, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Shift";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeArrangementListBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(49, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(242, 286);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(38, 23);
            this.testButton.TabIndex = 12;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // ArrangementEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 312);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ArrangementEdit";
            this.Text = "ArrangementEdit";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deRangeArrangementListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatedWindowBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardShortCutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource deRangeArrangementListBindingSource;
        private System.Windows.Forms.Button removeArrangementButton;
        private System.Windows.Forms.Button addArrangementButton;
        private System.Windows.Forms.ListBox arrangementListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox altCheckbox;
        private System.Windows.Forms.CheckBox ctrlCheckbox;
        private System.Windows.Forms.BindingSource keyboardShortCutBindingSource;
        private System.Windows.Forms.ComboBox keyCombobox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox locatedWindowListbox;
        private System.Windows.Forms.BindingSource locatedWindowBindingSource;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button testButton;
    }
}