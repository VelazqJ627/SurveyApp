using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Drake
    {//private variables
        private int drschoolId = 0;
        private string drfirstName = "n/a";
        private string drlastName = "n/a";
        private string drmajor = "n/a";

        //gets and sets

        public int DRschoolId
        {
            get { return this.drschoolId; }
            set { this.drschoolId = value; }
        }

        public string DRfirstName
        {
            get { return this.drfirstName; }
            set { this.drfirstName = value; }
        }

        public string DRlastName
        {
            get { return this.drlastName; }
            set { this.drlastName = value; }
        }

        public string DRMajor
        {
            get { return this.drmajor; }
            set { this.drmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + DRschoolId + "</br>";
            aMessage = aMessage + "First Name:" + DRfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + DRlastName + "</br>";
            aMessage = aMessage + " Major:" + DRMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public Drake()
        { }
        public Drake(int aDRschoolId, string aDRfirstName, string aDRlastName, string aDRMajor)
            : this()
        {
            this.DRschoolId = aDRschoolId;
            this.DRfirstName = aDRfirstName;
            this.DRlastName = aDRlastName;
            this.DRMajor = aDRMajor;
        }

        public Drake(int aDRschoolId, string aDRfirstName, string aDRlastName)
            : this(aDRschoolId, aDRfirstName, aDRlastName, "n/a")
        { }

        public Drake(int aDRschoolId, string aDRfirstName)
            : this(aDRschoolId, aDRfirstName, "n/a", "n/a")
        { }

        public Drake(int aDRschoolId)
            : this(aDRschoolId, "n/a", "n/a", "n/a")
        { }


    }
}