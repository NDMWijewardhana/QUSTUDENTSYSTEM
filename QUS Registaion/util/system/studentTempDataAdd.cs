using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUS_Registaion.bean;

/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 22 Nov 2012
 * @ Description    : Contain tempery data storage details
 * @ Last Edited    : 22 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.util.system
{
    class studentTempDataAdd
    {
        // Initializing the Struct Object and veriables 
        public int count = 0;    
        //Initializing struct array object and array size
        public stu_Data[]stu_Array= new stu_Data [100];     
        public struct stu_Data
        {
            public int studentId ;
            public string st_Name;
            public DateTime st_DOB ;
            public decimal st_GradePointAvg ;
            public string st_Active ;
        }

        public bool add_TemStudentData(studentBean st_Bean)
        {
            bool status = true;
          

            //Assigning the values to struct array
            stu_Array[count].studentId          = st_Bean.Studentid;
            stu_Array[count].st_Name            = st_Bean.St_name;
            stu_Array[count].st_DOB             = st_Bean.Dob;
            stu_Array[count].st_GradePointAvg   = st_Bean.St_gradepointavg;
            stu_Array[count].st_Active          = st_Bean.St_active;

           /* stu_Array[count].studentId = 10;
            stu_Array[count].st_Name = "dfsgfg";
            stu_Array[count].st_DOB = DateTime.Now;
            stu_Array[count].st_GradePointAvg = 2;
            stu_Array[count].st_Active = "yes";*/

            //Array count increment by 1
            count = count + 1;
            //return status
            return status;
        }
    }
}
