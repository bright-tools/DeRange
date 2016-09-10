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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRangeArrangementListBindingSource)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(681, 261);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 0;
            // 
            // removeArrangementButton
            // 
            this.removeArrangementButton.Location = new System.Drawing.Point(85, 235);
            this.removeArrangementButton.Name = "removeArrangementButton";
            this.removeArrangementButton.Size = new System.Drawing.Size(75, 23);
            this.removeArrangementButton.TabIndex = 2;
            this.removeArrangementButton.Text = "Remove";
            this.removeArrangementButton.UseVisualStyleBackColor = true;
            this.removeArrangementButton.Click += new System.EventHandler(this.removeArrangementButton_Click);
            // 
            // addArrangementButton
            // 
            this.addArrangementButton.Location = new System.Drawing.Point(3, 235);
            this.addArrangementButton.Name = "addArrangementButton";
            this.addArrangementButton.Size = new System.Drawing.Size(75, 23);
            this.addArrangementButton.TabIndex = 1;
            this.addArrangementButton.Text = "Add";
            this.addArrangementButton.UseVisualStyleBackColor = true;
            this.addArrangementButton.Click += new System.EventHandler(this.addArrangementButton_Click);
            // 
            // arrangementListBox
            // 
            this.arrangementListBox.DataSource = this.deRangeArrangementListBindingSource;
            this.arrangementListBox.DisplayMember = "StringOf";
            this.arrangementListBox.FormattingEnabled = true;
            this.arrangementListBox.Location = new System.Drawing.Point(0, 0);
            this.arrangementListBox.Name = "arrangementListBox";
            this.arrangementListBox.Size = new System.Drawing.Size(173, 225);
            this.arrangementListBox.TabIndex = 0;
            this.arrangementListBox.SelectedIndexChanged += new System.EventHandler(this.arrangementListBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deRangeArrangementListBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(39, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // ArrangementEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ArrangementEdit";
            this.Text = "ArrangementEdit";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deRangeArrangementListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource deRangeArrangementListBindingSource;
        private System.Windows.Forms.Button removeArrangementButton;
        private System.Windows.Forms.Button addArrangementButton;
        private System.Windows.Forms.ListBox arrangementListBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}