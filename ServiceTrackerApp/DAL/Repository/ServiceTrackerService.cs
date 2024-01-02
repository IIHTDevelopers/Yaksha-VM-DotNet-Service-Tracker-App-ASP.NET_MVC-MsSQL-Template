using ServiceTrackerApp.DAL.Interface;
using ServiceTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceTrackerApp.DAL.Repository
{
    public class ServiceTrackerService : IServiceTrackerInterface
    {
        private IServiceTrackerRepository _repo;
        public ServiceTrackerService(IServiceTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteService(int ServiceId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Service GetServiceByID(int ServiceId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Service> IServiceTrackerInterface.GetServices()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Service IServiceTrackerInterface.InsertService(Service Service)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IServiceTrackerInterface.UpdateService(Service Service)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}