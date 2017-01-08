using System;
using System.Web.Mvc;
using System.Web.UI;
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
            var computer = new ComputerRepo(new ComputerMssql());
            return View(computer.GetAll());
        }

        public ActionResult ShowBuild(int computerId)
        {
            var computer = new ComputerRepo(new ComputerMssql());
            return View(computer.GetById(computerId));
        }

        public ActionResult MyBuilds(string username)
        {
            var ur = new UserRepo(new UserMssql());
            return View(ur.GetByUsername(username));
        }

        public ActionResult EditBuild(int computerId)
        {
            var computer = new ComputerRepo(new ComputerMssql());
            return View(computer.GetById(computerId));
        }

        public ActionResult EditCpu(int computerId, int cpuId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var cp = new CpuRepo(new CpuMssql());
            var editedPc = cr.GetById(computerId);
            editedPc.Cpu = cp.GetById(cpuId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new {computerId});
        }

        public ActionResult EditMotherBoard(int computerId, int motherboardId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var mb = new MotherboardRepo(new MotherboardMssql());
            var editedPc = cr.GetById(computerId);
            editedPc.Motherboard = mb.GetById(motherboardId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new {computerId});
        }

        public ActionResult EditMemory(int computerId, int memoryId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var mr = new MemoryRepo(new MemoryMssql());
            var editedPc = cr.GetById(computerId);
            editedPc.Memory = mr.GetById(memoryId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new {computerId});
        }

        public ActionResult EditStorage(int computerId, int storageId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var sr = new StorageRepo(new StorageMssql());
            var editedPc = cr.GetById(computerId);
            editedPc.Storage = sr.GetById(storageId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new {computerId});
        }

        public ActionResult EditGpu(int computerId, int gpuId, int currentGpu)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var gr = new GpuRepo(new GpuMssql());
            var editedPc = cr.GetById(computerId);
            for (var i = 0; i < editedPc.Gpus.Count; i++)
                if (editedPc.Gpus[i].GpuId == currentGpu)
                    editedPc.Gpus[i] = gr.GetById(gpuId);
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new {computerId});
        }

        public ActionResult NewBuild()
        {
            if (Session["CurrentBuild"] == null)
            {
                var pc = new Computer();
                Session["CurrentBuild"] = pc;
            }

            return View();
        }

        public ActionResult AddCpu(int cpuId)
        {
            var cp = new CpuRepo(new CpuMssql());
            var pc = (Computer) Session["CurrentBuild"];
            pc.Cpu = cp.GetById(cpuId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }

        public ActionResult AddMotherboard(int motherboardId)
        {
            var rp = new MotherboardRepo(new MotherboardMssql());
            var pc = (Computer) Session["CurrentBuild"];
            pc.Motherboard = rp.GetById(motherboardId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }

        public ActionResult AddMemory(int memoryId)
        {
            var rp = new MemoryRepo(new MemoryMssql());
            var pc = (Computer) Session["CurrentBuild"];
            pc.Memory = rp.GetById(memoryId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }

        public ActionResult AddStorage(int storageId)
        {
            var rp = new StorageRepo(new StorageMssql());
            var pc = (Computer) Session["CurrentBuild"];
            pc.Storage = rp.GetById(storageId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }

        public ActionResult SaveBuild()
        {
            var pc = (Computer) Session["CurrentBuild"];
            var cr = new ComputerRepo(new ComputerMssql());
            try
            {
                cr.Add(pc, Session["Username"].ToString());
                Session["CurrentBuild"] = new Computer();
            }
            catch (NullReferenceException x)
            {
                return RedirectToAction("MissingParts", "Error");
            }
                
                return RedirectToAction("NewBuild", "Build");
            
            




        }
    }
}