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
        public ActionResult EditMotherBoard(int computerId, int motherboardId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            MotherboardRepo mb = new MotherboardRepo(new MotherboardMssql());
            Computer editedPc = cr.GetById(computerId);
            editedPc.Motherboard = mb.GetById(motherboardId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new { computerId = computerId });
        }
        public ActionResult EditMemory(int computerId, int memoryId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            MemoryRepo mr = new MemoryRepo(new MemoryMssql());
            Computer editedPc = cr.GetById(computerId);
            editedPc.Memory = mr.GetById(memoryId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new { computerId = computerId });
        }
        public ActionResult EditStorage(int computerId, int storageId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            StorageRepo sr = new StorageRepo(new StorageMssql());
            Computer editedPc = cr.GetById(computerId);
            editedPc.Storage = sr.GetById(storageId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new { computerId = computerId });
        }
        public ActionResult EditGpu(int computerId, int gpuId)
        {
#warning als ik  gpu's aanpas weet ik niet welke ik aanpas of dat ik er een verwijder
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            GpuRepo gr = new GpuRepo(new GpuMssql());
            Computer editedPc = cr.GetById(computerId);
            editedPc.Gpus[1] = sr.GetById(storageId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new { computerId = computerId });
        }
    }
}