using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace WebApplication1.Models
{
    public class DBConnection
    {
        OleDbConnection aConnection = new OleDbConnection();
  
        private List<DonaldGlover> aDonaldGlover = new List<DonaldGlover>();
        public bool InsertDonaldGlover(int DschoolId, string DfirstName, string DlastName, string DMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO DonaldGlover (DschoolId, DfirstName, DlastName, DMajor)";
            aSQL = aSQL + "VALUES('" + DschoolId + "','" + DfirstName + "','" + DlastName + "','" + DMajor + "')";
            //oledb is a tool/technology which is the license to the DB
            
            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

           aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<KevinHart> aKevinHart = new List<KevinHart>();
        public bool InsertKevinHart(int KschoolId, string KfirstName, string KlastName, string KMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO KevinHart (KschoolId, KfirstName, KlastName, KMajor)";
            aSQL = aSQL + "VALUES('" + KschoolId + "','" + KfirstName + "','" + KlastName + "','" + KMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Wild> aWild = new List<Wild>();
        public bool InsertWild(int WschoolId, string WfirstName, string WlastName, string WMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO Wild (WschoolId, WfirstName, WlastName, WMajor)";
            aSQL = aSQL + "VALUES('" + WschoolId + "','" + WfirstName + "','" + WlastName + "','" + WMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Drake> aDrake = new List<Drake>();
        public bool InsertDrake(int DRschoolId, string DRfirstName, string DRlastName, string DRMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO Drake (DRschoolId, DRfirstName, DRlastName, DRMajor)";
            aSQL = aSQL + "VALUES('" + DRschoolId + "','" + DRfirstName + "','" + DRlastName + "','" + DRMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Metallica> aMetallica = new List<Metallica>();
        public bool InsertMetallica(int MschoolId, string MfirstName, string MlastName, string MMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO Metallica (MschoolId, MfirstName, MlastName, MMajor)";
            aSQL = aSQL + "VALUES('" + MschoolId + "','" + MfirstName + "','" + MlastName + "','" + MMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Usher> aUsher = new List<Usher>();
        public bool InsertUsher(int UschoolId, string UfirstName, string UlastName, string UMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO Usher (UschoolId, UfirstName, UlastName, UMajor)";
            aSQL = aSQL + "VALUES('" + UschoolId + "','" + UfirstName + "','" + UlastName + "','" + UMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Beach> aBeach = new List<Beach>();
        public bool InsertBeach(int BschoolId, string BfirstName, string BlastName, string BMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO Beach (BschoolId, BfirstName, BlastName, BMajor)";
            aSQL = aSQL + "VALUES('" + BschoolId + "','" + BfirstName + "','" + BlastName + "','" + BMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Foam> aFoam = new List<Foam>();
        public bool InsertFoam(int FschoolId, string FfirstName, string FlastName, string FMajor)
        {
            bool aFlag = false;
            string aSQL = "INSERT INTO Foam (FschoolId, FfirstName, FlastName, FMajor)";
            aSQL = aSQL + "VALUES('" + FschoolId + "','" + FfirstName + "','" + FlastName + "','" + FMajor + "')";
            //oledb is a tool/technology which is the license to the DB

            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\coold\Desktop\HCI\Assignments\Glo1\survey.accdb;";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }
    }
}