using System.Web.Mvc;
using PcPartPickerAsp.DAL.Context;
using PcPartPickerAsp.DAL.Models;
using PcPartPickerAsp.DAL.Repository;
using PcPartPickerAsp.DAL.ViewModels;
using PcPartPickerAsp.Views;

namespace PcPartPickerAsp.Controllers
{
    public class PartController : Controller
    {
        // GET: Part
        public ActionResult Cpu(int computerId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var cp = new CpuRepo(new CpuMssql());
            var cvm = new CpuViewModel(cr.GetById(computerId), cp.GetAll());
            return View(cvm);
        }

        public ActionResult Motherboard(int computerId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var mb = new MotherboardRepo(new MotherboardMssql());
            var mvm = new MotherboardViewModel(cr.GetById(computerId), mb.GetAll());
            return View(mvm);
        }

        public ActionResult Memory(int computerId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var mr = new MemoryRepo(new MemoryMssql());
            var mvm = new MemoryViewModel(cr.GetById(computerId), mr.GetAll());
            return View(mvm);
        }

        public ActionResult Storage(int computerId)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var mr = new StorageRepo(new StorageMssql());
            var svm = new StorageViewModel(cr.GetById(computerId), mr.GetAll());
            return View(svm);
        }

        public ActionResult Gpu(int computerId, int selectedGpu)
        {
            var cr = new ComputerRepo(new ComputerMssql());
            var gr = new GpuRepo(new GpuMssql());
            var gvm = new GpuViewModel(cr.GetById(computerId), gr.GetAll(), selectedGpu);
            return View(gvm);
        }

        public ActionResult AddCpu()
        {
            var cp = new CpuRepo(new CpuMssql());
            var cvm = new CpuViewModel((Computer) Session["CurrentBuild"], cp.GetAll());
            return View(cvm);
        }

        public ActionResult AddMotherboard()
        {
            var rp = new MotherboardRepo(new MotherboardMssql());
            var cvm = new MotherboardViewModel((Computer) Session["CurrentBuild"], rp.GetAll());
            return View(cvm);
        }

        public ActionResult AddMemory()
        {
            var rp = new MemoryRepo(new MemoryMssql());
            var cvm = new MemoryViewModel((Computer) Session["CurrentBuild"], rp.GetAll());
            return View(cvm);
        }

        public ActionResult AddStorage()
        {
            var rp = new StorageRepo(new StorageMssql());
            var cvm = new StorageViewModel((Computer) Session["CurrentBuild"], rp.GetAll());
            return View(cvm);
        }
    }
}