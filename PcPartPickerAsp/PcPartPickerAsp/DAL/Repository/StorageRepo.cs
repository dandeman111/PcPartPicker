using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class StorageRepo
    {
        public IStorage Context { get; private set; }

        public StorageRepo(IStorage storageContext)
        {
            Context = storageContext;
        }
        public void Add(Storage storage)
        {
            throw new NotImplementedException();
        }

        public Storage GetById(int id)
        {
            return Context.GetById(id);
        }

        public List<Storage> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Storage storage)
        {
            throw new NotImplementedException();
        }

        public void Delete(Storage storage)
        {
            throw new NotImplementedException();
        }
    }
}