using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Wild
    {//private variables
        private int wschoolId = 0;
        private string wfirstName = "n/a";
        private string wlastName = "n/a";
        private string wmajor = "n/a";

        //gets and sets

        public int WschoolId
        {
            get { return this.wschoolId; }
            set { this.wschoolId = value; }
        }

        public string WfirstName
        {
            get { return this.wfirstName; }
            set { this.wfirstName = value; }
        }

        public string WlastName
        {
            get { return this.wlastName; }
            set { this.wlastName = value; }
        }

        public string WMajor
        {
            get { return this.wmajor; }
            set { this.wmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + WschoolId + "</br>";
            aMessage = aMessage + "First Name:" + WfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + WlastName + "</br>";
            aMessage = aMessage + " Major:" + WMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public Wild()
        { }
        public Wild(int aWschoolId, string aWfirstName, string aWlastName, string aWMajor)
            : this()
        {
            this.WschoolId = aWschoolId;
            this.WfirstName = aWfirstName;
            this.WlastName = aWlastName;
            this.WMajor = aWMajor;
        }

        public Wild(int aWschoolId, string aWfirstName, string aWlastName)
            : this(aWschoolId, aWfirstName, aWlastName, "n/a")
        { }

        public Wild(int aWschoolId, string aWfirstName)
            : this(aWschoolId, aWfirstName, "n/a", "n/a")
        { }

        public Wild(int aWschoolId)
            : this(aWschoolId, "n/a", "n/a", "n/a")
        { }


    }
}