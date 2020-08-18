using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        [ForeignKey("Zavod")]
        public int ZavodId { get; set; }
        public virtual Zavod Zavod { get; set; }
    }
}
