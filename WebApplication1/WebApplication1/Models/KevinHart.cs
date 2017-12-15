using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class KevinHart
    {
        //private variables
        private int kschoolId = 0;
        private string kfirstName = "n/a";
        private string klastName = "n/a";
        private string kmajor = "n/a";

        //gets and sets

        public int KschoolId
        {
            get { return this.kschoolId; }
            set { this.kschoolId = value; }
        }

        public string KfirstName
        {
            get { return this.kfirstName; }
            set { this.kfirstName = value; }
        }

        public string KlastName
        {
            get { return this.klastName; }
            set { this.klastName = value; }
        }

        public string KMajor
        {
            get { return this.kmajor; }
            set { this.kmajor = value; }
        }

        //toString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "School Id:" + KschoolId + "</br>";
            aMessage = aMessage + "First Name:" + KfirstName + "</br>";
            aMessage = aMessage + "Last Name:" + KlastName + "</br>";
            aMessage = aMessage + " Major:" + KMajor + "</br>";
            return aMessage;
        }

        //contructors 
        public KevinHart()
        { }
        public KevinHart(int aKschoolId, string aKfirstName, string aKlastName, string aKMajor)
            : this()
        {
            this.KschoolId = aKschoolId;
            this.KfirstName = aKfirstName;
            this.KlastName = aKlastName;
            this.KMajor = aKMajor;
        }

        public KevinHart(int aKschoolId, string aKfirstName, string aKlastName)
            : this(aKschoolId, aKfirstName, aKlastName, "n/a")
        { }

        public KevinHart(int aKschoolId, string aKfirstName)
            : this(aKschoolId, aKfirstName, "n/a", "n/a")
        { }

        public KevinHart(int aKschoolId)
            : this(aKschoolId, "n/a", "n/a", "n/a")
        { }


    }
}