namespace DeRange
{
    partial class DeRangePositionEdit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.windowList = new System.Windows.Forms.ListBox();
            this.deRangeWindowConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.xyPosEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.yPosTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xPosTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.positionList = new System.Windows.Forms.ListBox();
            this.deRangeWindowPositionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deRangeWindowPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowConfigurationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowPositionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowPositionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.Controls.Add(this.windowList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // windowList
            // 
            this.windowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowList.DataSource = this.deRangeWindowConfigurationBindingSource;
            this.windowList.DisplayMember = "m_windowTitle";
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(3, 3);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(142, 264);
            this.windowList.TabIndex = 0;
            this.windowList.SelectedIndexChanged += new System.EventHandler(this.window_SelectedIndexChanged);
            // 
            // deRangeWindowConfigurationBindingSource
            // 
            this.deRangeWindowConfigurationBindingSource.DataMember = "windowConfigurations";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.testButton);
            this.panel1.Controls.Add(this.xyPosEnabledCheckBox);
            this.panel1.Controls.Add(this.yPosTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.xPosTextbox);
            this.panel1.Location = new System.Drawing.Point(299, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 264);
            this.panel1.TabIndex = 2;
            // 
            // xyPosEnabledCheckBox
            // 
            this.xyPosEnabledCheckBox.AutoSize = true;
            this.xyPosEnabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deRangeWindowPositionListBindingSource, "xyPosEnabled", true));
            this.xyPosEnabledCheckBox.Location = new System.Drawing.Point(165, 23);
            this.xyPosEnabledCheckBox.Name = "xyPosEnabledCheckBox";
            this.xyPosEnabledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.xyPosEnabledCheckBox.TabIndex = 4;
            this.xyPosEnabledCheckBox.UseVisualStyleBackColor = true;
            this.xyPosEnabledCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // yPosTextbox
            // 
            this.yPosTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "yPos", true));
            this.yPosTextbox.Location = new System.Drawing.Point(45, 32);
            this.yPosTextbox.Name = "yPosTextbox";
            this.yPosTextbox.Size = new System.Drawing.Size(100, 20);
            this.yPosTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y Pos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Pos";
            // 
            // xPosTextbox
            // 
            this.xPosTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeWindowPositionListBindingSource, "xPos", true));
            this.xPosTextbox.Location = new System.Drawing.Point(45, 6);
            this.xPosTextbox.Name = "xPosTextbox";
            this.xPosTextbox.Size = new System.Drawing.Size(100, 20);
            this.xPosTextbox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.addPositionButton);
            this.panel2.Controls.Add(this.positionList);
            this.panel2.Location = new System.Drawing.Point(151, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 267);
            this.panel2.TabIndex = 3;
            // 
            // addPositionButton
            // 
            this.addPositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPositionButton.Location = new System.Drawing.Point(37, 241);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(75, 23);
            this.addPositionButton.TabIndex = 2;
            this.addPositionButton.Text = "Add";
            this.addPositionButton.UseVisualStyleBackColor = true;
            this.addPositionButton.Click += new System.EventHandler(this.addPositionButton_Click);
            // 
            // positionList
            // 
            this.positionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionList.DataSource = this.deRangeWindowPositionListBindingSource;
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(0, 0);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(142, 238);
            this.positionList.TabIndex = 1;
            this.positionList.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(130, 238);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // DeRangePositionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeRangePositionEdit";
            this.Text = "DeRangePositionEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowConfigurationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowPositionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeWindowPositionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox windowList;
        private System.Windows.Forms.ListBox positionList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox xyPosEnabledCheckBox;
        private System.Windows.Forms.TextBox yPosTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xPosTextbox;
        private System.Windows.Forms.BindingSource deRangeWindowConfigurationBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.BindingSource deRangeWindowPositionListBindingSource;
        private System.Windows.Forms.BindingSource deRangeWindowPositionBindingSource;
        private System.Windows.Forms.Button testButton;
    }
}