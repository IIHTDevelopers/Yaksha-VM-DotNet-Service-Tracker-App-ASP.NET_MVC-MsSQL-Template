using ServiceTrackerApp.DAL.Interface;
using ServiceTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ServiceTrackerApp.DAL.Repository
{
    public class ServiceTrackerRepository : IServiceTrackerRepository
    {
        private ServiceTrackerDbContext _context;
        public ServiceTrackerRepository(ServiceTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Service> GetServices()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Service GetServiceByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Service InsertService(Service Service)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteService(int ServiceID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateService(Service Service)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
