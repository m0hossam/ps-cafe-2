namespace TestDB.Forms
{
    partial class EmployeeForm
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
            this.database1DataSet = new TestDB.Database1DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TestDB.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            this.updateSalaryButton = new MaterialSkin.Controls.MaterialButton();
            this.changePasswordButton = new MaterialSkin.Controls.MaterialButton();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.backButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database1DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ItemBillTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestDB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(6, 67);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(743, 220);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsAdmin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn5.HeaderText = "Username";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn6.HeaderText = "Password";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.removeEmployeeButton.Depth = 0;
            this.removeEmployeeButton.HighEmphasis = true;
            this.removeEmployeeButton.Icon = null;
            this.removeEmployeeButton.Location = new System.Drawing.Point(34, 428);
            this.removeEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeEmployeeButton.Size = new System.Drawing.Size(158, 36);
            this.removeEmployeeButton.TabIndex = 2;
            this.removeEmployeeButton.Text = "Remove employee";
            this.removeEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeEmployeeButton.UseAccentColor = false;
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Username", true));
            this.usernameLabel.Location = new System.Drawing.Point(632, 335);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "label1";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addEmployeeButton.Depth = 0;
            this.addEmployeeButton.HighEmphasis = true;
            this.addEmployeeButton.Icon = null;
            this.addEmployeeButton.Location = new System.Drawing.Point(34, 489);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addEmployeeButton.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeButton.TabIndex = 23;
            this.addEmployeeButton.Text = "Add new Employee";
            this.addEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addEmployeeButton.UseAccentColor = false;
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // updateSalaryButton
            // 
            this.updateSalaryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateSalaryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateSalaryButton.Depth = 0;
            this.updateSalaryButton.HighEmphasis = true;
            this.updateSalaryButton.Icon = null;
            this.updateSalaryButton.Location = new System.Drawing.Point(34, 308);
            this.updateSalaryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateSalaryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateSalaryButton.Name = "updateSalaryButton";
            this.updateSalaryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateSalaryButton.Size = new System.Drawing.Size(135, 36);
            this.updateSalaryButton.TabIndex = 24;
            this.updateSalaryButton.Text = "update Salary";
            this.updateSalaryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateSalaryButton.UseAccentColor = false;
            this.updateSalaryButton.UseVisualStyleBackColor = true;
            this.updateSalaryButton.Click += new System.EventHandler(this.updateSalaryButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changePasswordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.changePasswordButton.Depth = 0;
            this.changePasswordButton.HighEmphasis = true;
            this.changePasswordButton.Icon = null;
            this.changePasswordButton.Location = new System.Drawing.Point(34, 365);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.changePasswordButton.Size = new System.Drawing.Size(163, 36);
            this.changePasswordButton.TabIndex = 25;
            this.changePasswordButton.Text = "change Password";
            this.changePasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.changePasswordButton.UseAccentColor = false;
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(258, 353);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(250, 48);
            this.passwordTextBox.TabIndex = 26;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Location = new System.Drawing.Point(258, 318);
            this.salaryNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(250, 20);
            this.salaryNumericUpDown.TabIndex = 43;
            // 
            // idLabel
            // 
            this.idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Id", true));
            this.idLabel.Location = new System.Drawing.Point(632, 312);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 23);
            this.idLabel.TabIndex = 44;
            this.idLabel.Text = "label1";
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backButton.Depth = 0;
            this.backButton.HighEmphasis = true;
            this.backButton.Icon = null;
            this.backButton.Location = new System.Drawing.Point(6, 592);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backButton.Size = new System.Drawing.Size(64, 36);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "back";
            this.backButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.backButton.UseAccentColor = false;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 637);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.salaryNumericUpDown);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.updateSalaryButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MaterialSkin.Controls.MaterialButton removeEmployeeButton;
        private System.Windows.Forms.Label usernameLabel;
        private MaterialSkin.Controls.MaterialButton addEmployeeButton;
        private MaterialSkin.Controls.MaterialButton updateSalaryButton;
        private MaterialSkin.Controls.MaterialButton changePasswordButton;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.Label idLabel;
        private MaterialSkin.Controls.MaterialButton backButton;
    }
}