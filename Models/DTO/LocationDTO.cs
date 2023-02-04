using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class LocationDTO
    {
        public int PkLocationID { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }

        public bool IsActive { get; set; }
    }


    public class AddLocationDTO
    {
      
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }

        public bool IsActive { get; set; }
    }
}
