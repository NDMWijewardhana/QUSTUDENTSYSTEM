namespace QUS_Registaion.ui
{
    partial class frmStuden_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
 

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panleStudentDetails = new System.Windows.Forms.Panel();
            this.lbl_RecodCount = new System.Windows.Forms.Label();
            this.btn_Addnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbGriedData = new System.Windows.Forms.GroupBox();
            this.gdvStudentDetails = new System.Windows.Forms.DataGridView();
            this.panleStudentDetails.SuspendLayout();
            this.grbGriedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panleStudentDetails
            // 
            this.panleStudentDetails.Controls.Add(this.lbl_RecodCount);
            this.panleStudentDetails.Controls.Add(this.btn_Addnew);
            this.panleStudentDetails.Controls.Add(this.btnSave);
            this.panleStudentDetails.Controls.Add(this.grbGriedData);
            this.panleStudentDetails.Location = new System.Drawing.Point(0, 5);
            this.panleStudentDetails.Name = "panleStudentDetails";
            this.panleStudentDetails.Size = new System.Drawing.Size(704, 447);
            this.panleStudentDetails.TabIndex = 0;
            // 
            // lbl_RecodCount
            // 
            this.lbl_RecodCount.AutoSize = true;
            this.lbl_RecodCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_RecodCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_RecodCount.Location = new System.Drawing.Point(228, 428);
            this.lbl_RecodCount.Name = "lbl_RecodCount";
            this.lbl_RecodCount.Size = new System.Drawing.Size(0, 13);
            this.lbl_RecodCount.TabIndex = 7;
            // 
            // btn_Addnew
            // 
            this.btn_Addnew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Addnew.Location = new System.Drawing.Point(10, 419);
            this.btn_Addnew.Name = "btn_Addnew";
            this.btn_Addnew.Size = new System.Drawing.Size(75, 23);
            this.btn_Addnew.TabIndex = 6;
            this.btn_Addnew.Text = "Add New";
            this.btn_Addnew.UseVisualStyleBackColor = true;
            this.btn_Addnew.Click += new System.EventHandler(this.btn_Addnew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(624, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbGriedData
            // 
            this.grbGriedData.Controls.Add(this.gdvStudentDetails);
            this.grbGriedData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grbGriedData.Location = new System.Drawing.Point(7, 11);
            this.grbGriedData.Name = "grbGriedData";
            this.grbGriedData.Size = new System.Drawing.Size(692, 404);
            this.grbGriedData.TabIndex = 3;
            this.grbGriedData.TabStop = false;
            this.grbGriedData.Text = "Student Details";
            // 
            // gdvStudentDetails
            // 
            this.gdvStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvStudentDetails.Location = new System.Drawing.Point(3, 17);
            this.gdvStudentDetails.Name = "gdvStudentDetails";
            this.gdvStudentDetails.Size = new System.Drawing.Size(686, 384);
            this.gdvStudentDetails.TabIndex = 0;
            // 
            // frmStuden_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(709, 453);
            this.Controls.Add(this.panleStudentDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStuden_Details";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStuden_Details_Load);
            this.panleStudentDetails.ResumeLayout(false);
            this.panleStudentDetails.PerformLayout();
            this.grbGriedData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvStudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panleStudentDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_Addnew;
        public System.Windows.Forms.Label lbl_RecodCount;
        private System.Windows.Forms.GroupBox grbGriedData;
        public System.Windows.Forms.DataGridView gdvStudentDetails;

    }
}