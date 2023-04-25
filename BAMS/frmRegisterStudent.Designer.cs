namespace BAMS
{
    partial class frmRegisterStudent
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
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label otherNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label dateOfAdmissionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterStudent));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.otherNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfAdmissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.studentIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAMSDataSet = new BAMS.BAMSDataSet();
            Label1 = new System.Windows.Forms.Label();
            studentIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            otherNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            dateOfAdmissionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(-1, 4);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(681, 60);
            Label1.TabIndex = 353;
            Label1.Text = "Register Student";
            Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIdLabel.ForeColor = System.Drawing.Color.White;
            studentIdLabel.Location = new System.Drawing.Point(57, 86);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(73, 16);
            studentIdLabel.TabIndex = 354;
            studentIdLabel.Text = "Student  Id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.ForeColor = System.Drawing.Color.White;
            firstNameLabel.Location = new System.Drawing.Point(57, 133);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(79, 16);
            firstNameLabel.TabIndex = 356;
            firstNameLabel.Text = "First  Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.ForeColor = System.Drawing.Color.White;
            lastNameLabel.Location = new System.Drawing.Point(57, 180);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(79, 16);
            lastNameLabel.TabIndex = 358;
            lastNameLabel.Text = "Last  Name:";
            // 
            // otherNameLabel
            // 
            otherNameLabel.AutoSize = true;
            otherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            otherNameLabel.ForeColor = System.Drawing.Color.White;
            otherNameLabel.Location = new System.Drawing.Point(57, 227);
            otherNameLabel.Name = "otherNameLabel";
            otherNameLabel.Size = new System.Drawing.Size(86, 16);
            otherNameLabel.TabIndex = 360;
            otherNameLabel.Text = "Other  Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.ForeColor = System.Drawing.Color.White;
            genderLabel.Location = new System.Drawing.Point(57, 274);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(56, 16);
            genderLabel.TabIndex = 362;
            genderLabel.Text = "Gender:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            dateOfBirthLabel.Location = new System.Drawing.Point(57, 321);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(88, 16);
            dateOfBirthLabel.TabIndex = 364;
            dateOfBirthLabel.Text = "Date Of  Birth:";
            // 
            // dateOfAdmissionLabel
            // 
            dateOfAdmissionLabel.AutoSize = true;
            dateOfAdmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfAdmissionLabel.ForeColor = System.Drawing.Color.White;
            dateOfAdmissionLabel.Location = new System.Drawing.Point(57, 368);
            dateOfAdmissionLabel.Name = "dateOfAdmissionLabel";
            dateOfAdmissionLabel.Size = new System.Drawing.Size(106, 16);
            dateOfAdmissionLabel.TabIndex = 366;
            dateOfAdmissionLabel.Text = "Admission Date:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(615, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 333;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(660, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 27);
            this.btnExit.TabIndex = 329;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRemoveImage.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(452, 314);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(170, 37);
            this.btnRemoveImage.TabIndex = 337;
            this.btnRemoveImage.Text = "&Remove Image";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSaveDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetails.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveDetails.Location = new System.Drawing.Point(561, 502);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(127, 37);
            this.btnSaveDetails.TabIndex = 338;
            this.btnSaveDetails.Text = "&Save Details";
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBrowse.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(452, 270);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(168, 37);
            this.btnBrowse.TabIndex = 336;
            this.btnBrowse.Text = "&Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.BackgroundImage")));
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.Image")));
            this.picturePictureBox.Location = new System.Drawing.Point(452, 86);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(168, 178);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 350;
            this.picturePictureBox.TabStop = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(184, 130);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.firstNameTextBox.TabIndex = 357;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(184, 177);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.lastNameTextBox.TabIndex = 359;
            // 
            // otherNameTextBox
            // 
            this.otherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "OtherName", true));
            this.otherNameTextBox.Location = new System.Drawing.Point(184, 224);
            this.otherNameTextBox.Name = "otherNameTextBox";
            this.otherNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.otherNameTextBox.TabIndex = 361;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(184, 322);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 365;
            // 
            // dateOfAdmissionDateTimePicker
            // 
            this.dateOfAdmissionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource, "DateOfAdmission", true));
            this.dateOfAdmissionDateTimePicker.Location = new System.Drawing.Point(184, 369);
            this.dateOfAdmissionDateTimePicker.Name = "dateOfAdmissionDateTimePicker";
            this.dateOfAdmissionDateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateOfAdmissionDateTimePicker.TabIndex = 367;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(184, 271);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(219, 21);
            this.genderComboBox.TabIndex = 368;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // studentIdNumericUpDown
            // 
            this.studentIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource, "StudentId", true));
            this.studentIdNumericUpDown.Location = new System.Drawing.Point(184, 82);
            this.studentIdNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.studentIdNumericUpDown.Name = "studentIdNumericUpDown";
            this.studentIdNumericUpDown.Size = new System.Drawing.Size(219, 20);
            this.studentIdNumericUpDown.TabIndex = 369;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.bAMSDataSet;
            // 
            // bAMSDataSet
            // 
            this.bAMSDataSet.DataSetName = "BAMSDataSet";
            this.bAMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(700, 551);
            this.Controls.Add(this.studentIdNumericUpDown);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(studentIdLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(otherNameLabel);
            this.Controls.Add(this.otherNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(dateOfAdmissionLabel);
            this.Controls.Add(this.dateOfAdmissionDateTimePicker);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisterStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisterStudent";
            this.Load += new System.EventHandler(this.frmRegisterStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnRemoveImage;
        internal System.Windows.Forms.Button btnSaveDetails;
        internal System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private BAMSDataSet bAMSDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox otherNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfAdmissionDateTimePicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown studentIdNumericUpDown;
    }
}