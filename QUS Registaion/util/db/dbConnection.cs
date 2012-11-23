using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 21 Nov 2012
 * @ Description    : Contain Database configaration
 * @ Last Edited    : 21 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.util.db
{
    class dbConnection
    {
        private string conString = null;

        public SqlConnection getConnection()
        {
            //Sql Connection object cretion
            SqlConnection con = null;

            try
            {
                //Connection String
                conString = "Data Source=HOME-A3B80070D9" + "\\" + "SQLEXPRESS;Initial Catalog=Student Registration;Integrated Security=True";
                con = new SqlConnection(conString);

                //Connection open
                con.Open();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Closing the connection
                con.Close();

            }

            //returning the connection object
            return con;
        }
    }
}
