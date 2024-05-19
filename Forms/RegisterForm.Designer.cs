namespace TestDB.Forms
{
    partial class RegisterForm
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
            this.registerBtn = new MaterialSkin.Controls.MaterialButton();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.femaleRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.maleRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.logInButton = new MaterialSkin.Controls.MaterialButton();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
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
            // registerBtn
            // 
            this.registerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerBtn.Depth = 0;
            this.registerBtn.HighEmphasis = true;
            this.registerBtn.Icon = null;
            this.registerBtn.Location = new System.Drawing.Point(351, 380);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.registerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerBtn.Size = new System.Drawing.Size(89, 36);
            this.registerBtn.TabIndex = 12;
            this.registerBtn.Text = "Register";
            this.registerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerBtn.UseAccentColor = false;
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AnimateReadOnly = false;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.LeadingIcon = null;
            this.usernameTextBox.Location = new System.Drawing.Point(297, 239);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 50);
            this.usernameTextBox.TabIndex = 43;
            this.usernameTextBox.Text = "";
            this.usernameTextBox.TrailingIcon = null;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Location = new System.Drawing.Point(297, 198);
            this.salaryNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(201, 20);
            this.salaryNumericUpDown.TabIndex = 42;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Depth = 0;
            this.femaleRadioBtn.Location = new System.Drawing.Point(411, 144);
            this.femaleRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.femaleRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.femaleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Ripple = true;
            this.femaleRadioBtn.Size = new System.Drawing.Size(87, 37);
            this.femaleRadioBtn.TabIndex = 41;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Depth = 0;
            this.maleRadioBtn.Location = new System.Drawing.Point(297, 144);
            this.maleRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maleRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Ripple = true;
            this.maleRadioBtn.Size = new System.Drawing.Size(70, 37);
            this.maleRadioBtn.TabIndex = 40;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(297, 89);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 50);
            this.nameTextBox.TabIndex = 39;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(140, 308);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Password";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(140, 254);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Username";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(140, 198);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "Salary";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(140, 154);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Gender";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(140, 99);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Full Name";
            // 
            // logInButton
            // 
            this.logInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logInButton.Depth = 0;
            this.logInButton.HighEmphasis = true;
            this.logInButton.Icon = null;
            this.logInButton.Location = new System.Drawing.Point(365, 427);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInButton.Name = "logInButton";
            this.logInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logInButton.Size = new System.Drawing.Size(64, 36);
            this.logInButton.TabIndex = 45;
            this.logInButton.Text = "LogIn";
            this.logInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logInButton.UseAccentColor = false;
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
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
            this.passwordTextBox.Location = new System.Drawing.Point(297, 294);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(201, 48);
            this.passwordTextBox.TabIndex = 46;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 471);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.salaryNumericUpDown);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.registerBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "PS Cafe - Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialButton registerBtn;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private MaterialSkin.Controls.MaterialRadioButton femaleRadioBtn;
        private MaterialSkin.Controls.MaterialRadioButton maleRadioBtn;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton logInButton;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
    }
}