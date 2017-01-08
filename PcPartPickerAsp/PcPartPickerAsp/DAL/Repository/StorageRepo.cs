using System;
using System.Collections.Generic;
using PcPartPickerAsp.DAL.Interface;
using PcPartPickerAsp.DAL.Models;

namespace PcPartPickerAsp.DAL.Repository
{
    public class StorageRepo
    {
        public StorageRepo(IStorage storageContext)
        {
            Context = storageContext;
        }

        public IStorage Context { get; }

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
            return Context.GetAll();
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