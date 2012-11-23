namespace QUS_Registaion.ui
{
    partial class frmStudentRegistation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer st_components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (st_components != null))
            {
                st_components.Dispose();
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
            this.st_components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistation));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGrateAvg = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtGradeAvg = new System.Windows.Forms.TextBox();
            this.cbTrue = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epStname = new System.Windows.Forms.ErrorProvider(this.st_components);
            this.epSradeAvg = new System.Windows.Forms.ErrorProvider(this.st_components);
            ((System.ComponentModel.ISupportInitialize)(this.epStname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSradeAvg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(12, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Student Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(12, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDOB.Location = new System.Drawing.Point(13, 69);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB";
            // 
            // lblGrateAvg
            // 
            this.lblGrateAvg.AutoSize = true;
            this.lblGrateAvg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGrateAvg.Location = new System.Drawing.Point(12, 95);
            this.lblGrateAvg.Name = "lblGrateAvg";
            this.lblGrateAvg.Size = new System.Drawing.Size(98, 13);
            this.lblGrateAvg.TabIndex = 3;
            this.lblGrateAvg.Text = "Grade Point Avg";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblActive.Location = new System.Drawing.Point(13, 121);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(43, 13);
            this.lblActive.TabIndex = 4;
            this.lblActive.Text = "Active";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudentId.Location = new System.Drawing.Point(119, 9);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(131, 21);
            this.txtStudentId.TabIndex = 5;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudentName.Location = new System.Drawing.Point(119, 37);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(239, 21);
            this.txtStudentName.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(119, 65);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(131, 21);
            this.dtpDOB.TabIndex = 7;
            // 
            // txtGradeAvg
            // 
            this.txtGradeAvg.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGradeAvg.Location = new System.Drawing.Point(119, 92);
            this.txtGradeAvg.Name = "txtGradeAvg";
            this.txtGradeAvg.Size = new System.Drawing.Size(131, 21);
            this.txtGradeAvg.TabIndex = 8;
            // 
            // cbTrue
            // 
            this.cbTrue.AutoSize = true;
            this.cbTrue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbTrue.Location = new System.Drawing.Point(119, 120);
            this.cbTrue.Name = "cbTrue";
            this.cbTrue.Size = new System.Drawing.Size(15, 14);
            this.cbTrue.TabIndex = 9;
            this.cbTrue.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(119, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(217, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epStname
            // 
            this.epStname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epStname.ContainerControl = this;
            // 
            // epSradeAvg
            // 
            this.epSradeAvg.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epSradeAvg.ContainerControl = this;
            // 
            // frmStudentRegistation
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(506, 192);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbTrue);
            this.Controls.Add(this.txtGradeAvg);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblGrateAvg);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentRegistation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "© Queens\'s University  Student Registration System : Student Registration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmStudentRegistation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epStname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSradeAvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGrateAvg;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtGradeAvg;
        private System.Windows.Forms.CheckBox cbTrue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epStname;
        private System.Windows.Forms.ErrorProvider epSradeAvg;
    }
}