using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUS_Registaion.businesslogic;
using QUS_Registaion.util.system;
using QUS_Registaion.bean;
using QUS_Registaion.ui;

namespace QUS_Registaion.ui
{
    public partial class frmStudentRegistation : Form
    {
        
        public frmStudentRegistation()
        {
            InitializeComponent();
        }
                
        private void frmStudentRegistation_Load(object sender, EventArgs e)
        {
            setStudentId();            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            globleVeriables.STU_ID = globleVeriables.STU_ID - 1;
            clear_Content();
            
            
        }
        public void setStudentId()
        {
            studentInfo stInfo = null;

            try
            {
                if (globleVeriables.STU_ID == 0)
                {
                    stInfo = new studentInfo();
                    int x = 0;
                    int tot = 0;

                    int i   = globleVeriables.STU_ID; 
                   
                    x = stInfo.getLastStID();

                    if (x == -1)
                    {
                        globleVeriables.STU_ID =  1;
                        txtStudentId.Text = globleVeriables.STU_ID.ToString();
                    }
                    else
                    {
                    tot = (x+1);
                    txtStudentId.Text = tot.ToString();
                    globleVeriables.STU_ID = tot;
                    }
                }
               
                else if (globleVeriables.STU_ID > 0)
                {
                    int y = 0;
                    int tot2 = 0;
                    y = globleVeriables.STU_ID;
                    tot2 = y+ 1;
                    txtStudentId.Text = tot2.ToString();
                    globleVeriables.STU_ID = tot2;
                }

            }
            catch (SqlException ex)
            {
                globleVeriables.STU_ID = globleVeriables.STU_ID - 1;
                if (ex.Message.Equals("Database Not Found!"))
                {
                    MessageBox.Show(systemMessage.DATABASE_NOTFOUND, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(systemMessage.TABLE_FAILED, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            studentBean stBean              = null;
            studentInfo stInfo = null;

            if (valid_control())
            {
                try
                {
                    stBean = new studentBean();
                    stInfo = new studentInfo();

                    stBean.Studentid = Int32.Parse(this.txtStudentId.Text.ToString().Trim());
                    stBean.St_name = this.txtStudentName.Text.Trim();
                    stBean.Dob = DateTime.Parse(this.dtpDOB.Text.Trim());
                    stBean.St_gradepointavg = Decimal.Parse(this.txtGradeAvg.Text.Trim());

                    if (this.cbTrue.Checked)
                    {
                        stBean.St_active = "Yes";
                    }
                    else
                    {
                        stBean.St_active = "No";
                    }

                    if (stInfo.add_TemStudentData(stBean))
                    { 
                        MessageBox.Show(systemMessage.TEMP_SAVE, systemMessage.MESSAGEBOXTITLE_SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmStuden_Details frm_Stdetail = new frmStuden_Details();                        
                        globleVeriables.STU_ID = globleVeriables.STU_ID - 1;
                                                
                        frmMain frm_M = new frmMain();                        
                        frm_Stdetail.MdiParent = frm_M;
                        frm_M.mainPanel.Controls.Clear();
                        frm_M.mainPanel.Controls.Add(frm_Stdetail);
                        frm_M.mainPanel.Dock = DockStyle.Fill;

                        frm_Stdetail.Show();
                        // Close form
                        this.Dispose();   

                    }
                    else
                    {
                        MessageBox.Show(systemMessage.TEMP_INSERT, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    globleVeriables.STU_ID = globleVeriables.STU_ID - 1;
                    if (ex.Message.Equals("Database Not Found!"))
                    {
                        MessageBox.Show(systemMessage.DATABASE_NOTFOUND, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(systemMessage.TEMP_INSERT, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               

                 
                clear_Content();
                setStudentId();
            }
        }
        public void clear_Content()
        {
            
            this.txtStudentName.Text = string.Empty;
            this.txtGradeAvg.Text = string.Empty; ;
            
        }
        public bool valid_control()
        {
            bool flag = true;
            string check_val = txtGradeAvg.Text.Trim();
            double check_Num;

            bool isNum = double.TryParse(check_val, out check_Num);

            if (txtStudentName.Text.Trim() == string.Empty)
            {
                epStname.SetError(txtStudentName, "Student name is required !");
                flag = false;
            }
            else if(txtGradeAvg.Text.Trim()== string.Empty)
            {
                epSradeAvg.SetError(txtGradeAvg, "Student great average is required !");
                flag = false;
            }
            else if (!isNum)
            {
                MessageBox.Show(systemMessage.NUM_VAL, systemMessage.MESSAGEBOXTITLE_SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            return flag;
        }

      

      
    }
}
