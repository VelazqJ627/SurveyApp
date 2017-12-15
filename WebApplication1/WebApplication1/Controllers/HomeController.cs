using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using System.Data.Odbc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DonaldGloverForm()
        {
            return View();
        }

        public ActionResult InsertDonaldGlover(int DschoolId, string DfirstName, string DlastName, string DMajor)
        {
            ViewBag.DschoolId = DschoolId;
            ViewBag.DfirstName = DfirstName;
            ViewBag.DlastName = DlastName;
            ViewBag.DMajor = DMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertDonaldGlover(DschoolId, DfirstName, DlastName, DMajor);

            string aSQL = "INSERT INTO DonaldGlover (DschoolId, DfirstName, DlastName, DMajor)";
            aSQL = aSQL + "VALUES('" + DschoolId + "','" + DfirstName + "','" + DlastName + "','" + DMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult KevinHartForm()
        {
            return View();
        }

        public ActionResult InsertKevinHart(int KschoolId, string KfirstName, string KlastName, string KMajor)
        {
            ViewBag.KschoolId = KschoolId;
            ViewBag.KfirstName = KfirstName;
            ViewBag.KlastName = KlastName;
            ViewBag.KMajor = KMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertKevinHart(KschoolId, KfirstName, KlastName, KMajor);

            string aSQL = "INSERT INTO KevinHart (KschoolId, KfirstName, KlastName, KMajor)";
            aSQL = aSQL + "VALUES('" + KschoolId + "','" + KfirstName + "','" + KlastName + "','" + KMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult WildForm()
        {
            return View();
        }

        public ActionResult InsertWild(int WschoolId, string WfirstName, string WlastName, string WMajor)
        {
            ViewBag.WschoolId = WschoolId;
            ViewBag.WfirstName = WfirstName;
            ViewBag.WlastName = WlastName;
            ViewBag.WMajor = WMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertWild(WschoolId, WfirstName, WlastName, WMajor);

            string aSQL = "INSERT INTO Wild (WschoolId, WfirstName, WlastName, WMajor)";
            aSQL = aSQL + "VALUES('" + WschoolId + "','" + WfirstName + "','" + WlastName + "','" + WMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult DrakeForm()
        {
            return View();
        }

        public ActionResult InsertDrake(int DRschoolId, string DRfirstName, string DRlastName, string DRMajor)
        {
            ViewBag.DRschoolId = DRschoolId;
            ViewBag.DRfirstName = DRfirstName;
            ViewBag.DRlastName = DRlastName;
            ViewBag.DRMajor = DRMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertDrake(DRschoolId, DRfirstName, DRlastName, DRMajor);

            string aSQL = "INSERT INTO Drake (DRschoolId, DRfirstName, DRlastName, DRMajor)";
            aSQL = aSQL + "VALUES('" + DRschoolId + "','" + DRfirstName + "','" + DRlastName + "','" + DRMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult MetallicaForm()
        {
            return View();
        }

        public ActionResult InsertMetallica(int MschoolId, string MfirstName, string MlastName, string MMajor)
        {
            ViewBag.MschoolId = MschoolId;
            ViewBag.MfirstName = MfirstName;
            ViewBag.MlastName = MlastName;
            ViewBag.MMajor = MMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertMetallica(MschoolId, MfirstName, MlastName, MMajor);

            string aSQL = "INSERT INTO Metallica (MschoolId, MfirstName, MlastName, MMajor)";
            aSQL = aSQL + "VALUES('" + MschoolId + "','" + MfirstName + "','" + MlastName + "','" + MMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult UsherForm()
        {
            return View();
        }

        public ActionResult InsertUsher(int UschoolId, string UfirstName, string UlastName, string UMajor)
        {
            ViewBag.UschoolId = UschoolId;
            ViewBag.UfirstName = UfirstName;
            ViewBag.UlastName = UlastName;
            ViewBag.UMajor = UMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertUsher(UschoolId, UfirstName, UlastName, UMajor);

            string aSQL = "INSERT INTO Usher (UschoolId, UfirstName, UlastName, UMajor)";
            aSQL = aSQL + "VALUES('" + UschoolId + "','" + UfirstName + "','" + UlastName + "','" + UMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult BeachForm()
        {
            return View();
        }

        public ActionResult InsertBeach(int BschoolId, string BfirstName, string BlastName, string BMajor)
        {
            ViewBag.BschoolId = BschoolId;
            ViewBag.BfirstName = BfirstName;
            ViewBag.BlastName = BlastName;
            ViewBag.BMajor = BMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertBeach(BschoolId, BfirstName, BlastName, BMajor);

            string aSQL = "INSERT INTO Beach (BschoolId, BfirstName, BlastName, BMajor)";
            aSQL = aSQL + "VALUES('" + BschoolId + "','" + BfirstName+ "','" + BlastName + "','" + BMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }

        public ActionResult FoamForm()
        {
            return View();
        }

        public ActionResult InsertFoam(int FschoolId, string FfirstName, string FlastName, string FMajor)
        {
            ViewBag.FschoolId = FschoolId;
            ViewBag.FfirstName = FfirstName;
            ViewBag.FlastName = FlastName;
            ViewBag.FMajor = FMajor;

            DBConnection aConnection = new DBConnection();

            aConnection.InsertFoam(FschoolId, FfirstName, FlastName, FMajor);

            string aSQL = "INSERT INTO Foam (FschoolId, FfirstName, FlastName, FMajor)";
            aSQL = aSQL + "VALUES('" + FschoolId + "','" + FfirstName + "','" + FlastName + "','" + FMajor + "')";

            ViewBag.SQL = aSQL;
            return View();
        }


    }
}