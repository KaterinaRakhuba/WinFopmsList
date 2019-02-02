namespace WinFormsList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deptsFormPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNewDepId = new System.Windows.Forms.TextBox();
            this.addDeptButton = new System.Windows.Forms.Button();
            this.textBoxNewDepName = new System.Windows.Forms.TextBox();
            this.peopleFormPanel = new System.Windows.Forms.Panel();
            this.textBoxIdDep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ShowAllButton1 = new System.Windows.Forms.Button();
            this.DeleteButton1 = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.depGridView = new System.Windows.Forms.DataGridView();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.SelectButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.deptsFormPanel.SuspendLayout();
            this.peopleFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deptsFormPanel);
            this.splitContainer1.Panel1.Controls.Add(this.peopleFormPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SelectButton1);
            this.splitContainer1.Panel2.Controls.Add(this.ShowAllButton1);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteButton1);
            this.splitContainer1.Panel2.Controls.Add(this.deletePersonButton);
            this.splitContainer1.Panel2.Controls.Add(this.depGridView);
            this.splitContainer1.Panel2.Controls.Add(this.peopleListBox);
            this.splitContainer1.Size = new System.Drawing.Size(1179, 513);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // deptsFormPanel
            // 
            this.deptsFormPanel.Controls.Add(this.label5);
            this.deptsFormPanel.Controls.Add(this.label6);
            this.deptsFormPanel.Controls.Add(this.textBoxNewDepId);
            this.deptsFormPanel.Controls.Add(this.addDeptButton);
            this.deptsFormPanel.Controls.Add(this.textBoxNewDepName);
            this.deptsFormPanel.Location = new System.Drawing.Point(16, 318);
            this.deptsFormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptsFormPanel.Name = "deptsFormPanel";
            this.deptsFormPanel.Size = new System.Drawing.Size(352, 160);
            this.deptsFormPanel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Id";
            // 
            // textBoxNewDepId
            // 
            this.textBoxNewDepId.Location = new System.Drawing.Point(4, 37);
            this.textBoxNewDepId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewDepId.Name = "textBoxNewDepId";
            this.textBoxNewDepId.Size = new System.Drawing.Size(343, 22);
            this.textBoxNewDepId.TabIndex = 0;
            // 
            // addDeptButton
            // 
            this.addDeptButton.Location = new System.Drawing.Point(5, 127);
            this.addDeptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDeptButton.Name = "addDeptButton";
            this.addDeptButton.Size = new System.Drawing.Size(100, 28);
            this.addDeptButton.TabIndex = 3;
            this.addDeptButton.Text = "Add";
            this.addDeptButton.UseVisualStyleBackColor = true;
            this.addDeptButton.Click += new System.EventHandler(this.addDeptButton_Click);
            // 
            // textBoxNewDepName
            // 
            this.textBoxNewDepName.Location = new System.Drawing.Point(5, 95);
            this.textBoxNewDepName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewDepName.Name = "textBoxNewDepName";
            this.textBoxNewDepName.Size = new System.Drawing.Size(343, 22);
            this.textBoxNewDepName.TabIndex = 1;
            // 
            // peopleFormPanel
            // 
            this.peopleFormPanel.Controls.Add(this.textBoxIdDep);
            this.peopleFormPanel.Controls.Add(this.label4);
            this.peopleFormPanel.Controls.Add(this.editPersonButton);
            this.peopleFormPanel.Controls.Add(this.label3);
            this.peopleFormPanel.Controls.Add(this.label2);
            this.peopleFormPanel.Controls.Add(this.label1);
            this.peopleFormPanel.Controls.Add(this.textBox1);
            this.peopleFormPanel.Controls.Add(this.addPersonButton);
            this.peopleFormPanel.Controls.Add(this.textBox2);
            this.peopleFormPanel.Controls.Add(this.textBox3);
            this.peopleFormPanel.Location = new System.Drawing.Point(16, 15);
            this.peopleFormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peopleFormPanel.Name = "peopleFormPanel";
            this.peopleFormPanel.Size = new System.Drawing.Size(352, 295);
            this.peopleFormPanel.TabIndex = 4;
            // 
            // textBoxIdDep
            // 
            this.textBoxIdDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxIdDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxIdDep.Enabled = false;
            this.textBoxIdDep.Location = new System.Drawing.Point(5, 215);
            this.textBoxIdDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdDep.Name = "textBoxIdDep";
            this.textBoxIdDep.Size = new System.Drawing.Size(343, 22);
            this.textBoxIdDep.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Department";
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(125, 250);
            this.editPersonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(100, 28);
            this.editPersonButton.TabIndex = 7;
            this.editPersonButton.Text = "Edit";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 22);
            this.textBox1.TabIndex = 0;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(5, 250);
            this.addPersonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(100, 28);
            this.addPersonButton.TabIndex = 3;
            this.addPersonButton.Text = "Add";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 154);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(343, 22);
            this.textBox3.TabIndex = 2;
            // 
            // ShowAllButton1
            // 
            this.ShowAllButton1.Location = new System.Drawing.Point(652, 267);
            this.ShowAllButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowAllButton1.Name = "ShowAllButton1";
            this.ShowAllButton1.Size = new System.Drawing.Size(112, 28);
            this.ShowAllButton1.TabIndex = 8;
            this.ShowAllButton1.Text = "Show all";
            this.ShowAllButton1.UseVisualStyleBackColor = true;
            this.ShowAllButton1.Click += new System.EventHandler(this.ShowAllButton1_Click);
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.Location = new System.Drawing.Point(15, 463);
            this.DeleteButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.Size = new System.Drawing.Size(93, 28);
            this.DeleteButton1.TabIndex = 6;
            this.DeleteButton1.Text = "Delete";
            this.DeleteButton1.UseVisualStyleBackColor = true;
            this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton1_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(15, 267);
            this.deletePersonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(100, 28);
            this.deletePersonButton.TabIndex = 8;
            this.deletePersonButton.Text = "Delete";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // depGridView
            // 
            this.depGridView.AllowUserToAddRows = false;
            this.depGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depGridView.Location = new System.Drawing.Point(15, 318);
            this.depGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depGridView.MultiSelect = false;
            this.depGridView.Name = "depGridView";
            this.depGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depGridView.Size = new System.Drawing.Size(755, 139);
            this.depGridView.TabIndex = 1;
            this.depGridView.SelectionChanged += new System.EventHandler(this.depGridView_SelectionChanged);
            // 
            // peopleListBox
            // 
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 16;
            this.peopleListBox.Location = new System.Drawing.Point(15, 15);
            this.peopleListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(748, 244);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.SelectedValueChanged += new System.EventHandler(this.peopleListBox_SelectedValueChanged);
            // 
            // SelectButton1
            // 
            this.SelectButton1.Location = new System.Drawing.Point(652, 463);
            this.SelectButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectButton1.Name = "SelectButton1";
            this.SelectButton1.Size = new System.Drawing.Size(111, 28);
            this.SelectButton1.TabIndex = 9;
            this.SelectButton1.Text = "Select";
            this.SelectButton1.UseVisualStyleBackColor = true;
            this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 513);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.deptsFormPanel.ResumeLayout(false);
            this.deptsFormPanel.PerformLayout();
            this.peopleFormPanel.ResumeLayout(false);
            this.peopleFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Panel peopleFormPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Panel deptsFormPanel;
        private System.Windows.Forms.Button ShowAllButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNewDepId;
        private System.Windows.Forms.Button addDeptButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewDepName;
        private System.Windows.Forms.DataGridView depGridView;
        private System.Windows.Forms.TextBox textBoxIdDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteButton1;
        private System.Windows.Forms.Button SelectButton1;
    }
}

