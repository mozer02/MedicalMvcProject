using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("tblProducts")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string GNO { get; set; }
        [Required, StringLength(50)]
        public string ProductCode { get; set; }
        [Required, StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(50)]
        public string BoxContent { get; set; }
        [Column(TypeName = "money")]
        public decimal BuyPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SellPrice { get; set; }

        public int UsageTime { get; set; }
        public DateTime SaveDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string SaveUserName { get; set; }
        public string UpdateUserName { get; set; }


        public virtual Currents Currents { get; set; }
        

    }
}
