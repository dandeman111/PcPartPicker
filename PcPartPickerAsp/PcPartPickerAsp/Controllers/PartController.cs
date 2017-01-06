using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PcPartPickerAsp.DAL.Context;
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
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            CpuRepo cp = new CpuRepo(new CpuMssql());
            CpuViewModel cvm = new CpuViewModel(cr.GetById(computerId),cp.GetAll());
            return View(cvm);
        }
        public ActionResult Motherboard(int computerId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            MotherboardRepo mb = new MotherboardRepo(new MotherboardMssql());
            MotherboardViewModel mvm = new MotherboardViewModel(cr.GetById(computerId), mb.GetAll());
            return View(mvm);
        }
        public ActionResult Memory(int computerId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            MemoryRepo mr = new MemoryRepo(new MemoryMssql());
            MemoryViewModel mvm = new MemoryViewModel(cr.GetById(computerId), mr.GetAll());
            return View(mvm);
        }
        public ActionResult Storage(int computerId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            StorageRepo mr = new StorageRepo(new StorageMssql());
            StorageViewModel svm = new StorageViewModel(cr.GetById(computerId), mr.GetAll());
            return View(svm);
        }
        public ActionResult Gpu(int computerId)
        {
            ComputerRepo cr = new ComputerRepo(new ComputerMssql());
            GpuRepo gr = new GpuRepo(new GpuMssql());
            GpuViewModel gvm = new GpuViewModel(cr.GetById(computerId), gr.GetAll());
            return View(gvm);
        }
    }
}