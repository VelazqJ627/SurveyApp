using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Metallica
    {//private variables
        private int mschoolId = 0;
        private string mfirstName = "n/a";
        private string mlastName = "n/a";
        private string mmajor = "n/a";

        //gets and sets

        public int MschoolId
        {
            get { return this.mschoolId; }
            set { this.mschoolId = value; }
        }

        public string MfirstName
        {
            get { return this.mfirstName; }
            set { this.mfirstName = value; }
        }

        public string MlastName
        {
            get { return this.mlastName; }
            set { this.mlastName = value; }
        }

        public string MMajor
        {
            get { return this.mmajor; }
            set { this.mmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + MschoolId + "</br>";
            aMessage = aMessage + "First Name:" + MfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + MlastName + "</br>";
            aMessage = aMessage + " Major:" + MMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public Metallica()
        { }
        public Metallica(int aMschoolId, string aMfirstName, string aMlastName, string aMMajor)
            : this()
        {
            this.MschoolId = aMschoolId;
            this.MfirstName = aMfirstName;
            this.MlastName = aMlastName;
            this.MMajor = aMMajor;
        }

        public Metallica(int aMschoolId, string aMfirstName, string aMlastName)
            : this(aMschoolId, aMfirstName, aMlastName, "n/a")
        { }

        public Metallica(int aMschoolId, string aMfirstName)
            : this(aMschoolId, aMfirstName, "n/a", "n/a")
        { }

        public Metallica(int aMschoolId)
            : this(aMschoolId, "n/a", "n/a", "n/a")
        { }


    }
}