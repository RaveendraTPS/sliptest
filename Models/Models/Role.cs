using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Role")]
    public class Role
    {
        #region CONSTANTS
        public const int ROLENAMELENGTH = 50;
      

        #endregion

        #region PROPERTIES
        [Key]
        public int PKJobId { get; set; }

        [StringLength(ROLENAMELENGTH)]
        [Column(TypeName = "VARCHAR")]
        public string RoleName { get; set; }
        #endregion

    }
}
