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
    }
}