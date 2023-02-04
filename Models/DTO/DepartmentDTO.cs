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
    public class DepartmentDTO
    {
        public int PKDepartmentId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int JobCode { get; set; }
        public bool IsActive { get; set; }
    }


    public class AddDepartmentDTO
    {
      

        public string Title { get; set; }
        public string Description { get; set; }
        public int JobCode { get; set; }

        public bool IsActive { get; set; }
    }
}
