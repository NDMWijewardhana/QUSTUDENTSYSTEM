using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QUS_Registaion.util.system;
using QUS_Registaion.util.db;
using QUS_Registaion.bean;
using System.Data;

/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 21 Nov 2012
 * @ Description    : Contain all system messages used in the system 
 * @ Last Edited    : 23 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.persistence
{
    class studentDB
    {
        public int getLastStID(SqlConnection sqlConn, SqlTransaction sqlTxn)
        {
            //Creating variable and objects           
            int stId = 0;
            //Inisilizing the Sql Command
            SqlCommand sqlCmd= new SqlCommand ();
            SqlDataReader sqlDr = null; 
            
            try
            {
                //Calling  the sp_GetLastStudentId add  table data
                sqlCmd = new SqlCommand("sp_GetLastStudentId", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Transaction = sqlTxn;

                sqlDr = sqlCmd.ExecuteReader();

                while (sqlDr.Read())
                {
                    stId = (int)sqlDr[0];
                }
                //Commit Transaction if there is no error occured 
                sqlDr.Close();
                sqlTxn.Commit();
            }
            catch (SqlException ex)
            {
                //Rowllback if error orcured and throwing error next layer
                sqlTxn.Rollback();
                throw ex;
            }
            finally
            {
                //disposing the conn object sqlcmd objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }
                
            }
            //return the value
            return stId;
        }

        public bool add_TemStudentData(studentBean st_Bean, SqlConnection sqlConn, SqlTransaction sqlTxn)
        {
           
            //Creating variable and objects

            SqlCommand sqlCmd = new SqlCommand();
            bool status = false;

            try
            {
                //Calling  the sp_InsertTempStudentData add temp table data
                sqlCmd = new SqlCommand("sp_InsertTempStudentData", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //Assing Sql Transaction sql Command
                sqlCmd.Transaction = sqlTxn;

                //seting the parameter data types
                sqlCmd.Parameters.Add("@studentId",SqlDbType.Int);
                sqlCmd.Parameters.Add("@st_Name", SqlDbType.VarChar);
                sqlCmd.Parameters.Add("@st_DOB", SqlDbType.DateTime);
                sqlCmd.Parameters.Add("@st_GradePointAvg", SqlDbType.Decimal);
                sqlCmd.Parameters.Add("@st_Active", SqlDbType.VarChar);

                //Assing the values for parametters
                sqlCmd.Parameters["@studentId"].Value = st_Bean.Studentid;
                sqlCmd.Parameters["@st_Name"].Value = st_Bean.St_name;
                sqlCmd.Parameters["@st_DOB"].Value = st_Bean.Dob;
                sqlCmd.Parameters["@st_GradePointAvg"].Value = st_Bean.St_gradepointavg;
                sqlCmd.Parameters["@st_Active"].Value = st_Bean.St_active;

                sqlCmd.ExecuteNonQuery();
                //Commit Transaction if there is no error occured
                sqlTxn.Commit();
                //set the status to true
                status = true;
              
            }
            catch (SqlException ex)
            {
                //Rowllback if error orcured and throwing error next layer
                sqlTxn.Rollback();
                throw ex;
            }
            finally
            {
                //disposing the conn object sqlcmd objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }
               
            }
            //returnig the value
            return status;
        }
        public bool add_StudentData( SqlConnection sqlConn, SqlTransaction sqlTxn)
        {
            //Creating variable and objects
            SqlCommand sqlCmd = new SqlCommand();
            bool status = false;

            try
            {
                //Calling  the sp_InsertStudentData add  table data
                sqlCmd = new SqlCommand("sp_InsertStudentData", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Transaction = sqlTxn;

                sqlCmd.ExecuteNonQuery();
                //Commit Transaction if there is no error occured
                sqlTxn.Commit();

                //set the status to true
                status = true;

            }
            catch (SqlException ex)
            {
                //Rowllback if error orcured and throwing error next layer
                sqlTxn.Rollback();
                throw ex;
            }
            finally
            {
                //disposing the conn object sqlcmd objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }

            }
            //returnig the value
            return status;
        }
        public DataSet getAllTepDataDorDataGride(SqlConnection sqlConn, SqlTransaction sqlTxn)
        {
            //Creating variable and objects           
            DataSet ds = null;
            SqlCommand sqlCmd = new SqlCommand();
            SqlDataAdapter sqlAdpt = null;

            try
            {
                sqlAdpt = new SqlDataAdapter();
                ds = new DataSet();

                //Calling  the sp_GetAllStudentdata add  table data
                sqlCmd = new SqlCommand("sp_GetAllStudentdata", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Transaction = sqlTxn;

                sqlAdpt.SelectCommand = sqlCmd;
                sqlAdpt.Fill(ds, "student_Data");
                sqlCmd.ExecuteNonQuery();                
               
                //Commit Transaction if there is no error occured
                sqlTxn.Commit();
                
            }
            catch (SqlException ex)
            {
                //Rowllback if error orcured and throwing error next layer
                sqlTxn.Rollback();
                throw ex;
            }
            finally
            {
                //disposing the conn object sqlcmd objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }
                sqlAdpt.Dispose();
            }
            //returnig the value
            return ds;
        }

        public int getTemCount(SqlConnection sqlConn, SqlTransaction sqlTxn)
        {
            //Creating variable and objects           
            int data_Count = 0;
            //Inisilizing the Sql Command
            SqlCommand sqlCmd= new SqlCommand ();
            SqlDataReader sqlDr = null; 
            
            try
            {
                //Calling  the sp_GetLastStudentId add  table data
                sqlCmd = new SqlCommand("sp_GetCount", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Transaction = sqlTxn;

                sqlDr = sqlCmd.ExecuteReader();

                while (sqlDr.Read())
                {
                    data_Count = (int)sqlDr[0];
                }
                //Commit Transaction if there is no error occured 
                sqlDr.Close();
                sqlTxn.Commit();
            }
            catch (SqlException ex)
            {
                //Rowllback if error orcured and throwing error next layer
                sqlTxn.Rollback();
                throw ex;
            }
            finally
            {
                //disposing the conn object sqlcmd objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }
                
            }
            //return the value
            return data_Count;
        }
          
       
        public bool delete_TempData(SqlConnection sqlConn, SqlTransaction sqlTxn)
        {
            //Creating variable and objects

            SqlCommand sqlCmd = new SqlCommand();
            bool status = false;

            try
            {
                //Calling  the sp_InsertStudentData delete temp table data
                sqlCmd = new SqlCommand("sp_DeleteTempStudentData", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //Assing Sql Transaction sql Command
                sqlCmd.Transaction = sqlTxn;

                sqlCmd.ExecuteNonQuery();
                //Commit Transaction if there is no error occured
                sqlTxn.Commit();

                //Assing status true
                status = true;

            }
            catch (SqlException ex)
            {
                //Rowllback if error orcured and throwing error next layer
                sqlTxn.Rollback();
                throw ex;
            }
            finally
            {
                //disposing the conn object sqlcmd objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlCmd != null)
                {
                    sqlCmd.Dispose();
                }
            }
            //returnig the value
            return status;
        }
    }
 }
    

