using StudentDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDb.ViewModels
{
    public class HomeDetalisViewModel
    {
        public IEnumerable<Student> student { get; set; }
        public string Title { get; set; }
    }
}
