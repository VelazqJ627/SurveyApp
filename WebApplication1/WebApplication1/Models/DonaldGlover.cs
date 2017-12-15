using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DonaldGlover
    { //private variables
        private int dschoolId = 0;
        private string dfirstName = "n/a";
        private string dlastName = "n/a";
        private string dmajor = "n/a";

        //gets and sets

        public int DschoolId
        {
            get { return this.dschoolId; }
            set { this.dschoolId = value; }
        }

        public string DfirstName
        {
            get { return this.dfirstName; }
            set { this.dfirstName = value; }
        }

        public string DlastName
        {
            get { return this.dlastName; }
            set { this.dlastName = value; }
        }

        public string DMajor
        {
            get { return this.dmajor; }
            set { this.dmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + DschoolId + "</br>";
            aMessage = aMessage + "First Name:" + DfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + DlastName + "</br>";
            aMessage = aMessage + " Major:" + DMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public DonaldGlover()
        { }
        public DonaldGlover(int aDschoolId, string aDfirstName, string aDlastName, string aDMajor)
            : this()
        {
            this.DschoolId = aDschoolId;
            this.DfirstName = aDfirstName;
            this.DlastName = aDlastName;
            this.DMajor = aDMajor;
        }

        public DonaldGlover(int aDschoolId, string aDfirstName, string aDlastName)
            : this(aDschoolId, aDfirstName, aDlastName, "n/a")
        { }

        public DonaldGlover(int aDschoolId, string aDfirstName)
            : this(aDschoolId, aDfirstName, "n/a", "n/a")
        { }

        public DonaldGlover(int aDschoolId)
            : this(aDschoolId, "n/a", "n/a", "n/a")
        { }


    }
}