namespace BAMS
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCatSettings = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Indigo;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(294, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 151;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnExit, "Close");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 44);
            this.label1.TabIndex = 150;
            this.label1.Text = "BAMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // btnAppSettings
            // 
            this.btnAppSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAppSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnAppSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnAppSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppSettings.Location = new System.Drawing.Point(1, 75);
            this.btnAppSettings.Name = "btnAppSettings";
            this.btnAppSettings.Size = new System.Drawing.Size(329, 62);
            this.btnAppSettings.TabIndex = 152;
            this.btnAppSettings.Text = "Register Student";
            this.toolTip1.SetToolTip(this.btnAppSettings, "Register Student");
            this.btnAppSettings.UseVisualStyleBackColor = true;
            this.btnAppSettings.Click += new System.EventHandler(this.btnAppSettings_Click);
            this.btnAppSettings.MouseHover += new System.EventHandler(this.btnAppSettings_MouseHover);
            // 
            // btnCatSettings
            // 
            this.btnCatSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCatSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnCatSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnCatSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatSettings.Location = new System.Drawing.Point(1, 143);
            this.btnCatSettings.Name = "btnCatSettings";
            this.btnCatSettings.Size = new System.Drawing.Size(329, 62);
            this.btnCatSettings.TabIndex = 154;
            this.btnCatSettings.Text = "Edit Student";
            this.toolTip1.SetToolTip(this.btnCatSettings, "Edit Student");
            this.btnCatSettings.UseVisualStyleBackColor = true;
            this.btnCatSettings.Click += new System.EventHandler(this.btnCatSettings_Click);
            this.btnCatSettings.MouseHover += new System.EventHandler(this.btnCatSettings_MouseHover);
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
            this.btnMinimize.Location = new System.Drawing.Point(264, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 172;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 62);
            this.button1.TabIndex = 175;
            this.button1.Text = "Student Attendance Report";
            this.toolTip1.SetToolTip(this.button1, "Student Attendance Report");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 62);
            this.button2.TabIndex = 177;
            this.button2.Text = "Serial Communication Settings";
            this.toolTip1.SetToolTip(this.button2, "Serial Communication Settings");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnComplaint
            // 
            this.btnComplaint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComplaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnComplaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaint.Location = new System.Drawing.Point(1, 211);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(329, 62);
            this.btnComplaint.TabIndex = 156;
            this.btnComplaint.Text = "Students Report";
            this.toolTip1.SetToolTip(this.btnComplaint, "Students Report");
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            this.btnComplaint.MouseHover += new System.EventHandler(this.btnComplaint_MouseHover);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(331, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnComplaint);
            this.Controls.Add(this.btnCatSettings);
            this.Controls.Add(this.btnAppSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Settings_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCatSettings;
        internal System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnComplaint;
    }
}