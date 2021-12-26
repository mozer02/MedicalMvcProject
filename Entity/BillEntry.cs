using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("tblBillEntries")]
    public class BillEntry
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int GNo { get; set; }
        [Required]
        public int EnterType { get; set; }

        public int BillNo { get; set; } // Fatura No

        public DateTime BillDate { get; set; } // Fatura tarih
        [Required, StringLength(200)]
        public string Description { get; set; } // Açıklma
        [Required]
        public DateTime SaveDate { get; set; }

        [Required]
        public DateTime UpdateDate { get; set; }


        public bool isActive { get; set; }
        public string SaveUserName { get; set; }
        public string UpdateUserName { get; set; }

        public virtual Currents Currents { get; set; } // TblCariler Foreign key



    }
}
