using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 22 Nov 2012
 * @ Description    : Contain all system messages used in the system 
 * @ Last Edited    : 22 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.util.system
{
    class systemMessage
    {
        #region DATABASE CONNECTION

        public static readonly string DATABASE_NOTFOUND = "Database not exist.";

        public static readonly string TABLE_NOTFOUND = "Table not exist.";
        public static readonly string TABLE_FAILED = "Faield to connect table.";
        public static readonly string MESSAGEBOXTITLE = "Error";
        public static readonly string MESSAGEBOXTITLE_SUCCESS = "Information";

        public static readonly string TEMP_INSERT = "Failed to insert record.";
        public static readonly string TEMP_SAVE = "Record add to view successfully.";
        public static readonly string SAVE = "Record added successfully.";

        public static readonly string EXIT_APP = "Do you want save data be for you exit?  ";

        public static readonly string NUM_VAL = "Please enter Numerical value for Grade Point Avg!";
        #endregion
    }
}
