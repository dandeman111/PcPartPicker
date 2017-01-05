using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PcPartPickerAsp.DAL.Context;
using PcPartPickerAsp.DAL.Repository;
using PcPartPickerAsp.Views;

namespace PcPartPickerAsp.Controllers
{
    public class PartController : Controller
    {
        // GET: Part
        public ActionResult Cpu(int computerId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            CpuRepo cp = new CpuRepo(new CpuMssql());
            CpuViewModel cvm = new CpuViewModel(cr.GetById(computerId),cp.GetAll());
            return View();
        }
    }
}