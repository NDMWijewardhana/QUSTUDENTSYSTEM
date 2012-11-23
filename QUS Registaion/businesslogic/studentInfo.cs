using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QUS_Registaion.persistence;
using QUS_Registaion.util.db;
using QUS_Registaion.bean;

/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 21 Nov 2012
 * @ Description    : Contain all besinesslogic related to the apllication
 * @ Last Edited    : 21 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.businesslogic
{
    class studentInfo
    {
        public int getLastStID()
        {
            //Creating variable and objects           
            int stId = 0;
            SqlConnection sqlConn = null;
            SqlTransaction sqlTrn = null;
            dbConnection dbConn = null;
            studentDB stDB = null;

            try
            {
                //Inizing objects
                stDB = new studentDB ();
                dbConn = new dbConnection();
                sqlConn = new SqlConnection();   
             
                //Inizing Sql Connection
                sqlConn = dbConn.getConnection();

                //Connection Open
                sqlConn.Open();
                //Transaction Beging
                sqlTrn = sqlConn.BeginTransaction();

                stId = stDB.getLastStID(sqlConn, sqlTrn);             
                            
            }
            catch (SqlException ex)
            {
                //throw exception to next layer
                throw ex;                             
            }
            finally
            {
                //disposing creating objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlTrn.Dispose();
            }
            //returning tha value
            return stId;
        }

        public bool add_TemStudentData(studentBean st_Bean)
        {
            //Creating variable and objects           
            bool status = false;
            SqlConnection sqlConn = null;
            SqlTransaction sqlTrn = null;
            dbConnection dbConn = null;
            studentDB stDB = null;

            try
            {
                //Inizing objects
                stDB = new studentDB();
                dbConn = new dbConnection();
                sqlConn = new SqlConnection();

                //Inizing Sql Connection
                sqlConn = dbConn.getConnection();

                //Connection Open
                sqlConn.Open();
                //Transaction Beging
                sqlTrn = sqlConn.BeginTransaction();
                //Assing the return valeu
                status = stDB.add_TemStudentData(st_Bean,sqlConn, sqlTrn);

            }
            catch (SqlException ex)
            {
                //throw exception to next layer
                throw ex;
            }
            finally
            {
                //disposing creating objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlTrn.Dispose();
            }
            //returning tha value
            return status;
        }
        public bool add_StudentData()
        {
            //Creating variable and objects           
            bool status = false;
            SqlConnection sqlConn = null;
            SqlTransaction sqlTrn = null;
            dbConnection dbConn = null;
            studentDB stDB = null;

            try
            {
                //Inizing objects
                stDB = new studentDB();
                dbConn = new dbConnection();
                sqlConn = new SqlConnection();

                //Inizing Sql Connection
                sqlConn = dbConn.getConnection();

                //Connection Open
                sqlConn.Open();

                //Transaction Beging
                sqlTrn = sqlConn.BeginTransaction();

                //Assing the return valeu
                status = stDB.add_StudentData(sqlConn, sqlTrn);

            }
            catch (SqlException ex)
            {
                //throw exception to next layer
                throw ex;
            }
            finally
            {
                //disposing creating objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlTrn.Dispose();
            }
            //returning tha value
            return status;
        }

        public DataSet getAllTepDataDorDataGride()
        {
            //Creating variable and objects           
            DataSet ds = null;
            SqlConnection sqlConn = null;
            SqlTransaction sqlTrn = null;
            dbConnection dbConn = null;
            studentDB stDB = null;

            try
            {
                //Inizing objects
                stDB = new studentDB();
                dbConn = new dbConnection();
                sqlConn = new SqlConnection();
                ds = new DataSet();

                //Inizing Sql Connection
                sqlConn = dbConn.getConnection();

                //Connection Open
                sqlConn.Open();
                //Transaction Beging

                sqlTrn = sqlConn.BeginTransaction();

                //Assing the return valeu
                ds = stDB.getAllTepDataDorDataGride(sqlConn, sqlTrn);

            }
            catch (SqlException ex)
            {
                //throw exception to next layer
                throw ex;
            }
            finally
            {
                //disposing creating objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlTrn.Dispose();
            }
            //returning tha dataset
            return ds;
        }
        public int getTemCount()
        {
            //Creating variable and objects           
            int data_Count = 0;
            SqlConnection sqlConn = null;
            SqlTransaction sqlTrn = null;
            dbConnection dbConn = null;
            studentDB stDB = null;

            try
            {
                //Inizing objects
                stDB = new studentDB();
                dbConn = new dbConnection();
                sqlConn = new SqlConnection();

                //Inizing Sql Connection
                sqlConn = dbConn.getConnection();

                //Connection Open
                sqlConn.Open();
                //Transaction Beging
                sqlTrn = sqlConn.BeginTransaction();

                //Assing the return valeu
                data_Count = stDB.getTemCount(sqlConn, sqlTrn);

            }
            catch (SqlException ex)
            {
                //throw exception to next layer
                throw ex;
            }
            finally
            {
                //disposing creating objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlTrn.Dispose();
            }
            //returning the count
            return data_Count;
        }

        public bool delete_TempData()
        {
            //Creating variable and objects           
            bool status = false;
            SqlConnection sqlConn = null;
            SqlTransaction sqlTrn = null;
            dbConnection dbConn = null;
            studentDB stDB = null;

            try
            {
                //Inizing objects
                stDB = new studentDB();
                dbConn = new dbConnection();
                sqlConn = new SqlConnection();

                //Inizing Sql Connection
                sqlConn = dbConn.getConnection();

                //Connection Open
                sqlConn.Open();
                //Transaction Beging
                sqlTrn = sqlConn.BeginTransaction();

                //Assing the return valeu
                status = stDB.delete_TempData(sqlConn, sqlTrn);

            }
            catch (SqlException ex)
            {
                //throw exception to next layer
                throw ex;
            }
            finally
            {
                //disposing creating objects
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlTrn.Dispose();
            }
            //returning the status
            return status;
        }
    }
}
