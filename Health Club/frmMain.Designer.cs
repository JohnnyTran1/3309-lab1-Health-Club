
namespace Health_Club
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
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.gboTypeOfMember = new System.Windows.Forms.GroupBox();
            this.gboMembershipFees = new System.Windows.Forms.GroupBox();
            this.lblTotalEnter = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblMonthlyFeeEnter = new System.Windows.Forms.Label();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.gboMembershipLength = new System.Windows.Forms.GroupBox();
            this.lblEnterMonthsError = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lblEnterTheNumberOfMonths = new System.Windows.Forms.Label();
            this.gboOptions = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTypeOFMemberShipError = new System.Windows.Forms.Label();
            this.gboTypeOfMember.SuspendLayout();
            this.gboMembershipFees.SuspendLayout();
            this.gboMembershipLength.SuspendLayout();
            this.gboOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(28, 19);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(51, 17);
            this.chkYoga.TabIndex = 0;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            this.chkYoga.CheckedChanged += new System.EventHandler(this.chkYoga_CheckedChanged);
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(28, 42);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(57, 17);
            this.chkKarate.TabIndex = 1;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            this.chkKarate.CheckedChanged += new System.EventHandler(this.chkKarate_CheckedChanged);
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Location = new System.Drawing.Point(28, 65);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(103, 17);
            this.chkTrainer.TabIndex = 2;
            this.chkTrainer.Text = "Personal Trainer";
            this.chkTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTrainer.UseVisualStyleBackColor = true;
            this.chkTrainer.CheckedChanged += new System.EventHandler(this.chkTrainer_CheckedChanged);
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(41, 11);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(95, 17);
            this.radAdult.TabIndex = 3;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            this.radAdult.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(41, 57);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(62, 17);
            this.radStudent.TabIndex = 4;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(41, 34);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(111, 17);
            this.radChild.TabIndex = 5;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child (12 or under)";
            this.radChild.UseVisualStyleBackColor = true;
            this.radChild.CheckedChanged += new System.EventHandler(this.radChild_CheckedChanged);
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(41, 80);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(142, 17);
            this.radSenior.TabIndex = 6;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen (ages 65+)";
            this.radSenior.UseVisualStyleBackColor = true;
            this.radSenior.CheckedChanged += new System.EventHandler(this.radSenior_CheckedChanged);
            // 
            // gboTypeOfMember
            // 
            this.gboTypeOfMember.Controls.Add(this.radChild);
            this.gboTypeOfMember.Controls.Add(this.radSenior);
            this.gboTypeOfMember.Controls.Add(this.radAdult);
            this.gboTypeOfMember.Controls.Add(this.radStudent);
            this.gboTypeOfMember.Location = new System.Drawing.Point(26, 32);
            this.gboTypeOfMember.Name = "gboTypeOfMember";
            this.gboTypeOfMember.Size = new System.Drawing.Size(200, 112);
            this.gboTypeOfMember.TabIndex = 7;
            this.gboTypeOfMember.TabStop = false;
            this.gboTypeOfMember.Text = "Type Of Membership";
            this.gboTypeOfMember.Enter += new System.EventHandler(this.gboTypeOfMember_Enter);
            // 
            // gboMembershipFees
            // 
            this.gboMembershipFees.Controls.Add(this.lblTotalEnter);
            this.gboMembershipFees.Controls.Add(this.lblTotalFee);
            this.gboMembershipFees.Controls.Add(this.lblMonthlyFeeEnter);
            this.gboMembershipFees.Controls.Add(this.lblMonthlyFee);
            this.gboMembershipFees.Location = new System.Drawing.Point(274, 177);
            this.gboMembershipFees.Name = "gboMembershipFees";
            this.gboMembershipFees.Size = new System.Drawing.Size(200, 100);
            this.gboMembershipFees.TabIndex = 8;
            this.gboMembershipFees.TabStop = false;
            this.gboMembershipFees.Text = "Membership Fees";
            // 
            // lblTotalEnter
            // 
            this.lblTotalEnter.AutoSize = true;
            this.lblTotalEnter.Location = new System.Drawing.Point(26, 57);
            this.lblTotalEnter.Name = "lblTotalEnter";
            this.lblTotalEnter.Size = new System.Drawing.Size(34, 13);
            this.lblTotalEnter.TabIndex = 12;
            this.lblTotalEnter.Text = "Total:";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(110, 57);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(65, 13);
            this.lblTotalFee.TabIndex = 15;
            this.lblTotalFee.Text = "PlaceHolder";
            this.lblTotalFee.Visible = false;
            // 
            // lblMonthlyFeeEnter
            // 
            this.lblMonthlyFeeEnter.AutoSize = true;
            this.lblMonthlyFeeEnter.Location = new System.Drawing.Point(26, 27);
            this.lblMonthlyFeeEnter.Name = "lblMonthlyFeeEnter";
            this.lblMonthlyFeeEnter.Size = new System.Drawing.Size(68, 13);
            this.lblMonthlyFeeEnter.TabIndex = 14;
            this.lblMonthlyFeeEnter.Text = "Monthly Fee:";
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Location = new System.Drawing.Point(110, 27);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(68, 13);
            this.lblMonthlyFee.TabIndex = 13;
            this.lblMonthlyFee.Text = "Place Holder";
            this.lblMonthlyFee.Visible = false;
            // 
            // gboMembershipLength
            // 
            this.gboMembershipLength.Controls.Add(this.lblEnterMonthsError);
            this.gboMembershipLength.Controls.Add(this.txtMonths);
            this.gboMembershipLength.Controls.Add(this.lblEnterTheNumberOfMonths);
            this.gboMembershipLength.Location = new System.Drawing.Point(26, 177);
            this.gboMembershipLength.Name = "gboMembershipLength";
            this.gboMembershipLength.Size = new System.Drawing.Size(200, 100);
            this.gboMembershipLength.TabIndex = 1;
            this.gboMembershipLength.TabStop = false;
            this.gboMembershipLength.Text = "Membership Length";
            // 
            // lblEnterMonthsError
            // 
            this.lblEnterMonthsError.AutoSize = true;
            this.lblEnterMonthsError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnterMonthsError.Location = new System.Drawing.Point(7, 81);
            this.lblEnterMonthsError.Name = "lblEnterMonthsError";
            this.lblEnterMonthsError.Size = new System.Drawing.Size(68, 13);
            this.lblEnterMonthsError.TabIndex = 2;
            this.lblEnterMonthsError.Text = "Place Holder";
            this.lblEnterMonthsError.Visible = false;
            this.lblEnterMonthsError.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(6, 57);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(188, 20);
            this.txtMonths.TabIndex = 1;
            // 
            // lblEnterTheNumberOfMonths
            // 
            this.lblEnterTheNumberOfMonths.AutoSize = true;
            this.lblEnterTheNumberOfMonths.Location = new System.Drawing.Point(41, 27);
            this.lblEnterTheNumberOfMonths.Name = "lblEnterTheNumberOfMonths";
            this.lblEnterTheNumberOfMonths.Size = new System.Drawing.Size(143, 13);
            this.lblEnterTheNumberOfMonths.TabIndex = 0;
            this.lblEnterTheNumberOfMonths.Text = "Enter the Number of Months:";
            this.lblEnterTheNumberOfMonths.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gboOptions
            // 
            this.gboOptions.Controls.Add(this.chkYoga);
            this.gboOptions.Controls.Add(this.chkKarate);
            this.gboOptions.Controls.Add(this.chkTrainer);
            this.gboOptions.Location = new System.Drawing.Point(274, 32);
            this.gboOptions.Name = "gboOptions";
            this.gboOptions.Size = new System.Drawing.Size(200, 100);
            this.gboOptions.TabIndex = 1;
            this.gboOptions.TabStop = false;
            this.gboOptions.Text = "Options";
            this.gboOptions.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 322);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 40);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTypeOFMemberShipError
            // 
            this.lblTypeOFMemberShipError.AutoSize = true;
            this.lblTypeOFMemberShipError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTypeOFMemberShipError.Location = new System.Drawing.Point(23, 147);
            this.lblTypeOFMemberShipError.Name = "lblTypeOFMemberShipError";
            this.lblTypeOFMemberShipError.Size = new System.Drawing.Size(68, 13);
            this.lblTypeOFMemberShipError.TabIndex = 3;
            this.lblTypeOFMemberShipError.Text = "Place Holder";
            this.lblTypeOFMemberShipError.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTypeOFMemberShipError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gboMembershipLength);
            this.Controls.Add(this.gboOptions);
            this.Controls.Add(this.gboMembershipFees);
            this.Controls.Add(this.gboTypeOfMember);
            this.Name = "frmMain";
            this.Text = "Membership Fee Calculator";
            this.gboTypeOfMember.ResumeLayout(false);
            this.gboTypeOfMember.PerformLayout();
            this.gboMembershipFees.ResumeLayout(false);
            this.gboMembershipFees.PerformLayout();
            this.gboMembershipLength.ResumeLayout(false);
            this.gboMembershipLength.PerformLayout();
            this.gboOptions.ResumeLayout(false);
            this.gboOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.GroupBox gboTypeOfMember;
        private System.Windows.Forms.GroupBox gboMembershipFees;
        private System.Windows.Forms.GroupBox gboMembershipLength;
        private System.Windows.Forms.GroupBox gboOptions;
        private System.Windows.Forms.Label lblTotalEnter;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblMonthlyFeeEnter;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label lblEnterTheNumberOfMonths;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEnterMonthsError;
        private System.Windows.Forms.Label lblTypeOFMemberShipError;
    }
}

