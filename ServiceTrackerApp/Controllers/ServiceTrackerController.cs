using ServiceTrackerApp.DAL.Interface;
using ServiceTrackerApp.DAL.Repository;
using ServiceTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ServiceTrackerApp.Controllers
{
    public class ServiceTrackerController : Controller
    {
        private readonly IServiceTrackerInterface _Repository;
        public ServiceTrackerController(IServiceTrackerInterface service)
        {
            _Repository = service;
        }
        public ServiceTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: ServiceTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Service Service)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Service Service)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}