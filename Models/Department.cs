﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Learningcore.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }
        public string Floor { get; set; }
    }
}
