using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Beach
    {//private variables
        private int bschoolId = 0;
        private string bfirstName = "n/a";
        private string blastName = "n/a";
        private string bmajor = "n/a";

        //gets and sets

        public int BschoolId
        {
            get { return this.bschoolId; }
            set { this.bschoolId = value; }
        }

        public string BfirstName
        {
            get { return this.bfirstName; }
            set { this.bfirstName = value; }
        }

        public string BlastName
        {
            get { return this.blastName; }
            set { this.blastName = value; }
        }

        public string BMajor
        {
            get { return this.bmajor; }
            set { this.bmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + BschoolId + "</br>";
            aMessage = aMessage + "First Name:" + BfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + BlastName + "</br>";
            aMessage = aMessage + " Major:" + BMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public Beach()
        { }
        public Beach(int aBschoolId, string aBfirstName, string aBlastName, string aBMajor)
            : this()
        {
            this.BschoolId = aBschoolId;
            this.BfirstName = aBfirstName;
            this.BlastName = aBlastName;
            this.BMajor = aBMajor;
        }

        public Beach(int aBschoolId, string aBfirstName, string aBlastName)
            : this(aBschoolId, aBfirstName, aBlastName, "n/a")
        { }

        public Beach(int aBschoolId, string aBfirstName)
            : this(aBschoolId, aBfirstName, "n/a", "n/a")
        { }

        public Beach(int aBschoolId)
            : this(aBschoolId, "n/a", "n/a", "n/a")
        { }


    }
}