using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VinylCollection.Models
{
    public class Library
    {
        [Key]
        public Guid CollectorID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public virtual Collection<Record> RecordList { get; set; }

        public Library()
        {
            RecordList = new Collection<Record>();
        }


    }
}
