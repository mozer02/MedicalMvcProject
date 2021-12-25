using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("tblStockStatuses")]
    public class StockStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int StockCode { get; set; }
        [Required, StringLength(50)]
        public string Barcode { get; set; }
        [Required, StringLength(50)]
        public string Product { get; set; }
        [Required]
        public int Lot { get; set; }
        public int StockCount { get; set; } //stokadeti
        public int OnSaleCount { get; set; } //Raf adeti

        public int ConsigneeCount{ get; set; } //Konsinye adeti
        public int BranchCount { get; set; } // Şube adeti
        public DateTime PD { get; set; } // Üretim tarihi

        public DateTime ED { get; set; } // Son kullanma tarihi
    }
}
