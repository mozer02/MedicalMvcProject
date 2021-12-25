using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("tblBillDetails")]
    public class BillDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string GNo { get; set; }
        [Required]
        public int SeriesNo { get; set; }
        [Required, StringLength(100)]
        public string Barcode { get; set; }
        [Required, StringLength(50)]
        public string ProductCode { get; set; }
        [Required]
        public int LotSeriesNo { get; set; }
        [Required]
        public int Total { get; set; }
        [StringLength(200)]
        public string Note { get; set; }
        [Required]
        public DateTime PD { get; set; } // Üretim tarihi
        [Required]
        public DateTime ED { get; set; } // Son kullanma tarihi

        [Column(TypeName = "money")]
        public decimal BuyPrice { get; set; }
    }
}
