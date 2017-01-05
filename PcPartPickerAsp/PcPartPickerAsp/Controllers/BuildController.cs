using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PcPartPickerAsp.DAL.Context;
using PcPartPickerAsp.DAL.Models;
using PcPartPickerAsp.DAL.Repository;

namespace PcPartPickerAsp.Controllers
{
    public class BuildController : Controller
    {
        // GET: Build
        public ActionResult Builds()
        {
            ComputerRepo computer = new ComputerRepo(new ComputerMssql());
            return View(computer.GetAll());
        }

        public ActionResult ShowBuild(int computerId)
        {
            ComputerRepo computer = new ComputerRepo(new ComputerMssql());
            return View(computer.GetById(computerId));
        }

        public ActionResult MyBuilds(string username)
        {
            UserRepo ur = new UserRepo(new UserMssql());
            return View(ur.GetByUsername(username));
        }

        public ActionResult EditBuild(int computerId)
        {
            ComputerRepo computer = new ComputerRepo(new ComputerMssql());
            return View(computer.GetById(computerId));
        }

        public ActionResult EditCpu(int computerId, int cpuId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            CpuRepo cp = new CpuRepo(new CpuMssql());
            Computer editedPc = cr.GetById(computerId);
            editedPc.Cpu = cp.GetById(cpuId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new {computerId = computerId});
        }
        public ActionResult EditMotherBoard(int computerId, int mbId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            MotherboardRepo mb = new MotherboardRepo(new MotherboardMssql());
            Computer editedPc = cr.GetById(computerId);
            editedPc.Motherboard = mb.GetById(mbId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new { computerId = computerId });
        }
    }
}