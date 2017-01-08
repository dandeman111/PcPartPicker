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
        public ActionResult EditGpu(int computerId, int gpuId, int currentGpu)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            GpuRepo gr = new GpuRepo(new GpuMssql());
            Computer editedPc = cr.GetById(computerId);
            for (int i = 0; i < editedPc.Gpus.Count ; i++)
            {
                if (editedPc.Gpus[i].GpuId == currentGpu)
                {
                    editedPc.Gpus[i] = gr.GetById(gpuId);
                }
            }
            cr.Update(editedPc);
            return RedirectToAction("EditBuild", "Build", new { computerId = computerId });
        }
        public ActionResult NewBuild()
        {
            if (Session["CurrentBuild"] == null)
            {
                Computer pc = new Computer();
                Session["CurrentBuild"] = pc;
            }
           
            return View();
        }
        public ActionResult AddCpu(int cpuId)
        {
            CpuRepo cp = new CpuRepo(new CpuMssql());
            Computer pc = (Computer) Session["CurrentBuild"];
            pc.Cpu = cp.GetById(cpuId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }
        public ActionResult AddMotherboard(int motherboardId)
        {
            MotherboardRepo rp = new MotherboardRepo(new MotherboardMssql());
            Computer pc = (Computer)Session["CurrentBuild"];
            pc.Motherboard = rp.GetById(motherboardId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }
        public ActionResult AddMemory(int memoryId)
        {
            MemoryRepo rp = new MemoryRepo(new MemoryMssql());
            Computer pc = (Computer)Session["CurrentBuild"];
            pc.Memory = rp.GetById(memoryId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }
        public ActionResult AddStorage(int storageId)
        {
            StorageRepo rp = new StorageRepo(new StorageMssql());
            Computer pc = (Computer)Session["CurrentBuild"];
            pc.Storage = rp.GetById(storageId);
            Session["CurrentBuild"] = pc;
            return RedirectToAction("NewBuild", "Build");
        }
        public ActionResult SaveBuild()
        {
            Computer pc = (Computer)Session["CurrentBuild"];
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());

            cr.Add(pc, Session["Username"].ToString());
            Session["CurrentBuild"] = new Computer();
            return RedirectToAction("NewBuild", "Build");
        }
    }
}