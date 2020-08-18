using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Zavod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Job> jobs { get; set; }
        public Zavod()
        {
            jobs = new List<Job>();
        }

    }
}
