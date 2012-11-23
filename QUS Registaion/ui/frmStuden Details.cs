using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUS_Registaion.ui;
using QUS_Registaion.util.system;
using QUS_Registaion.businesslogic;


/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 21 Nov 2012
 * @ Description    : Student details form
 * @ Last Edited    : 22 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.ui
{
    public partial class frmStuden_Details : Form
    {
        public frmStuden_Details()
        {
            InitializeComponent();
        }
        
    
        private void frmStuden_Details_Load(object sender, EventArgs e)
        {
            fill_DataGried();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fill_DataGried();
            studentInfo st_Info = new studentInfo();
            int count = st_Info.getTemCount();
            frmMain frm_M = new frmMain();
            frmStudentRegistation frm_Reg = new frmStudentRegistation();

            try
            {
                if (st_Info.add_StudentData() && st_Info.delete_TempData())
                {
                    DialogResult dResult = MessageBox.Show( +count+"  "+"Records added successfully.", systemMessage.MESSAGEBOXTITLE_SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dResult == DialogResult.OK)
                    {
                       
                        frmStuden_Details frm_Stdetail = new frmStuden_Details();
                        
                        frmMain frm_M1 = new frmMain();
                        frm_Stdetail.MdiParent = frm_M1;
                        frm_M1.mainPanel.Controls.Clear();
                        frm_M1.mainPanel.Controls.Add(frm_Stdetail);
                        frm_M1.mainPanel.Dock = DockStyle.Fill;
                        frm_Stdetail.Show();
                        this.Close();
                        fill_DataGried();
                                             
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(systemMessage.TEMP_INSERT, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        
        private void btn_Addnew_Click(object sender, EventArgs e)
        {
            frmStudentRegistation frm_Reg = new frmStudentRegistation();    
            
            frm_Reg.Show();
            fill_DataGried();
            
        }
        
       
        public void fill_DataGried()
        {
            studentInfo st_Info = null;
            DataSet ds = null;

            try
            {
                st_Info = new studentInfo();
                ds = new DataSet();

                ds = st_Info.getAllTepDataDorDataGride();

                this.gdvStudentDetails.DataSource = ds;
                this.gdvStudentDetails.DataMember = "student_Data";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ds.Dispose();
            }
        }
        

    }
}
