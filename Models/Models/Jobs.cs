using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Departments")]
    public class Department
    {
        #region CONSTANTS
        public const int TITLENAMELENGTH = 50;
        public const int DESCRIPTION = 50;

        #endregion

        #region PROPERTIES
        [Key]
        public int PKDepartmentId { get; set; }

        [StringLength(TITLENAMELENGTH)]
        [Column(TypeName = "VARCHAR")]
        public string Title { get; set; }
        public string Description { get; set; }
        public int JobCode { get; set; }
        public bool IsActive { get; set; }
        #endregion
    }
}
