using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VinylCollection.Models
{
    public class Record
    {
        [Key]
        public Guid CollectorID { get; set; }
        public String Title { get; set; }
        public int Rating { get; set; }


    }
}
