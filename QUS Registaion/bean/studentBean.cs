using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * @ By             : Dushantha Madushan Wijewardhana 
 * @ Date           : 21 Nov 2012
 * @ Description    : Contain all bean data
 * @ Last Edited    : 22 Nov 2012
 * @ Last Edit By   : Dushantha Madushan Wijewardhana  
 * */

namespace QUS_Registaion.bean
{
    class studentBean
    {
        int studentid = 0;

        public int Studentid
        {
            get { return studentid; }
            set { studentid = value; }
        }
        string st_name = null;

        public string St_name
        {
            get { return st_name; }
            set { st_name = value; }
        }

        DateTime dob = DateTime.Now;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        decimal st_gradepointavg = 0;

        public decimal St_gradepointavg
        {
            get { return st_gradepointavg; }
            set { st_gradepointavg = value; }
        }

        string st_active;

        public string St_active
        {
            get { return st_active; }
            set { st_active = value; }
        }        
    }
}
