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
            this.hotKeySelector1 = new DeRange.Forms.HotKeySelector();
            this.nonMatchingWindowsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setZIndexCheckBox = new System.Windows.Forms.CheckBox();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.locatedWindowListbox = new System.Windows.Forms.ListBox();
            this.locatedWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeArrangementListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatedWindowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.removeArrangementButton);
            this.splitContainer1.Panel1.Controls.Add(this.addArrangementButton);
            this.splitContainer1.Panel1.Controls.Add(this.arrangementListBox);
            this.splitContainer1.Panel1MinSize = 175;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hotKeySelector1);
            this.splitContainer1.Panel2.Controls.Add(this.nonMatchingWindowsComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.setZIndexCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.downButton);
            this.splitContainer1.Panel2.Controls.Add(this.upButton);
            this.splitContainer1.Panel2.Controls.Add(this.testButton);
            this.splitContainer1.Panel2.Controls.Add(this.removeButton);
            this.splitContainer1.Panel2.Controls.Add(this.updateButton);
            this.splitContainer1.Panel2.Controls.Add(this.addButton);
            this.splitContainer1.Panel2.Controls.Add(this.locatedWindowListbox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(689, 374);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // removeArrangementButton
            // 
            this.removeArrangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeArrangementButton.Image = global::DeRange.Properties.Resources.Remove_16x;
            this.removeArrangementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeArrangementButton.Location = new System.Drawing.Point(98, 346);
            this.removeArrangementButton.Name = "removeArrangementButton";
            this.removeArrangementButton.Size = new System.Drawing.Size(75, 23);
            this.removeArrangementButton.TabIndex = 2;
            this.removeArrangementButton.Text = "Remove";
            this.removeArrangementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeArrangementButton.UseVisualStyleBackColor = true;
            this.removeArrangementButton.Click += new System.EventHandler(this.removeArrangementButton_Click);
            // 
            // addArrangementButton
            // 
            this.addArrangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addArrangementButton.Image = global::DeRange.Properties.Resources.Add_16x;
            this.addArrangementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addArrangementButton.Location = new System.Drawing.Point(17, 346);
            this.addArrangementButton.Name = "addArrangementButton";
            this.addArrangementButton.Size = new System.Drawing.Size(75, 23);
            this.addArrangementButton.TabIndex = 1;
            this.addArrangementButton.Text = "Add";
            this.addArrangementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.arrangementListBox.IntegralHeight = false;
            this.arrangementListBox.Location = new System.Drawing.Point(3, 3);
            this.arrangementListBox.Name = "arrangementListBox";
            this.arrangementListBox.Size = new System.Drawing.Size(177, 337);
            this.arrangementListBox.TabIndex = 0;
            this.arrangementListBox.SelectedValueChanged += new System.EventHandler(this.arrangementListBox_SelectedValueChanged);
            // 
            // hotKeySelector1
            // 
            this.hotKeySelector1.Location = new System.Drawing.Point(3, 41);
            this.hotKeySelector1.Name = "hotKeySelector1";
            this.hotKeySelector1.Size = new System.Drawing.Size(214, 79);
            this.hotKeySelector1.TabIndex = 17;
            // 
            // nonMatchingWindowsComboBox
            // 
            this.nonMatchingWindowsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.deRangeArrangementListBindingSource, "NonMatchingWindowStatus", true));
            this.nonMatchingWindowsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nonMatchingWindowsComboBox.Enabled = false;
            this.nonMatchingWindowsComboBox.FormattingEnabled = true;
            this.nonMatchingWindowsComboBox.Location = new System.Drawing.Point(366, 46);
            this.nonMatchingWindowsComboBox.Name = "nonMatchingWindowsComboBox";
            this.nonMatchingWindowsComboBox.Size = new System.Drawing.Size(123, 21);
            this.nonMatchingWindowsComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Non-Matching Windows:";
            // 
            // setZIndexCheckBox
            // 
            this.setZIndexCheckBox.AutoSize = true;
            this.setZIndexCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deRangeArrangementListBindingSource, "SetZIndex", true));
            this.setZIndexCheckBox.Location = new System.Drawing.Point(242, 16);
            this.setZIndexCheckBox.Name = "setZIndexCheckBox";
            this.setZIndexCheckBox.Size = new System.Drawing.Size(177, 17);
            this.setZIndexCheckBox.TabIndex = 10;
            this.setZIndexCheckBox.Text = "Set Z-Index Based on List Order";
            this.setZIndexCheckBox.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.Enabled = false;
            this.downButton.Image = global::DeRange.Properties.Resources.StackDown_16x;
            this.downButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downButton.Location = new System.Drawing.Point(404, 311);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(89, 23);
            this.downButton.TabIndex = 14;
            this.downButton.Text = "Move Down";
            this.downButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Enabled = false;
            this.upButton.Image = global::DeRange.Properties.Resources.StackUp_16x;
            this.upButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upButton.Location = new System.Drawing.Point(404, 282);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(89, 23);
            this.upButton.TabIndex = 13;
            this.upButton.Text = "Move Up";
            this.upButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.Image = global::DeRange.Properties.Resources.Test_16x;
            this.testButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testButton.Location = new System.Drawing.Point(404, 345);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(89, 23);
            this.testButton.TabIndex = 12;
            this.testButton.Text = "Test";
            this.testButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Image = global::DeRange.Properties.Resources.Remove_16x;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(404, 253);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Image = global::DeRange.Properties.Resources.UpdateListItem_16x;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.Location = new System.Drawing.Point(404, 224);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::DeRange.Properties.Resources.Add_16x;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(404, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // locatedWindowListbox
            // 
            this.locatedWindowListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locatedWindowListbox.DataSource = this.locatedWindowBindingSource;
            this.locatedWindowListbox.FormattingEnabled = true;
            this.locatedWindowListbox.IntegralHeight = false;
            this.locatedWindowListbox.Location = new System.Drawing.Point(5, 126);
            this.locatedWindowListbox.Name = "locatedWindowListbox";
            this.locatedWindowListbox.Size = new System.Drawing.Size(393, 243);
            this.locatedWindowListbox.TabIndex = 6;
            this.locatedWindowListbox.SelectedValueChanged += new System.EventHandler(this.locatedWindowListbox_SelectedValueChanged);
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
            // ArrangementEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 374);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(705, 413);
            this.Name = "ArrangementEdit";
            this.Text = "Edit Window Arrangement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deRangeArrangementListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatedWindowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource deRangeArrangementListBindingSource;
        private System.Windows.Forms.Button removeArrangementButton;
        private System.Windows.Forms.Button addArrangementButton;
        private System.Windows.Forms.ListBox arrangementListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox locatedWindowListbox;
        private System.Windows.Forms.BindingSource locatedWindowBindingSource;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.CheckBox setZIndexCheckBox;
        private System.Windows.Forms.ComboBox nonMatchingWindowsComboBox;
        private System.Windows.Forms.Label label2;
        private Forms.HotKeySelector hotKeySelector1;
    }
}