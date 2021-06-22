using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organogram.Models
{
    public class Worker
    {
        public int ID { get; set; }
        public string Profession { get; set; }
        public string Name { get; set; }
        public Worker SeniorID { get; set; }
    }
}
