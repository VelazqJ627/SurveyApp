using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usher
    {//private variables
        private int uschoolId = 0;
        private string ufirstName = "n/a";
        private string ulastName = "n/a";
        private string umajor = "n/a";

        //gets and sets

        public int UschoolId
        {
            get { return this.uschoolId; }
            set { this.uschoolId = value; }
        }

        public string UfirstName
        {
            get { return this.ufirstName; }
            set { this.ufirstName = value; }
        }

        public string UlastName
        {
            get { return this.ulastName; }
            set { this.ulastName = value; }
        }

        public string UMajor
        {
            get { return this.umajor; }
            set { this.umajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + UschoolId + "</br>";
            aMessage = aMessage + "First Name:" + UfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + UlastName + "</br>";
            aMessage = aMessage + " Major:" + UMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public Usher()
        { }
        public Usher(int aUschoolId, string aUfirstName, string aUlastName, string aUMajor)
            : this()
        {
            this.UschoolId = aUschoolId;
            this.UfirstName = aUfirstName;
            this.UlastName = aUlastName;
            this.UMajor = aUMajor;
        }

        public Usher(int aUschoolId, string aUfirstName, string aUlastName)
            : this(aUschoolId, aUfirstName, aUlastName, "n/a")
        { }

        public Usher(int aUschoolId, string aUfirstName)
            : this(aUschoolId, aUfirstName, "n/a", "n/a")
        { }

        public Usher(int aUschoolId)
            : this(aUschoolId, "n/a", "n/a", "n/a")
        { }


    }
}