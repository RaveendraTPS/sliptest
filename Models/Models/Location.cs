using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.Models
{
    [Table("Location")]
    public class Location
    {
        #region CONSTANTS
        public const int CITYLENGTH = 50;
        public const int COUNTRYLENGTH = 50;
        public const int STATELENGTH = 50;
        public const int PINCODELENGTH = 50;

        #endregion
        [Key]
        public int PkLocationID { get; set; }


        [StringLength(CITYLENGTH)]
        [Column(TypeName = "VARCHAR")]
        public string city { get; set; }
        [StringLength(COUNTRYLENGTH)]
        [Column(TypeName = "VARCHAR")]
        public string country { get; set; }

        [StringLength(STATELENGTH)]
        [Column(TypeName = "VARCHAR")]
        public string state { get; set; }

        [StringLength(PINCODELENGTH)]
        [Column(TypeName = "VARCHAR")]
        public string pincode { get; set; }

        public bool IsActive { get; set; }

    }
}
