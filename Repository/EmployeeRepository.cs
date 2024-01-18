using Learningcore.Data;
using Learningcore.Interfaces;
using Learningcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learningcore.Repository
{
    public class EmployeeRepository : IEmployees
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            this._db = dbContext;
        }

        public bool create(Employee model)
        {
            _db.Employee.Add(model);
            return save();
        }

        public bool delete(Employee model)
        {
            _db.Employee.Remove(model);
            return save();
        }

        public ICollection<Employee> findAll()
        {
            return _db.Employee.ToList();
        }

        public Employee findById(int id)
        {
            return _db.Employee.Find(id);
        }

        public bool save()
        {
            var savechanges =_db.SaveChanges();
            return savechanges > 0;
        }

        public bool update(Employee model)
        {
            _db.Employee.Update(model);
            return save();

        }
    }
}
