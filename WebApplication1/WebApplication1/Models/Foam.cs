using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Foam
    {//private variables
        private int fschoolId = 0;
        private string ffirstName = "n/a";
        private string flastName = "n/a";
        private string fmajor = "n/a";

        //gets and sets

        public int FschoolId
        {
            get { return this.fschoolId; }
            set { this.fschoolId = value; }
        }

        public string FfirstName
        {
            get { return this.ffirstName; }
            set { this.ffirstName = value; }
        }

        public string FlastName
        {
            get { return this.flastName; }
            set { this.flastName = value; }
        }

        public string FMajor
        {
            get { return this.fmajor; }
            set { this.fmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + FschoolId + "</br>";
            aMessage = aMessage + "First Name:" + FfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + FlastName + "</br>";
            aMessage = aMessage + " Major:" + FMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public Foam()
        { }
        public Foam(int aFschoolId, string aFfirstName, string aFlastName, string aFMajor)
            : this()
        {
            this.FschoolId = aFschoolId;
            this.FfirstName = aFfirstName;
            this.FlastName = aFlastName;
            this.FMajor = aFMajor;
        }

        public Foam(int aFschoolId, string aFfirstName, string aFlastName)
            : this(aFschoolId, aFfirstName, aFlastName, "n/a")
        { }

        public Foam(int aFschoolId, string aFfirstName)
            : this(aFschoolId, aFfirstName, "n/a", "n/a")
        { }

        public Foam(int aFschoolId)
            : this(aFschoolId, "n/a", "n/a", "n/a")
        { }
    }
}