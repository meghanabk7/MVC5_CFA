using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_CFA.Models
{
    public class Employee
    {
        public int ID { get; set; }
       
        public string Name { get; set; }
        
        public DateTime DOJ { get; set; }
        public string designation { get; set; }

    }
}