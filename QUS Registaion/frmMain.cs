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

namespace QUS_Registaion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globleVeriables.STU_ID = 0;
            studentInfo st_Info = new studentInfo ();
            int count = st_Info.getTemCount();

            if (count > 0)
            {

                DialogResult dialogResult = MessageBox.Show(systemMessage.EXIT_APP, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK)
                {
                    
                    try
                    {
                        if (st_Info.add_StudentData()&& st_Info.delete_TempData())
                        {
                            DialogResult dResult = MessageBox.Show(+count+"  "+"Records add to view successfully.", systemMessage.MESSAGEBOXTITLE_SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (dResult == DialogResult.OK)
                            {
                                Application.Exit(); ;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(systemMessage.TEMP_INSERT, systemMessage.MESSAGEBOXTITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuden_Details frmSD = new frmStuden_Details();

            frmSD.MdiParent = this;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(frmSD);
            frmSD.Dock = DockStyle.Fill;
            //this.panel3.Height = 400;
            frmSD.Show();

            //frmStuden_Details frmSD = new frmStuden_Details (); 
            //frmSD.ShowDialog();
            this.Text = "© Queens's University  Student Registration System : Student Details";            

        }    
 
    }
}
