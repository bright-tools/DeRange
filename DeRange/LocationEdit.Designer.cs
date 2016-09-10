namespace DeRange
{
    partial class LocationEdit
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
            this.deRangeWindowPositionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.removePositionButton = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.positionList = new System.Windows.Forms.ListBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.sizeEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateFromWindowButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.xyPosEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.yPosTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xPosTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowPositionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.removePositionButton);
            this.splitContainer1.Panel1.Controls.Add(this.addPositionButton);
            this.splitContainer1.Panel1.Controls.Add(this.positionList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.sizeEnabledCheckbox);
            this.splitContainer1.Panel2.Controls.Add(this.heightTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.widthTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.updateFromWindowButton);
            this.splitContainer1.Panel2.Controls.Add(this.testButton);
            this.splitContainer1.Panel2.Controls.Add(this.xyPosEnabledCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.yPosTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.xPosTextbox);
            this.splitContainer1.Size = new System.Drawing.Size(738, 273);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 1;
            // 
            // removePositionButton
            // 
            this.removePositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removePositionButton.Location = new System.Drawing.Point(115, 245);
            this.removePositionButton.Name = "removePositionButton";
            this.removePositionButton.Size = new System.Drawing.Size(75, 23);
            this.removePositionButton.TabIndex = 5;
            this.removePositionButton.Text = "Remove";
            this.removePositionButton.UseVisualStyleBackColor = true;
            this.removePositionButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addPositionButton
            // 
            this.addPositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPositionButton.Location = new System.Drawing.Point(34, 245);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(75, 23);
            this.addPositionButton.TabIndex = 4;
            this.addPositionButton.Text = "Add";
            this.addPositionButton.UseVisualStyleBackColor = true;
            this.addPositionButton.Click += new System.EventHandler(this.addPositionButton_Click_1);
            // 
            // positionList
            // 
            this.positionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionList.DataSource = this.deRangeWindowPositionListBindingSource;
            this.positionList.DisplayMember = "StringOf";
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(0, 4);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(345, 238);
            this.positionList.TabIndex = 3;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.deRangeWindowPositionListBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(49, 142);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 21;
            // 
            // sizeEnabledCheckbox
            // 
            this.sizeEnabledCheckbox.AutoSize = true;
            this.sizeEnabledCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deRangeWindowPositionListBindingSource, "SizeEnabled", true));
            this.sizeEnabledCheckbox.Location = new System.Drawing.Point(169, 107);
            this.sizeEnabledCheckbox.Name = "sizeEnabledCheckbox";
            this.sizeEnabledCheckbox.Size = new System.Drawing.Size(15, 14);
            this.sizeEnabledCheckbox.TabIndex = 20;
            this.sizeEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // heightTextbox
            // 
            this.heightTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "Height", true));
            this.heightTextbox.Location = new System.Drawing.Point(49, 116);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(100, 20);
            this.heightTextbox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Width";
            // 
            // widthTextbox
            // 
            this.widthTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "Width", true));
            this.widthTextbox.Location = new System.Drawing.Point(49, 90);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(100, 20);
            this.widthTextbox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(49, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // updateFromWindowButton
            // 
            this.updateFromWindowButton.Location = new System.Drawing.Point(11, 245);
            this.updateFromWindowButton.Name = "updateFromWindowButton";
            this.updateFromWindowButton.Size = new System.Drawing.Size(117, 23);
            this.updateFromWindowButton.TabIndex = 13;
            this.updateFromWindowButton.Text = "Update from Window";
            this.updateFromWindowButton.UseVisualStyleBackColor = true;
            this.updateFromWindowButton.Click += new System.EventHandler(this.updateFromWindowButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(134, 245);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(105, 23);
            this.testButton.TabIndex = 12;
            this.testButton.Text = "Apply to Window";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // xyPosEnabledCheckBox
            // 
            this.xyPosEnabledCheckBox.AutoSize = true;
            this.xyPosEnabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deRangeWindowPositionListBindingSource, "xyPosEnabled", true));
            this.xyPosEnabledCheckBox.Location = new System.Drawing.Point(169, 55);
            this.xyPosEnabledCheckBox.Name = "xyPosEnabledCheckBox";
            this.xyPosEnabledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.xyPosEnabledCheckBox.TabIndex = 11;
            this.xyPosEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // yPosTextbox
            // 
            this.yPosTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "YPos", true));
            this.yPosTextbox.Location = new System.Drawing.Point(49, 64);
            this.yPosTextbox.Name = "yPosTextbox";
            this.yPosTextbox.Size = new System.Drawing.Size(100, 20);
            this.yPosTextbox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y Pos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X Pos";
            // 
            // xPosTextbox
            // 
            this.xPosTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "XPos", true));
            this.xPosTextbox.Location = new System.Drawing.Point(49, 38);
            this.xPosTextbox.Name = "xPosTextbox";
            this.xPosTextbox.Size = new System.Drawing.Size(100, 20);
            this.xPosTextbox.TabIndex = 7;
            // 
            // LocationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 283);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LocationEdit";
            this.Text = "DeRangePositionEdit";
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowPositionListBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource deRangeWindowPositionListBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.ListBox positionList;
        private System.Windows.Forms.Button updateFromWindowButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.CheckBox xyPosEnabledCheckBox;
        private System.Windows.Forms.TextBox yPosTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xPosTextbox;
        private System.Windows.Forms.CheckBox sizeEnabledCheckbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button removePositionButton;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}