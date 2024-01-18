using Learningcore.Data;
using Learningcore.Interfaces;
using Learningcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learningcore.Repository
{
    public class DepartmentRepository : IDepartment
    {

        private readonly ApplicationDbContext _db;
        public DepartmentRepository(ApplicationDbContext applicationDbContext)
        {
            this._db = applicationDbContext;
        }
        public bool create(Department model)
        {
            _db.Department.Add(model);
            return save();
        }

        public bool delete(Department model)
        {
            throw new NotImplementedException();
        }

        public ICollection<Department> findAll()
        {
            return _db.Department.ToList();
        }

        public Department findById(int id)
        {
            return _db.Department.Find(id);
        }

        public bool save()
        {
            var savechanges = _db.SaveChanges();
            return savechanges > 0;
        }

        public bool update(Department model)
        {
            _db.Department.Update(model);
            return save();
        }
    }
}
